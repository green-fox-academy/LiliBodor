using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWeb.Models;

namespace TodoWeb.Repositories
{
    public class TodoDbContext : DbContext 
    {
        public DbSet<Todo> thingsToDo { get; set; }

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }
    }
}
