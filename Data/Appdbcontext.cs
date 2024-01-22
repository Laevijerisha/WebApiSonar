namespace Read.Data;
using Read.Models;
using Microsoft.EntityFrameworkCore;

public class Appdbcontext : DbContext
{
    public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
    {

    }
    public DbSet<DoctorModel> Doctors{ get; set; }

}
