using BookShop.SRC.Interfaces;
using BookShop.SRC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_shop.SRC.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<BSModCategory> AllCategories
        {
            get
            {
                return new List<BSModCategory>
                {
                    new BSModCategory{ ID = 1, Desk = "Художественная литература", Name = "Собор парижской Богоматери"},
                    new BSModCategory{ ID = 2, Desk = "Художественная литература", Name = "Преступление и наказание"},
                    new BSModCategory{ ID = 3, Desk = "Художественная литература", Name = "Братья Карамазовы"}
                };
            }
        }
    }
}
