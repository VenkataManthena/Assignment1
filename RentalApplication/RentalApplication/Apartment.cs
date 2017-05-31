using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalEntities
{
    class Apartment
    {
        //attributes//

        //Apartment Number : An ID to uniquely identify an apartment
         public int ApartmentNumber;

        // Model : This attribute specifies the model of the apartment
         public string Model;

        //Location : This attribute specifies the location of the apartment
        public string Location;

        //PricePerMonthInDollars : This attribute specifies the monthly rent (in dollars) of the apartment
        public float PricePerMonthInDollars;
        

        // A parameterized constructor used to initialize the members of the class
       public Apartment(int number, string model, string location, float monthlyrent)
        {
            ApartmentNumber = number;
            Model = model;
            Location = location;
            PricePerMonthInDollars = monthlyrent;
        }

       public  void printApartmentDetails()
        {
            Console.WriteLine("Apartment Number   " + ApartmentNumber);
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Location:" + Location);
            Console.WriteLine("PricePerMonthInDollars:" + PricePerMonthInDollars);
            Console.ReadLine();
        }
    }
}
