using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CNegocio;
using System.Web.Http.Description;
using Newtonsoft.Json;

namespace Api.Controllers
{
    public class ProductsController : ApiController
    {

        Methods objM = new Methods();
        //[ResponseType(typeof(void))]
        [HttpPost]
        public IHttpActionResult InsertProducts(int idPro, string descripcion, decimal price)
        {
            bool res;
            try
            {
                
                res = objM.InsertProducts(idPro, descripcion, price);
                
            }catch(Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
            return Ok(res);
        }

        //[ResponseType(typeof(void))]
        [HttpGet]
        public IHttpActionResult GetProductId(int idP)
        {
            string json;
            object[] res;
            try
            {
                res  = objM.GetProductsId(idP);
                json = JsonConvert.SerializeObject(res);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
            return Ok(res);
        }

        //[ResponseType(typeof(void))]
        [HttpGet]
        public IHttpActionResult GetAllProducts()
        {
            object[] arr;
            string json;
            try
            {
                arr = objM.GetAllProduct();
                json = JsonConvert.SerializeObject(arr);
            }catch(Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
            return Ok(arr);
        }

        
        [HttpDelete]
        public IHttpActionResult  DeleteProduct(int idProd)
        {
            bool res;
            try
            {
                res = objM.DeleteProducts(idProd);
            }catch(Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
            return Ok(res);
            
            
        }

        [HttpPut]
        public IHttpActionResult UpdateProduct(int idProducts, string des,decimal value)
        {
            bool res;
            try
            {
                res = objM.UpdateProduct(idProducts, des, value);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
            return Ok(res);
            
        }
       
        
        
    }
}
