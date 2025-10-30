using Model;
using System;
using ViewModel;
namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ColorDB cdb = new();
            ColorList cList = cdb.SelectAll();
            foreach (Color c in cList)
                Console.WriteLine(c);
            Console.WriteLine(" ");

            CountryDB cndb = new();
            CountryList cnList = cndb.SelectAll();
            foreach (Country cn in cnList)
                Console.WriteLine(cn);
            Console.WriteLine(" ");

            MaterialDB mdb = new();
            MaterialList mList = mdb.SelectAll();
            foreach (Material m in mList)
                Console.WriteLine(m);
            Console.WriteLine(" ");

            ArtDB adb = new();
            ArtList aList = adb.SelectAll();
            foreach (Art a in aList)
                Console.WriteLine(a);
            Console.WriteLine(" ");

            FollowerDB fdb = new();
            FollowerList fList = fdb.SelectAll();
            foreach (Follower f in fList)
                Console.WriteLine(f);
            Console.WriteLine(" ");

            UserDB udb = new();
            UserList uList = udb.SelectAll();
            foreach (User u in uList)
                Console.WriteLine(u);
            Console.WriteLine(" ");

            TagArtDB tadb = new();
            TagArtList taList = tadb.SelectAll();
            foreach (TagArt ta in taList)
                Console.WriteLine(ta);
            Console.WriteLine(" ");

            SellerDB sdb = new();
            SellerList sList = sdb.SelectAll();
            foreach (Seller s in sList)
                Console.WriteLine(s);
            Console.WriteLine(" ");


        }
    }
}
