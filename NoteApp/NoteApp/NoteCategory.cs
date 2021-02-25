using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Перечисление "Категории заметок" 
    /// </summary>
    public enum NoteCategory
    {
        /// <summary>
        /// Категория Работа
        /// </summary>
        Work,
        /// <summary>
        /// Категория Дом
        /// </summary>
        Home,
        /// <summary>
        /// Категория Здоровье и спорт
        /// </summary>
        HealthAndSport,
        /// <summary>
        /// Категория Люди
        /// </summary>
        People,
        /// <summary>
        /// Категория Документы
        /// </summary>
        Documents,
        /// <summary>
        /// Категория Финансы
        /// </summary>
        Finance,
        /// <summary>
        /// Категория Другое
        /// </summary>
        Other
    }
}
