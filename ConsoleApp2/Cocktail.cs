using System;

namespace ConsoleApp2
{
    public class Cocktail : Beverage
    {
        protected override bool NeedBoilWater() => false;
        protected override string VesselName => "бокал";

        protected override void Brew()
        {
            Console.WriteLine("Смешиваем ингредиенты коктейля");
        }

        protected override void AddIce()
        {
            Console.WriteLine("Добавляем лед");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Украшаем коктйель");
        }
    }
}
