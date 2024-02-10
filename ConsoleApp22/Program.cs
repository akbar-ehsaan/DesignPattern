// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.ComTypes;
using ConsoleApp22.AbstractFactory;
using ConsoleApp22.Adapter;
using ConsoleApp22.Bridge;
using ConsoleApp22.Builder;
using ConsoleApp22.Composite;
using ConsoleApp22.Factory;
using ConsoleApp22.Prototype;
using ConsoleApp22.Singleton;

Console.WriteLine("Hello, World!");
Console.WriteLine("Factory method example");
Document[] documents = new Document[2];
documents[0] = new Resume();
documents[1] = new Report();
foreach (Document document in documents)
{
    Console.WriteLine("\n" + document.GetType().Name + "--");
    foreach (Page page in document.Pages)
    {
        Console.WriteLine(" " + page.GetType().Name);
    }
}
Console.WriteLine("end of factory method example");
Console.WriteLine("__________________________________");

Console.WriteLine("abstractFactory method example");
ContinentFactory africa = new AfricaFactory();
AnimalWorld world= new AnimalWorld(africa);
world.RunFoodChain();

ContinentFactory america = new AmericaFactory();
world = new AnimalWorld(america);
world.RunFoodChain();
Console.WriteLine("end of abstractFactory example");
Console.WriteLine("__________________________________");
Console.WriteLine("builder method example");
VehicleBuilder builder;
Shop shop=new Shop();

builder = new ScooterBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new CarBuilder();
shop.Construct(builder);
builder.Vehicle.Show();

builder = new MotorCycleBuilder();
shop.Construct(builder);
builder.Vehicle.Show();
Console.WriteLine("end builder method example");
Console.WriteLine("__________________________________");
Console.WriteLine("prototype method example");

ColorManager colorManager = new ColorManager();

colorManager["red"] = new Color(255, 0, 0);
colorManager["green"] = new Color(0, 255, 0);
colorManager["blue"] = new Color(0, 0, 255);
// User adds personalized colors
colorManager["angry"] = new Color(255, 54, 0);
colorManager["peace"] = new Color(128, 211, 128);
colorManager["flame"] = new Color(211, 34, 20);


Color color1 = colorManager["red"].Clone() as Color;
Color color2 = colorManager["peace"].Clone() as Color;
Color color3 = colorManager["flame"].Clone() as Color;

Console.WriteLine("prototype end method example");
Console.WriteLine("__________________________________");
Console.WriteLine("singleton method example");

Singleton s1 = Singleton.Instance();
Singleton s2 = Singleton.Instance();
if (s1 == s2)
{
    Console.WriteLine("Objects are the same instance");
}
Console.WriteLine("end singleton method example");
Console.WriteLine("__________________________________");
Console.WriteLine("adapter method example");

Target target = new Adapter();
target.Request();

Console.WriteLine("end adapter method example");
Console.WriteLine("__________________________________");

Console.WriteLine("bridge method example");

var customers = new Customers();
customers.Data = new CustomerData("Chicago");
customers.Show();
customers.Next();
customers.Show();
customers.Next();
customers.Show();
customers.Add("Henry Velasquez");
customers.ShowAll();

Console.WriteLine("end bridge method example");
Console.WriteLine("__________________________________");
Console.WriteLine("composite method example");

CompositeElement root = new CompositeElement("Picture");
root.Add(new PrimitiveElement("Red Line"));
root.Add(new PrimitiveElement("Blue Circle"));
root.Add(new PrimitiveElement("Green Box"));

CompositeElement comp = new CompositeElement("Two Circles");
comp.Add(new PrimitiveElement("Black Circle"));
comp.Add(new PrimitiveElement("White Circle"));
root.Add(comp);
root.Display(1);

PrimitiveElement pe = new PrimitiveElement("Yellow Line");
root.Add(pe);
root.Remove(pe);


Console.WriteLine("end composite method example");
Console.WriteLine("__________________________________");






Console.ReadKey();


