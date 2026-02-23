namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating a new instance object of the 'Car' class
            Car objToyota = new Car();
            
            // Setting the values of the properties of the object
            objToyota.Make = "Toyota";
            objToyota.Model = "Corolla";
            objToyota.Year = 2014;

            // Printing the values of each property
            Console.WriteLine($"The 'objToyota' instance of the Car class has \nMake: {objToyota.Make}, \nModel: {objToyota.Model} and \nYear: {objToyota.Year} property values.");
            
        }
        
    }
    
    
    // Creating a new public class blueprint
    public class Car
    {
        /* default Constructor
        public Car()
        {
        }                                               
        */
    
        // Property 'Make'
        public string Make { get; set; }
        
        // Property 'Model'
        public string Model { get; set; }
        
        // Property 'Year'
        public int Year { get; set; }
        
        
    }
}
