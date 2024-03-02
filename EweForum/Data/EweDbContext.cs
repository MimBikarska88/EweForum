using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EweForum.Infrastructure.Data
{
    public class EweDbContext :DbContext 
    {
        public EweDbContext(DbContextOptions options) :base(options) { }
       
    }
}
