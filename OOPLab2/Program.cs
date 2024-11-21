﻿using OOP.Constructions;
using OOP.Constructions.DTO;
using OOP.Constructions.Models;
using OOP.IndustrialHall;
using OOP.ResidentalBuilding;
using OOPLab2.AbsComBuild;
using OOPLab2.BuildingWrappers;
using OOPLab2.ComBuild;
using OOPLab2.Interfaces;

var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, BuildMaterialEnum.Wood, "Material");
var construction3 = new Construction(new CreateConstructionDTO()
{
    BuildMaterial = BuildMaterialEnum.Wood,
    Width = 100,
    Height = 100,
    Entrances = 2
}
);
Console.WriteLine(construction2.Height);
Console.WriteLine(construction2.Width);
Console.WriteLine(construction2.Entrances);
Console.WriteLine(construction2.HumanCapacity);
Console.WriteLine(construction2.BuildMaterial);
Console.WriteLine(construction2.BuildMaterial);
Console.WriteLine("Hello");

Console.WriteLine(construction1.Height);
Console.WriteLine(construction1.Width);
Console.WriteLine(construction1.Entrances);
Console.WriteLine(construction1.HumanCapacity);
Console.WriteLine(construction1.BuildMaterial);
Console.WriteLine(construction1.Roofing);


Console.WriteLine(construction3.Height);
Console.WriteLine(construction3.Width);
Console.WriteLine(construction3.Entrances);
Console.WriteLine(construction3.BuildMaterial);

Console.WriteLine(construction1.GetSquareCost());

var resbuild = new ResidentalBuilding(3);
var indhall = new IndustrialHall();
Console.WriteLine(resbuild.Entrances);
Console.WriteLine(indhall.BuildMaterial);

var wrapper1 = new BuildingWrapper(resbuild);
var wrapper2 = new BuildingWrapper(indhall);
var CommercialBuild = new CommercialBuilding(new CreateConstructionDTO()
{
    BuildMaterial = BuildMaterialEnum.Brik,
    Height = 100,
    Width = 100,
    Entrances = 2
}, "B2B");

Console.WriteLine(wrapper1.GetWrappedSquareCost());
Console.WriteLine(wrapper2.GetWrappedSquareCost());
