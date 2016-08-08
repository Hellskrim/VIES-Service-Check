using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
namespace ZadanieC
{
    public class ViesSoapImp:VIESCheckService
    {

        public bool checkVat(string countryCode, string vatNumber)
        {
            return getDetailVat(countryCode, vatNumber).gsValid;
        }

        public VatValid getDetailVat(string countryCode, string vatNumber)
        {
            bool valid;
            string name;
            string address;

            VatChecker.checkVatService checkVatService = new VatChecker.checkVatService();
            checkVatService.checkVat(ref countryCode, ref vatNumber, out valid, out name, out address);
            
            VatValid viesVat = new VatValid(countryCode, vatNumber, valid, name, address);
            return viesVat;
        }


        public bool checkVatApprox(string countryCode, string vatNumber, string requesterCountryCode, string requesterVatNumber)
        {
            return getDetailVatApprox(countryCode, vatNumber, requesterCountryCode, requesterVatNumber).gsValid;
        }
        public VatValidApprox getDetailVatApprox(string countryCode, string vatNumber, string requesterCountryCode, string requesterVatNumber)
        {
            string traderName = "";
            string traderCompanyType = "";
            string traderStreet = "";
            string traderPostcode = "";
            string traderCity = "";
            bool valid;
            string traderAddress;
            VatChecker.matchCode traderNameMatch;
            bool traderNameMatchSpecified;
            VatChecker.matchCode traderCompanyTypeMatch;
            bool traderCompanyTypeMatchSpecified;
            VatChecker.matchCode traderStreetMatch;
            bool traderStreetMatchSpecified;
            VatChecker.matchCode traderPostcodeMatch;
            bool traderPostcodeMatchSpecified;
            VatChecker.matchCode traderCityMatch;
            bool traderCityMatchSpecified;
            string requestIdentifier;
            VatChecker.checkVatService checkVatServiceApprox = new VatChecker.checkVatService();

            checkVatServiceApprox.checkVatApprox(ref countryCode,ref vatNumber, ref traderName, ref traderCompanyType, ref traderStreet, ref traderPostcode,
                                                 ref traderCity, requesterCountryCode, requesterVatNumber, out valid, out traderAddress, out traderNameMatch,
                                                 out traderNameMatchSpecified, out traderCompanyTypeMatch, out traderCompanyTypeMatchSpecified, out traderStreetMatch,
                                                 out traderStreetMatchSpecified, out traderPostcodeMatch, out traderPostcodeMatchSpecified, out traderCityMatch,
                                                 out traderCityMatchSpecified, out requestIdentifier);

            VatValidApprox viesVatApprox = new VatValidApprox(countryCode, vatNumber, traderName, traderCompanyType, traderStreet, traderPostcode, traderCity,
                                                              requesterCountryCode, requesterVatNumber, valid, traderAddress, traderNameMatch, traderNameMatchSpecified,
                                                              traderCompanyTypeMatch, traderCompanyTypeMatchSpecified, traderStreetMatch, traderStreetMatchSpecified,
                                                              traderPostcodeMatch, traderPostcodeMatchSpecified, traderCityMatch, traderCityMatchSpecified, requestIdentifier);
            return viesVatApprox;
    }

    }
}
