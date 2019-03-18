using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string funcName;
        public List<Func> funComposed;
        public event EventHandler<double> OnCalculate;

        // constructor
        public ComposedMission(string str)
        {
            this.funcName = str;
            this.funComposed = new List<Func>();
        }

        // Add function
        public ComposedMission Add(Func f)
        {
            this.funComposed.Add(f);
            return this;
        }

        public double Calculate(double value)
        {
            double result = value;
            foreach (Func f in funComposed)
            {
                if (funComposed != null && f != null)
                    result = f(value);
            }
            OnCalculate?.Invoke(this,result); // Raise the event
            return result;
        }
        string IMission.Name => this.funcName;
        string IMission.Type => "Composed";
    }
}