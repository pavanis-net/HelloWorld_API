using HelloWorld_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld_API.BusinessLayer
{
    public interface IHelloBusinessLayer
    {
        List<HelloModel> GetHello();

        HelloModel GetByID(int id);

        HelloModel Save(HelloModel obj);

        HelloModel Delete(int id);

    }
}