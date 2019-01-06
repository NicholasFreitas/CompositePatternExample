using System.Collections.Generic;

namespace CompositePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITask> bedroomSubtasks = new List<ITask>();
            bedroomSubtasks.Add(new SubTask("Make Bed"));
            bedroomSubtasks.Add(new SubTask("Do Desk"));
            bedroomSubtasks.Add(new SubTask("Dust Room"));

            var bedRoomTask = new Task("Bedroom", bedroomSubtasks);
                       

            List<ITask> kitchenSubtasks = new List<ITask>();
            kitchenSubtasks.Add(new SubTask("Clean Table"));
            kitchenSubtasks.Add(new SubTask("Wash Floor"));
            kitchenSubtasks.Add(new SubTask("Do Laundry"));
            kitchenSubtasks.Add(new SubTask("Wash Dishes"));

            var kitchenTask = new Task("Kitchen", kitchenSubtasks);
                                          

            List<ITask> todoSubtasks = new List<ITask>();
            todoSubtasks.Add(bedRoomTask);
            todoSubtasks.Add(kitchenTask);
                       


            var todoList = new Task("House", todoSubtasks);
            todoList.DisplayHeading();
            
        }
    }
}
