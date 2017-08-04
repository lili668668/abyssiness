using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using abyssiness;
using Microsoft.EntityFrameworkCore;

namespace abyssiness.Controllers
{
    public class RegisterController : Controller
    {
        private readonly abbyssContext _abbyssContext;

        public RegisterController(abbyssContext context)
        {
            _abbyssContext = context;
        }

        public IActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewMember([Bind("Account, Password, Name, Phone")] Member member)
        {
            Console.WriteLine("account:" + member.Account);
            Console.WriteLine("password:" + member.Password);
            Console.WriteLine("name:" + member.Name);
            Console.WriteLine("phone:" + member.Phone);

            try {
                if (ModelState.IsValid) {
                    _abbyssContext.Add(member);
                    await _abbyssContext.SaveChangesAsync();
                }
            } catch (DbUpdateException) {
                ModelState.AddModelError("", "Failed");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
