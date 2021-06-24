using System;
using System.IO;


namespace arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //string SourcePath = @"C:\Windows\Temp\flie1.txt";

            // string targetPath = @"C:\Windows\Temp\flie2.txt";

            //string[] lines = File.ReadAllLines(SourcePath);
            //foreach (string line in lines)
            // {

            //System.Console.WriteLine(line);

            //}


            //try
            //{
            //FileInfo fileinfo = new FileInfo(SourcePath);
            //fileinfo.CopyTo(targetPath);
            //}
            //catch (IOException e)
            // {

            //System.Console.WriteLine("An Error Occurred" +e.Message);

            //}


            string Path = @"C:\Windows\Temp\flie3.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                // !fs = new FileStream(Path, FileMode.Open);
                //  !sr = new StreamReader(fs);

                //@ ou

                sr = File.OpenText(Path);
                //! 

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }




            }
            catch (IOException e)
            {

                System.Console.WriteLine("An Error Accurred " + e.Message);
            }
            finally
            {


                if (sr != null) sr.Close();
                if (fs != null) fs.Close();


            }




        }
    }
}
