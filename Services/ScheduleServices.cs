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
        public string GetCurrentProject()
        {
            return _repo.Get_ProjectById(1).name;
        }
    }
}