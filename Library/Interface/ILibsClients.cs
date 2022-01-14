using Library.Models;
using System;
using System.Collections.Generic;

namespace Library.Interface
{
    public interface ILibsClients
    {
        IEnumerable<LibraryRecords> AllLibrary { get; }
    }
}
