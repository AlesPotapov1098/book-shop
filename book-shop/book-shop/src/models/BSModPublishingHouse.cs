using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.src.models
{
    /// <summary>
    /// Класс для сущности издательство
    /// </summary>
    public class BSModPublishingHouse
    {
        /// <summary>
        /// Уникальный идентификатор сущности
        /// </summary>
            public int ID { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
            public string Address { get; set; }

        /// <summary>
        /// Название издательства
        /// </summary>
            public string Name { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
            public string PhoneNumber { get; set; }

        /// <summary>
        /// Факс
        /// </summary>
            public string FaxNumber { get; set; }

        /// <summary>
        /// Менеджер
        /// </summary>
            public BSModManager Manager { get; set; }
    }
}
