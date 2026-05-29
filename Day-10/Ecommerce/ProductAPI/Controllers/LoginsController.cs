using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class LoginsController : ControllerBase
{
    private readonly EshoppingDbContext _context;
    public LoginsController(EshoppingDbContext context)
    {
        _context = context;
    }

    // GET: api/Login
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Login>>> GetLogin()
    {
        return await _context.Logins.ToListAsync();
    }

    // GET: api/Login/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Login>> GetLogin(int id)
    {
        var login = await _context.Logins.FindAsync(id);

        if (login == null)
        {
            return NotFound();
        }

        return login;
    }

    // PUT: api/Login/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutLogin(int? id, Login login)
    {
        if (id != login.Id)
        {
            return BadRequest();
        }

        _context.Entry(login).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!LoginExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Login
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult> PostLogin(Login login)
    {
        var loginObject = await _context.Logins.FirstOrDefaultAsync(x =>
        x.UserName == login.UserName &&
        x.Password == login.Password);

        if (loginObject == null)
        {
            return Unauthorized("Invalid username or password");
        }

        return Ok(loginObject);
    }

    // DELETE: api/Login/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLogin(int? id)
    {
        var login = await _context.Logins.FindAsync(id);
        if (login == null)
        {
            return NotFound();
        }

        _context.Logins.Remove(login);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool LoginExists(int? id)
    {
        return _context.Logins.Any(e => e.Id == id);
    }
}
