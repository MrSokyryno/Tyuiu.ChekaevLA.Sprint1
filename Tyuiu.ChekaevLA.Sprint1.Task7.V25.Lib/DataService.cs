namespace Tyuiu.ChekaevLA.Sprint1.Task7.V25.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task7V25
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Exp(x) - ((Math.Pow(y, 2) + 6 + Math.Cos(Math.Pow(x, 3)) + x * y - 2 * Math.Pow(x, 2))
                / (Math.Sin(Math.Pow(x, 4) + 13) + 9 * y - 2)),3);
        }
    }
}
