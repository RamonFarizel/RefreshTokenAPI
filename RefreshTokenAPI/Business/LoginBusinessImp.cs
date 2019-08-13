using RefreshTokenAPI.Business.Interface;
using RefreshTokenAPI.Models;
using RefreshTokenAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshTokenAPI.Business
{
    public class LoginBusinessImp : ILoginBusiness
    {
        private ILoginRepository _loginRepository;

        public LoginBusinessImp(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public User FindUser(string user)
        {
            return _loginRepository.FindUser(user);
        }
    }
}
