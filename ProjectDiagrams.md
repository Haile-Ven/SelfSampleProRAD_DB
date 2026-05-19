# SelfSampleProRAD_DB Project Diagrams

## Class Diagram

```
+------------------------+       +------------------------+       +------------------------+
|        Account        |       |       Employee        |       |         Tasks         |
+------------------------+       +------------------------+       +------------------------+
| +UserId: Guid         |<----->| +EmployeeId: Guid     |       | +TaskId: Guid         |
| +UserName: string     |       | +FirstName: string    |       | +TaskName: string     |
| +Password: string     |       | +LastName: string     |       | +Status: char         |
| +Status: char         |       | +Gender: char         |       +------------------------+
+------------------------+       | +Age: byte           |                ^
                                | +Position: string    |                |
                                | +Salary: float       |                |
                                | +Tax: float          |                |
                                | +Catagory: string    |                |
                                | +UserId: Guid?       |                |
                                +------------------------+                |
                                          ^   ^                          |
                                          |   |                          |
                                          |   |                          |
                                          |   |                          |
                              +-----------+   +-----------+              |
                              |                           |              |
                              |                           |              |
                    +------------------------+            |              |
                    |     EmployeeTasks     |------------+              |
                    +------------------------+                          |
                    | +ETID: Guid           |                          |
                    | +TaskId: Guid         |--------------------------+
                    | +AssignedToId: Guid   |
                    | +AssignedById: Guid   |
                    +------------------------+
```

## Entity-Relationship Diagram

```
+------------+     1     +------------+
|  Account   |<--------->|  Employee  |
+------------+           +------------+
| PK: UserId |           | PK: EmployeeId |
+------------+           | FK: UserId |
                         +------------+
                              ^ ^
                              | |
                     Assigned| |Assigned
                         By  | |  To
                              | |
                              v v
+------------+           +------------+
|   Tasks    |<--------->|EmployeeTasks|
+------------+           +------------+
| PK: TaskId |           | PK: ETID   |
+------------+           | FK: TaskId |
                         | FK: AssignedToId |
                         | FK: AssignedById |
                         +------------+
```

## Use-Case Diagram

```
                    +---------------------+
                    |    Employee Portal  |
                    +---------------------+
                               ^
                               |
                 +------------+------------+
                 |                         |
        +--------v------+        +---------v-------+
        |   Developer   |        | Project Manager |
        +---------------+        +-----------------+
        | - View Profile|        | - View Profile  |
        | - Change PWD  |        | - Change PWD    |
        | - View Tasks  |        | - Assign Tasks  |
        | - Start Task  |        | - View Assigned |
        | - Submit Task |        |   Tasks         |
        +---------------+        +-----------------+
                 ^                         ^
                 |                         |
                 |      +--------+        |
                 +------|  Admin |--------+
                        +--------+
                        | - All Developer &    |
                        |   Manager Functions  |
                        | - Add New Employee   |
                        | - View All Employees |
                        | - Activate/Deactivate|
                        |   Accounts           |
                        +---------------------+
```

## Dark Mode Feature

The application includes a dark mode toggle feature that changes the appearance of all controls on the form. Key implementation details include:

1. A toggle button in the top-right corner with moon/sun icons
2. A recursive method to apply dark/light themes to all controls
3. Special handling for different control types (DataGridView, TextBox, etc.)
4. Dark mode support for the ToastNotification control
5. Proper theme persistence during form interactions
