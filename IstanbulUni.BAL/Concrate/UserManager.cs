using IstanbulUni.BAL.Abstract;
using IstanbulUni.DAL.Abstract;
using IstanbulUni.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.BAL.Concrate
{
    public class UserManager : IUserService
    {
        IUser _user;
        public UserManager(IUser user)
        {
            _user = user;
        }

        public List<User> GetListBl()
        {
            return _user.GetAll();
        }

        public bool UserAddBl(User user)
        {
            var _userInfo = _user.get(t => t.Email == user.Email && t.Password == user.Password);
            if (_userInfo != null)
            {
                return true;
            }
            else { _user.Insert(user); return false; }
        }

        public bool UserLogin(User user)
        {
            var userInfo = _user.get(t => t.Email == user.Email && t.Password == user.Password);
            if (userInfo != null)
                return true;
            else return false;
        }
    }
}
