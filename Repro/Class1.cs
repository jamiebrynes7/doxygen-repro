using System;

namespace Repro
{
    public class ChildClass : BaseClass
    {
        public ChildClass() : base("", "") {}
        
        public ChildClass(string foo, string bar): base(foo ?? "", bar ?? "") {}
    }

    public class BaseClass
    {
        public BaseClass(string foo, string bar) {}
    }
}
