namespace Library.ElectricalEngineering.Helpers
{
    public class ResistanceHelper
    {
        public static double CalculateParallelResistance(params double[] resistances)
        {
            if (resistances == null || resistances.Length == 0)
                throw new ArgumentException("At least one resistance value must be provided.");
            double reciprocalSum = 0.0;
            foreach (var resistance in resistances)
            {
                if (resistance <= 0)
                    throw new ArgumentException("Resistance values must be greater than zero.");
                reciprocalSum += 1.0 / resistance;
            }
            return 1.0 / reciprocalSum;
        }
    }
}
