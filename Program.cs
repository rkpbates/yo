using System;
using System.IO;

class ScanTube
    {
    public static void Main(string[] args)
    {
        try
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\batesr4\Desktop\Index\Tube Transfer Files\scan1.csv"))
            using (StreamReader sr2 = new StreamReader(@"C:\Users\batesr4\Desktop\Index\Tube Transfer Files\scan2.csv"))
            {
                string line;
                string line2;

                while ((line = sr.ReadLine()) != null && (line2 = sr2.ReadLine()) != null)
                {
                    string[] lineValues1 = line.Split(new char[] { ';' });
                    string[] lineValues2 = line2.Split(new char[] { ';' });
                    // columns for first .csv
                    string column01 = lineValues1[0];
                    string column02 = lineValues1[1];
                    string column03 = lineValues1[2];
                    string column04 = lineValues1[3];
                    string column05 = lineValues1[4];
                    string column06 = lineValues1[5];
                    string column07 = lineValues1[6];
                    // columns for second .csv
                    string column08 = lineValues2[0];
                    string column09 = lineValues2[1];
                    string column10 = lineValues2[2];
                    string column11 = lineValues2[3];
                    string column12 = lineValues2[4];
                    string column13 = lineValues2[5];
                    string column14 = lineValues2[6];

                    if (lineValues1[5] != lineValues2[5])
                        //Specifically comparing Barcode columns between the .csv files
                    {
                        Console.WriteLine("Does not match {0}, {1}", column06, column13);
                    }
                    else
                    {
                        Console.WriteLine("Match");
                    }
                }
            }
        }
        catch
        {

        }
    }  
}
