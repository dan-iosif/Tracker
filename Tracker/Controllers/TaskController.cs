using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Tracker.Services.IServices;
using Tracker.Services.Models;

namespace Tracker.Controllers
{
    public class TasksController : ApiController
    {
        protected ITaskService TaskService;

        public TasksController(ITaskService taskService)
        {
            TaskService = taskService;
        }
        
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetTasks()
        {
            return Ok(TaskService.GetTasks());
        }
        [Authorize]
        [HttpPost]
        public IHttpActionResult AddTask([FromBody] TaskDTO task)
        {
            return Ok(TaskService.AddTask(task));
        }

    }
}