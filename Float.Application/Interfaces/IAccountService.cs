﻿using Float.Application.DTOs.Account;
using Float.Application.Wrappers;
using System.Threading.Tasks;

namespace Float.Application.Interfaces
{
    public interface IAccountService
    {
       Task<Response<UserAccountDTO>> CreateUserAccount(UserAccountDTO newUser);
    }
}
