namespace AspNetCoreTest.Api.Endpoints;

public static class DeleteUserEndpoint
{
    public static IResult Handler(int id)
    {
        var context = new FakeAppContext();
        var users = context.Users.ToList();
        var user = users.FirstOrDefault(x => x.Id == id);
        context.Users.Remove(user);
        return Results.Ok(user);
    }
}