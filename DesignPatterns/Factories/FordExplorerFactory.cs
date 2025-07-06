using DesignPatterns.ModelBuilders;
namespace DesignPatterns.Factories;
using DesignPatterns.Models;
public class FordExplorerFactory : CarFactory
{
    public override Vehicle CreateCar()
    {

        return new CarModelBuilder()
            .setModel("Explorer")
            .setColor("black").Build();

    }
}