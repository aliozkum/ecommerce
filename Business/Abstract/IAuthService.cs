﻿using Core.Entities.Concrate;
using Core.Utilities.Results;
using Core.Utilities.Security.jwt;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IResult userExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);

    }
}