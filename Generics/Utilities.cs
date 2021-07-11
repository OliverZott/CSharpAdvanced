using System;


// Types of constraints:
//      - where T : IComparable
//      - where T : struct      ... for value types
//      - where T : class
//      - where T : new()


namespace Generics
{

    // Generic on class level
    // 'new()' is for default constructor of unknown object (T not specified yet)
    public class Utilities<T> where T : IComparable, new()
    {

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething()
        {
            var obj = new T();
        }

    }

    // Generic on function level
    public class Utilities2
    {

        public T Max<T>(T a, T b) where T : IComparable
        {

            return a.CompareTo(b) > 0 ? a : b;
        }

    }


    // Custom class as constraint
    public class DiscountCalculator<TProduct> where TProduct : Book
    {
    }


    public class Nullable<T> where T : struct
    {

        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue => _value is not null;

        public T GetValueOrDefault
        {
            get
            {
                if (HasValue)
                    return (T)_value;

                return default(T);
            }
        }
    }

}