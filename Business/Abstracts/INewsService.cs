using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface INewsService
    {
        List<string> MynetGetAllNewsTitle();

        List<string> NewYorkGetNews();

        List<string> GetAllNews();
        List<string> GetAllRetaildetailbe();
        List<string> GetAllAcrossNews();
    }
}
