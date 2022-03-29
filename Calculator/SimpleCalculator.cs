using CalculatorDebugger;

namespace Calculator
{
    public class SimpleCalculator : ISimpleCalculator
    {
        IDebugger debugger;

        public SimpleCalculator()
        {

        }

        public SimpleCalculator(IDebugger debugger)
        {
            this.debugger = debugger;
        }

        public int Add(int start, int amount)
        {
            var result = start + amount;

            CallDebugger($"Add method result: {result}");
            return result;
        }

        public float Divide(int start, int by)
        {
            var result = (float)start / by;

            CallDebugger($"Divide method result: {result}");
            return result;
        }

        public int Multiply(int start, int by)
        {
            var result = start * by;

            CallDebugger($"Multiply method result: {result}");
            return result;
        }

        public int Subtract(int start, int amount)
        {
            var result =  start - amount;

            CallDebugger($"Subtract method result: {result}");
            
            return result;
        }

        private void CallDebugger(string message)
        {
            if (debugger != null)
            {
                debugger.ReportResult(message);
            }

        }
    }
}
