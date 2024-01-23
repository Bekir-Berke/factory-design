class Program{
    interface ICar{
    string getColor();
    double getPrice();
    int getModelYear();
    bool getBackupCamera();
    void showCarInfo();
}
class BMW : ICar
{
    private string color;
    private double price;
    private int modelYear;
    private bool backupCamera;
    public BMW(String color, double price, int modelYear, bool backupCamera){
        this.color = color;
        this.price = price;
        this.modelYear = modelYear;
        this.backupCamera = backupCamera;
    }

    public bool getBackupCamera()
    {
        return backupCamera;
    }

    public string getColor()
    {
       return color;
    }

    public double getPrice()
    {
        return price;
    }

    public int getModelYear()
    {
        return modelYear;
    }

    public void showCarInfo()
    {
        Console.WriteLine("Araba Markası : BMW");
        Console.WriteLine("Araba Fiyatı : "+price);
        Console.WriteLine("Araba Model Yılı : "+modelYear);
        if(backupCamera){
            Console.WriteLine("Arka Kamera Özelliği : Var");
        }else{
            Console.WriteLine("Arka Kamera Özelliği : Yok");
        }
    }
}

class Audi : ICar
{
    private string color;
    private double price;
    private int modelYear;
    private bool backupCamera;
    public Audi(String color, double price, int modelYear, bool backupCamera){
        this.color = color;
        this.price = price;
        this.modelYear = modelYear;
        this.backupCamera = backupCamera;
    }

    public bool getBackupCamera()
    {
        return backupCamera;
    }

    public string getColor()
    {
        return color;
    }

    public int getModelYear()
    {
        return modelYear;
    }

    public double getPrice()
    {
        return price;
    }

    public void showCarInfo()
    {
        Console.WriteLine("Araba Markası : Audi");
        Console.WriteLine("Araba Fiyatı : "+price);
        Console.WriteLine("Araba Model Yılı : "+modelYear);
        if(backupCamera){
            Console.WriteLine("Arka Kamera Özelliği : Var");
        }else{
            Console.WriteLine("Arka Kamera Özelliği : Yok");
        }
    }
}
class CarFactory{
    public static ICar createCar(String mark, String color, double price, int modelYear, bool backupCamera){
        
        ICar car = null;
        if(mark.Equals("BMW")){
            car = new BMW(color, price, modelYear, backupCamera);
        }
        else if(mark.Equals("Audi")){
            car = new Audi(color, price, modelYear, backupCamera);
        }
        else{
            Console.WriteLine(mark+" markasının üretimi desteklenmemektedir.");
        }
        return car;
    }
}
public static void Main(string[] args)
{
        ICar bmw = CarFactory.createCar("BMW", "Siyah", 240000, 2016, true);
        ICar audi = CarFactory.createCar("Audi", "Beyaz", 194000, 2018, false);
        bmw.showCarInfo();
}
}