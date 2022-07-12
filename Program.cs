using System;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string word = "basic";
            //    ProDocumentProgram pro = new ProDocumentProgram();
            //    ExpertDocumentProgram expert = new ExpertDocumentProgram();
            //    DocumentProgram basic = new DocumentProgram();

            //    if (word == "pro")
            //    {
            //        pro.EditDocument();
            //        pro.SaveDocument();
            //        pro.OpenDocument();
            //    }
            //    else if(word == "basic")
            //    {
            //        basic.EditDocument();
            //        basic.SaveDocument();
            //        basic.OpenDocument();
            //    }
            //    else if(word == "expert")
            //    {
            //        expert.EditDocument();
            //        expert.SaveDocument();
            //        expert.OpenDocument();
            //    }
            //    else
            //    {
            //        Console.WriteLine("nothing");
            //    }

            var obj = new Invoice();
            obj.Article = "LapTop";

            Invoice invoice = new Invoice("678904", "Alex", "Foxtrot");


            obj.Article = "USB-hab";
            obj.Quantity = 6;

            double result = obj.CostCalculation(true, 1400, 4);
            Console.WriteLine(result);
        }
    
    }
}