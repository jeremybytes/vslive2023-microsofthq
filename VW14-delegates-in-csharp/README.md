# Get Func-y: Delegates in C#

*Level: Introductory / Intermediate*  

Delegates are the gateway to functional programming. So lets understand delegates and how we can change the way we program by using functions as parameters, variables, and properties. In addition, we'll see how the built in delegate types, Func and Action, are waiting to make our lives easier. We'll see how delegates can add elegance, extensibility, and safety to our programming.

You will learn:
* What delegates are  
* How to use functions as parameters and return values  
* Write code that can be easily extended  

## Project Layout
To build and run the code, you will need to have .NET 7 installed on your machine. The demo project is a Windows desktop project, so it will only run on Windows.

**/completed/delegates** contains a desktop application that demonstrates how to use delegates  

### Files
**MainWindow.xaml.cs** contains the UI code. This is where we use delegates in various ways.  
**Person.cs** contains the "Person" class where we add a "ToString()" method that take a delegate as a parameter.  
**Snippets.cs"** contains some "completed" code that is pasted into the project (so you do not need to watch me type everything).  

## Development Environments
**Visual Studio 2022**  
The "func-action-delegates.sln" contains the project listed above.

**Visual Studio Code**  
In Visual Studio Code, you can open the folder that has the "delegates.csproj" file.

## Resources

**Articles:**  
* [C# Delegates](http://www.jeremybytes.com/Downloads/GetFuncyWithDelegates.pdf) - PDF Walkthrough of the code samples.  
Note: This is a bit old, but the code is all still valid.
* [Exceptions in Multicast Delegates](http://jeremybytes.blogspot.com/2011/11/exceptions-in-multi-cast-delegates.html)  
* [More Delegate Exception Handling](http://jeremybytes.blogspot.com/2013/03/more-delegate-exception-handling.html)  
* [Recognizing Higher-Order Functions in C#](http://jeremybytes.blogspot.com/2014/06/recognizing-higher-order-function-in-c.html)  
* [Named Delegates Compared to Anonymous Delegates](http://jeremybytes.blogspot.com/2015/03/named-delegates-compared-to-anonymous.html)  

**YouTube Series**  
* Video Playlist: [C# Delegates](https://www.youtube.com/watch?v=cQ5qF9PmyCQ)  
* Video: [C# Delegates - Part 1: Basics](http://www.youtube.com/watch?v=v6Zb0nD7PHA)  
* Video: [C# Delegates - Part 2: Get Func-y (+ Lambdas)](http://www.youtube.com/watch?v=0nd-tcQcslc)  
* Video: [C# Delegates - Part 3: Action and Multicast Delegates](http://www.youtube.com/watch?v=0qnwc5XqVs0)  

**Additional Topics**  
* Topic (videos and articles): [Learn to Love Lambdas in C# (and LINQ, Too!)](http://www.jeremybytes.com/Demos.aspx#LLL)  
* Video: [Anatomy of a Lambda Expression](http://www.youtube.com/watch?v=WJItr-ecdCE)  
* Topic (videos and articles): [Generics in C#](http://www.jeremybytes.com/Demos.aspx#GEN)  

For additional information, please visit [jeremybytes.com](http://www.jeremybytes.com).