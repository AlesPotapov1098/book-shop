using BookShop.SRC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Interfaces
{
    public interface ICategory
    {
        IEnumerable<BSModCategory> AllCategories { get; }
    }
}
