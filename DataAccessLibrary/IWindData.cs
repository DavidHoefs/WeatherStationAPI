using System.Collections.Generic;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IWindData
    {
        List<WindDataModel> GetAllData();
        void InsertData(WindDataModel data);
    }
}