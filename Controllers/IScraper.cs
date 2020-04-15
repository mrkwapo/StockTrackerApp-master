using System.Collections.Generic;

namespace MultiUserMVC.Controllers
{
    public interface IScraper
    {
        void LoginYahoo();
        List<string> ParseData();
        void saveStocks();
    }
}