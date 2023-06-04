// See https://aka.ms/new-console-template for more information

using DesignPattern.AbstractFactory;
public class Program
{
    public static void Main(string[] args)
    {
        //FactoryMethod
        DesignPattern.FactoryMethod.Client clientFactoryMethod = new DesignPattern.FactoryMethod.Client();
        clientFactoryMethod.apply();


        //AbstractFactory
        IAbstractFactory factory1 = new ConcreteFactory1();
        IAbstractFactory factory2 = new ConcreteFactory2();

        DesignPattern.AbstractFactory.Client clientAbstractFactory1 = new DesignPattern.AbstractFactory.Client(factory1);
        DesignPattern.AbstractFactory.Client cleintAbstractFactory2 = new DesignPattern.AbstractFactory.Client(factory2);

        clientAbstractFactory1.UseProducts();
        cleintAbstractFactory2.UseProducts();
    }
}