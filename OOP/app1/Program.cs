// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Product prd1 = new Product();

prd1.name = "süt";
prd1.price = 24.5F;
prd1.quantity = 18;
prd1.generatedDate = DateTime.Now;


Console.WriteLine(prd1.name);
Console.WriteLine(prd1.price);
Console.WriteLine(prd1.quantity);
Console.WriteLine(prd1.generatedDate);