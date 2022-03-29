using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDebugger
{
    public class Debugger : IDebugger
    {

        void IDebugger.ReportResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}
