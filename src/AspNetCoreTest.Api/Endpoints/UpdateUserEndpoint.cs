using AspNetCoreTest.Api.Models;

namespace AspNetCoreTest.Api.Endpoints;

public static class UpdateUserEndpoint
{
    public static IResult Handler(User user)
    {
        try
        {
            var context = new FakeAppContext();
            var allUsers = context.Users.ToList();
            var userToUpdate = allUsers.FirstOrDefault(u => u.Id == user.Id);
            context.Users.Remove(userToUpdate);
            context.Users.Add(user);
            context.SaveChanges();
            return Results.Ok(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}