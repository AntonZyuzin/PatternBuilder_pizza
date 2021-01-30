using System;

namespace PatternBuilderPizza
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Margarita mrg = new Margarita();
            Diablo dbl = new Diablo();

            Console.WriteLine("Выберите пиццу (1 или 2)\n" + "1) Маргарита\n" + "2) Диабло");
            int num = Int32.Parse(Console.ReadLine());

            if (num == 1)
            {
                mrg.setDough("бездрожжевое тесто");
                mrg.setSauce("томатный соус");
                mrg.setFilling("сыр Моцарелла, базилик, помидоры");
            }
            if (num == 2)
            {
                dbl.setDough("дрожжевое тесто");
                dbl.setSauce("томатный соус");
                dbl.setSauce("сыр Моцарелла, шампиньоны, чили, паприка");
            }
            if (num != 1 && num != 2)
            {
                Console.WriteLine("Недопустимое значение");
            }

        }
    }
}
