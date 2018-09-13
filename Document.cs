using System;

namespace Doc
{
    class Program
    {
        public static void Main()
        {
          String name, content;
          
         Console.WriteLine("Document");
         Console.WriteLine();

         
         Console.WriteLine("Enter what you want to name your document: ");
         name=ReadLine();

        
         using (StreamWriter sw = File.CreateText(name))
         {
         sw.WriteLine("What do you want in this document?");
         }
         sw.Close();
         try
         {
         using (StreamReader sr= File.OpenText(name))
         {
             content=sr.ReadLine();
         }
          
          catch(Exception e)
          {
              Console.WriteLine("Exception: " e.Message);
          }
          finally
          {
              Console.WriteLine("Executing Finally Block");
          }
          sr.Close();
         }
            int count=content.Length;
          
            Console.WriteLine(name, "Was successfully saved and contains ", count, "characters");

        }
          
    }
}