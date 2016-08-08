using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieC
{
    public static class VIESCheckServFact
    {
        public static VIESCheckService getService(ServiceType serviceType)
        {
            switch(serviceType)
            {
                case ServiceType.SOAP:
                    return new ViesSoapImp();
                default:
                    return new ViesSoapImp();
            }
        }
    }
}
