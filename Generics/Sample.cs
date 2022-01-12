using System;

namespace Generics
{
    class Sample
    {
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // where T : IComparable
        // where T : Product
        // where T : struct
        // where T : class 
        // where T : new()

        // Constraint to an interface
        static T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // Constraint to a class
        static float CalculateDiscount<TProduct>(TProduct product) where TProduct : Product
        {
            //product.Price;
            return 0;
        }

        // Constraint to a value type
        struct Nullable<T> where T : struct
        {
            private object _value;

            public Nullable(T value)
                : this()
            {
                _value = value;
            }

            public bool HasValue
            {
                get { return _value != null; }
            }

            public T GetValueOrDefault()
            {
                if (HasValue)
                    return (T)_value;

                return default(T);
            }
        }

        // Constraint to default constructor 
        static void DoSomething<T>(T value) where T : new()
        {
            var obj = new T();
        }
    }
}
