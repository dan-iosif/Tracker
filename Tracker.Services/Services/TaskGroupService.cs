using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.IRepository.Interfaces;
using Tracker.IRepository.Models;
using Tracker.Services.IServices;

namespace Tracker.Services.Services
{
    public class TaskGroupService : ITaskGroupService
    {
        private ITaskGroupRepository TaskGroupRepo;

        public TaskGroupService(ITaskGroupRepository taskGroupRepo)
        {
            TaskGroupRepo = taskGroupRepo;
        }
        public bool AddTaskGroup(TaskGroupModel taskGroup)
        {
            try
            {
                if (taskGroup == null)
                {
                    throw new Exception("TaskGroupService: Insert TaskGroupService did not receive a TaskGroup");
                }
                TaskGroupRepo.AddTaskGroup(taskGroup);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<TaskGroupModel> GetTaskGroups()
        {
            return TaskGroupRepo.GetAllTaskGroups().ToList();
        }
    }
}
