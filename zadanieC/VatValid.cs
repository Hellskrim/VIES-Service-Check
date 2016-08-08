using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
namespace ZadanieC
{
    public class VatValid
    {
        private string countryCode;
        private string vatNumber;
        private bool valid;
        private string name;
        private string address;

        public VatValid()
        {

        }
        public VatValid(string countryCode, string vatNumber, bool valid, string name, string address)
        {
            this.gsCountryCode = countryCode;
            this.gsVatNumber = vatNumber;
            this.gsValid = valid;
            this.gsName = name;
            this.gsAddress = address;
        }
        public string gsCountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }
        public string gsVatNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; }
        }
        public string gsName
        {
            get { return name; }
            set { name = value; }
        }
        public string gsAddress
        {
            get { return address; }
            set { address = value; }
        }
        public bool gsValid
        {
            get { return valid; }
            set { valid = value; }
        }

    }
}
