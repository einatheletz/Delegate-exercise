using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class FunctionsContainer
    {
        //data member of dictionary that get string and return Lambda Expressions
        //with proprty set and get
        private Dictionary<String, Func<double, double>> functionsContainer { get; set; }
        //constructor of the class
        public FunctionsContainer()
        {
            this.functionsContainer = new Dictionary<string, Func<double,double>>();
        }

        //implementaion in the calss of indexer that get string and return Lambda Expressions
        public Func<double,double> this[String function]
        {
            get
            {
                //if the name of the function not found in the dictionary
                //and the id function
                if (!functionsContainer.ContainsKey(function))
                {
                    this.functionsContainer.Add(function, val => val);
                }
                //if the name is in the dictionary return Lambda Expressions
                return functionsContainer[function];
            }
            set
            {
                //if the name is not found in the dictionary
                //put him inside
                if (!functionsContainer.ContainsKey(function))
                {
                    this.functionsContainer.Add(function, value);
                }
                //if the name is found chang the value
                else
                {
                    this.functionsContainer[function] = value;
                }
            }
        }

        //This function retune array that contains all the names
        //of the mission in argument
        public String[] getAllMissions()
        {
            String [] funcionName = new String[functionsContainer.Count];
            for(int i = 0; i < functionsContainer.Count; i++)
            {
                funcionName[i] = functionsContainer.ElementAt(i).Key;
            }
            return funcionName;

        }




    }
}
