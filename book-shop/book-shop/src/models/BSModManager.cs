using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.SRC.Models
{
    public class BSModManager
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
            public int ID { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
            public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
            public string SurName { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
            public string Sex { get; set; }
    }
}
