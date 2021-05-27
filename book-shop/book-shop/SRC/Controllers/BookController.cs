using BookShop.SRC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBook m_AllBooks;

        public BookController(IBook book)
        {
            m_AllBooks = book;
        }

        public ViewResult List()
        {
            var books = m_AllBooks.Books;
            return View(books);
        }
    }
}
