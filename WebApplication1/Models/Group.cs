namespace WebApplication1.Models
{
    // Models/Group.cs
    public class Group
    {
        public int GroupId { get; set; }                 
        public string Name { get; set; }          
        public int Course { get; set; }
        public int SpecialtyId { get; set; }

        // Навигационное свойство (один ко многим)
        public ICollection<Student> Students { get; set; } // У группы много студентов
    }
}
