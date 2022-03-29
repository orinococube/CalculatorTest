using CalculatorDebugger;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTests
{
    public class MockDebugger : IDebugger
    {
        public List<string> MessageStore = new List<string>();
        void IDebugger.ReportResult(string message)
        {
            MessageStore.Add(message);
        }
    }
}
