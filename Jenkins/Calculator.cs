using System;
using System.Linq.Expressions;

namespace Jenkins
{
    public class Calculator<T>
    {
        public T Add(T a, T b)
        {
            ParameterExpression param_a = Expression.Parameter(typeof(T), "a");
            ParameterExpression param_b = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Add(param_a, param_b);

            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, param_a, param_b).Compile();
            return add(a, b);
        }

        public T Subtract(T a, T b)
        {
            ParameterExpression param_a = Expression.Parameter(typeof(T), "a");
            ParameterExpression param_b = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Subtract(param_a, param_b);

            Func<T, T, T> subtract = Expression.Lambda<Func<T, T, T>>(body, param_a, param_b).Compile();
            return subtract(a, b);
        }

        public T Multiply(T a, T b)
        {
            ParameterExpression param_a = Expression.Parameter(typeof(T), "a");
            ParameterExpression param_b = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Multiply(param_a, param_b);

            Func<T, T, T> multiply = Expression.Lambda<Func<T, T, T>>(body, param_a, param_b).Compile();
            return multiply(a, b);
        }

        public T Divide(T a, T b)
        {
            ParameterExpression param_a = Expression.Parameter(typeof(T), "a");
            ParameterExpression param_b = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Divide(param_a, param_b);

            Func<T, T, T> divide = Expression.Lambda<Func<T, T, T>>(body, param_a, param_b).Compile();
            return divide(a, b);
        }

        public T Power(T a, T b)
        {
            ParameterExpression param_a = Expression.Parameter(typeof(T), "a");
            ParameterExpression param_b = Expression.Parameter(typeof(T), "b");

            BinaryExpression body = Expression.Power(param_a, param_b);

            Func<T, T, T> power = Expression.Lambda<Func<T, T, T>>(body, param_a, param_b).Compile();
            return power(a, b);
        }
    }
}