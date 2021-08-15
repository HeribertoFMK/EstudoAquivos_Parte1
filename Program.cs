using System;
using System.IO;


namespace arquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO Exercico sobre File e FileInfo

            //?primeiro exercico(passar conteudo do texto1 para o texto2 por meio de uma função static(File))
            string SourcePath = @"C:\csharp\texto1.txt";
            string TargetPath = @"C:\csharp\texto2.txt";

            try
            {
                File.Copy(SourcePath, TargetPath);

            }
            catch (IOException e)
            {

                System.Console.WriteLine("Erro encontrado!");
                System.Console.WriteLine(e.Message);
            }


            //?Segundo exercico(passar conteudo do texto1 para o texto2 por meio de uma função static(File) e ler arquivo)
            // string SourcePath = @"C:\csharp\texto1.txt";
            // string TargetPath = @"C:\csharp\texto2.txt";

            try
            {
                File.Copy(SourcePath,TargetPath);
                string[] lines = File.ReadAllLines(TargetPath);//! Neste caso funciona tando acionando SourcePath quanto TargePath
                foreach(string line in lines)
                System.Console.WriteLine(line);

            }
            catch (IOException e)
            {

                System.Console.WriteLine("Erro encontrado!");
                System.Console.WriteLine(e.Message);
            }

            //?Terceiro exercico(passar conteudo do texto1 para o texto2 instanciando os arquivo(FileInfo))

            // string SourcePath = @"C:\csharp\texto1.txt";
            // string TargetPath = @"C:\csharp\texto2.txt";




            try
            {
                FileInfo fi = new FileInfo(SourcePath);
                fi.CopyTo(TargetPath);
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Houve um erro!");
                System.Console.WriteLine(e.Message);


            }
            //?Quarto exercico(passar conteudo do texto1 para o texto2 instanciando os arquivo(FileInfo) e lendo o mesmo)

            // string SourcePath = @"C:\csharp\texto1.txt";
            // string TargetPath = @"C:\csharp\texto2.txt";




            try
            {
                FileInfo fi = new FileInfo(SourcePath);
                fi.CopyTo(TargetPath);
                string[] lines = File.ReadAllLines(SourcePath);
                foreach(string line in lines){

                    System.Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Houve um erro!");
                System.Console.WriteLine(e.Message);


            }









        }
    }
}
