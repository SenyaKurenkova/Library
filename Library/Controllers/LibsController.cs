using Library.Interface;
using Library.mocks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class LibsController : Controller
    {
        private readonly IAllClients _allClients;
        private readonly ILibsClients _libsClients;

        public LibsController(IAllClients iAllClients, ILibsClients iLibClients)
        {
            _allClients = iAllClients;
            _libsClients = iLibClients;
        }

        public ViewResult List()
        {
            ViewBag.LibClients = "Все книги";
            var book = _libsClients.AllLibrary;
            return View(book);
        }
    }
}
