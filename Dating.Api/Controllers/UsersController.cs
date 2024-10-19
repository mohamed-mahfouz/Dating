using Dating.Api.Data;
using Dating.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dating.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext dataContext) : ControllerBase
{
    private readonly DataContext _dataContext = dataContext;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _dataContext.Users.ToListAsync();
        return users;
    }
 
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _dataContext.Users.FindAsync(id);
        
        if(user == null)
            return NotFound();

        return user;
    }
}
