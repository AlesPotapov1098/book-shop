using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.src.models
{
    /// <summary>
    /// Класс сущности заказчика
    /// </summary>
    public class BSModCustomer
    {
        /// <summary>
        /// Имя заказчика
        /// </summary>
            public string Name { get; set; }

        /// <summary>
        /// Фамилия заказчика
        /// </summary>
            public string SurName { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
            public string PhoneNumber { get; set; }
    }
}
