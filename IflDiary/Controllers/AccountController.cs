﻿using Microsoft.AspNetCore.Mvc;

namespace IflDiary.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
