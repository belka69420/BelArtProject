using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : BaseEntity
    {
        private string userName;
        private string pass;
        private Country country;
        private string? city;
        private string? street;
        private string? streetNumber;
        private DateTime birthDate;
        private string? profilePic;
        private string? instaLink;
        private string? tiktokLink;
        private string? facebookLink;
        private string name;

        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public Country Country { get => country; set => country = value; }
        public string? City { get => city; set => city = value; }
        public string? Street { get => street; set => street = value; }
        public string? StreetNumber { get => streetNumber; set => streetNumber = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string? ProfilePic { get => profilePic; set => profilePic = value; }
        public string? InstaLink { get => instaLink; set => instaLink = value; }
        public string? TiktokLink { get => tiktokLink; set => tiktokLink = value; }
        public string? FacebookLink { get => facebookLink; set => facebookLink = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return base.ToString() +name+" - @"+userName+" ,PASSWORD: "+pass+ " Located: " + country + ", " + city + ", " + street + " " + streetNumber +
                " || Birth Day: " +birthDate+" || INSTAGRAM "+instaLink+" | TikTok "+tiktokLink+" | FaceBook "+facebookLink;
        }
    }
}
