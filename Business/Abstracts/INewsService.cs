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

        string MynetNewsTitleSearch(string key);

        //string NewYorkTimesNewsTitleSearch(string key);

        List<string> NewYorkGetNews();

        void GetAllNews();

        List<string> GetAllFeedburnerNews();
        List<string> GetAllRetaildetailbe();
        List<string> GetAllAcrossNews();
    }
}
