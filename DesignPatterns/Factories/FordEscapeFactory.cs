namespace DesignPatterns.Factories;
using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

public class FordEscapeFactory : CarFactory
{
    
    public override Vehicle CreateCar()
    {

        return new CarModelBuilder()
            .setModel("Escape")
            .setColor("red").Build();

    }
    
}