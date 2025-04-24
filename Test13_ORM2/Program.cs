using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test13_ORM2
{
    class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string PrimaryAddress { get; set; }
        public string SecondaryAddress { get; set; }
        public string District { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

        public TimestampAttribute LastUpdate { get; set; } = new TimestampAttribute();

        public virtual City City { get; set; }
    }

    class City
    {
        [Key]
        public int CityId { get; set; }

        public string CityName { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public TimestampAttribute LastUpdate { get; set; } = new TimestampAttribute();

        public virtual ICollection<Address> Addresses { get; set; }
    }

    class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public TimestampAttribute LastUpdate { get; set; } = new TimestampAttribute();

        public virtual ICollection<City> Cities { get; set; }
    }
}
