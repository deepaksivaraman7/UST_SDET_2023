using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Node
    {
        public TaskItem Data { get; set; }
        public Node Next { get; set; }

        public Node(TaskItem data)
        {
            Data = data;
            Next = null;
        }
    }
}
