// See https://aka.ms/new-console-template for more information
using ElectricalEngineeringLibrary.Math;
using ElectricalEngineeringLibrary.Helpers;
using EngineeringConsole;

Console.WriteLine("Hello, World!");




for (int i = 1; i < 10; i++)
{
    Console.WriteLine(MiscTests.CalculateTotalCurrent((double)i));
}


//Console.WriteLine(FractionHelper.DecimalToFraction(1.5));
//Console.WriteLine(ResistanceHelper.CalculateParallelResistance(64,64));
