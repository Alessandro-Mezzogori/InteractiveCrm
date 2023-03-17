using Microsoft.CodeAnalysis;

namespace InteractiveCrm
{
    public class EntryPointResolver
    {
        public EntryPointResolver() { }

        public EntryPointInfo Resolve(Compilation compilation)
        {
            return new EntryPointInfo
            {
                Class = "MainClass",
                Method = "Execute",
                Namespace = null
            };
        }
    }
}