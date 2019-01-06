using System.Collections.Generic;

namespace CompositePatternExample
{
    class Task : ITask
    {
        List<ITask> SubTaskList;
        string Heading;

        public Task(string header, List<ITask> subtasks)
        {
            Heading = header;
            SubTaskList = subtasks;
        }


        public void DisplayHeading()
        {
            System.Console.WriteLine(Heading);
            foreach (var subtask in SubTaskList)
            {
                subtask.DisplayHeading();
            }
        }
    }
}
