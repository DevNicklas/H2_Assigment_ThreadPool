using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H2_Assigment_ThreadPool
{
    /// <summary>
    /// Represents the fourth assigment/exercise for thread pool
    /// </summary>
    internal class ExerciseThree
    {

        // This is the answer for the different methods and there functionality
        // Start() - Starts the execution of a thread
        // Sleep() - Pauses the execution of the thread for a specified amount of time
        // Suspend() - Used to suspend the execution of a thread temporarily
        // Resume() - Used to resume the execution of a suspended thread
        // Abort() - Attempts to abort the execution of a thread
        // Join() - Waits to the thread to terminate

        /// <summary>
        /// Runs exercise three
        /// </summary>
        public void RunExercise()
        {
            ThreadPool.QueueUserWorkItem(Task1);
            ThreadPool.QueueUserWorkItem(Task2);
            ThreadPool.QueueUserWorkItem(Task3);
        }

        /// <summary>
        /// Represents a task method that checks if the current thread is alive and sleeps for 1 second if it is
        /// </summary>
        /// <param name="obj">A callback argument</param>
        public void Task1(object obj)
        {
            Thread taskThread = Thread.CurrentThread;
            Console.WriteLine("Is Task 1 thread alive? " + taskThread.IsAlive);

            // Check if thread is alive
            if(taskThread.IsAlive)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Task 1 thread slept for 1 second");
            }
        }

        /// <summary>
        /// Represents a task method that checks if the current thread is a background thread, and aborts the thread if it is
        /// </summary>
        /// <param name="obj">A callback argument</param>
        public void Task2(object obj)
        {
            Thread taskThread = Thread.CurrentThread;
            Console.WriteLine("Is Task 2 thread in background? " + taskThread.IsBackground);

            // Check if thread is a background thread
            if (taskThread.IsBackground)
            {
                taskThread.Abort();
            }
        }

        /// <summary>
        /// Represents a task method that prints the priority of the current thread
        /// </summary>
        /// <param name="obj">A callback argument</param>
        public void Task3(object obj)
        {
            Thread taskThread = Thread.CurrentThread;
            Console.WriteLine("Priority of Task 3 thread: " + taskThread.Priority);

            Thread otherThread = new Thread(Task4);
            otherThread.Start();
            otherThread.Join();
        }

        /// <summary>
        /// Represents a task that just sleeps
        /// </summary>
        /// <param name="obj">A callback argument</param>
        public void Task4(object obj)
        {
            Thread.Sleep(2000);
        }
    }
}
