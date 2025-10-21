using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Art: BaseEntity
    {
        private Seller idSeller;
        private string picLink1;
        private string? picLink2;
        private string? picLink3;
        private string? picLink4;
        private Country country;
        private string? city;
        private string? street;
        private string? streetNumber;
        private string? placeName;
        private string pieceName;
        private string? selfPickUp;
        private string price;
        private string height;
        private string width;
        private string? about;
        private Color? color1;
        private Color? color2;
        private Color? color3;
        private Material material;

        public Seller IdSeller { get => idSeller; set => idSeller = value; }
        public string PicLink1 { get => picLink1; set => picLink1 = value; }
        public string? PicLink2 { get => picLink2; set => picLink2 = value; }
        public string? PicLink3 { get => picLink3; set => picLink3 = value; }
        public string? PicLink4 { get => picLink4; set => picLink4 = value; }
        public Country Country { get => country; set => country = value; }
        public string? City { get => city; set => city = value; }
        public string? Street { get => street; set => street = value; }
        public string? StreetNumber { get => streetNumber; set => streetNumber = value; }
        public string? PlaceName { get => placeName; set => placeName = value; }
        public string PieceName { get => pieceName; set => pieceName = value; }
        public string? SelfPickUp { get => selfPickUp; set => selfPickUp = value; }
        public string Price { get => price; set => price = value; }
        public string Height { get => height; set => height = value; }
        public string Width { get => width; set => width = value; }
        public string? About { get => about; set => about = value; }
        public Color? Color1 { get => color1; set => color1 = value; }
        public Color? Color2 { get => color2; set => color2 = value; }
        public Color? Color3 { get => color3; set => color3 = value; }
        internal Material Material { get => material; set => material = value; }

        public override string ToString()
        {
            return base.ToString() + "PIECE: " + pieceName + " By: " + idSeller.ArtistName + " - @" + idSeller.UserName + " -ABOUT- " + about +
                " || " + price + "$ , Height: " + height + " X Width: " + width +
                " Located: " + country + ", " + city + ", " + street + " " + streetNumber +
                " || " + color1 + ", " + color2 + ", " + color3 + ", Material: " + material;
        }
    }
}
