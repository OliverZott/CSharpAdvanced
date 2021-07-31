# Generics

- on class-level
- on function-level
- **Constraint** types:
  - IComparable
  - struct (for value types)
  - class
  - new
- Multi constrains with coma separator





-----------------------------------------------------------------------------------------
# Delegates

- Reference / Pointer to a function
- Used for designing extensible and flexible applications(eg frameworks)
- e.g. Client can be made responsible for implementing functions
- Multicast delegates [Link](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/how-to-combine-delegates-multicast-delegates)

## Steps
- create custom delegate
- implement/use methods with the same signature

## ERROR
in debug mode: filterHandler not derived from: 
  - `System.MulticastDelegate`
  - `System.Delegate`
  

## Example questions
**What will be the result value if you add multiple methods to a delegate of type Func<int,int> and call that delegate?**

Some of the candidates have realized the delegate is a reference to a group of functions, but struggled to answer the question since each function in the delegate will yield a result, but of course the call to the delegate can have only one result.
The answer is all subsequent resuts get overwritten by the next one, until the last one.

**What happens if an exception is thrown inside of a method, which is added to the delegate.?**
The answer is, the the delegate call will skip the call to any subsequent methods, and the exception is propagated to the caller.

**What if you want to skip only the method that has thrown the exception?**
You can get the list of methods added to the delegate by calling GetInvocationList() which can be iterated through, and you can deal with the exception between the calls. 





-----------------------------------------------------------------------------------------
# Lamba Expressions

- Compact functions
- Use in...
  - LINQ (Enumerable static methods like `Where()`)
  - Collection (List) methods like `FindAll()`
  - As **Predicate Delegate ** 
    https://www.tutorialsteacher.com/csharp/csharp-predicate



    

-----------------------------------------------------------------------------------------
# Events

- Reduce coupling by using **Publisher** and **Subscriber**, which don't know anything about each other!
- Publisher needs to invoke method in the subscribers 
- Therefore we need agreement/contract between publisher and subscriber -> **Delegate** determines signature of  **EventHandler**.
- **EventHander** (`OnFunctionName()`) is called in the subscribers by the publisher, when event is raised. 

## Implementation
1. ( Define a delegate. Convention: `MethodnameEventHandler()` or use default `EventHandler<TArgs>` or `EventHandler` )
2. Define an event based on the delegate or just standard EventHandler
3. Raise the event. Convention: `protected virtual void OnEventname()`7
4. Create Subscriber Services
5. Create subscription (rhs) according to event we are interested in (lhs)

## Event Args 
- Implement custom event argument class to pass additional arguments





-----------------------------------------------------------------------------------------
# Extension Methods

- Add methods to class without extending the class 
- Extension classes are **public static**
- Naming Convention: `ClassnameExtension`





-----------------------------------------------------------------------------------------
# LINQ

- Gives the capability to query objects!
  - objects in memory (e.g. collections -> Linq to object)
  - databases
  - xml
  - ADO.NET data sets 





-----------------------------------------------------------------------------------------
# Nullable Types

- Value Types cannot be null
- Sometimes wanna have null (e.g. Birthday in a database)
- Null-Coalescing operator





-----------------------------------------------------------------------------------------
# Dynamic

- Static typed languages
   - type resolution at **compile-time**
   - therefore earlier feedback
- Dynamic typed  languages
   - type resolution at **runtime**
   - more unit-tests needed for feedback
   - but easier and faster to code
- .NET4 added dynamic capability 

### dynamic
- **dynamic** easier then use reflection
- same as **object** type
- flexibility comes at cost of performance 
- unlike *object* the value stored in the variable can have it's members invoked WITHOUT explicit cast!

### Reflection

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/reflection

- reflection is way to inspect the meta-data about the type and access properties and methods!

### How resolve types/properties/members at runtime?
- **CLR** - *Common Language Runtime* is .NETs virtual machine ...
- ... that gets compiled code (**IL** - *Intermediate Language*) ...
- ... and converts that into machine-code at **run-time**
- **DLR** sits on top of **CLR** and gives the dynamic capability





-----------------------------------------------------------------------------------------
# Exception handling

- catch-block:
  - recover from error and prevent application from crashing
  - **re-throw** error to the **caller**


### GUIDELINE
- Always have global exception handling block in application (e.g. Main method in console application)
- Catch exception specifically! 
- Finally block used for managed resources (not managed by CLR --> No garbage collection applied by CLR
  - Better: **using** statement!
- **Custom Exceptions** if special exception handling is needed (e.g. default videos if smth in video-service goes wrong)
  - Uses inner exceptions --> often in EntityFramework database stuff!





  -----------------------------------------------------------------------------------------
# Asynchronous Programming

- used for blocking operations:
  - web accesses
  - databases
  - images

### How?
- Traditional approaches
  - Multi-threading
  - Callbacks
- New approach since NET 4.5
  - *Task-based*
  - **Async** / **Await**








