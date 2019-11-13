using Motarbetesfunktionalitet.DåligaIdëer;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Motarbetesfunktionalitet
{
    public static class Extensions
    {
        public static T Ping<T>(this T obj, out T ball) =>
            ball = obj;

        public static TNew Pong<TOld, TNew>(this TOld obj, TNew ball) =>
            ball;

        public static Delegate Tripp<T>(this T obj, Delegate func) =>
            func;

        public static Action Trapp(this Delegate func, params object[] args) =>
            () => func.DynamicInvoke(args);

        public static Action Trull(this Action func, bool doot = true)
        {
            if (doot)
                func.Invoke();

            return func;
        }

        public static KravRamsa Ole<T>(this T obj, Delegate func, bool doot = true, params object[] args) =>
            new KravRamsa().Ole(func, doot, args);

        public static TObj Tjoff<TObj, TProp>(this TObj obj, TProp puck, Expression<Func<TObj, TProp>> mål) =>
            obj.Pong(mål.Body as MemberExpression)
                .Ping(out var stolpe)
                .Pong(stolpe.Member as PropertyInfo)
                .Ping(out var nät)
                .Pong<PropertyInfo, Action>(
                    () =>
                        obj
                            .Tripp((Action<object?, object?>)nät.SetValue)
                            .Trapp(obj, puck)
                            .Trull())
                .Trull(nät != null)
                .Pong(obj);
    }
}
