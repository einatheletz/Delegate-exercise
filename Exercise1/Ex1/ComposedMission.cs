using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        //date member of event amd list of Lambda Expressionsin
        public event EventHandler<double> OnCalculate;
        private List<Func<double, double>> funcList;
        private String type;
        //property of type
        public String Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        private String name;
        //property of type
        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        //constructor of the class
        public ComposedMission(String name)
        {
            this.name = name;
            this.type = "Composed";
            this.funcList = new List<Func<double, double>>();
        }

        //This function add Lambda Expressionsin to the list of function
        public ComposedMission Add(Func<double, double> func)
        {
            this.funcList.Add(func);
            return this;
        }

        //calculate the value of the expression 
        //according to the Lambda Expressionsin in the list
        public double Calculate(double value)
        {
            double res = value;
            foreach (var missin in this.funcList)
            {
                res = missin(res);  
            }
            this.OnCalculate?.Invoke(this, res);
            return res;
        }
    }
}
