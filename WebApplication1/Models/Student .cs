namespace WebApplication1.Models
{
    // Models/Student.cs
    public class Student
    {
        public int Id { get; set; }                 // Первичный ключ
        public string FirstName { get; set; }       // Имя
        public string LastName { get; set; }        // Фамилия
        public DateTime BirthDate { get; set; }     // Дата рождения

        // Внешний ключ на группу
        public int GroupId { get; set; }            // Это внешний ключ!

        // Навигационное свойство
        public Group Group { get; set; }            // Студент принадлежит одной группе
    }
}
