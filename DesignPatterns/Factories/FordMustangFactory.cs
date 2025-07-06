namespace DesignPatterns.Factories;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

public class FordMustangFactory : CarFactory
{
    
    public override Vehicle CreateCar()
    {

        return new CarModelBuilder()
            .setModel("Mustang")
            .setColor("blue").Build();

    }
    
}