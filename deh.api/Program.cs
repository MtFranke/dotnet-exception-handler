using deh.api.Infrastructure;
using deh.api.Requests;
using deh.api.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();

app.MapPost("/user", ([FromBody] UserRequest user, IUserService userService)
    =>
{
    userService.AddAsync(user);
    return Results.NoContent();
});

app.MapGet("/user/{pesel}", (string pesel, IUserService userService)
    => userService.GetAsync(pesel));

app.Run();