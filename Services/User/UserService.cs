using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models.Common;
using Models.Entities;
using Models.Request;
using Models.Respose;
using Services.Tools;

namespace Services.User
{
    public class UserService: IUserService
    {
        private readonly ShopContext _dbContext;
        private readonly AppSettings _appSettings;
        public UserService(ShopContext dbContext, IOptions<AppSettings> appSettings)
        {
            _dbContext = dbContext;
            _appSettings = appSettings.Value;
        }
        public LoginResponse SignIn(SignInDto credential)
        {
            LoginResponse response = new LoginResponse();
            var password = Encrypt.GetSha256(credential.Password);
            var user = _dbContext.Users.FirstOrDefault(d => d.Email == credential.Email && d.Password == password);
            if (user == null) return null;
            response.Email = user.Email;
            response.Token = GetToken(user);
            return response;
        }

        public LoginResponse SignUp(SignUpDto credential)
        {
            LoginResponse response = new LoginResponse();
            Users newUser = new Users();
            
            var password = Encrypt.GetSha256(credential.Password);
            var userExist = UserExist(credential.Email);
            if (userExist != null) throw new HttpRequestException(HttpStatusCode.Conflict.ToString());
            
            newUser.Name = credential.Name;
            newUser.Email = credential.Email;
            newUser.Password = password;
            var user = _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
            
            response.Email = newUser.Email;
            response.Token = GetToken(newUser);
            return response;
        }

        public List<Users> GetAll()
        {
            var users = _dbContext.Users.ToList();
            return users;
        }

        private Users UserExist(string email)
        {
            var userExist = _dbContext.Users.FirstOrDefault(d => d.Email == email);
            return userExist;
        }
        private string GetToken(Users payload)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, payload.Id.ToString()),
                        new Claim(ClaimTypes.Email, payload.Email)
                    }),
                    Expires = DateTime.UtcNow.AddDays(60),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}