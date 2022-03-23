using System;

namespace AcmeScripting
{
    public class PipelineGlobals
    {
        public dynamic payload { get; init; }

        public void Log<T>(T t)
        {
            Console.WriteLine(t);
        }
    }
}
