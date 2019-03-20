using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Ids = new List<string>();//lista de identificadores

        private void Form1_Load(object sender, EventArgs e)
        {
            Charge();//carga todos los elementos de la base de datos en customers
        }

        private void Lst_Datos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada cambio en el index de la lista carga por el ID los datos
            customersOP CuoP = new customersOP();
            Charge(CuoP.GetCustomerById(Ids[Lst_Datos.SelectedIndex]));
            
        }

        private void Btn_all_Click(object sender, EventArgs e)
        {
            //Recarga todos los elementos
            Charge();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            cleaner();
            MessageBox.Show("Introduzca valores en Nombre o Id para buscar");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string identificador;
            customersOP Cuop = new customersOP();

            if (Txb_Id.Text != "")
            {
                identificador = Txb_Id.Text;
                Charge(Cuop.GetCustomerById(identificador));//metodo de carga de datos a textbox
            }
            else if (Txb_ContactName.Text != "")
            {
                identificador = Txb_ContactName.Text;
                Charge (Cuop.GetCustomerByName(identificador));
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string identificador;
            customersOP Cuop = new customersOP();

            if (Txb_Id.Text != "")
            {
                identificador = Txb_Id.Text;
                Edit(Cuop.GetCustomerById(identificador));//Metodo para editar los campos del objeto
            }
            else if (Txb_ContactName.Text != "")
            {
                identificador = Txb_ContactName.Text;
                Edit(Cuop.GetCustomerByName(identificador));
            }
            else
            {
                MessageBox.Show("Escriba un ID o un Nombre para actualizar");
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //--------------------Borrado de Customers--------------
            string identificador;
            customersOP Cuop = new customersOP();
            if (Txb_Id.Text != "")
            {
                identificador = Txb_Id.Text;
                Cuop.DeleteCustomer(identificador);
            }
            else
            {
                MessageBox.Show("Escriba un ID para borrar");
            }
            Ids.RemoveRange(0, Lst_Datos.Items.Count);
            Charge();

        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            //-----------------------Crear Customer------------------
            Customer NewCust = ChargeC();
            customersOP CuoP = new customersOP();
            CuoP.CreateCustomer(NewCust);
            cleaner();
            Charge();
        }


        public void cleaner()
        {
            Txb_Id.Text = "";
            Txb_CompanyName.Text = "";
            Txb_ContactName.Text = "";
            Txb_ContactTitle.Text = "";
            Txb_Addres.Text = "";
            Txb_city.Text = "";
            Txb_Region.Text = "";
            Txb_Pc.Text = "";
            Txb_Country.Text = "";
            Txb_Phone.Text = "";
            Txb_Fax.Text = "";
        }

        public Customer ChargeC()
        {
            Customer cust = new Customer();
            cust.CustomerID = Txb_Id.Text;
            cust.CompanyName = Txb_CompanyName.Text;
            cust.ContactName = Txb_ContactName.Text;
            cust.ContactTitle = Txb_ContactTitle.Text;
            cust.Address = Txb_Addres.Text;
            cust.City = Txb_city.Text;
            cust.Region = Txb_Region.Text;
            cust.PostalCode = Txb_Pc.Text;
            cust.Country = Txb_Country.Text;
            cust.Phone = Txb_Phone.Text;
            cust.Fax = Txb_Fax.Text;
            return  cust;
        }

        public void Charge()//carga datos al list y ala lista
        {
            customersOP Custop = new customersOP();
            Lst_Datos.Items.Clear();
            foreach (Customer c in Custop.GetCustomers())
            {
                Lst_Datos.Items.Add(c.ContactName);
                Ids.Add(c.CustomerID);
            }
            Lst_Datos.SelectedIndex = 0;
            Charge(Custop.GetCustomerById(Ids[0]));//cargo el primero objeto de la lsita de strings ids

        }

        public void Charge(Customer cust)
        {

            Txb_Id.Text = cust.CustomerID;
            Txb_CompanyName.Text = cust.CompanyName;
            Txb_ContactName.Text = cust.ContactName;
            Txb_ContactTitle.Text = cust.ContactTitle;
            Txb_Addres.Text = cust.Address;
            Txb_city.Text = cust.City;
            Txb_Region.Text = cust.Region;
            Txb_Pc.Text = cust.PostalCode;
            Txb_Country.Text = cust.Country;
            Txb_Phone.Text = cust.Phone;
            Txb_Fax.Text = cust.Fax;
        }

        public void Edit(Customer cust)
        {
            customersOP Cuop = new customersOP();

            if (Txb_Addres.Text != "" && Txb_Addres.Text != cust.Address)
                Cuop.UpdateCustomerAdress(cust.CustomerID, Txb_Addres.Text);
            if (Txb_CompanyName.Text != "" && Txb_CompanyName.Text != cust.CompanyName)
                Cuop.UpdateCustomerCompanyName(cust.CustomerID, Txb_CompanyName.Text);
            if (Txb_ContactName.Text != "" && Txb_ContactName.Text != cust.ContactName)
                Cuop.UpdateCustomerContactN(cust.CustomerID, Txb_ContactName.Text);
            if (Txb_ContactTitle.Text != "" && Txb_ContactTitle.Text != cust.ContactTitle)
                Cuop.UpdateCustomerCTitle(cust.CustomerID, Txb_ContactTitle.Text);
            if ( Txb_city.Text != cust.City)
                Cuop.UpdateCustomerCity(cust.CustomerID, Txb_city.Text);
            if ( Txb_Region.Text != cust.Region)
                Cuop.UpdateCustomerReg(cust.CustomerID, Txb_Region.Text);
            if ( Txb_Pc.Text != cust.PostalCode)
                Cuop.UpdateCustomerCpostal(cust.CustomerID, Txb_Pc.Text);
            if (Txb_Country.Text != "" && Txb_Country.Text != cust.Country)
                Cuop.UpdateCustomerCountry(cust.CustomerID, Txb_Country.Text);
            if ( Txb_Phone.Text != cust.Phone)
                Cuop.UpdateCustomerPnum(cust.CustomerID, Txb_Phone.Text);
            if ( Txb_Fax.Text != cust.Fax)
                Cuop.UpdateCustomerFax(cust.CustomerID, Txb_Fax.Text);
            
        }

       
    }
}
