using Microsoft.EntityFrameworkCore;

namespace SelfSampleProRAD_DB.Controller
{
    class TasksController
    {
        private readonly AppDbContext _context;
        public TasksController(AppDbContext context)
        {
            _context = context;
        }
        //public int AssignTask(int tskId, string tskNm, string aTo, string aBy)
        //{

        //}

        //public SqlDataReader ViewTasksFor(string taskTo)
        //{

        //}

        //public SqlDataReader ViewTasksTo(string taskBy)
        //{

        //}

        //public byte startWorking(int taskID)
        //{

        //}
        //public byte submitWork(int taskID)
        //{

        //}
    }
}
