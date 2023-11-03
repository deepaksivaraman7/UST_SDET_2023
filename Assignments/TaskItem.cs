using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TaskItem
    {
        public TaskItem(int taskId, string? taskDescription, bool isCompleted)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }

        public int TaskId { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
        
    }
}
