using Library.Interface;
using Library.Models;
using System;
using System.Collections.Generic;

namespace Library.mocks
{
    public class MockLibRec : ILibsClients
    {
        public IEnumerable<LibraryRecords> AllLibrary
        {
            get { 
                return new List<LibraryRecords>{
                new LibraryRecords{ Id =1, Book = "А. С. Пушкин. Дубровский"},
                new LibraryRecords{ Id =2, Book = "А. С. Пушкин. Евгений Онегин"},
                new LibraryRecords{ Id =3, Book = "А. С. Пушкин. Капитанская дочка"},
                new LibraryRecords{ Id =4, Book = "А. С. Пушкин. Сборник"}

                }; 
            }
        }


    }
}
