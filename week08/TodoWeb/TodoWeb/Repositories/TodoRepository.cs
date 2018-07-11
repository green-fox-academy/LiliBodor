using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWeb.Models;

namespace TodoWeb.Repositories
{
    public class TodoRepository : ITodoRepository<Todo>
    {
        private TodoDbContext todoDbContext;

        public TodoRepository(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public void Creat(Todo element)
        {
            todoDbContext.thingsToDo.Add(element);
            todoDbContext.SaveChanges();
        }

        public void Delete(Todo element)
        {
            todoDbContext.thingsToDo.Remove(element);
            todoDbContext.SaveChanges();
        }

        public List<Todo> GetAllElements()
        {
            return todoDbContext.thingsToDo.ToList();
        }

        public void Update(Todo element)
        {
            todoDbContext.thingsToDo.Update(element);
            todoDbContext.SaveChanges();
        }
    }
}
