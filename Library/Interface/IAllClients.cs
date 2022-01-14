using Library.Models;
using System;
using System.Collections.Generic;

namespace Library.Interface
{
    public interface IAllClients
    {
        IEnumerable<Clients> Clients { get; }
        IEnumerable<Clients> getNameClient { get; }
        Clients GetObjectClients(int clientId); 
    }
}
