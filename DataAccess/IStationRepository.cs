using BusinessContractors;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IStationRepository
    {
        Station CreateStation(Station station);

        List<Station> GetAllStations();

        //Station UpdateStation(DeleteUpdateStationCommand command);

        //bool DeleteStationById(int id);

        Station GetStationById(int id);
    }
}
