using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ScanTube
    {
    public static void Main(string[] args)
    {
        try
        {
            using (StreamReader sr1 = new StreamReader(@"C:\Users\batesr4\Desktop\Index\Tube Transfer Files\scan1.csv"))
            using (StreamReader sr2 = new StreamReader(@"C:\Users\batesr4\Desktop\Index\Tube Transfer Files\scan2.csv"))
            {
                string line;
                string line2;

                while ((line = sr1.ReadLine()) != null && (line2 = sr2.ReadLine()) != null)
                {
                    string[] lineValues1 = line.Split(new char[] { ';' });
                    string[] lineValues2 = line2.Split(new char[] { ';' });
                    //Columns for first .csv
                    string gridPos = lineValues1[0];
                    string siteOnGrid = lineValues1[1];
                    string tipNumber = lineValues1[2];
                    string configName = lineValues1[3];
                    string rackLabel = lineValues1[4];
                    string carrierBarcode = lineValues1[5];
                    string srcRackID = lineValues1[6];
                    //Columns for second .csv
                    string gridPos2 = lineValues2[0];
                    string siteOnGrid2 = lineValues2[1];
                    string tipNumber2 = lineValues2[2];
                    string configName2 = lineValues2[3];
                    string rackLabel2 = lineValues2[4];
                    string carrierBarcode2 = lineValues2[5];
                    string srcRackID2 = lineValues2[6];

                    int total = 0;
                    if (lineValues1[5] == lineValues2[5] && lineValues1[5] != ("CarrierBarcode") && lineValues2[5] != ("CarrierBarcode"))
                    //Specifically comparing Barcode columns between the .csv files
                        {
                            Console.WriteLine("Match: {0}, {1}", carrierBarcode, carrierBarcode2);
                            total += 0;
                        //continue;
                        }
                    else if(lineValues1[5] != lineValues2[5])
                        {
                            Console.WriteLine("Does not match: {0}, {1}", carrierBarcode, carrierBarcode2);
                            total += 1;
                        }
                    else
                        {

                        }
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\batesr4\Desktop\Index\Tube Transfer Files\temp.txt"))
                        {
                        sw.WriteLine(total);
                        }

                }
            }
        }
        catch
        {   
        }
    }  
}

