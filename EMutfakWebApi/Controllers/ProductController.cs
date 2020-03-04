using EMutfakWebApi.Models;
using EMutfakWebApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMutfakWebApi.Controllers
{
    public class ProductController : ApiController
    {
        ProductService service = new ProductService();
        // GET api/<controller>
        public List<Products> Get()
        {
            return service.GetList(); 
                }

        // GET api/<controller>/5
        public Products Get(int id)
        {
            return service.Get(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Products value)
        {
            service.Create(value);
        }

        // PUT api/<controller>
        public void Put([FromBody]Products products)
        {
            service.Update(products);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}