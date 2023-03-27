abstract class DomesticAnimal{
    //Properties
    public string Id { get; set; }
    public short Age { get; set; }

    //Methods
    public void to_run()
    {
        //return "is running";
        Console.WriteLine("is running");
    }

    //public string sound()
    // {
    //      return "???";   
    //}

    //Structure definitions
    public abstract string sound ();

}