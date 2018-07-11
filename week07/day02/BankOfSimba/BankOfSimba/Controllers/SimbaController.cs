using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class SimbaController : Controller
    {
        public static List<BankAccount> bankAccounts = new List<BankAccount>
          {
             new BankAccount {Name ="Simba", Balance = 2000, AnimalType = "Animal.Lion" },
             new BankAccount {Name = "Pumbaa", Balance = 1000, AnimalType = "Animal.Warthog" },
             new BankAccount {Name = "Timon", Balance = 1020, AnimalType = "Animal.Meerkat" },
             new BankAccount {Name = "Rafiki", Balance = 5000, AnimalType = "Animal.Mandrill" },
             new BankAccount {Name = "Scar", Balance = 1000, AnimalType = "Animal.Lion" },
            
        };

        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult Simba()
        {
            BankAccount bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Animal.Lion"
            };
            return View(bankAccount);
        }

        [Route("account")]
        public IActionResult Account()
        {
            return View(bankAccounts);
        }

    }
}
