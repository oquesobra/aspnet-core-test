namespace AspNetCoreTest.Api.Endpoints;

public static class ReadUsersEndpoint
{
    public static IResult Handler()
    {
        var context = new FakeAppContext();
        var users = context.Users.ToList();
        return Results.Ok(users);
    }
}