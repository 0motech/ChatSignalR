﻿using Microsoft.AspNetCore.Mvc;

namespace ChatSignalR.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
