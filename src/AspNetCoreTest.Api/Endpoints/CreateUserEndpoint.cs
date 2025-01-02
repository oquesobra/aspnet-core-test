using AspNetCoreTest.Api.Models;

namespace AspNetCoreTest.Api.Endpoints;

public static class CreateUserEndpoint
{
    public static IResult Handler(User user)
    {
        var context = new FakeAppContext();
        context.Users.Add(user);
        context.SaveChanges();
        return Results.Ok(user);
    }
}