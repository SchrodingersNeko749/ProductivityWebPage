using ProductivityWebPage.Model;

namespace ProductivityWebPage.Model
{
    public class ScheduleRepository
    {
        private ScheduleContext _db; 
        public ScheduleRepository()
        {
            _db = new ScheduleContext();
        }
        public TodoItem GetTodoItem(int id)
        {
            var todo = _db.TodoItems
                .OrderBy(t => t.id)
                .First();
            return todo;
        }
        public TodoItem GetProjectTodoItem(int project_id)
        {
            var todos = _db.TodoItems
                .Where(t => t.ProjectId == project_id);
            return todos.First();
        }
        public IQueryable<TodoItem> GetProjectTodos(int project_id)
        {
            var todos = _db.TodoItems
                .Where(t => t.ProjectId == project_id);
            return todos;
        }
        public void AddTodoItem(TodoItem todo)
        {
            _db.TodoItems.Add(todo);
            _db.SaveChanges();
        }
        public void DeleteTodoItem()
        {

        }
        public void ChangeTodoItem()
        {

        }
        public Project GetProjectById(int id)
        {
            var project = _db.Projects
                .Where(p => p.id == id);
            return project.First();
        }
        public void AddProject()
        {

        }
        public void DeleteProject()
        {

        }
        public void ChangeProject()
        {
            
        }
        public List<TimeTable> GetTimeTable()
        {
            return  _db.TimeTable.ToList();
        }
        public List<TodoItem> GetTodos()
        {
            return _db.TodoItems.ToList();
        }
    }
}