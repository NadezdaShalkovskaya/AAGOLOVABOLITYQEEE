using System;


class MobilePhone
{
    
    public string Brand { get; set; }
    public double Price { get; set; }
    public double Memory { get; set; }

    
    public MobilePhone(string brand, double price, double memory)
    {
        Brand = brand;
        Price = price;
        Memory = memory;
    }

    
    public virtual double CalculateValueForMoney()
    {
        return Memory / Price; 
    }

    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Цена: {Price} руб., Объем памяти: {Memory} Гб, Q: {CalculateValueForMoney()}");
    }
}


class DualSIMPhone : MobilePhone
{
    public int SIMCardCount { get; set; } 

    
    public DualSIMPhone(string brand, double price, double memory, int simCardCount)
        : base(brand, price, memory)
    {
        SIMCardCount = simCardCount;
    }

    
    public override double CalculateValueForMoney()
    {
        return (Memory / Price) * SIMCardCount; 
    }

 
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество SIM-карт: {SIMCardCount}, Qp: {CalculateValueForMoney()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        MobilePhone phone1 = new MobilePhone("Samsung", 30000, 64);
        DualSIMPhone phone2 = new DualSIMPhone("Xiaomi", 25000, 128, 2);

        
        phone1.DisplayInfo();
        Console.WriteLine();
        phone2.DisplayInfo();
    }
}