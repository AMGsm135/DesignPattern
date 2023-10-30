public static class Factory
{

    public static Car CreateObject(string type)
    {
        switch (type)
        {
            case "BMW":
                return new BMW(1990);
            case "Bogatti":
                return new Bogatti(1998);
            default:
                return new BMW(1998);
        }
    }


}