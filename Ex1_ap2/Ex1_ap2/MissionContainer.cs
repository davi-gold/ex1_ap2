using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    // This class represents Functions Container - only one function
    public class FunctionsContainer
    {
        private Dictionary<string, Func> dict;
        // constructor
        public FunctionsContainer()
        {
            dict = new Dictionary<string, Func>();
        }

        public List<string> getAllMissions()
        {
            List<string> funcList = new List<string>(this.dict.Keys);
            return funcList;
        }

        public Func this[string str]
        {
            get
            {
                if (!dict.ContainsKey(str))
                    dict[str] = value => value; // for "stam" function
                return dict[str];
            }
            set
            {
                dict[str] = value;
            }
        }
    }
}