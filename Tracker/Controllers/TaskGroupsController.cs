using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Tracker.IRepository.Models;
using Tracker.Services.IServices;

namespace Tracker.Controllers
{
    public class TaskGroupsController : ApiController
    {
        protected ITaskGroupService taskGroupService;

        public TaskGroupsController(ITaskGroupService taskGroupService)
        {
            this.taskGroupService = taskGroupService;
        }


        [HttpGet]
        public IHttpActionResult GetTaskGroups()
        {
            return Ok(taskGroupService.GetTaskGroups());
        }

        [HttpPost]
        public IHttpActionResult AddTaskGroup([FromBody] TaskGroupModel  taskGroup)
        {
            return Ok(taskGroupService.AddTaskGroup(taskGroup));
        }
    }
}