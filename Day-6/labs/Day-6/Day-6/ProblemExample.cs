using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class BankAccount
    {
        private int balance = 10000;
        private readonly object lockObj = new object();
        public void Withdraw(int amount, string threadName)
        {
            lock (lockObj)
            {
                Console.WriteLine($"{threadName} is trying to withdraw ₹{amount}");

                if (balance >= amount)
                {
                    Console.WriteLine($"{threadName} found sufficient balance: ₹{balance}");

                    // Simulate delay (to expose race condition if no lock)
                    Thread.Sleep(1000);
                    balance -= amount;
                    Console.WriteLine($"{threadName} successfully withdrew ₹{amount}");
                    Console.WriteLine($"Remaining Balance: ₹{balance}");
                }
                else
                {
                    Console.WriteLine($"{threadName} FAILED! Insufficient balance: ₹{balance}");
                }

                Console.WriteLine("------------------------------------");
            }
        }
    }

    class ProblemExample
    {
        static void Main6()
        {
            BankAccount account = new BankAccount();

            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                int threadNum = i + 1;

                threads[i] = new Thread(() =>
                {
                    account.Withdraw(3000, $"Thread-{threadNum}");
                });

                threads[i].Start();
            }
            foreach (var t in threads)
            {
                t.Join();
            }

            Console.WriteLine("All transactions completed.");
        }
    }
}
