using TravelAgents.Persistence;
using TravelAgents.Services.Authentication;
using TravelAgents.Services.Bookings;
using TravelAgents.Services.Destinations;
using TravelAgents.Services.Origins;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<TravelAgentsDbContext>(options =>
{

});
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddSingleton<IBookingService, BookingService>();
builder.Services.AddSingleton<IOriginService, OriginService>();
builder.Services.AddSingleton<IDestinationService, DestinationService>();
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

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
