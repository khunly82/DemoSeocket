using DemoSeocket.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

// Add services to the container.

var app = builder.Build();

app.MapHub<MessageHub>("/ws");

// Configure the HTTP request pipeline.




app.Run();
