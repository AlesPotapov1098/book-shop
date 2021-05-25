using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Models
{
    /// <summary>
    /// Класс сущности поставка
    /// </summary>
    public class BSModSupply
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
            public int ID { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
            public DateTime Date { get; set; }

        /// <summary>
        /// Идентификатор издательства
        /// </summary>
            public int PublishingHouseID { get; set; }

        /// <summary>
        /// Индентификатор книги
        /// </summary>
            public string BookID { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
            public uint Count { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
            public ushort Price { get; set; }
    }
}
