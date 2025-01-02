using AspNetCoreTest.Api.Endpoints;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/create", handler: CreateUserEndpoint.Handler);
app.MapPost("/read", handler: ReadUserEndpoint.Handler);
app.MapPost("/read-all", handler: ReadUsersEndpoint.Handler);
app.MapPost("/update", handler: UpdateUserEndpoint.Handler);
app.MapPost("/delete", handler: DeleteUserEndpoint.Handler);

app.Run();