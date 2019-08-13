using RefreshTokenAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshTokenAPI.Business.Interface
{
    public interface ILoginBusiness
    {
        User FindUser(string user);
    }
}
