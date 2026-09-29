namespace Tyuiu.ChekaevLA.Sprint1.Task6.V10.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            if (value == "")
            {
                return "";
            }

            string x = "";
            string y = "";

            for (int i = 0; i < value.Length; i++)
            { 
                if (value[i] != ' ')
                {
                    x = x + value[i];
                }
                else
                {
                    if (x.Length % 2 == 1)
                    {
                        x = x.Remove(x.Length / 2, 1);
                    }
                    y = y + x + value[i];
                    x = "";
                }
            }

            if (x.Length % 2 == 1)
            {
                x = x.Remove(x.Length / 2, 1);
            }
            y = y + x;
            
            return y;
        }
    }
}
