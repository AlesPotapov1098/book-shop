namespace BookShop.src.models
{
    /// <summary>
    /// Класс для хранения сущности книга
    /// </summary>
    public class Book
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
            public Author Author { get; set; }
    }
}
