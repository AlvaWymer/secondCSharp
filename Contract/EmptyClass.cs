using System;
namespace Contract
{
    public class EmptyClass
    {
        static void Main(string[] args){
            Entreprise en = new Entreprise("1",3); 
            Program p = new Program("1sdf","2sdf", "09-09-23-334", "1" ,55);
            Console.WriteLine(p.Infos());
        }
    }
}
