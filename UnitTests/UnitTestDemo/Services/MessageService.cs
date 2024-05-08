using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestDemo.Services
{
    public class MessageService
    {
        public Func<string> msg1 = () => "Hello there test!";
        public Func<string> msg2 = () => "Good Morning!";        
    }
}