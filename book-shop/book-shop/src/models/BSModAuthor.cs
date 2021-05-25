using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.src.models
{
    /// <summary>
    /// Класс для хранения сущности автор
    /// </summary>
    public class BSModAuthor
    {
        /// <summary>
        /// Уникальный идентификатор автора
        /// </summary>
            public int ID { get; set; }

        /// <summary>
        /// Имя автора
        /// </summary>
            public string Name { get; set; }

        /// <summary>
        /// Фамилия автора
        /// </summary>
         public string SurName { get; set; }

        /// <summary>
        /// Годы жизни, локальная переменная класса
        /// </summary>
            private string _years;

        /// <summary>
        /// Годы жизни, константа
        /// </summary>
            public string Years => _years;

        /// <summary>
        /// Метод для указания даты рождения и смерти
        /// </summary>
        /// <param name="born">Год рождения</param>
        /// <param name="dead">Год смерти</param>
        public void SetYears(ushort born, ushort dead)
        {
            _years = born.ToString() + " - " + dead.ToString();
        }
    }
}
