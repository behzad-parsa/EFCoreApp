using EFCoreApp.Infrastructure.Persistance.Context;

public class Program
{
    private static void Main(string[] args)
    {
        ApplicationDbContext context = new ApplicationDbContext();
        var record = context.Users.FirstOrDefault();

    }
}