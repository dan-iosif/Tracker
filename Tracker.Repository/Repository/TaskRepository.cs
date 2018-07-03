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
    public class TaskRepository: BaseRepository, ITaskRepository
    {
        public void AddUser(TaskModel taskModel)
        {
            DbContext.Tasks.Add(new Tasks()
            {
                Name = taskModel.Name,
                Description = taskModel.Description,
            });
            DbContext.SaveChanges();
        }

        public IEnumerable<TaskModel> GetAllTasks()
        {
            var result = DbContext.Tasks.Select(x => new TaskModel()
            {
                Name = x.Name,
                Description = x.Description,
                Id_Task = x.Id_Task
            }).ToList();
            return result;
        }
    }
}
