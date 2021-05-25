using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.src.models
{
    /// <summary>
    /// Класс для сущности издательство
    /// </summary>
    public class PublishingHouse
    {
        /// <summary>
        /// Уникальный идентификатор сущности
        /// </summary>
            public int ID { get; set; }

        /// <summary>
        /// Название издательства
        /// </summary>
            public string Name { get; set; }

    }
}
