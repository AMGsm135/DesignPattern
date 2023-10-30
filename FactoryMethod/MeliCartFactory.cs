public class MeliCartfactory : FactoryMethod
{
    protected override ICriditCart MakeCart(string name)
    {
        return new MeliCart(name);
    }
}