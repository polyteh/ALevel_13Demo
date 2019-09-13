using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeTask;

namespace GeneralTaskLib
{
    public class GeneralTask
    {
        private int numberOfIteration;
        private int maxIterationNumber = 1;
        List<SpecificTask> curTaskList;

        public GeneralTask(string _name, int _difficulty, int _durationInHours)
        {
            this.Name = _name;
            this.Difficulty = _difficulty;
            this.DurationInHours = _durationInHours;
            curTaskList = new List<SpecificTask>();
        }

        public string Name { get; set; }
        public int Difficulty { get; set; }
        public int DurationInHours { get; set; }


        public void AddSpecificTask(SpecificTask _newTask)
        {
            curTaskList.Add(_newTask);
        }
        public bool MakeTask()
        {

            foreach (var task in curTaskList)
            {
                if (this.maxIterationNumber > 0)
                {
                    this.maxIterationNumber -= (int)Math.Ceiling(this.Difficulty * task.Priority);
                }

            }
            Console.WriteLine($"Make task complete, you have score {maxIterationNumber}");
            return this.maxIterationNumber>=0? true:false;
        }

        public void PrintTotalDiff()
        {
            foreach (var task in curTaskList)
            {
                Console.WriteLine($"{ task.GetType()} duration is {(int)Math.Ceiling(this.Difficulty * task.Priority)}");
            }

        }
    }
}
