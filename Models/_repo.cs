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
        public TodoItem Get_TodoItem(int id)
        {
            var todo = _db.TodoItems
                .OrderBy(t => t.id)
                .First();
            return todo;
        }
        public void Add_TodoItem(TodoItem todo)
        {
            _db.TodoItems.Add(todo);
            _db.SaveChanges();
        }
        public void Delete_TodoItem()
        {

        }
        public void Change_TodoItem()
        {

        }
        public Project Get_ProjectById(int id)
        {
            var project = _db.Projects
                .Where(p => p.id == id);
            return project.First();

        }
        public void Add_Project()
        {

        }
        public void Delete_Project()
        {

        }
        public void Change_Project()
        {
            
        }
        public List<TimeTable> GetTimeTable()
        {
            return  _db.TimeTable.ToList();
        }
    }
}