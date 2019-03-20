using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.clases
{
    class OrdersOp
    {
        private NorthwindEntities Opentities = new NorthwindEntities();

        //--------------------Create Querys------------------------------------------

        //--------------------Read query---------------------------------------------
        public List<Order> GetOrders()
        {
            return Opentities.Orders.ToList();
        }

        public List<Order> GetOrderByCustomerName(string name)
        {
            string Id = Opentities.Customers.FirstOrDefault(c => c.ContactName == name).CustomerID;
            return Opentities.Orders.Where(c => c.CustomerID == Id).ToList(); ;
        }



        //---------------------Update query------------------------------------------
        public void UpdateOrderCustomerId(Order _order,string name)//Update CustomerId
        {
            string Id = Opentities.Customers.FirstOrDefault(c => c.ContactName == name).CustomerID;
            _order.CustomerID = Id;
            Opentities.SaveChanges();
        }

        public void UpdateOrderEmployeeId(Order _order, string name, string last)//Update EmployeeId
        {
            int Id = Opentities.Employees.FirstOrDefault(c => c.FirstName == name 
                                                        && c.LastName == last).EmployeeID;
            _order.EmployeeID = Id;
            Opentities.SaveChanges();
        }
        public void UpdateOrderDateOrder(Order _order, DateTime Date)//Update orderDate
        {
            _order.OrderDate = Date;
            Opentities.SaveChanges();
        }
        public void UpdateOrderDateRequiered(Order _order, DateTime Date)//Update Requiered date
        {
            _order.OrderDate = Date;
            Opentities.SaveChanges();
        }
        public void UpdateOrderDateShiped(Order _order, DateTime Date)//Update Shiped Data
        {
            _order.OrderDate = Date;
            Opentities.SaveChanges();
        }
        public void UpdateOrderShipVia(Order _order, string name)//Update shipvia
        {
            int Id = Opentities.Shippers.FirstOrDefault(c => c.CompanyName == name).ShipperID;
            _order.ShipVia = Id;
            Opentities.SaveChanges();
        }
        public void UpdateOrderFreight(Order _order, decimal cost)//Update Freigth
        {
            _order.Freight = cost;
            Opentities.SaveChanges();
        }
        public void UpdateOrderShipName(Order _order, string name)//Update ShipName
        {
            _order.ShipName = name;
            Opentities.SaveChanges();
        }
        public void UpdateOrderShipAddres(Order _order, string Addres)//Update Addres
        {
            _order.ShipName = Addres;
            Opentities.SaveChanges();
        }
        public void UpdateOrderShipCity(Order _order, string City)//Update City
        {
            _order.ShipCity = City;
            Opentities.SaveChanges();
        }
        public void UpdateOrderShipRegion(Order _order, string Region)//Update Region
        {
            _order.ShipRegion = Region;
            Opentities.SaveChanges();
        }
        public void UpdateOrderShipPostal(Order _order, string Postal)//Update postal code
        {
            _order.ShipPostalCode = Postal;
            Opentities.SaveChanges();
        }
        public void UpdateOrderShipCountry(Order _order, string Country)//Update shipcountry
        {
            _order.ShipCity = Country;
            Opentities.SaveChanges();
        }


        //----------------------Delete Query-----------------------------------------
        public void DeleteOrder(Order _order)
        {
            Opentities.Orders.Remove(_order);
        }
    }
}
