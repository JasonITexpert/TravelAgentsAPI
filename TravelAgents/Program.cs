using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TravelAgents.Persistence;
using TravelAgents.Services.Authentication;
using TravelAgents.Services.Bookings;
using TravelAgents.Services.Destinations;
using TravelAgents.Services.Origins;
using TravelAgents.Services.Users;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddControllers();

    builder.Services.AddDbContext<TravelAgentsDbContext>(options =>
    {
    });
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
    builder.Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

    var jwtSettings = new JwtSettings();
    builder.Configuration.Bind(JwtSettings.sectionName, jwtSettings);
    builder.Services.AddSingleton(Options.Create(jwtSettings));
    builder.Services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings.Issuer,
        ValidAudience = jwtSettings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwtSettings.Secret)
        )
    }
    );
    builder.Services.AddScoped<IUserService, UserService>();
    builder.Services.AddSingleton<IBookingService, BookingService>();
    builder.Services.AddSingleton<IOriginService, OriginService>();
    builder.Services.AddSingleton<IDestinationService, DestinationService>();
}
//Uncomment code belown and the other commented code to enable swagger
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

//Uncomment code 
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
app.UseExceptionHandler("/error");
app.UseHttpsRedirection();
app.MapControllers();
app.UseAuthentication();
app.UseAuthorization();
app.Run();
