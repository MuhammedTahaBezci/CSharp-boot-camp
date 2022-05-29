using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            ICreditManager housingLoanManager = new HousingLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            ICreditManager businessLoanManager = new BusinessLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {databaseLoggerService, fileLoggerService };

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.ToRecourse(housingLoanManager, loggers);

            List<ICreditManager> loans = new List<ICreditManager> {housingLoanManager, vehicleLoanManager };

            //recourseManager.CreditPreApproval(loans);

        }
    }
}