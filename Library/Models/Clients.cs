using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual LibraryRecords LibRecs { get; set; }
    }
}
