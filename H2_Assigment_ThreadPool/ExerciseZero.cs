using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H2_Assigment_ThreadPool
{
    /// <summary>
    /// Represents the first assigment/exercise for thread pool
    /// </summary>
    internal class ExerciseZero
    {
        /// <summary>
        /// Runs exercise zero
        /// </summary>
        public void RunExercise()
        {
            ExerciseZero exerciseZero = new ExerciseZero();

            //for (int i = 0; i < 2; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(exerciseZero.Task1));
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(exerciseZero.Task2));
            //}

            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(exerciseZero.Task1);
                ThreadPool.QueueUserWorkItem(exerciseZero.Task2);
            }

            Console.Read();
        }

        /// <summary>
        /// Writes out that the task is executed
        /// </summary>
        /// <param name="obj"></param>
        public void Task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        /// <summary>
        /// Writes out that the task is executed
        /// </summary>
        /// <param name="obj"></param>
        public void Task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }
    }
}
