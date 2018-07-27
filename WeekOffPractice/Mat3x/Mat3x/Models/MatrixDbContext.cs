using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3x.Models
{
    public class MatrixDbContext : DbContext
    {
        public DbSet<Matrix> Matrices { get; set; }
        public MatrixDbContext(DbContextOptions<MatrixDbContext> options) : base(options)
        {
        }
    }
}
