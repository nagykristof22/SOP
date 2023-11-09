using System;
using System.Collections.Generic;
using System.Threading;

enum CannedFoodType
{
    Corn,
    Beans
}

class CannedFood
{
    public CannedFoodType Type { get; set; }
    public double Weight { get; set; }

    public CannedFood(CannedFoodType type, double weight)
    {
        Type = type;
        Weight = weight;
    }
}

class CanningMachine
{
    public void FillCan(CannedFood food)
    {
        Console.WriteLine($"Filling can with {food.Type}... (takes 3 seconds)");
        Thread.Sleep(3000);
    }
}

class LabelingMachine
{
    public void LabelCan(CannedFood food)
    {
        Console.WriteLine($"Labeling {food.Type} can... (takes 1 second)");
        Thread.Sleep(1000);
    }
}

class PackingMachine
{
    public void PackBox(List<CannedFood> cans)
    {
        foreach (var can in cans)
        {
            Console.WriteLine($"Packing {can.Type} can into the box...");
        }
    }
}

class Controller
{
    static List<CannedFood> buffer = new List<CannedFood>();
    static CanningMachine canningMachine = new CanningMachine();
    static LabelingMachine labelingMachine = new LabelingMachine();
    static PackingMachine packingMachine = new PackingMachine();

    public static void RunFactory()
    {
        for (int i = 0; i < 10; i++)
        {
            ProduceCannedFood();
            Thread.Sleep(500);
        }
    }

    private static void ProduceCannedFood()
    {
        Random random = new Random();
        double weight = random.Next(150, 401);

        CannedFoodType type = (weight >= 150 && weight <= 200) ? CannedFoodType.Corn : CannedFoodType.Beans;
        CannedFood food = new CannedFood(type, weight);

        canningMachine.FillCan(food);
        labelingMachine.LabelCan(food);

        lock (buffer)
        {
            buffer.Add(food);

            if (buffer.Count == (type == CannedFoodType.Corn ? 6 : 4))
            {
                packingMachine.PackBox(new List<CannedFood>(buffer));
                buffer.Clear();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Controller.RunFactory();
    }
}
