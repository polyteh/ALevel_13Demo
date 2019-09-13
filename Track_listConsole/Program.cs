using GeneralTaskLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskListLib;
using TypeTask;

namespace Track_listConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // database of tasks
            TaskTrackerList myTaskList = new TaskTrackerList();

            
            // create new general task
            GeneralTask mynewTask = new GeneralTask("firsttask", 5, 30);

            // create new specific tasks and add to the general
            Bug newBug1 = new Bug("first bug");
            Bug newBug2 = new Bug("second bug");
            mynewTask.AddSpecificTask(newBug1);
            mynewTask.AddSpecificTask(newBug2);

            // add general task to the database
            myTaskList.AddGeneralTask(mynewTask);

            // print how many iteration we have in the current task
            TaskTrackerList.myList[0].PrintTotalDiff();
            // run the task 
            TaskTrackerList.myList[0].MakeTask();

            Console.ReadKey();





        }
    }
}
