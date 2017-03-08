using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice3
{
   public abstract class Employees
    {
        //The problem: You are now the developer for Acme Fun Corp.  You have been asked to design a HR system.  
        //You will need a base class from which different types of employee inherit. 
        //Use abstractions and inheritance to accomplish your goals


        //fields

        //bool fullTime;
        //int employeeIDNum;
        //bool salaryPay;
        double pay;
        int ptoDays;
        //string location;

        public Employees()
        {

        }

        public Employees(double pay, int ptoDays)
        {
            this.pay = pay;
            this.ptoDays = ptoDays;
        }

        //methods
        //calculate pto
        //get a raise

        public int CalculatePTO()
        {

            return ptoDays;
        }

    }
}
