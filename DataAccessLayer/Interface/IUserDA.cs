using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using GE = Global.Entity;


namespace DataAccessLayer.Interface
{
    public interface IUserDA
    {
        //List<GE::Users> GetUsers();
        List<User> GetUsers();

    }
}
