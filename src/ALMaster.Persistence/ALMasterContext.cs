using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ALMaster.Domain.Models.Users;
using ALMaster.Domain.Models.Roles;
using ALMaster.Domain;
using Microsoft.EntityFrameworkCore;

namespace ALMaster.Persistence
{
  public class ALMasterContext : IdentityDbContext<User, Role, Guid>, IUnitOfWork
  {
    public ALMasterContext()
    {
    }

    public ALMasterContext(DbContextOptions<ALMasterContext> options)
        : base(options)
    {
    }
  }
}
