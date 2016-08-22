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

        public static Func<T,TReturn2> AndThen<T, TReturn, TReturn2>( this Func<T,TReturn> first,Func<TReturn,TReturn2> next )
        {
            return x => next(first(x));
        }

        public static Func<T,TReturn2> Compose<T, TReturn1, TReturn2>( this Func<TReturn1,TReturn2> func1,Func<T,TReturn1> func2 )
        {
            return x => func1(func2(x));
        }

    }


    
}
