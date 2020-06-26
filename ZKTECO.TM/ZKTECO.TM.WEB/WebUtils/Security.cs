using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ZKTECO.TM.WEB.WebUtils
{
    public class Security
    {
        private static string _Connection = null;
        private static byte[] _SecretKey = null;

        public static string Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }

        public static byte[] SecretKey
        {

            get { return _SecretKey; }
            set { _SecretKey = value; }
        }


        public static dynamic GenerateToken(string id, bool noExpire = true)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            // var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, id)
                }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(SecretKey), SecurityAlgorithms.HmacSha256Signature)
            };
            if (noExpire)
            {
                tokenDescriptor.Expires = DateTime.Now.AddDays(100);
            }
            else
            {
                tokenDescriptor.Expires = DateTime.Now.AddHours(23);
            }
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new
            {
                token = tokenHandler.WriteToken(token),
                tokenExpiration = tokenDescriptor.Expires.GetValueOrDefault()
            };
        }
    }
}
