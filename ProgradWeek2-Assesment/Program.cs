using System.Linq;
using System.Text.RegularExpressions;

namespace ProgradWeek2_Assesment
{
    internal class Program
    {
        /*Travelling through Europe one needs to pay attention to
    how the license plate in the given country is displayed.
    When crossing the border you need to park on the shoulder,
    unscrew the plate, re-group the characters according to
    the local regulations, attach it back and proceed with the journey.

    Create a solution that can format the dmv number
    into a plate number with correct grouping.
    The function input consists of string s and group length n.
     The output has to be upper case characters and digits.
    The new groups are made from right to left and connected by -.
     The original order of the dmv number is preserved.

    Examples
    LicensePlate("5F3Z-2e-9-w", 4) ➞ "5F3Z-2E9W"

    LicensePlate("2-5g-3-J", 2) ➞ "2-5G-3J"

    LicensePlate("2-4A0r7-4k", 3) ➞ "24-A0R-74K"

    LicensePlate("nlj-206-fv", 3) ➞ "NL-J20-6FV"*/
        static string ReorderedDMVNumber(string DMVNumber,int GroupNumber)
        {
            string reorderLicenceNumber="";
            string temporaryString="";
            foreach(string str in DMVNumber.Split("-").ToList())
                temporaryString += str;
            for(int i=temporaryString.Length-1,j=1;i>=0;i--)
            {
                if (j == GroupNumber && i>0)
                {
                    reorderLicenceNumber = "-" + Char.ToUpper(temporaryString[i]) + reorderLicenceNumber;
                    j = 1;
                }
                else
                {
                    reorderLicenceNumber = Char.ToUpper(temporaryString[i]) + reorderLicenceNumber;
                    j++;
                }

            }
               

            return reorderLicenceNumber;
        }
        static void LicencePlateRun()
        {
            Console.WriteLine(ReorderedDMVNumber("5F3Z-2e-9-w", 4));
            Console.WriteLine(ReorderedDMVNumber("2-5g-3-J", 2));
            Console.WriteLine(ReorderedDMVNumber("2-4A0r7-4k", 3));
            Console.WriteLine(ReorderedDMVNumber("nlj-206-fv", 3));
        }
        static int TimeToProcessLicensePlate(string CustomerName,int NumberOfAgents,string ReminingPeople)
        {
            List<string> customers = ReminingPeople.Split().ToList();
            customers.Add(CustomerName);
            customers.Sort();
            int Index = 1;
            foreach(string customer in customers)
            {
                if(customer == CustomerName)
                {
                    Index++;
                    break;
                }
                Index++;
            }
            return (Index> NumberOfAgents?Index / NumberOfAgents:1)*20;
        }
        static void TimeToProcessLicensePlateRun()
        {
            Console.WriteLine(TimeToProcessLicensePlate("Eric", 2, "Adam Caroline Rebecca Frank"));
            Console.WriteLine(TimeToProcessLicensePlate("Zebediah", 1, "Bob Jim Becky Pat"));
            Console.WriteLine(TimeToProcessLicensePlate("Aaron", 3, "Jane Max Olivia Sam"));

        }

        static void Main(string[] args)
        {
            //LicencePlateRun();
            TimeToProcessLicensePlateRun();

            
        }
    }
}