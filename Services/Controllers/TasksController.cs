using Microsoft.AspNetCore.Mvc;
using TaskMasterBackend.Models;
using TaskMasterBackend.Services;

namespace TaskMasterBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly TaskService _service;

        public TasksController(TaskService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => _service.GetById(id) is TaskItem task ? Ok(task) : NotFound();

        [HttpPost]
        public IActionResult Create(TaskItem task) => CreatedAtAction(nameof(GetById), new { id = _service.Add(task).Id }, task);

        [HttpPut("{id}")]
        public IActionResult Update(int id, TaskItem task) => _service.Update(id, task) ? NoContent() : NotFound();

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => _service.Delete(id) ? NoContent() : NotFound();
    }
}
