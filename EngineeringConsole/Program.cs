// See https://aka.ms/new-console-template for more information
using ElectricalEngineeringLibrary.Math;
using ElectricalEngineeringLibrary.Helpers;
using EngineeringConsole;

Console.WriteLine("Hello, World!");



//Console.WriteLine(FractionHelper.DecimalToFraction(1.5));
var paralellelResistance = ResistanceHelper.CalculateParallelResistance(1,2);
var fraction = FractionHelper.DecimalToFraction(paralellelResistance);
Console.WriteLine(fraction.ToString());

var voltageFromDivider = VoltageHelper.CalculateVoltageFromDivider(3, 1, 2);
Console.WriteLine(voltageFromDivider);
