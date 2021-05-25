namespace BookShop.SRC.Models
{
    /// <summary>
    /// Класс для хранения сущности книга
    /// </summary>
    public class BSModBook
    {
        /// <summary>
        /// Уникальный идентификатор книги по международному стандарту
        /// </summary>
            public string ID { get; set; }

        /// <summary>
        /// Название книги
        /// </summary>
            public string Title { get; set; }

        /// <summary>
        /// Предметная область
        /// </summary>
            public string SubjectArea { get; set; }

        /// <summary>
        /// Объем книги
        /// </summary>
            public ushort Volume { get; set; }

        /// <summary>
        /// Цена книги
        /// </summary>
            public ushort Price { get; set; }

        /// <summary>
        /// Автор книги
        /// </summary>
            public BSModAuthor Author { get; set; }
    }
}
