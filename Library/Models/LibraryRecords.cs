using System.Collections.Generic;

namespace Library.Models
{
    public class LibraryRecords
    {
        public int Id { get; set; }
        public string Book { get; set; }

        public List<LibraryRecords> client { get; set; }

    }

}

