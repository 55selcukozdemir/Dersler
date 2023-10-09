calss Product {

    // yapısal özellikler
    public string name;
    public float price;
    public DateTime generatedDate;
    public int quantity;

    // Bu değer dışarıdan erişim engeli olması için private olarak saklandı.
    private float tacRate = .18f;

    // davranışsal özellikler  
    public float getTotalPirce(){
        return price * quantity + CalculateTax();
    }


    /*
    * Sınıf dışında erişmek için kapalı konumdadır. 
    * Informating hiding : Bilgi sakladık
    */
    private float CalculateTax(){
        return private * quantity * tacRate;
    }

}