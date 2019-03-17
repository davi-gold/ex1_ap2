using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise_1
{
    public class FunctionsContainer
    {
        Dictionary<String, Func> dict;

        // constructor
        FunctionsContainer()
        {
            dict = new Dictionary<string, Func>();
        }
        
        // this function 
        public List<function> getAllMissions()
        {
            List<string> funcList = new ArrayList<string>(this.dict.Keys);
            return funcList;
        }

        public dict this[String str]
        {
            get
            {
                return this.dict[str];
            }
            set
            {
                this.dict[str] = value;
            }
        }
    }
}
