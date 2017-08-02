using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using abyssiness.Models;

namespace abyssiness.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewMember([Bind("account, password, name, phone")] Member member)
        {
            Console.WriteLine("account:" + member.account);
            Console.WriteLine("password:" + member.password);
            Console.WriteLine("name:" + member.name);
            Console.WriteLine("phone:" + member.phone);
            return RedirectToAction("Index", "Home");
        }
    }
}
