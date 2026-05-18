using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    public class BankAccount1
    {
        private int balance = 10000;

        private readonly object lockObj = new object();

        public void Withdraw(int amount, string taskName)
        {
            lock (lockObj)
            {
                Console.WriteLine($"{taskName} is trying to withdraw ₹{amount}");
                if (balance >= amount)
                {
                    Console.WriteLine($"{taskName} found sufficient balance: ₹{balance}");

                    // Simulate delay
                    Thread.Sleep(1000);

                    balance -= amount;

                    Console.WriteLine($"{taskName} successfully withdrew ₹{amount}");
                    Console.WriteLine($"Remaining Balance: ₹{balance}");
                }
                else
                {
                    Console.WriteLine($"{taskName} FAILED! Insufficient balance: ₹{balance}");
                }

                Console.WriteLine("------------------------------------");
            }
        }
    }

    class TaskExample
    {
        static void Main()
        {
            BankAccount1 account = new BankAccount1();

            Task[] tasks = new Task[5];

            for (int i = 0; i < 5; i++)
            {
                int taskNum = i + 1;

                tasks[i] = Task.Run(() =>
                {
                    account.Withdraw(3000, $"Task-{taskNum}");
                });
            }
            Task.WaitAll(tasks);
            Console.WriteLine("All transactions completed.");
        }
    }
}
