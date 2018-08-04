using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.IRepository.Interfaces;
using Tracker.IRepository.Models;
using Tracker.Data;

namespace Tracker.Repository.Repository
{
    public class TaskGroupRepository : BaseRepository, ITaskGroupRepository
    {
        public void AddTaskGroup(TaskGroupModel taskGroup)
        {
            DbContext.TaskGroups.Add(new TaskGroups()
            {
                GroupName = taskGroup.GroupName
            });
            DbContext.SaveChanges();
        }

        public IEnumerable<TaskGroupModel> GetAllTaskGroups()
        {
            var result = DbContext.TaskGroups.Select(x => new TaskGroupModel()
            {
                GroupName = x.GroupName,
                Id_TaskGroupModel = x.Id_TaskGroup
            }).ToList();
            return result;
        }
    }
}
