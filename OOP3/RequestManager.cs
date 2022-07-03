using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class RequestManager
    {
        //method injection
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)//BAŞVURU YAP
        {
            //başvuran bilgilerini değerlendirme
            //
            //
            //
            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPreliminaryInformation(List<ICreditManager> creditManagers)
        {
            foreach (ICreditManager item in creditManagers)
            {
                item.Calculate();
            }
        }
    }
}
