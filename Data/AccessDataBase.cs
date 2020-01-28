using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections;

namespace Data
{
    public class AccessDataBase : DbContext 
    {
            public AccessDataBase () : base("name=ApiContex")
            {

            }
        //public PRODUCTEntities()
        //: base("name=PRODUCTEntities")
        //base("name=ProductAzureContext")

        ApiContex bd = new ApiContex();
        //InsertProducts
        public bool insertProduct (int idPr,string des, decimal value)
        {
            PRODUCT objProducts = new PRODUCT {ID=idPr,DESCRIPTION=des,PRICE=value};
            if (objProducts == null)
            {
                return false;

            }
            else
            {
                bd.PRODUCTS.Add(objProducts);
                bd.SaveChanges();
                return true;
            }
 
        }
        //GetProductId
        public PRODUCT GetProductsId(int id)
        {

            PRODUCT objp = bd.PRODUCTS.FirstOrDefault(p => p.ID == id);
            //object[] arr = ((IEnumerable)objp).Cast<object>()
            //                .Select(x => x.ToString())
            //                .ToArray();
            return objp;

        }


        // GetAllProducts
        public List<PRODUCT> GetAllProducts()
        {
            List<PRODUCT> productsList = (from PRODUCTS in bd.PRODUCTS select PRODUCTS).ToList<PRODUCT>();
            return productsList;
        }

        //DeleteProducts
        public bool DeleteProducts(int id)
        {
            PRODUCT pro = bd.PRODUCTS.FirstOrDefault(p => p.ID == id);
            if (pro == null)
            {
                return false;
            }
            else
            {
                bd.PRODUCTS.Remove(pro);
                bd.SaveChanges();
                return true;
            }
            
        }

        //UpdateProducts
        public bool UpdateProducts (int id, string des, decimal value)
        {
            PRODUCT Upro = bd.PRODUCTS.FirstOrDefault(p => p.ID == id);
            Upro.DESCRIPTION = des;
            Upro.PRICE = value;
            if (Upro == null)
            {
                return false;
            }else
            {
                bd.SaveChanges();
                return true;
            }
        }

        
    }
        
    
}
