using System;

namespace ConsoleApp2
{
    public abstract class Beverage
    {
        // Шаблонный метод
        public void PrepareRecipe()
        {
            if (NeedBoilWater())
                BoilWater();

            Brew();
            AddIce();      
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual bool NeedBoilWater() => true;

        protected virtual void AddIce() { }

        protected virtual string VesselName => "чашку";

        private void BoilWater()
        {
            Console.WriteLine("Вода закипела");
        }

        private void PourInCup()
        {
            Console.WriteLine($"Напиток налит в {VesselName}");
        }
    }
}
