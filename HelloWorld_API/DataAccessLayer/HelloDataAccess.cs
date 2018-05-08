using System;
using HelloWorld_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld_API.DataAccessLayer
{
    public class HelloDataAccess : IHelloDataAccess
    {
        private List<HelloModel> messages = new List<HelloModel>
        {
            new HelloModel { ID = 1, Message = "Hello World" },
             new HelloModel { ID = 2, Message = "Hello Universe" },
        };

        public HelloModel  Delete(int id)
        {
            var message = GetByID(id);
            if (message != null)
            {
                messages.Remove(message);
                return message;
            }
            return null;
        }

       

       public HelloModel GetByID(int id)
        {
           if(id!=0)
            {
                return messages.FirstOrDefault(x => x.ID == id);
            }
            return null;
        }

        List<HelloModel> IHelloDataAccess.GetHello()
        {
            return messages;
            //return new HelloModel
            //{
            //    ID = 1,
            //    Message = "Hello World"
            //};
        }

        HelloModel IHelloDataAccess.Save(HelloModel obj)
        {
            HelloModel message = new HelloModel();
            if (messages == null)
            {
                message = new HelloModel
                {
                    ID = 1 ,
                    Message = obj.Message
                };

              //  messages.Add(message);
                return message;
            }
            message.ID = messages.Count + 1;
            message.Message = obj.Message;
            return message;
        }
    }
}