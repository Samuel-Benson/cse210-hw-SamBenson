class vehicle
{
    private string make;
    private string model;
    private int miles;

    public vehicle(string make, string model, int miles)
    {
        this.make = make;
        this.model = model;
        this.miles = miles;
    }
}

class Car : vehicle 
{
    public Car(string make, string model, int miles) : base(make, model, miles)
    {

    }
}

class Truck: vehicle
{
    private int towing;

    public Truck(string make, string model, int miles, int towing) : base(make, model, miles)
    {
        this.towing = towing;
    }
}