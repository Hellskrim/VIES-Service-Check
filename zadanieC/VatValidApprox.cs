using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieC.VatChecker;

namespace ZadanieC
{
    public class VatValidApprox
    {
        private string countryCode;
        private string vatNumber;
        private string traderName;
        private string traderCompanyType;
        private string traderStreet;
        private string traderPostcode;
        private string traderCity;
        private string requesterCountryCode;
        private string requesterVatNumber;
        private bool   valid;
        private string traderAddress;
        private VatChecker.matchCode traderNameMatch;
        private bool   traderNameMatchSpecified;
        private VatChecker.matchCode traderCompanyTypeMatch;
        private bool   traderCompanyTypeMatchSpecified;
        private VatChecker.matchCode traderStreetMatch;
        private bool   traderStreetMatchSpecified;
        private VatChecker.matchCode traderPostcodeMatch;
        private bool   traderPostcodeMatchSpecified;
        private VatChecker.matchCode traderCityMatch;
        private bool   traderCityMatchSpecified;
        private string requestIdentifier;

        public VatValidApprox()
        {

        }

        public VatValidApprox( string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode,
                               string traderCity, string requesterCountryCode, string requesterVatNumber, bool valid, string traderAddress,
                               VatChecker.matchCode traderNameMatch, bool traderNameMatchSpecified, VatChecker.matchCode traderCompanyTypeMatch,
                               bool traderCompanyTypeMatchSpecified, VatChecker.matchCode traderStreetMatch, bool traderStreetMatchSpecified,
                               VatChecker.matchCode traderPostcodeMatch, bool traderPostcodeMatchSpecified, VatChecker.matchCode traderCityMatch,
                               bool traderCityMatchSpecified, string requestIdentifier)
        {
            this.gsCountryCode = countryCode;
            this.gsVatNumber = vatNumber;
            this.gsTraderName = traderName;
            this.gsTraderCompanyType = traderCompanyType;
            this.gsTraderStreet = traderStreet;
            this.gsTraderPostcode = traderPostcode;
            this.gsTraderCity = traderCity;
            this.gsRequesterCountryCode = requesterCountryCode;
            this.gsRequesterVatNumber = requesterVatNumber;
            this.gsValid = valid;
            this.gsTraderAddress = traderAddress;
            this.gsTraderNameMatch = traderNameMatch;
            this.gsTraderNameMatchSpecified = traderNameMatchSpecified;
            this.gsTraderCompanyTypeMatch = traderCompanyTypeMatch;
            this.gsTraderCompanyTypeMatchSpecified = traderCompanyTypeMatchSpecified;
            this.gsTraderStreetMatch = traderStreetMatch;
            this.gsTraderStreetMatchSpecified = traderStreetMatchSpecified;
            this.gsTraderPostcodeMatch = traderPostcodeMatch;
            this.gsTraderPostcodeMatchSpecified = traderPostcodeMatchSpecified;
            this.gsTraderCityMatch = traderCityMatch;
            this.gsTraderCityMatchSpecified = traderCityMatchSpecified;
            this.gsRequestIdentifier = requestIdentifier;
        }

        public string gsCountryCode { get { return countryCode; } set { countryCode = value; } }
        public string gsVatNumber { get { return vatNumber; } set { vatNumber = value; } }
        public string gsTraderName { get { return traderName; } set { traderName = value; } }
        public string gsTraderCompanyType { get { return traderCompanyType; } set { traderCompanyType = value; } }
        public string gsTraderStreet { get { return traderStreet; } set { traderStreet = value; } }
        public string gsTraderPostcode { get { return traderPostcode; } set { traderPostcode = value; } }
        public string gsTraderCity { get { return traderCity; } set { traderCity = value; } }
        public string gsRequesterCountryCode { get { return requesterCountryCode; } set { requesterCountryCode = value; } }
        public string gsRequesterVatNumber { get { return requesterVatNumber; } set { requesterVatNumber = value; } }
        public bool gsValid { get { return valid; } set { valid = value; } }
        public string gsTraderAddress { get { return traderAddress; } set { traderAddress = value; } }
        public matchCode gsTraderNameMatch { get { return traderNameMatch; } set { traderNameMatch = value; } }
        public bool gsTraderNameMatchSpecified { get { return traderNameMatchSpecified; } set { traderNameMatchSpecified = value; } }
        public matchCode gsTraderCompanyTypeMatch { get { return traderCompanyTypeMatch; } set { traderCompanyTypeMatch = value; } }
        public bool gsTraderCompanyTypeMatchSpecified { get { return traderCompanyTypeMatchSpecified; } set { traderCompanyTypeMatchSpecified = value; } }
        public matchCode gsTraderStreetMatch { get { return traderStreetMatch; } set { traderStreetMatch = value; } }
        public bool gsTraderStreetMatchSpecified { get { return traderStreetMatchSpecified; } set { traderStreetMatchSpecified = value; } }
        public matchCode gsTraderPostcodeMatch { get { return traderPostcodeMatch; } set { traderPostcodeMatch = value; } }
        public bool gsTraderPostcodeMatchSpecified { get { return traderPostcodeMatchSpecified; } set { traderPostcodeMatchSpecified = value; } }
        public matchCode gsTraderCityMatch { get { return traderCityMatch; } set { traderCityMatch = value; } }
        public bool gsTraderCityMatchSpecified { get { return traderCityMatchSpecified; } set { traderCityMatchSpecified = value; } }
        public string gsRequestIdentifier { get { return requestIdentifier; } set { requestIdentifier = value; } }

        
    }
}
