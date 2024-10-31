// See https://aka.ms/new-console-template for more information
using OOPLab2.Constructions;
using OOPLab2.Constructions.DTO;

var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, "Wood");
var construction3 = new Construction(
    new CreateConstructionDTO()
    {
    BuildMaterial = "Material",
    Height  = 100,
    Width = 100,
    Entrances = 2
    }
);
Console.WriteLine(construction2.Height);
Console.WriteLine(construction2.Width);
Console.WriteLine(construction2.Entrances);
Console.WriteLine(construction2.HumanCapacity);
Console.WriteLine(construction2.BuildMaterial);

Console.WriteLine(construction1.Height);
Console.WriteLine(construction1.Width);
Console.WriteLine(construction1.Entrances);
Console.WriteLine(construction1.HumanCapacity);
Console.WriteLine(construction1.BuildMaterial);

Console.WriteLine(construction3.Height);
Console.WriteLine(construction3.Width);
Console.WriteLine(construction3.Entrances);
Console.WriteLine(construction3.HumanCapacity);
Console.WriteLine(construction3.BuildMaterial);