using System.Collections.Generic; 
namespace exam_2_ajmerker
{
    public interface IGetStats
    {
        List<QBStats> GetQBStats();
        List<RBStats> GetRBStats();
        List<WRStats> GetWRStats();
    }
}