using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    // This class represents Composed Mission - one or more functions
    public class ComposedMission : IMission
    {
        private double result;
        private string funcName;
        private event Func funcComp; 

        public event EventHandler<double> OnCalculate;

        // Constructor
        public ComposedMission(string str)
        {
            this.funcName = str;
        }

        // Add function
        public ComposedMission Add(Func f)
        {
            this.funcComp += f;
            return this; // for fluent programming
        }

        // This function runs the inner functions for calculation and call the subscribers 
        public double Calculate(double value)
        {
            this.result = value;
            this.funcComp(value);
            // if not null then invoke the function inside with the parameter 'result'
            OnCalculate?.Invoke(this,result); // Raise the event
            return result;
        }

        // Properties
        string IMission.Name => this.funcName;
        string IMission.Type => "Composed";
    }
}