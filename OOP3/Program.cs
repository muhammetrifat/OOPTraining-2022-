using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            ICreditManager businessLoanManager = new BusinessLoanManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new DatabaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            RequestManager requestManager = new RequestManager();
            //requestManager.MakeAnApplication(businessLoanManager, smsLoggerService);//her ikisi de aynı işe yarar
            requestManager.MakeAnApplication(new BusinessLoanManager(), 
                new List<ILoggerService> { 
                    new DatabaseLoggerService(), 
                    new SmsLoggerService()
                });//^^^^^^^^^^^^^^^^^

            List<ICreditManager> creditManagers = new List<ICreditManager>();
            creditManagers.Add(consumerLoanManager);
            creditManagers.Add(vehicleLoanManager);
            creditManagers.Add(mortgageLoanManager);

            //requestManager.CreditPreliminaryInformation(creditManagers);

        }
    }
}