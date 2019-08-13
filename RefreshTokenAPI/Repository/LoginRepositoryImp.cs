using RefreshTokenAPI.Models;
using RefreshTokenAPI.Models.Context;
using RefreshTokenAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshTokenAPI.Repository
{
    public class LoginRepositoryImp : ILoginRepository
    {
        private SQLContext _context;

        public LoginRepositoryImp(SQLContext context)
        {
            _context = context;
        }

        public User FindUser(string user)
        {
            return _context.LoginUsuario.SingleOrDefault(x => x.UserID.Equals(user));
        }
    }
}
