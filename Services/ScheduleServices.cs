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
                var id = timetable.SingleOrDefault(t => t.start_time <= now && now < t.end_time).project_id;
                return _repo.Get_ProjectById(id);
            }
            catch (System.NullReferenceException)
            {
                return new Project("Test");
                throw;
            }
        }
    }
}