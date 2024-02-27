using BusinessLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;

namespace BusinessLayer
{
    public class UserBL : IUserBL
    {
        private readonly IUserDA userDA;

        public UserBL(IUserDA userBL)
        {
            this.userDA = userBL;
        }


        //public List<GE::Users> GetUsers()
        public List<User> GetUsers()

        {
            return this.userDA.GetUsers();
        }
    }
}
