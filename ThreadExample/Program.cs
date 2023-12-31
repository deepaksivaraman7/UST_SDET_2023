﻿//using System;
//using System.Threading;

//class ThreadExample
//{
//    static void Main()
//    { // Create two threads
//        Thread thread1 = new Thread(T1); Thread thread2 = new Thread(T1);

//        // Start the threads
//        thread1.Start();
//        thread2.Start();

//        // Wait for the threads to finish
//        thread1.Join();
//        thread2.Join();

//        Console.WriteLine("Both threads have completed their work.");
//    }

//    static void T1()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
//            Thread.Sleep(100); // Simulate some work
//        }
//    }
//}


//using System;
//using System.Threading;

//class Warehouse
//{
//    private int boxCount = 0;

//    public void AddBox(int workerId)
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Thread.Sleep(200); // Simulate the time it takes to add a box
//            boxCount++;
//            Console.WriteLine($"Worker {workerId} added a box. Total boxes: {boxCount}");
//        }
//    }
//    public int GetTotalBoxes()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Thread.Sleep(200); // Simulate the time it takes to add a box
//            boxCount++;
//        }
//        return boxCount;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Warehouse warehouse = new Warehouse();

//        Thread worker1 = new Thread(() => warehouse.AddBox(1));
//        Thread worker2 = new Thread(() => warehouse.AddBox(2));

//        worker1.Start();
//        worker2.Start();

//        worker1.Join();
//        worker2.Join();

//        Console.WriteLine("Work completed. Total boxes in the warehouse: " + warehouse.GetTotalBoxes());
//    }
//}
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class CourseRegistration
{
    private List<string> registeredStudents = new List<string>();

    public void RegisterStudent(string studentName)
    {
        Thread.Sleep(100); // Simulate the time it takes to register a student
        lock (registeredStudents)
        {
            registeredStudents.Add(studentName);
            Console.WriteLine($"{studentName} has registered for the course.");
        }
    }

    public int GetRegisteredStudentCount()
    {
        lock (registeredStudents)
        {
            return registeredStudents.Count;
        }
    }
}

class Program
{
    static void Main()
    {
        CourseRegistration course = new CourseRegistration(); int numberOfStudents = 5;

        List<Thread> studentThreads = new List<Thread>();

        for (int i = 1; i <= numberOfStudents; i++)
        {
            string studentName = $"Student {i}";
            Thread studentThread = new Thread(() => course.RegisterStudent(studentName));
            studentThreads.Add(studentThread);
            studentThread.Start();
        }

        foreach (Thread studentThread in studentThreads)
        {
            studentThread.Join();
        }

        Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
    }
}
//using System;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main()
//    {
//        Console.WriteLine("Starting the asynchronous operation...");

//        //Perform an asynchronous operation
//        await PerformAsyncOperation();

//        Console.WriteLine("Asynchronous operation completed.");
//    }

//    static async Task PerformAsyncOperation()
//    {
//        //Simulate an asynchronous operation
//        await Task.Delay(2000); // Delay for 2 seconds (simulating work)
//        Console.WriteLine("Async operation is complete.");
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main()
//    {
//        List<string> urls = new List<string> { "https://www.example.com", "https://www.google.com", "https://www.microsoft.com" };

//        Console.WriteLine("Downloading web pages asynchronously...");

//        List<Task<string>> downloadTasks = new List<Task<string>>();

//        foreach (string url in urls)
//        {
//            downloadTasks.Add(DownloadWebPageAsync(url));
//        }

//        await Task.WhenAll(downloadTasks);

//        foreach (Task<string> task in downloadTasks)
//        {
//            string content = await task;
//            Console.WriteLine($"Downloaded {content.Length} bytes from a web page.");
//        }

//        Console.WriteLine("All web pages downloaded.");
//    }

//    static async Task<string> DownloadWebPageAsync(string url)
//    {
//        using (HttpClient client = new HttpClient())
//        {
//            string content = await client.GetStringAsync(url);
//            return content;
//        }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//class CourseRegistration
//{
//    private List<string> registeredStudents = new List<string>();

//    public async Task RegisterStudentAsync(string studentName)
//    {
//        // Simulate an asynchronous registration process
//        await Task.Delay(1000); // Delay for 1 second (simulating work)
//        lock (registeredStudents)
//        {
//            registeredStudents.Add(studentName);
//            Console.WriteLine($"{studentName} has registered for the course.");
//        }
//    }

//    public int GetRegisteredStudentCount()
//    {
//        lock (registeredStudents)
//        {
//            return registeredStudents.Count;
//        }
//    }
//}
//class Program
//{
//    static async Task Main()
//    {
//        CourseRegistration course = new CourseRegistration(); int numberOfStudents = 5;

//        List<Task> registrationTasks = new List<Task>();

//        for (int i = 1; i <= numberOfStudents; i++)
//        {
//            string studentName = $"Student {i}";
//            Task registrationTask = course.RegisterStudentAsync(studentName);
//            registrationTasks.Add(registrationTask);
//        }

//        await Task.WhenAll(registrationTasks);

//        Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
//    }
//}