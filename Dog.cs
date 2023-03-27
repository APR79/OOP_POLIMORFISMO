class Dog : DomesticAnimal
{
    //implement abstract method
    public override string sound()
    {
        return "Guau Guau";
    }

    public void view_sound_dog(){
        Console.WriteLine(sound());
    }
}