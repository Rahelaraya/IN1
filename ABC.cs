
namespace IN_1
{
 

    public abstract class Te
    {
        public abstract void Hotwater();

    }

    //SUB

    public class BlackTe : Te
    {
        public override void Hotwater()
        {
            Console.WriteLine(" BlackTe Hotwater");
        }

    }
}
