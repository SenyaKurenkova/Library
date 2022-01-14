using Library.Interface;
using Library.mocks;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.mocks
{
    public class MockClients : IAllClients
    {
        private readonly ILibsClients _clientsLib = new MockLibRec();

        public IEnumerable<Clients> Clients {
            get
            {
                return new List<Clients>{
                new Clients { Id =1, BirthDate = Convert.ToDateTime("01.01.1980"), CreateDate= Convert.ToDateTime("01.01.2022"), Name = "Олег Андреевич Иванов",  LibRecs = (LibraryRecords)_clientsLib.AllLibrary.First()},
                new Clients{ Id =2, BirthDate = Convert.ToDateTime("01.02.1982"), CreateDate= Convert.ToDateTime("01.01.2022"), Name = "Олег Петрович Малков",  LibRecs = (LibraryRecords)_clientsLib.AllLibrary.Last()},
               // new Clients{ Id =3, BirthDate = Convert.ToDateTime("01.12.1982"), CreateDate= Convert.ToDateTime("01.01.2022"), Name = "Виктор Петрович Малков"},
                //new Clients{ Id =4, BirthDate = Convert.ToDateTime("11.02.1981"), CreateDate= Convert.ToDateTime("01.01.2022"), Name = "Павел Петрович Петров"}

                };
            }
        }

        public IEnumerable<Clients> getNameClient { get; set; }

        public Clients GetObjectClients(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}

