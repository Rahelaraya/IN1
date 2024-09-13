
namespace IN_1
{
    
    // Poly

    public class Trees
    {
        public string name;

        public string Typ;

        public virtual void InForest()
        {
            Console.WriteLine(" Trees in Forest");
        }
    }

    public class Leaf : Trees
    {
        public override void InForest()
        {
            Console.WriteLine("Leaf In Forest");


        }

    }
    public class mushroom : Trees
    {
        public override void InForest()
        {
            Console.WriteLine("mushroom In Forest");


        }

    }


}
