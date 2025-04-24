using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test13_ORM
{
    class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual Cities? City { get; set; }

        public DateTime RegisterDate { get; set; }
    }

    class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Users> User { get; set; } = new List<Users>();

    }

    class Rents
    {
        [Key]
        public int RentId { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Users? User { get; set; }
        public int? ScooterId { get; set; }
        [ForeignKey("ScooterId")]
        public virtual Scooters? Scooter { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class Scooters

    {

        [Key]
        public int ScooterId { get; set; }
        public string Model { get; set; }
        public string GpsPosition { get; set; }
        public bool IsTaken { get; set; }
    }
}
