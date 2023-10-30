public abstract class FactoryMethod
{
    protected abstract ICriditCart MakeCart(string name);

    public ICriditCart CreateCart(string name)
    {
        return this.MakeCart(name);
    }
}