using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace CNegocio
{
    public class Methods
    {
        AccessDataBase obj = new AccessDataBase();
        PRODUCT objp = new PRODUCT();

        public Methods()
        {
        }

        public bool InsertProducts(int id, string des, decimal price)
        {
            bool res;
            res = obj.insertProduct(id, des, price);
            return res;
        }

        public bool DeleteProducts(int id)
        {
            bool res;
            res = obj.DeleteProducts(id);
            return res;
        }

        public object[] GetAllProduct()
        {
            List<PRODUCT> objP = obj.GetAllProducts();
            object[] arr = objP.ToArray();
            return arr;
        }

        public object [] GetProductsId(int id)
        {
            List<PRODUCT> objProd = new List<PRODUCT>();
            PRODUCT arr = obj.GetProductsId(id);
            objProd.Add(arr);
            object[] arrP = objProd.ToArray();
            //object[] objPr = new object [] {arr.ID,arr.DESCRIPTION,arr.PRICE};
            return arrP;
        }

        public bool UpdateProduct (int id, string des, decimal value)
        {
            bool res;
            res = obj.UpdateProducts(id, des, value);
            return res;
        }
    }
}
