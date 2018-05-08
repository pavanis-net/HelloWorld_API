using HelloWorld_API.Models;
using System.Collections.Generic;
using HelloWorld_API.BusinessLayer;
using HelloWorld_API.Controllers;
//using Xunit;
using Moq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectHelloWorld
{
    class TestHelloWorld
    {
        private Mock<IHelloBusinessLayer> _objHelloBal = new Mock<IHelloBusinessLayer>();

        [TestMethod]
        public void GetAllMethodWithResults()
        {
            var valueController = new ValuesController(_objHelloBal.Object);

            List<HelloModel> messages = new List<HelloModel>
        {
            new HelloModel { ID = 1, Message = "Hello World" },
             new HelloModel { ID = 2, Message = "Hello Universe" },
        };
            valueController.Get();

        }

    }

}

