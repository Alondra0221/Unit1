using System;
namespace Cars
{
    public class Person
    {
        ///Atributes
        public int code { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public List<License> licenses;
        public List<Vehicle> vehicles;
        public Boolean suspiciosFraud { get; set; }

        //Extra variable
        private int carsN => countVehicles();
        

        //Constructor
        public Person()
        {
            this.code = 0;
            this.name = "";
            this.surname = "";
            this.age = 0;
            this.gender = "";
            this.suspiciosFraud = false;
            this.licenses = new List<License>();
            this.vehicles = new List<Vehicle>();



        }


        public void addLicense(License license)
        {
            //Condition 1 
            if (age < 18 | age > 90)
            {
                Console.WriteLine("You can´t have a license because you are " + age + " years old.");
                return;
            }
            
            //Condition 3

            for (int i=0; i< licenses.Count; i++)

            {
                if (licenses[i].type== license.type)
                {
                    if (licenses[i].expiration > DateTime.Today)
                    {
                        Console.WriteLine("Your license type " + license.type +" have not expired yet");
                        return; 
                    }
                    else
                    {
                        licenses[i].initial = license.initial;
                        licenses[i].expiration = license.expiration;
                    }


                }

            }
            licenses.Add(license);


        }

        public void cancelCar(string type)
        {
            for (int j = 0; j < licenses.Count; j++)
            {
                if (licenses[j].type == type)
                {
                    vehicles.RemoveAt(j);
                }
            }
            
        }

        public void addCar(Vehicle vehicle)
        {
            //Condition 2
            if (gender == "Female" && vehicle.color == "Red")
            {
                vehicles.Add(vehicle);
            }

            //Condition 4
            else if (gender == "Male")
            {
                if (vehicle.brand == "Ford" | vehicle.brand=="Toyota" )
                {
                    vehicles.Add(vehicle);
                }
                else
                {
                    return;
                }
            }

            

        }

        public void checkSupiciosFraud()
        {
            //Condition 5

            if (carsN > 5)
            {
                this.suspiciosFraud = true;
                Console.WriteLine("The citizen "+ name + " with id: " + code + " is suspected of fraud");
            }
            else
            {
                this.suspiciosFraud = false;
            }

        }


        private int countVehicles()
        {
            int c = 0;

            for (int i = 0; i < vehicles.Count; i++)
            {
                c = c + 1;

            }
            return c;

        }
    }
}
