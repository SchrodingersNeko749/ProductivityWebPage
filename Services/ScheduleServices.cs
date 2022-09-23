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
                // get a chore or project-less task
                return null;
                throw;
            }
        }
        public void AddTodo(int project_id, string name, string description)
        {
            TodoItem todo = new TodoItem(project_id, name, description);
            _repo.AddTodoItem(todo);
        }
        
        public TodoItem GetProjectTodoItem (int project_id)
        {
            return _repo.GetProjectTodoItem(project_id);
        }
    }
}