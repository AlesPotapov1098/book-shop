using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Models
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
        /// Идентификатор менеджера
        /// </summary>
            public int ManagerID { get; set; }
    }
}
