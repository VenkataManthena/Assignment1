using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalEntities
{
    class Application
    {
        
       //attributes//

        //FirstName :  This attribute specifies the applicant's firstname in the rental application
        public string FirstName;

        //LastName :  This attribute specifies the applicant's lastname in the rental application
        public string LastName;

        //SSN : This attribute specifies the applicant's SSN in the rental application
        private int SSN;

        //DriverLicense : This attribute specifies the applicant's Driver License in the rental application
        private string driverLicense;

        //TypeOfApplication : This attribute specifies the type of the rental application such as Paper or Online.
        public string typeOfApplication;

        //CellPhone : This attribute specifies the applicant's contact number in the rental application.
        private int contactNumber;

        // A parameterized constructor using "this" keyword to differentiate between the members of the class and parameters
        public Application(string FirstName, string LastName, int SSN, string driverLicense, string typeOfApplication, int contactNumber)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SSN = SSN;
            this.driverLicense = driverLicense;
            this.typeOfApplication = typeOfApplication;
            this.contactNumber = contactNumber;

        }

       public  void printApplicationDetails()
        {
            Console.WriteLine("First Name   " + FirstName);
            Console.WriteLine("Last Name:" + LastName);
            Console.WriteLine("SSN:" + SSN);
            Console.WriteLine("Driver License:" + driverLicense);
            Console.WriteLine("TypeOfApplication:" + typeOfApplication);
            Console.WriteLine("Contact Number:" + contactNumber);
            Console.ReadLine();
        }

    }
}
