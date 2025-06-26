using DemoSeocket.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCors(b => b.AddDefaultPolicy(o => 
    o.WithOrigins("http://localhost:5173").AllowAnyMethod().AllowCredentials().AllowAnyHeader()
));

// Add services to the container.

var app = builder.Build();

app.MapHub<MessageHub>("/ws");

// Configure the HTTP request pipeline.




app.Run();
