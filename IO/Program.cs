using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            dir.CreateSubdirectory("TestDir");

            for (int i=0;i<9;i++)
            {
                dir.CreateSubdirectory(string.Format(@"TestDir\Folder-{0}", i));
                Console.WriteLine("Created Folder-{0}",i);
            }

            Console.ReadKey();

            //Удаление на классе-объекте Directory
            //try
            //{
            //        Directory.Delete(@"C:\TestDir",true);//true гарантирует удаление подкаталогов
            //    }
            //catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            for (int i=0;i<9;i++)
            {
                try
                {
                    Directory.Delete(string.Format(@"C:\TestDir\Folder-{0}", i));
                    Console.WriteLine("Folder-{0} deleted",i);
                }
                catch(Exception e) {Console.WriteLine(e.Message);}
            }




            Console.ReadKey();


        }
    }
}
