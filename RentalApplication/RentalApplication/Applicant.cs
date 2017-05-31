using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalEntities
{
    class Applicant
    {
          // Attributes of class "Applicant"

          //FirstName :  This attribute specifies the firstname of the applicant
          public string firstName;

         //LastName :  This attribute specifies the lastname of the applicant
         public string lastName;

        // Age : This attribute specifies the  age of the applicant
         public int age;

        //isEmployed : This attribute specifies whether the applicant is employed or not
         public bool isEmployed;

        //visaStatus : This attribute specifies the visa status of the applicant
         private string visaStatus;

        //monthlySalary : This attribute specifies the monthly income of the applicant.
         private float monthlySalary;


        // An instance constructor with which you can use a copy constructor 
        public Applicant(string fName, string lName, int age, bool isEmployed, string status, float monthlyIncome)
        {
            firstName = fName;
            lastName = lName;
            this.age = age;
            this.isEmployed = isEmployed;
            visaStatus = status;
            monthlySalary = monthlyIncome;
        }
         
        // A copy constructor to initialize the members with object of type Applicant 
        public Applicant(Applicant applicantObj)
        {
            firstName = applicantObj.firstName;
            lastName = applicantObj.lastName;
            age = applicantObj.age;
            isEmployed = applicantObj.isEmployed;
            visaStatus = applicantObj.visaStatus;
            monthlySalary = applicantObj.monthlySalary;
        }

        public void printApplicantDetails()
        {

            Console.WriteLine("First Name   " + firstName);
            Console.WriteLine("Last Name:" + lastName);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("IsEmployed:" + isEmployed);
            Console.WriteLine("Visa Status:" + visaStatus);
            Console.WriteLine("Monthly Salary:" + monthlySalary);
            Console.ReadLine();
        }
    }
}
