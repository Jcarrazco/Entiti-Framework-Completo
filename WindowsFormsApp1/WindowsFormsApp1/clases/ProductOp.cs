using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.clases
{
    class ProductOp
    {
        private NorthwindEntities prodentities = new NorthwindEntities();
        //-------------------Create Query------------------------------------
        public void CreateProduct(Product Prod)
        {
            prodentities.Products.Add(Prod);
            prodentities.SaveChanges();
        }

        //--------------------Read Query--------------------------------------
        public List<Product> GetProducts()
        {
            return prodentities.Products.ToList();
        }

        public Product GetProductByName(string PName)//buscar por nombre
        {
            return prodentities.Products.FirstOrDefault(c => c.ProductName == PName);
        }

        //--------------------Update queries----------------------------------
        public void UpdateProductName(Product _product, string NewName)//Update ProductName
        {
            _product.ProductName = NewName;
            prodentities.SaveChanges();
        }

        public void UpdateProductSupplierId(Product _product, string SuplName)//UPdate Supplier by name
        {
            int Id = prodentities.Suppliers.FirstOrDefault(c => c.ContactName == SuplName).SupplierID;
            _product.SupplierID = Id;
            prodentities.SaveChanges();
        }

        public void UpdateProductCategoryID(Product _product, string CatName)//UPdate Category 
        {
            int Id = prodentities.Categories.FirstOrDefault(c => c.CategoryName == CatName).CategoryID;
            _product.CategoryID = Id;
            prodentities.SaveChanges();
        }

        public void UpdateProductQuantityPUnit(Product _product, string Quantity)//Update Quantity X Unit
        {
            _product.QuantityPerUnit = Quantity;
            prodentities.SaveChanges();
        }

        public void UpdateProductPrice(Product _product, decimal price)//Update product unit price
        {
            _product.UnitPrice = price;
            prodentities.SaveChanges();
        }

        public void UpdateProductUnitStock(Product _Product, Int16 stock)//Update Unit Stock
        {
            _Product.UnitsInStock = stock;
            prodentities.SaveChanges();
        }

        public void UpdateProductUnitsOrder(Product _Product, Int16 Order)//Update productos unidades en orden
        {
            _Product.UnitsOnOrder = Order;
            prodentities.SaveChanges();
        }

        public void UpdateProductReorderlvl(Product _Product, Int16 Rlvl)//Update productos nivel de orden
        {
            _Product.ReorderLevel = Rlvl;
            prodentities.SaveChanges();
        }

        public void UpdateProductState(Product _product, bool State)//Update estado del producto descontinuado
        {
            _product.Discontinued = State;
            prodentities.SaveChanges();
        }
        //----------------------------Delete query------------------------------------------------

        public void DeleteProductByName(string name)
        {
            var Product = prodentities.Products.FirstOrDefault(c => c.ProductName == name);
            prodentities.Products.Remove(Product);
            prodentities.SaveChanges();
        }
    }
}
