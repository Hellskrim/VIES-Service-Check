using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieC
{
    public interface VIESCheckService
    {
        bool checkVat(string countryCode, string vatNumber);
        VatValid getDetailVat(string countryCode, string vatNumber);


        bool checkVatApprox(string countryCode, string vatNumber, string requesterCountryCode, string requesterVatNumber);

        VatValidApprox getDetailVatApprox(string countryCode, string vatNumber, string requesterCountryCode, string requesterVatNumber);
    }
}
