
using EfDatabase.Models;

AppDbContext db = new AppDbContext();
db.TblProductlists.Add(new TblProductlist
{
    ProductName = "Apple",
    Price = 1000.00m,
    Quantity = 10,
    CreatedByName = "Nay Zaw Oo",
    CreatedDateTime = DateTime.Now
});

db.SaveChanges();
var list = db.TblProductlists.ToList();
foreach (var lst in list)
{
    Console.WriteLine(lst.ProductName);
}

var item = db.TblProductlists.Where(x => x.ProductCode == "P001").FirstOrDefault();
if(item != null)
{
    item.ProductName = "Orange";
};
db.SaveChanges();

db.TblProductlists.Remove(item);

db.SaveChanges();



