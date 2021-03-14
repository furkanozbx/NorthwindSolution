using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;

namespace Northwind.ServiceLibrary
{

    public class ShipperService : IShipperService
    {
        public List<Shipper> GetShippers()
        {
            using (NorthwindEntities db=new NorthwindEntities ())
            {
                return db.Shippers.ToList();
            }
        }
    }
}
