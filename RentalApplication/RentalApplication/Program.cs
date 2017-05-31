using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalEntities
{
    class Program
    {
        static void Main(string[] args)
        {

            Applicant applicantOne = new Applicant("Peter", "Siddle", 32, true, "H1B",25000);

            Applicant employedApplicant = new Applicant(applicantOne);

            employedApplicant.printApplicantDetails();

            Application paperApplication = new Application("Jeyraj", "Albert", 176 - 97 - 6537, "AU8229G7", "Paper", 315 - 415 - 5515);

            paperApplication.printApplicationDetails();

            Application onlineApplication = new Application("Dickson", "Donna", 186 - 98 - 6352, "TX867382", "Online", 873 - 653 - 6282);

            onlineApplication.printApplicationDetails();

            Apartment singleStoreyApartment = new Apartment(8029-1116, "Single Storey", "Irving", 1000);

            singleStoreyApartment.printApartmentDetails();

            Apartment multiStoreyApartment = new Apartment(8029 - 3116, "Multi Storey", "Irving", 2000);

            multiStoreyApartment.printApartmentDetails();
        }
    }
}
