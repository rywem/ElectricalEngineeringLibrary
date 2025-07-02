// See https://aka.ms/new-console-template for more information
using ElectricalEngineeringLibrary.Math;
using ElectricalEngineeringLibrary.Helpers;
using EngineeringConsole;
using EngineeringConsole.Examples;

Console.WriteLine("Hello, World!");



//Console.WriteLine(FractionHelper.DecimalToFraction(1.5));

// calculate current from current divider 

ChapterFiveExamples.Ch5Point2();


var currentFromDivider = CurrentHelper.CalculateCurrentFromDivider(1, 1, 1);
Console.WriteLine($"Current From divider {currentFromDivider}");
var voltageFromDivider = VoltageHelper.CalculateVoltageFromDivider(2, 1, 1);
Console.WriteLine(voltageFromDivider);


var paralellelResistance = ResistanceHelper.CalculateParallelResistance(1,1);
Console.WriteLine(VoltageHelper.CalculateVoltageFromCurrent(currentFromDivider, paralellelResistance));
Console.WriteLine($"Parallel Resistance {paralellelResistance}");
var fraction = FractionHelper.DecimalToFraction(paralellelResistance);
Console.WriteLine($"Parallel Resistance as a fraction: {fraction.ToString()}");

