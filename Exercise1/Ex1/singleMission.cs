using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        //date member func,event OnCalculate,type,name
        private Func<double, double> func ;      
        public event EventHandler<double> OnCalculate;
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
        public SingleMission(Func<double, double> func ,String name)
        {
            this.func = func;
            this.name = name;
            this.type = "Single";
        }

        //calculate the value of the expression 
        //according to the Lambda Expressionsin in the constructor
        public double Calculate(double value)
        {
            double res = this.func(value);
            this.OnCalculate?.Invoke(this, res); 
            return res;

        }
    }
}
