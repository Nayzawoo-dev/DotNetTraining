// See https://aka.ms/new-console-template for more information
using Efcoretest2.Models;



AppDbContext db = new AppDbContext();
db.TblProductlists.Add(new TblProductlist
{
    ProductName = "Orange",
    Price = 1000.00m,
    Quantity = 10,
    CreatedDateTime = DateTime.Now,
    CreatedByName = "Nay Zaw Oo"
});

db.SaveChanges();

var item = db.TblProductlists.Where(x => x.ProductCode == "P003").FirstOrDefault();
db.TblProductlists.Remove(item);
db.SaveChanges();
db.TblProductlists.Remove(item);
db.SaveChanges();
Console.WriteLine("Hello, World!");

var item2 = db.TblWindows.Where(x => x.UserName == "Ya Na").FirstOrDefault();
if(item2 != null)
{
    item2.UserName = "Khoon Shoon";
}
db.SaveChanges();


