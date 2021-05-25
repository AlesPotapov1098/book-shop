using BookShop.SRC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Interfaces
{
    public interface IBook
    {
        IEnumerable<BSModBook> Books { get; }

        IEnumerable<BSModBook> GetBook { get; set; }

        BSModBook GetObjectBook ( string bookID );
    }
}
