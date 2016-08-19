using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecotatorPattern
{
    public static class LambdaExtensios
    {
        public static Action<T> AndThen<T>( this Action<T> first,Action<T> next )
        {
            return e => { first(e); next(e); };
        }

        public static Func<T,TReturn> AndThen<T, TReturn>( this Func<T,TReturn> first,Func<T,TReturn> next )
        {
            return ( x ) =>
            {
                dynamic a = first(x);
                dynamic b = next(a);
                return b;
            };
        }

        public static Func<T,TReturn2> Compose<T, TReturn1, TReturn2>( this Func<TReturn1,TReturn2> func1,Func<T,TReturn1> func2 )
        {
            return x => func1(func2(x));
        }
    }
}
