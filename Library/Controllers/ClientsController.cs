using Library.Interface;
using Library.mocks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IAllClients _allClients;
        private readonly ILibsClients _libsClients;

        public ClientsController(IAllClients iAllClients, ILibsClients iLibClients)
        {
            _allClients = iAllClients;
            _libsClients = iLibClients;
        }

        public ViewResult List()
        {
            ViewBag.LibClients = "Все клиенты";
            var clients = _allClients.Clients;
            return View(clients);
        }
    }
}
