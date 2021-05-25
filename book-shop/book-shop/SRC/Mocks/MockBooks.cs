using BookShop.SRC.Interfaces;
using BookShop.SRC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_shop.SRC.Mocks
{
    public class MockBooks : IBook
    {
        private readonly ICategory category = new MockCategory();

        public IEnumerable<BSModBook> Books 
        { 
            get
            {
                return new List<BSModBook>
                {
                    new BSModBook
                    {
                        ID = "10101010", 
                        Price = 100, 
                        SubjectArea = "Художественная литература", 
                        Title = "Собор Парижской Богоматери", 
                        Volume = 500
                    },

                    new BSModBook
                    {
                        ID = "983293490",
                        Price = 200,
                        SubjectArea = "Художественная литература",
                        Title = "Преступление и наказание",
                        Volume = 500
                    },

                    new BSModBook
                    {
                        ID = "9489032489032",
                        Price = 349,
                        SubjectArea = "Художественная литература",
                        Title = "Братья Карамазовы",
                        Volume = 1000
                    }

                };
            }
        }

        public IEnumerable<BSModBook> GetBook 
        { 
            get => throw new NotImplementedException(); 
            
            set => throw new NotImplementedException(); 
        }

        public BSModBook GetObjectBook ( string bookID )
        {
            throw new NotImplementedException();
        }
    }
}
