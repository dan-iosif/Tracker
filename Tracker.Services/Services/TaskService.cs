using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.IRepository.Interfaces;
using Tracker.IRepository.Models;
using Tracker.Services.IServices;
using Tracker.Services.Models;

namespace Tracker.Services.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository TaskRepo;

        public TaskService(ITaskRepository taskRepo)
        {
            TaskRepo = taskRepo;
        }

        public bool AddTask(TaskDTO task)
        {
            if (task == null) return false;
            TaskRepo.AddUser(new TaskModel() {
               Name = task.Name,
               Description = task.Description,
            });
            return true;
        }

        public List<TaskDTO> GetTasks()
        {
            return TaskRepo.GetAllTasks().Select(x=> new TaskDTO() {
                Id_Task = x.Id_Task,
                Name = x.Name,
                Description = x.Description
            }).ToList();
        }

        public bool UpsertTask(TaskDTO task)
        {
            //face update
            if (task.Id_Task > 0) {

            }
            else
            {
                //do insert

            }
            return true;
        }
    }
}
