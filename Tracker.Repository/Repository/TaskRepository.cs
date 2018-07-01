using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.IRepository.Interfaces;
using Tracker.IRepository.Models;

namespace Tracker.Repository.Repository
{
    public class TaskRepository: BaseRepository, ITaskRepository
    {
        public IEnumerable<TaskModel> GetAllTasks()
        {
            return null;
        }
    }
}
