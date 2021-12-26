using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WEB_PROJESI.Models;

namespace WEB_PROJESI.Data
{
    public class ApplicationDbContext : IdentityDbContext<Course>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
       
    }
}
