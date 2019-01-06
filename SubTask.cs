using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternExample
{
    class SubTask : ITask
    {
        string SubTaskHeading;

        public SubTask(string heading)
        {
            SubTaskHeading = heading;
        }

        public void DisplayHeading()
        {
            Console.WriteLine(SubTaskHeading);
        }
    }
}
