using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StationJsonRepository : IStationRepository
    {
        private readonly string PATH = "..\\..\\..\\..\\DataAccess\\Data\\Stations.json";
        private readonly JsonStation jsonStation;
        
        private JsonStation GetSavedStations()
        {
            JsonStation jsonStation;
            if (!File.Exists(PATH))
            {
                jsonStation = new JsonStation();
            }
            else
            {
                string savedStations;
                using (var sr = new StreamReader(PATH))
                {
                    savedStations = sr.ReadToEnd();
                }
                jsonStation = JsonConvert.DeserializeObject<JsonStation>(savedStations);
            }
            return jsonStation;
        }

        private void AddStation(JsonStation json, Station station)
        {
            if (jsonStation?.Stations == null)
            {
                throw new ArgumentNullException(nameof(jsonStation), "invalid saved stations");
            }
            var lastSavedId = jsonStation.Stations.Count == 0 ? 0 : jsonStation.Stations.Max(s => s.Id);
            station.Id = lastSavedId + 1;
            jsonStation.Stations.Add(station);
        }

        private void SaveStation(JsonStation json)
        {
            var savedStations = JsonConvert.SerializeObject(json);
            using (var sw = new StreamWriter(PATH))
            {
                sw.Write(savedStations);
            }
        }

        public Station CreateStation(Station station)
        {
            var jsonStations = this.GetSavedStations();
            this.AddStation(jsonStations, station);
            this.SaveStation(jsonStations);
            return station;
        }

        public bool DeleteStationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Station> GetAllStations()
        {
            throw new NotImplementedException();
        }

        public Station GetStationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
