using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingAndOverriding
{
    public class MethodOverloaing
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a,int b)
        {
            return a + b;

        }
    }
}
