using ProductivityWebPage.Model;
namespace ProductivityWebPage.Services
{
    public class ScheduleService
    {
        private ScheduleRepository _repo;
        public ScheduleService()
        {
            _repo = new ScheduleRepository();
        }
        public string Datass()
        {
            return "datass";
        }
        public Project GetCurrentProject()
        {
            var now = DateTime.Now;
            var timetable = _repo.GetTimeTable(); 
            try
            {
                var id = timetable.FirstOrDefault(t => t.StartTime <= now && now < t.EndTime).ProjectId;
                return _repo.GetProjectById(id);
            }
            catch (System.NullReferenceException)
            {
                Project p = _repo.GetProjectById(4);
                return p;
                throw;
            }
        }
        public void AddTodo(TodoItem todo)
        {
            _repo.AddTodoItem(todo);
        }
        
        public TodoItem GetProjectTodoItem (int project_id)
        {
            return _repo.GetProjectTodoItem(project_id);
        }
        public IQueryable<TodoItem> GetProjectTodoItems (int project_id)
        {
            return _repo.GetProjectTodos(project_id);
        }
    }
}