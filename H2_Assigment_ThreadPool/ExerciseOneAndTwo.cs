using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace H2_Assigment_ThreadPool
{
    /// <summary>
    /// Represents the second and third assigment/exercise for thread pool
    /// </summary>
    internal class ExerciseOneAndTwo
    {
        /// <summary>
        /// Runs exercise one and two
        /// </summary>
        public void RunExercise()
        {
            Stopwatch myWatch = new Stopwatch();

            Console.WriteLine("Thread Pool Execution");
            myWatch.Start();

            // ThreadPool Method Execution time
            ProcessWithThreadPoolMethod();
            myWatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod : " + myWatch.ElapsedTicks.ToString());
            myWatch.Reset();

            // Thread Method Execution time
            Console.WriteLine("Thread Execution");
            myWatch.Start();

            ProcessWithThreadMethod();
            myWatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod : " + myWatch.ElapsedTicks.ToString());
        }

        /// <summary>
        /// Callback method
        /// </summary>
        /// <param name="callback">A callback argument</param>
        public void Process(object callback)
        {
            // This is the answer for why the method should use the parameter callback
            // It is required to use the object callback as an parameter.
            // Its required for the QueueUserWorkItem and the WaitCallback, which is used in the ThreadPool method
        
            // This is the answer for the execution time
            // The ThreadPool method is almost as fast as always, there are almost no difference of execution
            // But the Thread method has a big difference of execution time.
            for(int i = 0; i < 100000; i++)
            {
                for(int j = 0; j < 100000; j++)
                {

                }
            }
        }

        /// <summary>
        /// Executes the Process method using individual threads.
        /// </summary>
        public void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        /// <summary>
        /// Executes the Process method using the ThreadPool.
        /// </summary>
        public void ProcessWithThreadPoolMethod()
        {
            for(int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
