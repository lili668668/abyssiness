using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using abyssiness;

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
            Console.WriteLine("account:" + member.Account);
            Console.WriteLine("password:" + member.Password);
            Console.WriteLine("name:" + member.Name);
            Console.WriteLine("phone:" + member.Phone);
            return RedirectToAction("Index", "Home");
        }
    }
}
