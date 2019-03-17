using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Func(double var);
    public class SingleMission : IMission
    {
        private Func f;
        private string funcName;
        public event EventHandler<double> OnCalculate;
        double result;

        // constructor
        public SingleMission(Func func, String str)
        {
            this.f = func;
            this.funcName = new String(str);
        }


        public double Calculate(double value)
        {
            this.result = this.f(value);
            OnCalculate?.Invoke(this, result); // Raise the event
            return result;
        }

        String Name
        {
            get
            {
                return this.funcName;
            }
        }

        String Type
        {
            get
            {
                return "Single";
            }
        }
    }
}
