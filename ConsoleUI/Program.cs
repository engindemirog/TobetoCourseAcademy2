using Business.Concretes;

CategoryManager categoryManager = new CategoryManager();
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.Name);
}