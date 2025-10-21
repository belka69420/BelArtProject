using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Seller : User
    {
        private string? about;
        private bool messages;
        private string? backgroundPic;
        private string artistName;
        private string? sellerTag1;
        private string? sellerTag2;
        private string? sellerTag3;

        public string? About { get => about; set => about = value; }
        public bool Messages { get => messages; set => messages = value; }
        public string? BackgroundPic { get => backgroundPic; set => backgroundPic = value; }
        public string ArtistName { get => artistName; set => artistName = value; }
        public string? SellerTag1 { get => sellerTag1; set => sellerTag1 = value; }
        public string? SellerTag2 { get => sellerTag2; set => sellerTag2 = value; }
        public string? SellerTag3 { get => sellerTag3; set => sellerTag3 = value; }

        public override string ToString()
        {
            return base.ToString() + artistName + "  About: " + about + " #" + sellerTag1 + " #" + sellerTag2 + " #" + sellerTag3;
        }
    }
}
