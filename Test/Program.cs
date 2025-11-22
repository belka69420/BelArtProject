using Model;
using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using ViewModel;
using Color = Model.Color;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            // SELECT

            //ColorDB cdb = new();
            //ColorList cList = cdb.SelectAll();
            //foreach (Color c in cList)
            //    Console.WriteLine(c);
            //Console.WriteLine(" ");

            //CountryDB cndb = new();
            //CountryList cnList = cndb.SelectAll();
            //foreach (Country cn in cnList)
            //    Console.WriteLine(cn);
            //Console.WriteLine(" ");

            //MaterialDB mdb = new();
            //MaterialList mList = mdb.SelectAll();
            //foreach (Material m in mList)
            //    Console.WriteLine(m);
            //Console.WriteLine(" ");

            //ArtDB adb = new();
            //ArtList aList = adb.SelectAll();
            //foreach (Art a in aList)
            //    Console.WriteLine(a);
            //Console.WriteLine(" ");

            //UserDB udb = new();
            //UserList uList = udb.SelectAll();
            //foreach (User u in uList)
            //    Console.WriteLine(u);
            //Console.WriteLine(" ");

            //SellerDB sdb = new();
            //SellerList sList = sdb.SelectAll();
            //foreach (Seller s in sList)
            //    Console.WriteLine(s);
            //Console.WriteLine(" ");

            //FollowerDB fdb = new();
            //FollowerList fList = fdb.SelectAll();
            //foreach (Follower f in fList)
            //    Console.WriteLine(f);
            //Console.WriteLine(" ");

            //TagArtDB tadb = new();
            //TagArtList taList = tadb.SelectAll();
            //foreach (TagArt ta in taList)
            //    Console.WriteLine(ta);
            //Console.WriteLine(" ");

            // UPDATE

            //Color colorToUpdate = cList[0];
            //colorToUpdate.ColorName = "Baby Pink";
            //cdb.Update(colorToUpdate);
            //colorToUpdate.RgbCode = "42069";
            //cdb.Update(colorToUpdate);
            //int cu = cdb.SaveChanges();
            //Console.WriteLine($"{cu} rows been updated");
            //Console.WriteLine(" ");

            //Country countryToUpdate = cnList[0];
            //countryToUpdate.CountryName = "Ukrein";
            //cndb.Update(countryToUpdate);
            //int cnu = cndb.SaveChanges();
            //Console.WriteLine($"{cnu} rows been updated");
            //Console.WriteLine(" ");

            //Material materialToUpdate = mList[0];
            //materialToUpdate.MaterialName = "markers";
            //mdb.Update(materialToUpdate);
            //int mu = mdb.SaveChanges();
            //Console.WriteLine($"{mu} rows been updated");
            //Console.WriteLine(" ");

            //Art artToUpdate = aList[0];
            //artToUpdate.PieceName = "Sunset Dreams";
            //adb.Update(artToUpdate);
            //artToUpdate.Price = "250";
            //adb.Update(artToUpdate);
            //artToUpdate.About = "A warm sunset painting full of emotion.";
            //adb.Update(artToUpdate);
            //int au = adb.SaveChanges();
            //Console.WriteLine($"{au} rows been updated");
            //Console.WriteLine(" ");

            //User userToUpdate = uList[0];
            //userToUpdate.UserName = "NewUserName123";
            //userToUpdate.Pass = "newpassword456";
            //userToUpdate.City = "New City";
            //userToUpdate.Street = "Main Street 42";
            //userToUpdate.StreetNumber = "99";
            //userToUpdate.ProfilePic = "newProfilePicLink.jpg";
            //userToUpdate.InstaLink = "https://instagram.com/newUser";
            //userToUpdate.TiktokLink = "https://tiktok.com/@newUser";
            //userToUpdate.FacebookLink = "https://facebook.com/newUser";
            //userToUpdate.Name = "New Full Name";
            //udb.Update(userToUpdate); // Save changes
            //int uu = udb.SaveChanges();
            //Console.WriteLine($"{uu} rows have been updated");
            //Console.WriteLine(" ");

            //Seller sellerToUpdate = sList[0];
            //sellerToUpdate.About = "Modern art inspired by nature";
            //sdb.Update(sellerToUpdate); //sellerToUpdate.ArtistName = "ArtByLuna";
            //sdb.Update(sellerToUpdate);//sellerToUpdate.SellerTag1 = "abstract";
            //sellerToUpdate.SellerTag2 = "modern";
            //sellerToUpdate.SellerTag3 = "nature";
            //sdb.Update(sellerToUpdate);
            //int su = sdb.SaveChanges();
            //Console.WriteLine($"{su} rows been updated");
            //Console.WriteLine(" ");

            //Follower followerToUpdate = fList[0];
            //followerToUpdate.IdFollowed = fList.Last().IdFollower;
            //fdb.Update(followerToUpdate);
            //followerToUpdate.IdFollower = fList[1].IdFollowed;
            //fdb.Update(followerToUpdate);
            //int fu = fdb.SaveChanges();
            //Console.WriteLine($"{fu} rows been updated");
            //Console.WriteLine(" ");

            //TagArt tagArtToUpdate = taList[0];
            //tagArtToUpdate.IdArt = aList.Last();
            //tadb.Update(tagArtToUpdate);
            //tagArtToUpdate.TagName = "cute";
            //tadb.Update(tagArtToUpdate);
            //int tu = tadb.SaveChanges();
            //Console.WriteLine($"{tu} rows been updated");
            //Console.WriteLine(" ");

            // INSERT

            //Color color1 = new Color { ColorName = "color", RgbCode = "1238888" };
            //cdb.Insert(color1);
            //int cx = cdb.SaveChanges();
            //Console.WriteLine("rows affected: " + cx);

            ////Country country1 = new Country { CountryName = "japan" };
            ////cndb.Insert(country1);
            ////int cnx = cndb.SaveChanges();
            ////Console.WriteLine(cnx);

            ////Material material1 = new Material { MaterialName = "somting" };
            ////mdb.Insert(material1);
            ////int mx = mdb.SaveChanges();
            ////Console.WriteLine("rows added: " + mx);

            ////Art art1 = new Art
            ////{
            ////    IdSeller = sList[0],
            ////    PicLink1 = "art1_pic1.jpg",
            ////    PicLink2 = "art1_pic2.jpg",
            ////    PicLink3 = "art1_pic3.jpg",
            ////    PicLink4 = "art1_pic4.jpg",
            ////    Country = cnList[0],
            ////    City = "Jerusalem",
            ////    Street = "King George",
            ////    StreetNumber = "22",
            ////    PlaceName = "Art Studio 5",
            ////    PieceName = "Blue Horizon",
            ////    SelfPickUp = "Yes",
            ////    Price = "450",
            ////    Height = "60",
            ////    Width = "90",
            ////    About = "A peaceful blue-themed painting symbolizing serenity.",
            ////    Color1 = cList[5],
            ////    Color2 = cList[6],
            ////    Color3 = cList[7],
            ////    Material = mList[4]
            ////};
            ////adb.Insert(art1 );
            ////int ax = adb.SaveChanges();
            ////Console.WriteLine(ax);

            //User user1 = new User
            //{
            //    UserName = "maayan_bel",
            //    Pass = "12345",
            //    Country = cnList[2],
            //    City = "Tel Aviv",
            //    Street = "Herzl",
            //    StreetNumber = "10",
            //    BirthDate = new DateTime(2005, 6, 12),
            //    ProfilePic = "profile1.jpg",
            //    InstaLink = "https://www.instagram.com/maayan_bel",
            //    TiktokLink = "https://www.tiktok.com/@maayan_bel",
            //    FacebookLink = "https://www.facebook.com/maayan.bel",
            //    Name = "Maayan Bel"
            //};
            //udb.Insert(user1);
            //int ux = udb.SaveChanges();
            //Console.WriteLine(ux);

            //Seller seller1 = new Seller
            //{

            //    About = "I create unique abstract paintings.",
            //    Messages = true, // true if the seller accepts messages
            //    BackgroundPic = "background1.jpg",
            //    ArtistName = "Maayan Bel",
            //    SellerTag1 = "abstract",
            //    SellerTag2 = "colorful",
            //    SellerTag3 = "modern",
            //    Id = uList[10].Id
            //};
            //sdb.Insert(seller1);
            //int sx = sdb.SaveChanges();
            //Console.WriteLine(sx);

            ////Follower follower1 = new Follower { IdFollower = uList[4], IdFollowed= uList[0] };
            ////fdb.Insert(follower1);
            ////int fx = fdb.SaveChanges();
            ////Console.WriteLine(fx);

            ////TagArt tagArt1 = new TagArt { IdArt = aList[2], TagName = "newstyle" };
            ////tadb.Insert(tagArt1 );
            ////int tx = tadb.SaveChanges();
            ////Console.WriteLine(tx);

            // DELETE

            //Console.WriteLine("\nDelete");
            //Color colorToDelete = cList.Last();
            //cdb.Delete(colorToDelete);
            //int cy = cdb.SaveChanges();
            //Console.WriteLine($"{cy} rows were deleted");
            //Console.WriteLine("colors after delete: ");
            //cList = cdb.SelectAll();
            //foreach (Color c in cList)
            //    Console.WriteLine(c.ColorName + "  " + c.RgbCode + " " + c.Id);

            //Console.WriteLine("\nDelete");
            //Country countryToDelete = cnList.Last();
            //cndb.Delete(countryToDelete);
            //int cny = cndb.SaveChanges();
            //Console.WriteLine($"{cny} rows were deleted");
            //Console.WriteLine("countries after delete: ");
            //cnList = cndb.SelectAll();
            //foreach (Country cn in cnList)
            //    Console.WriteLine(cn.CountryName + " " + cn.Id);

            // Console.WriteLine("\nDelete");
            // Material materialToDelete = mList.Last();
            // mdb.Delete(materialToDelete);
            // int my = mdb.SaveChanges();
            // Console.WriteLine($"{my} rows were deleted");
            // Console.WriteLine("materials after delete: ");
            // mList = mdb.SelectAll();
            //foreach (Material m in mList)
            //     Console.WriteLine(m);

            // Console.WriteLine("\nDelete");
            // Art artToDelete = aList.Last();
            // adb.Delete(artToDelete);
            // int ay = adb.SaveChanges();
            // Console.WriteLine(ay + " rows were deleted");
            // Console.WriteLine("arts after delete: ");
            // aList = adb.SelectAll();
            // foreach (Art a in aList)
            //     Console.WriteLine(a);
            // Console.WriteLine(" ");

            // Console.WriteLine("\nDelete");
            // User userToDelete = uList.Last();
            // udb.Delete(userToDelete);
            // int uy = udb.SaveChanges();
            // Console.WriteLine(uy + " rows were deleted");
            // Console.WriteLine("users after delete: ");
            // uList = udb.SelectAll();
            // foreach (User u in uList)
            //     Console.WriteLine(u);
            // Console.WriteLine(" ");

            // Console.WriteLine("\nDelete");
            // Seller sellerToDelete = sList.Last();
            // sdb.Delete(sellerToDelete);
            // int sy = sdb.SaveChanges();
            // Console.WriteLine(sy + " rows were deleted");
            // Console.WriteLine("sellers after delete: ");
            // sList = sdb.SelectAll();
            // foreach (Seller s in sList)
            //     Console.WriteLine(s);
            // Console.WriteLine(" ");

            // Console.WriteLine("\nDelete");
            // Follower followerToDelete = fList.Last();
            // fdb.Delete(followerToDelete);
            // int fy = fdb.SaveChanges();
            // Console.WriteLine(fy + " rows were deleted");
            // Console.WriteLine("followers after delete: ");
            // fList = fdb.SelectAll();
            // foreach (Follower f in fList)
            //     Console.WriteLine(f);
            // Console.WriteLine(" ");

            // Console.WriteLine("\nDelete");
            // TagArt tagArtToDelete = taList.Last();
            // tadb.Delete(tagArtToDelete);
            // int tay = tadb.SaveChanges();
            // Console.WriteLine(tay + " rows were deleted");
            // Console.WriteLine("tagarts after delete: ");
            // taList = tadb.SelectAll();
            // foreach (TagArt ta in taList)
            //     Console.WriteLine(ta);
            // Console.WriteLine(" ");




        }
    }
}
