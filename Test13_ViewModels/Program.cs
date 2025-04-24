using System.ComponentModel.DataAnnotations;

namespace Test13_ViewModels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class ToDoList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
