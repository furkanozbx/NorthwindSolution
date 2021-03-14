using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ServiceLibrary
{
    [ServiceContract]
    public interface IShipperService
    {
        [OperationContract]
        List<Shipper> GetShippers();
    }
}
