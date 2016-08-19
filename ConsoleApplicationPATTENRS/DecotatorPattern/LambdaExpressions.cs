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

        public static Func<T,U> AndThen<T, U>( this Func<T,U> first,Func<T,U> next ) where U : IConvertible
        {
            return ( x ) =>
            {
                dynamic a = first(x);
                dynamic b = next(x);
                return a + b - x;
            };
        }
    }
}
