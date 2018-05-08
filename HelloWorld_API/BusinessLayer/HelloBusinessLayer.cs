using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWorld_API.Models;
using HelloWorld_API.DataAccessLayer;

namespace HelloWorld_API.BusinessLayer
{
    public class HelloBusinessLayer : IHelloBusinessLayer
{
        private readonly IHelloDataAccess _objHelloDal;
        public HelloBusinessLayer(IHelloDataAccess objHelloDal)
        {
            _objHelloDal = objHelloDal;
        }

        public HelloModel Delete(int id)
        {
            return _objHelloDal.Delete(id);
        }

        public HelloModel GetByID(int id)
        {
            return _objHelloDal.GetByID(id);
        }

        public List<HelloModel> GetHello()
        {
            return _objHelloDal.GetHello();
        }

        public HelloModel Save(HelloModel obj)
        {
            return _objHelloDal.Save(obj);
        }
    }
}