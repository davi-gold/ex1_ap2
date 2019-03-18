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
        private event Func funcLst;
        private double result;
        public event EventHandler<double> OnCalculate;

        // constructor
        public ComposedMission(string str)
        {
            this.funcName = str;
        }

        // Add function
        public ComposedMission Add(Func f)
        {
            this.funcLst += f;
            return this; // for fluent programming
        }
        public double Calculate(double value)
        {
            if (funcLst != null)
                this.result = funcLst(value);
            OnCalculate?.Invoke(this,result); // Raise the event
            return result;
        }
        string IMission.Name => this.funcName;
        string IMission.Type => "Composed";
    }
}