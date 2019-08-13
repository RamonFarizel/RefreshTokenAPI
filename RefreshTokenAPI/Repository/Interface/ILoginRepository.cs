using RefreshTokenAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshTokenAPI.Repository.Interface
{
    public interface ILoginRepository
    {
        User FindUser(string user);
    }
}
