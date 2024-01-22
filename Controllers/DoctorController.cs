using Microsoft.AspNetCore.Mvc;
namespace Create.Controllers;
using Read.Data;
using Read.Models;
using Microsoft.EntityFrameworkCore;

[Route("[controller]")]
[ApiController]
public class DoctorController : ControllerBase
{
  private readonly Appdbcontext context;
  public DoctorController(Appdbcontext context)
  {
    this.context = context;
  }
  [HttpGet]
  public async Task<IEnumerable<DoctorModel>> UserList()
  {
    return await context.Doctors.ToListAsync();
  }
  [HttpGet("{id}")]
  public async Task<IActionResult> GetUserListById(int id)
  {
    if (id < 1)
      return BadRequest();
    var Doctor = await context.Doctors.FirstOrDefaultAsync(m => m.Id == id);
    if (Doctor == null)
      return NotFound();
    return Ok(Doctor);
  }
}