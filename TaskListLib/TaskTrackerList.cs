using GeneralTaskLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListLib
{

    public class TaskTrackerList
    {

        public static List<GeneralTask> myList=new List<GeneralTask>();

        public void AddGeneralTask(GeneralTask newTask)
        {
            myList.Add(newTask);
        }

        public bool ExecuteTask(GeneralTask executeTask)
        {
            return executeTask.MakeTask();

        }
    }
}
