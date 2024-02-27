using DataAccessLayer.Interface;
using DataAccessLayer.Models;
//using GE = Global.Entity;

namespace DataAccessLayer
{
    public class UserDA : IUserDA
    {
        private readonly AppDbContext _context;

        public UserDA(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        //public List<User> GetUsers()
        //{
        //    throw new NotImplementedException();
        //}


        public List<User> GetUsers()

        {
            var data = this._context.Users.ToList();

            List<User> USERS = new List<User>();

            if (data != null && data.Count > 0)
            {
                data.ForEach(item =>
                {
                    //USERS.Add(new GE.Users()
                    USERS.Add(new User()

                    {
                        fName = item.fName,
                        lName = item.lName,
                        Email = item.Email,
                        Password = item.Password,
                        Address = item.Address,
                        Phone = item.Phone,
                        DOB = item.DOB,
                        Referral = item.Referral,
                        State = item.State,
                        Location = item.Location
                    });
                });
            }

            return data;
        }
    }
}
