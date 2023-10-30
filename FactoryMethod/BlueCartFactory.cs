public class BlueCartFactory : FactoryMethod
{
    protected override ICriditCart MakeCart(string name)
    {
        return new BlueCart(name);
    }
}