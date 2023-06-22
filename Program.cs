// See https://aka.ms/new-console-template for more information


using DesignPattern.AbstractFactory;
using DesignPattern.AnlogBuilder;

public class Program
{
    public static void Main(string[] args)
    {
        //FactoryMethod
        // DesignPattern.FactoryMethod.Client clientFactoryMethod = new DesignPattern.FactoryMethod.Client();
        // clientFactoryMethod.apply();


        // //--------------------------AbstractFactory----------------------
        // IAbstractFactory factory1 = new ConcreteFactory1();
        // IAbstractFactory factory2 = new ConcreteFactory2();
        // IAbstractFactory factory3 = new ConcreteFactory3();

        // DesignPattern.AbstractFactory.Client clientAbstractFactory1 = new DesignPattern.AbstractFactory.Client(factory1);
        // DesignPattern.AbstractFactory.Client cleintAbstractFactory2 = new DesignPattern.AbstractFactory.Client(factory2);
        // DesignPattern.AbstractFactory.Client cleintAbstractFactory3 = new DesignPattern.AbstractFactory.Client(factory3);

        // clientAbstractFactory1.UseProducts();
        // cleintAbstractFactory2.UseProducts();
        // cleintAbstractFactory3.UseProducts();

        //---------------------------------AbstractFactoryGuru------------------------------------------
        new DesignPattern.AbstractFactoryGuru.Client().Main();

        // //Builder
        // GlassHome1 builder1 = new GlassHome1();
        // DesignPattern.AnlogBuilder.Directory directory = new DesignPattern.AnlogBuilder.Directory(builder1);

        // directory.Construct();
        // Glass product1 = builder1.GetProduct1();
        // product1.Display();

        // Console.WriteLine("********Another Builder********");
        // BrickAndGlassHome builder2 = new BrickAndGlassHome();
        // DesignPattern.AnlogBuilder.Directory directory2 = new DesignPattern.AnlogBuilder.Directory(builder2);

        // directory2.ConstructBrick();
        // Glass product2 = builder2.GetProduct1();
        // product2.Display();
        // Brick product2o1= builder2.product();
        // product2o1.Display();


        
    }
}