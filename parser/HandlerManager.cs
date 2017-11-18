using System;

namespace parser
{
    internal static class HandlerManager
    {
        public static Handler GetHandler(string[] args)
        {
            return new YamlHandler(args);
        }
    }

    internal class YamlHandler : Handler    {
        public YamlHandler(string[] args)
        {
            
        }

        public override void Start()
        {
            
        }
    }
}