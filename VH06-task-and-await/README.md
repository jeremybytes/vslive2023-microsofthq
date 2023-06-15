# I'll Get Back to You: Task, Await, and Asynchronous Methods in C#  

*Level: Introductory / Intermediate*  

There's a lot of confusion about async/await, Task/TPL, and asynchronous and parallel programming in general. So let's start with the basics and look at how we can call asynchronous methods using Task and then see how the "await" operator can makes things easier for us. Along the way, we'll look at continuations, ConfigureAwait, and exception handling.

You will learn:  
* How to run code after a Task is complete  
* How to handle exceptions that occur in an asynchronous method  
* When to use "ConfigureAwait"    

## Project Layout
To build and run the code, you will need to have .NET 7 installed on your machine. The demo project is a Windows desktop project, so it will only run on Windows.

**/completed/UsingTask.UI** contains a desktop application that uses asynchronous methods  
**/completed/UsingTask.Library** contains library code with asynchronous methods (called by the UI). The library calls the people service (below).  
**/completed/UsingTask.Shared** contains data objects used by both the library and the service.  
**/completed/People.Service** contains the people service (used by the library)  

## Development Environments
**Visual Studio 2022**  
The "UsingTask.sln" contains all of the projects listed above. You can either set the solution to start both the UI and Service projects (using the Solution Properties window), or you can start the service manually (see "Running the Service") and have the "UsingTask.UI" as the Startup project.

**Visual Studio Code**  
In Visual Studio Code, you will want to start the service separately from the command line (see "Running the Service"). You can leave the service running while working with the desktop application.

## Running the Service
The **.NET service** can be started from the command line by navigating to the ".../completed/People.Service" directory and typing `dotnet run`. This provides endpoints at the following locations:

* http://localhost:9874/people  
Provides a list of "Person" objects. This service will delay for 3 seconds before responding. Sample result:

```json
[{"id":1,"givenName":"John","familyName":"Koenig","startDate":"1975-10-17T00:00:00-07:00","rating":6,"formatString":null},  
{"id":2,"givenName":"Dylan","familyName":"Hunt","startDate":"2000-10-02T00:00:00-07:00","rating":8,"formatString":null}, 
{...}]
```

## Resources
**Articles**  
* [Task and Await: Consuming Awaitable Methods](http://jeremybytes.blogspot.com/2014/12/task-and-await-consuming-awaitable.html)  
* [UI Considerations When Using Asynchronous Methods](http://jeremybytes.blogspot.com/2014/12/ui-considerations-when-using.html)  
* [Task and Await: Basic Exception Handling](http://jeremybytes.blogspot.com/2015/01/task-and-await-basic-exception-handling.html)  
* [Task Continuations: Checking IsFaulted, IsCompleted, and Task.Status](http://jeremybytes.blogspot.com/2015/01/task-continuations-checking-isfaulted.html)  
* [Task.IsCompletedSuccessfully - YAY! (and hmmm)](https://jeremybytes.blogspot.com/2019/04/taskiscompletedsuccessfully-yay-and-hmmm.html)  
* [Task and Await: Basic Cancellation](http://jeremybytes.blogspot.com/2015/01/task-and-await-basic-cancellation.html)  
* [Brownfield Async: Converting IAsyncResult to Task](http://jeremybytes.blogspot.com/2016/03/brownfield-async-converting.html)  
* Book Review: [Parallel Programming with Microsoft .NET](http://jeremybytes.blogspot.com/2014/02/book-review-parallel-programming-with.html)  
* Book Review: [Async in C# 5.0](http://jeremybytes.blogspot.com/2013/01/book-review-async-in-c-50.html)  

**Video Series**  
* Playlist: [Task and Await in C#](https://www.youtube.com/watch?v=0qiB3oW_nd8&list=PLdbkZkVDyKZWWjJ5yUdd_ooLORZgOSHSP)
* Part 1: [Consuming Asynchronous Methods](https://www.youtube.com/watch?v=0qiB3oW_nd8)
* Part 2: [Basic Exception Handling](https://www.youtube.com/watch?v=2bFp7Ob-fC8)
* Part 3: [IsFaulted, IsCompleted, and Task.Status](https://www.youtube.com/watch?v=uqvfNx2de5s)
* Part 4: [Basic Cancellation](https://www.youtube.com/watch?v=q5wpZaGJ4wY)

**Progress Reporting**  
* [Simple Progress Reporting with Task](https://jeremybytes.blogspot.com/2016/12/simple-progress-reporting-with-task.html)
* [Custom Progress Reporting with Task](https://jeremybytes.blogspot.com/2016/12/custom-progress-reporting-with-task.html)
* [When Progress Reporting Goes Bad: Incremental Progress vs. Cumulative Progress](https://jeremybytes.blogspot.com/2016/12/incremental-progress-reporting-vs.html)
* [Pay Attention to Where You Create Progress Objects](https://jeremybytes.blogspot.com/2015/07/pay-attention-to-where-you-create.html)

**Related Topics**
* [Learn to Love Lambdas (and LINQ, Too!)](http://www.jeremybytes.com/Demos.aspx#LLL)
* [Get Func-y: Delegates in C#](http://www.jeremybytes.com/Demos.aspx#GF) 
* [T, Earl Grey, Hot: Generics in C#](http://www.jeremybytes.com/Demos.aspx#GEN)

**Experts**  
* [Stephen Cleary](http://blog.stephencleary.com/)
* [Lucian Wischik](http://blogs.msdn.com/b/lucian/)
* [Stephen Toub](https://devblogs.microsoft.com/pfxteam/author/toub/)

**Parallel Programming wtih Task**  
* [Run Faster: Parallel Programming in C#](http://www.jeremybytes.com/Demos.aspx#ParallelProgramming)  
* Book Review: [Parallel Programming with Microsoft .NET](https://jeremybytes.blogspot.com/2014/02/book-review-parallel-programming-with.html)  