using HelloWorld_API.Models;
using System.Collections.Generic;

namespace HelloWorld_API.DataAccessLayer
{
    public interface IHelloDataAccess
    {
        List<HelloModel> GetHello();

        HelloModel GetByID(int id);

        HelloModel Save(HelloModel obj);

        HelloModel Delete(int id);
       
       
    }
}