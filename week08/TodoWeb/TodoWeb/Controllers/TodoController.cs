using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWeb.Models;
using TodoWeb.Repositories;

namespace TodoWeb.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("todo")]
        public IActionResult List()
        {
            return Content("This is my first todo");
        }

        [HttpPost]
        public IActionResult AddTodo(Todo todo)
        {
            todoRepository.Creat(todo);
            todoRepository.SaveChanges();
            return View(List, thingsToDo.ToList();
        }

    }
}