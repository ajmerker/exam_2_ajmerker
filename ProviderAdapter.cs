using System.Collections.Generic; 
namespace exam_2_ajmerker
{
    public class ProviderAdapter : IGetStats
    {
        NewProvider newProvider;

        public ProviderAdapter(NewProvider newProvider)
        {
            this.newProvider = newProvider; 
        }

        public List<QBStats> GetQBStats()
        {
            
            List<QBStats> qbStats = new List<QBStats>();
            
            qbStats.Add(new QBStats(){ID="QB1", PassingYards = 175, 
                        RushingYards=22.5, PassingTDs=1, RushingTDs=0});
            qbStats.Add(new QBStats(){ID="QB2", PassingYards = 305.5, 
                        RushingYards=2.5, PassingTDs=3, RushingTDs=1});
            qbStats.Add(new QBStats(){ID="QB3", PassingYards = 205.5, 
                        RushingYards=12.5, PassingTDs=2, RushingTDs=1});

            return qbStats; 
             
        }
        public List<RBStats> GetRBStats()
        {
            
            List<RBStats> rbStats = new List<RBStats>();
            newProvider.GetOffensiveStats(); 
            return rbStats; 

        }
        public List<WRStats> GetWRStats()
        {
            List<WRStats> wrStats = new List<WRStats>();
            wrStats.Add(new WRStats(){ID="WR1", ReceivingYards = 72, 
                        RushingYards=5.25, ReceivingTDs=1, RushingTDs=0});
            wrStats.Add(new WRStats(){ID="WR1", ReceivingYards = 25, 
                        RushingYards=0, ReceivingTDs=0, RushingTDs=0});
            wrStats.Add(new WRStats(){ID="WR1", ReceivingYards = 125, 
                        RushingYards=12.0, ReceivingTDs=2, RushingTDs=0});
            return wrStats; 
        }


    }
}