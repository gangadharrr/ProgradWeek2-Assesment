namespace ProgradWeek2_Assesment
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            LicencePlateRun();
        }
    }
}