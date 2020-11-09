using System.Collections.Generic; 
using System;

namespace exam_2_ajmerker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quarter Back 
            Console.WriteLine("This weeks QB stats are below!");
            IGetStats statsObj = new NormalProvider();
            List<QBStats> qbStats = statsObj.GetQBStats();
            foreach(QBStats qb in qbStats){
                Console.WriteLine(qb.ToString());
            }
            
            Console.WriteLine("QB Stats with the New Provider: "); 
            
           IGetStats newStats = new ProviderAdapter(new NewProvider()); 
           List<QBStats> myQBStats = newStats.GetQBStats(); 
            foreach(QBStats qb in myQBStats){
                Console.WriteLine(qb.ToString());
            }
            


            //WR
            Console.WriteLine("\nThis weeks WR stats are below!");
            List<WRStats> wrStats = statsObj.GetWRStats();
            foreach(WRStats wr in wrStats){
                Console.WriteLine(wr.ToString());
            }
            
            Console.WriteLine("WR stats with new provider"); 
            IGetStats newWRStats = new ProviderAdapter(new NewProvider()); 
           List<WRStats> myWRStats = newStats.GetWRStats(); 
            foreach(WRStats wr in myWRStats){
                Console.WriteLine(wr.ToString());
            }


            //I Think this example is the more correct way of doing it but I can't get it to work!! 
            //Running back 
            Console.WriteLine("\nThis weeks RB stats are below!");
            List<RBStats> rbStats = statsObj.GetRBStats();
            foreach(RBStats rb in rbStats){
                Console.WriteLine(rb.ToString());
            }

            IGetStats newrbStats = new ProviderAdapter(new NewProvider()); 
           List<RBStats> myRBStats = newStats.GetRBStats(); 
            foreach(RBStats rb in myRBStats){
                Console.WriteLine(rb.ToString());
                Console.WriteLine("We got here aswell"); 
            }

            Console.WriteLine("We got here"); 
        }
    }
}
