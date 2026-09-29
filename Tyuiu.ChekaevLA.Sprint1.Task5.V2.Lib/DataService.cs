namespace Tyuiu.ChekaevLA.Sprint1.Task5.V2.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            return Convert.ToInt32((temp - 32) * 5 / 9);
        }
    }
}
