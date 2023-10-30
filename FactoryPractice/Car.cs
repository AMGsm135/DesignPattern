public abstract class Car
{
    public Car(string brand, int creationYear)
    {
        this.CreationYear = creationYear;
        this.Brand = brand;
    }
    public string Brand;

    public int CreationYear;
}