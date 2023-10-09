calss Product {

    // yapısal özellikler
    public string name;
    public float price;
    public DateTime generatedDate;
    public int quantity;


    // davranışsal özellikler  
    public float getTotalPirce(){
        return price * quantity;
    }
}