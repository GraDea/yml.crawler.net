using System;

namespace parser
{
    class Program
    {
        static void Main(string[] args)
        {
           var handler = HandlerManager.GetHandler(args);
            handler.Start();
        }
    }

    internal static class HandlerManager
    {
        public static Handler GetHandler(string[] args)
        {
            throw new NotImplementedException();
        }
    }

    internal abstract class Handler
    {
        public Handler()
        {
            
        }

        public abstract void Start();
    }
}
