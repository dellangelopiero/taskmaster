using TaskMasterBackend.Models;

namespace TaskMasterBackend.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private int _nextId = 1;

        public List<TaskItem> GetAll() => _tasks;
        public TaskItem? GetById(int id) => _tasks.FirstOrDefault(t => t.Id == id);

        public TaskItem Add(TaskItem task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
            return task;
        }

        public bool Update(int id, TaskItem task)
        {
            var existing = GetById(id);
            if (existing == null) return false;
            existing.Title = task.Title;
            existing.Completed = task.Completed;
            existing.Priority = task.Priority;
            return true;
        }

        public bool Delete(int id)
        {
            var task = GetById(id);
            if (task == null) return false;
            _tasks.Remove(task);
            return true;
        }
    }
}
