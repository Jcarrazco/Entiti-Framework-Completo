using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //CRUD: Create Read Update Delete
    class customersOP
    {
        private NorthwindEntities entities = new NorthwindEntities();
        //-------------------Create Query------------------------------------
        public void CreateCustomer(Customer NewCustom)
        {
            entities.Customers.Add(NewCustom);
            entities.SaveChanges();
        }


        //-------------------Read queries------------------------------------
        public List<Customer> GetCustomers()//lista todos
        {
            return entities.Customers.ToList();
        }

        public Customer GetCustomerById(string id)//bucar por ID
        {
            return entities.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public Customer GetCustomerByName(string name)//buscar por nombre
        {
            return entities.Customers.FirstOrDefault(c => c.ContactName == name);
        }
        //-------------------Updates-----------------------------------------------
        public void UpdateCustomerCompanyName (string id, string CompanyName)//update company name
        {
            var customer = GetCustomerById(id);

            if (customer != null)
            {
                customer.CompanyName = CompanyName;
                entities.SaveChanges();//cambia o gurada los valores
            }
        }

        public void UpdateCustomerContactN (string id, string contact)//Update name contact
        {
            var custom = GetCustomerById(id);

            if (custom != null)
            {
                custom.ContactName = contact;
                entities.SaveChanges();
            }

        }

        public void UpdateCustomerAdress (string id, string Addres)//update addres
        {
            var custom = GetCustomerById(id);
            if (custom != null)
            {
                custom.Address = Addres;
                entities.SaveChanges();
            }
        }

        public void UpdateCustomerCTitle(string id, string Title)//update ContactTitle
        {
            var custom = GetCustomerById(id);
            if (custom != null)
            {
                custom.ContactTitle = Title;
                entities.SaveChanges();
            }
            
        }

        public void UpdateCustomerCity(string id, string City)//update City
        {
            var custom = GetCustomerById(id);

            if (custom != null)
            {
                custom.City = City;
                entities.SaveChanges();
            }
            
        }

        public void UpdateCustomerReg(string id, string Reg)//update Region
        {
            var custom = GetCustomerById(id);

            if (custom != null)
            {
                custom.Region = Reg;
                entities.SaveChanges();
            }
        }

        public void UpdateCustomerCpostal(string id, string Cpostal)//update Postal code
        {
            var custom = GetCustomerById(id);

            if (custom != null)
            {
                custom.PostalCode = Cpostal;
                entities.SaveChanges();
            }
        }

        public void UpdateCustomerCountry(string id, string Country)//update Country
        {
            var custom = GetCustomerById(id);

            if (custom != null)
            {
                custom.Country = Country;
                entities.SaveChanges();
            }
        }

        public void UpdateCustomerPnum(string id, string Pnum)//update Phone Number
        {
            var custom = GetCustomerById(id);

            if (custom != null)
            {
                custom.Phone = Pnum;
                entities.SaveChanges();
            }
        }

        public void UpdateCustomerFax(string id, string Fax)//update Fax
        {
            var custom = GetCustomerById(id);

            if (custom != null)
            {
                custom.Fax = Fax;
                entities.SaveChanges();
            }
        }

        //-----------------------------------------DELETE query-------------------------
        public void DeleteCustomer (string ID)//delete by id
        {
            var customr = GetCustomerById(ID);//obtiene el Customer Id
            List<Order> orden = entities.Orders.ToList();//lista todas las ordenes
            List<Order> Res_order = new List<Order>();//lista de resultados
            foreach (Order o in orden)//saca una lista de las ordenes que corresponden a los customers
            {
                if (o.CustomerID == ID)
                    Res_order.Add(o);
            }
            //busca en las lista de ordenes y borra los detalles de la orden y la orden
            foreach (Order o in Res_order)
            {
                foreach(Order_Detail od in entities.Order_Details.ToList())
                {
                    if(od.OrderID == o.OrderID)
                    entities.Order_Details.Remove(od);
                }
                entities.Orders.Remove(o);
            }
            entities.Customers.Remove(customr);
            entities.SaveChanges();
        }
    }
}
