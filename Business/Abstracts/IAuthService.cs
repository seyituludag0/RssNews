using Core.Security.JWT;
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IAuthService
    {
        //User Register(UserForRegisterDto userForRegisterDto, string password);
        //User Login(UserForLoginDto userForLoginDto);
        //bool UserExists(string email);
        //AccessToken CreateAccessToken(User user);
        //string ChangePassword(ChangePasswordDto changePasswordDto);

        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult ChangePassword(ChangePasswordDto changePasswordDto);
    }
}
