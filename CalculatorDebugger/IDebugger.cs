using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDebugger
{
    public interface IDebugger
    {
        public void ReportResult(string message);
    }
}
