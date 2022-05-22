using RealLifeInterfaceAndAbstract.Abstract;
using RealLifeInterfaceAndAbstract.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealLifeInterfaceAndAbstract.Adapters
{
    internal class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.Name.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth);
            return true;
        }
    }
}
