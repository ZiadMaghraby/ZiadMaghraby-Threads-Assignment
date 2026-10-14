# Part 03 - Locking Research

Student name: Ziad Mohamed Elmaghraby
Group / ID: 

## Q1: What is System.Threading.Monitor used for?
Class in .Net responsible for synchronizing access to objects

## Q2: What does the C# lock statement compile to?
it compiles to a try/finally
bool lockTaken = false;
try
{
    Monitor.Enter(obj, ref lockTaken); 
}
finally
{
    if (lockTaken) Monitor.Exit(obj);
}

## Q3: At least two differences between lock and direct Monitor APIs?
lock is more easier and safer to use as it automatically handles the try/finally and Monitor.Exit.

## Q4: When would you use Monitor.TryEnter, Monitor.Pulse, or Monitor.Wait?
Use Monitor.TryEnter when you want to attempt to acquire a lock without blocking indefinitely
Use Monitor.Pulse OR Monitor.Wait in advanced scenarios where you need to implement a producer-consumer pattern or coordinate threads waiting for a condition to be met.

## Q5: Show the same critical section with lock and Monitor.Enter / Monitor.Exit.
private readonly object _lockObj = new object();

public void SafeOperationWithLock()
{
    lock (_lockObj)
    {
        (Critical Section)
        Console.WriteLine("Executing safely using lock statement.");
    }
}


private readonly object _lockObj = new object();

public void SafeOperationWithMonitor()
{
    bool lockTaken = false;
    try
    {
        Monitor.Enter(_lockObj, ref lockTaken);
        (Critical Section)
        Console.WriteLine("Executing safely using Monitor APIs.");
    }
    finally
    {
        if (lockTaken)
        {
            Monitor.Exit(_lockObj);
        }
    }
}
## Sources
https://learn.microsoft.com/en-us/dotnet/api/system.threading.monitor?view=net-10.0
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/lock
