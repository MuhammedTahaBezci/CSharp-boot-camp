using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RecourseManager
    {
        public void ToRecourse(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPreApproval(List<ICreditManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }

        
    }
}
