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
        public Project GetCurrentProject(string datetimestring)
        {
            var now = DateTime.Parse(datetimestring);
            var timetable = _repo.GetTimeTable(); 
            try
            {
                var id = timetable.FirstOrDefault(t => t.start_time <= now && now < t.end_time).project_id;
                return _repo.GetProjectById(id);
            }
            catch (System.NullReferenceException)
            {
                return new Project("Test");
                throw;
            }
        }
        public void AddTodo(int project_id, string name, string description)
        {
            TodoItem todo = new TodoItem(project_id, name, description);
            _repo.AddTodoItem(todo);
        }
        public TodoItem GetTodoItem (int project_id)
        {
            return _repo.GetProjectTodoItem(project_id);
        }
    }
}