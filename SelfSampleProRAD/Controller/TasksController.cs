using SelfSampleProRAD_DB.Model;
using SelfSampleProRAD_DB.DTOs;
using System.Threading.Tasks;
namespace SelfSampleProRAD_DB.Controller
{
    class TasksController
    {
        private readonly AppDbContext _context;
        public TasksController() : this(new AppDbContext()) { }
        public TasksController(AppDbContext context)
        {
            _context = context;
        }
        public (EmployeeTasks,string,bool) AssignTask(string tskNm, Guid aTo, Guid aBy)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var task = new Tasks
                {
                    TaskName = tskNm,
                    Status = 'P'
                };
                var taskResponse = _context.Tasks.Add(task);
                _context.SaveChanges();
                var employeeTask = new EmployeeTasks
                {
                    TaskId = taskResponse.Entity.TaskId,
                    AssignedToId = aTo,
                    AssignedById = aBy
                };
                var employeeTaskResponse = _context.EmployeeTasks.Add(employeeTask);
                _context.SaveChanges();
                transaction.Commit();
                return (employeeTask, "Task Successfully assigned",true);
            } catch (Exception ex) { return (null,"Error: " + ex.Message,false); }
        }

        private static string GetStatusText(char status)
        {
            if (status == 'P') return "Pending";
            if (status == 'S') return "Started";
            if (status == 'C') return "Completed";
            return "Unknown";
        }

        public (List<TaskViewToResponseDTO>, string) ViewTasksFor(Guid taskTo)
        {
            try
            {
                var tasks = _context.EmployeeTasks
                    .Where(t => t.AssignedToId == taskTo && t.Tasks.Status !='C')
                    .Select(t => new TaskViewToResponseDTO
                    {
                        TaskId = t.TaskId,
                        FirstName = t.AssignedBy.FirstName,
                        LastName = t.AssignedBy.LastName,
                        TaskName = t.Tasks.TaskName,
                        Status = GetStatusText(t.Tasks.Status)
                    })
                    .ToList();
                return (tasks, "Success");
            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.InnerException.Message ?? ex.Message);
            }
        }

        public (List<TaskViewByResponseDTO>, string) ViewTasksBy(Guid taskBy)
        {
            try
            {
                var tasks = _context.EmployeeTasks
                    .Where(t => t.AssignedById == taskBy)
                    .Select(t => new TaskViewByResponseDTO
                    {
                        FullName = $"{t.AssignedTo.FirstName} {t.AssignedTo.LastName}",
                        TaskName = t.Tasks.TaskName,
                        Status = GetStatusText(t.Tasks.Status)
                    })
                    .ToList();
                return (tasks, "Success");
            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.InnerException?.Message ?? ex.Message);
            }
        }

        public (string, bool) startWorking(Guid taskID)
        {
            var task = _context.Tasks
                .Where(t => t.TaskId == taskID).FirstOrDefault();
            if (task == null) return ("Task not found.", false);
            if (task.Status == 'C') return ("Task is already completed.", false);
            task.Status = 'S';
            try
            {
                _context.Update(task);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message, false);
            }
            return ("Task started.", true);
        }

        public (string,bool) submitWork(Guid taskID)
        {
            var task = _context.Tasks
                .Where(t => t.TaskId == taskID).FirstOrDefault();
            if (task == null) return ("Task not found.",false);
            if (task.Status == 'C') return ("Task is already completed.", false);
            task.Status = 'C';
            try
            {
                _context.Update(task);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message,false);
            }
            return ("Task completed.", true);
        }
    }
}
