using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.IRepository.Models;

namespace Tracker.Services.IServices
{
    public interface ITaskGroupService
    {
        List<TaskGroupModel> GetTaskGroups();
        bool AddTaskGroup(TaskGroupModel taskGroup);
    }
}
