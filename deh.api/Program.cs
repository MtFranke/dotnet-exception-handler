using deh.api.DTO;
using deh.api.Infrastructure;
using deh.api.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();

app.MapPost("/user/add", ([FromBody]UserRequest user,  IUserService userService) 
    => userService.Add(user));

app.Run();