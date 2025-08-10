// See https://aka.ms/new-console-template for more information
using Library.ElectricalEngineering.Math;
using Library.ElectricalEngineering.Helpers;
using EngineeringConsole;
using EngineeringConsole.Examples;
using Library.ElectricalEngineering.Printers;
Console.WriteLine("Hello, World!");
//Console.WriteLine(ResistanceHelper.CalculateParallelResistance(2, 1, 4, 2 ));

//var voltage = VoltageHelper.CalculateVoltageFromCurrentAtNodeWithParallelResistors(3, 2, 1, 4, 2);
/*var current = CurrentHelper.CalculateCurrentFromVoltageAtNodeWithParallelResistors(5, 2, 1, 4, 2);
var voltage2 = VoltageHelper.CalculateVoltageFromCurrentAtNodeWithParallelResistors(current, 2, 1, 4, 2);
*/
var voltageDivider = VoltageHelper.CalculateVoltageFromDivider(5, 2, 4);
//Console.WriteLine(voltage);

var factors = FactorHelper.GetFactors(12);
foreach (var factor in factors)
{
    Console.WriteLine($"{factor.Number1}\t{factor.Number2}\t{factor.Product}");
}

BitPrinter.PrintBitCombinations(3);



//Console.WriteLine(FractionHelper.DecimalToFraction(1.5));

// calculate current from current divider 


ChapterFiveExamples.Ch5OneBitAdder();

return;
var currentFromDivider = CurrentHelper.CalculateCurrentFromDivider(1, 1, 1);
Console.WriteLine($"Current From divider {currentFromDivider}");
var voltageFromDivider = VoltageHelper.CalculateVoltageFromDivider(2, 1, 1);
Console.WriteLine(voltageFromDivider);


var paralellelResistance = ResistanceHelper.CalculateParallelResistance(1,1);
Console.WriteLine(VoltageHelper.CalculateVoltageFromCurrent(currentFromDivider, paralellelResistance));
Console.WriteLine($"Parallel Resistance {paralellelResistance}");
var fraction = FractionHelper.DecimalToFraction(paralellelResistance);
Console.WriteLine($"Parallel Resistance as a fraction: {fraction.ToString()}");

