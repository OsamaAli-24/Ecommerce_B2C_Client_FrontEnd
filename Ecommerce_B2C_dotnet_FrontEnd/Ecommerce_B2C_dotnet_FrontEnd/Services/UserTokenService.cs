using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services
{
    public class UserTokenService:ITokenService
    {
        public Object GetToken(LoginResults param)
        {
            string key = "28EDC39862124CD7331ADEF9ED8E2"; //Secret key which will be used later during validation    
            var issuer = "http://innovative-it.com";  //normally this will be your site URL    

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Create a List of Claims, Keep claims name short    
            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permClaims.Add(new Claim("valid", "1"));
            permClaims.Add(new Claim("userId", param.Id.ToString()));
            permClaims.Add(new Claim("name", param.FirstName + param.LastName));
            permClaims.Add(new Claim("Email", param.Email));
           //permClaims.Add(new Claim("Role", param.Role));
            //Create Security Token object by giving required parameters    
            var token = new JwtSecurityToken(issuer, //Issure    
                            issuer,  //Audience    
                            permClaims,
                            expires: DateTime.Now.AddDays(1),
                            signingCredentials: credentials);
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);
            return new { data = jwt_token };
        }
    }
}