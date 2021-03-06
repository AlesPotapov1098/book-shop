using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Models
{
    /// <summary>
    /// Класс сущности заказ
    /// </summary>
    public class BSModOrder
    {
        /// <summary>
        /// Уникальный идентификатор заказа
        /// </summary>
            public int ID { get; set; }

        /// <summary>
        /// Книга
        /// </summary>
            public BSModBook Book { get; set; }

        /// <summary>
        /// Дата заказка
        /// </summary>
            public DateTime DateStart { get; set; }

        /// <summary>
        /// Дата исполнения
        /// </summary>
            public DateTime DateEnd { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
            public ushort Count { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
            public BSModManager Worker { get; set; }
    }
}
