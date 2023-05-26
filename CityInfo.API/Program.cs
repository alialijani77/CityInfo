using CityInfo.DataLayer.Context;
using CityInfo.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//	.AddNewtonsoftJson(options =>
//	options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
////possible object cycle was detected which is not supported
//);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DbContext
builder.Services.AddDbContext<CityInfoDbContext>(options => options.
UseSqlServer(builder.Configuration.GetConnectionString("CityInfoDbContext")));
#endregion

#region RegisterDependencies
CityInfo.IoC.DependencyContainer.RegisterDependencies(builder.Services);
#endregion

builder.Services.AddAuthentication("Bearer")
	.AddJwtBearer(option =>
	{
		option.TokenValidationParameters = new()
		{
			ValidateIssuer = true,
			ValidateIssuerSigningKey = true,
			ValidateAudience = true,
			ValidIssuer = builder.Configuration["Authentication:Issuer"],
			ValidAudience = builder.Configuration["Authentication:Audience"],
			IssuerSigningKey = new SymmetricSecurityKey(
				Encoding.ASCII.GetBytes(builder.Configuration["Authentication:SecretForKey"])
				)
		};
	});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
