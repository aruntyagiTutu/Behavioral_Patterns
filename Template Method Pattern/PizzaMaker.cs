using System;

namespace Template_PizzaMaker
{
    class Pizza
    {

    }
    class PizzaMaker
    {
        public Pizza pizza;
        public PizzaMaker()
        {
            pizza = new Pizza();
        }

        // template method
        public Pizza Prepare()
        {
            PrepareBase();
            if(IsCheeseBurst())
                CheeseFill();
            AddVeggie();
            AddOns();
            Bake();
            Box();

            return pizza;
        }

       protected  virtual  void PrepareBase()
       {
           Console.WriteLine("Basic base");
       }

       protected virtual void AddVeggie()
       {
           Console.WriteLine("Basic veggie added");
       }


       protected virtual bool IsCheeseBurst()
       {
           return false;
       }

       protected virtual void CheeseFill()
       {

       }

       public virtual void AddOns()
       {

       }

       public virtual void Box()
       {
           Console.WriteLine("place in box");
       }
       
       public virtual void Bake()
       {
           Console.WriteLine("Place in Oven for 10 minutes");
       }

    }

    class ItalianPizzaMaker: PizzaMaker
    {
        public ItalianPizzaMaker() : base()
        {

        }

          protected override bool IsCheeseBurst()
       {
           return false;
       }

       protected override void CheeseFill()
       {
           Console.WriteLine("Add cottage cheese");
       }

       public override void AddOns()
       {
           AddOlives();
           SprinkleWine();
       }

        void AddOlives()
       {
           Console.WriteLine("Sprinkle olives");
       }

       void SprinkleWine()
       {
           Console.WriteLine("Sprinkle Wine");
       }
    } 

}

namespace Template_Client
{
    using Template_PizzaMaker;

    class SomeCustomer
    {
        public void OrderPizza()
        {
           PizzaMaker pm = new PizzaMaker();
           var pizza = pm.Prepare();
        }

        public void OrderItalianPizza()
        {
            ItalianPizzaMaker pm = new ItalianPizzaMaker();
            var pizza = pm.Prepare();
        }
    }

}