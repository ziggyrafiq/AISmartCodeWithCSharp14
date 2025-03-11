using AISmartCodeWithCSharp14.Models;
using Microsoft.EntityFrameworkCore;

namespace AISmartCodeWithCSharp14.Services;

public class UserService
{
    private readonly DbContext _context;

    public UserService(DbContext context)
    {
        _context = context;
    }

    // AI-assisted method generation
    /// <summary>
    /// Retrieves a user by their ID.
    /// </summary>
    public async Task<User?> GetUserByIdAsync(Guid id) =>
    await _context.Set<User>().FirstOrDefaultAsync(u => u.Id == id);

    //AI-Debugging method
    //public void PrintUserNames(List<User> users)
    //{
    //    foreach (var user in users)
    //    {
    //        Console.WriteLine(user.FullName);
    //    }
    //}

    //AI-Debugging Suggested Fix
    public void PrintUserNames(List<User>? users)
    {
        if (users is not { Count: > 0 })
        {
            Console.WriteLine("No users found.");
            return;
        }

        users.ForEach(user => Console.WriteLine(user.FullName));
    }


}
