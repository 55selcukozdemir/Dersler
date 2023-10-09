
// 🐺🐺 yeni bir product Instance oluşturduk, new'ledik vs.
Product prd1 = new Product();

prd1.Name = "süt";
prd1.price = 24.5F;
prd1.quantity = 18;
prd1.generatedDate = DateTime.Now;


// Ve değerlerini ekrana yazdırdık.
Console.WriteLine(prd1.Name);
Console.WriteLine(prd1.price);
Console.WriteLine(prd1.quantity);
Console.WriteLine(prd1.generatedDate);
Console.WriteLine(prd1.getTotalPirce());




Product prd2 = new Product(){
    Name = "Su"
}; 

Console.WriteLine(prd2.Name);
