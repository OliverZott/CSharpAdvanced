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


