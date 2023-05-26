using AutoMapper;
using City.Info.Application.Services.Interfaces;
using CityInfo.Domain.Entities;
using CityInfo.Domain.Interfaces.Authentication;
using CityInfo.Domain.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace City.Info.Application.Services.Implementions.Authentication
{
	public class AuthenticationService : IAuthenticationService
	{
		private readonly IAuthenticationRepository _authenticationRepository;
		private readonly IConfiguration _Configuration;

		public AuthenticationService(IAuthenticationRepository authenticationRepository,IConfiguration configuration)
        {
			_authenticationRepository = authenticationRepository;
			_Configuration = configuration;
        }
        public async Task<string> Authenticate(UserLoginViewModel userLoginViewModel)
		{
			var user = new User();
			user.Email = userLoginViewModel.Email;
			user.Password = userLoginViewModel.Password;
			var isUserExist = await _authenticationRepository.IsUserExist(user);
			if(!isUserExist)
			{
				return null;
			}
			var securitykey = new SymmetricSecurityKey(
				Encoding.ASCII.GetBytes(_Configuration["Authentication:SecretForKey"])
				);

			var signingCredentials = new SigningCredentials(
				securitykey,SecurityAlgorithms.HmacSha256
				);

			var claimsForToken = new List<Claim>();
			claimsForToken.Add(new Claim("email", userLoginViewModel.Email));
			//claimsForToken.Add(new Claim("userId", userLoginViewModel.Email));

			var jwtSecurityToken = new JwtSecurityToken(
				 _Configuration["Authentication:Issuer"],
				 _Configuration["Authentication:Audience"],
				 claimsForToken,
				 DateTime.UtcNow,
				 DateTime.UtcNow.AddHours(1),
				 signingCredentials
				);

			var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);


			return tokenToReturn.ToString();
		}
	}
}
