using CalculatorDebugger;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTests
{
    public interface IMockDebugger : IDebugger
    {
        public List<string> MessageStore { get; set; }
    }
}
