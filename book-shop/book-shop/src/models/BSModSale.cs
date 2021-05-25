using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Models
{
    /// <summary>
    /// Класс сущности продажа
    /// </summary>
    public class BSModSale
    {
        /// <summary>
        /// Дата
        /// </summary>
            public DateTime Date { get; set; }

        /// <summary>
        /// Идентификатор книги
        /// </summary>
            public string BookID { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
            public uint Count { get; set; }

        /// <summary>
        /// Номер чека
        /// </summary>
            public ulong CheckNumber { get; set; }
    }
}
