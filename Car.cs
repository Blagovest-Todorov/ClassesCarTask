namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }               

        public int Year
        {
            get { return year; }
            set { year = value; }
        }       

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }        

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance) 
        {
            double remainFuel = FuelQuantity - distance * FuelConsumption;

            if (remainFuel > 0)
            {
                FuelQuantity = remainFuel;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }            
        }

        public string WhoAmI() 
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity}L";
        }
    }
}
