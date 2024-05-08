using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Services
{
    public class ArithService
    {
        public Func<int, int, int> add = (a, b) => a + b;
        public Func<int, int, int> mul = (a, b) => a * b;
        public Func<int, int, int> sub = (a, b) => a - b;
        public Func<int, int, int> div = (a, b) => a / b;
    }
}