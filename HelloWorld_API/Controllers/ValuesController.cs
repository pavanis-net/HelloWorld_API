using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld_API.BusinessLayer;
using HelloWorld_API.Models;


namespace HelloWorld_API.Controllers
{
   
    public class ValuesController : ApiController
    {
        private readonly IHelloBusinessLayer _objHelloBAL;

       public  ValuesController (IHelloBusinessLayer objHelloBal)
        {
            _objHelloBAL = objHelloBal;
        }
      
        public IHttpActionResult Get()
        {
            try
            {
                var objHello = _objHelloBAL.GetHello();

                return Ok(objHello);
            }
            catch (HttpRequestException httpRequestException)
            {
                return BadRequest("Error: " + httpRequestException.Message);
            }
        }


        public IHttpActionResult Get(int? id)
        {
            try
            {
                var objHello = _objHelloBAL.GetByID(id.Value);

                return Ok(objHello);
            }
            catch (HttpRequestException httpRequestException)
            {
                return BadRequest("Error: " + httpRequestException.Message);
            }
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]string value)
        {
            try
            {
                HelloModel objHelloModel = new HelloModel() { Message = value.ToString() };
                 _objHelloBAL.Save(objHelloModel);
                return Ok();
            }
            catch (HttpRequestException httpRequestException)
            {
                return BadRequest("Error: " + httpRequestException.Message);
            }
             
        }


        // DELETE api/values/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _objHelloBAL.Delete(id);
                return Ok();
            }
            catch (HttpRequestException httpRequestException)
            {
                return BadRequest("Error: " + httpRequestException.Message);
            }

        }
    }
}
