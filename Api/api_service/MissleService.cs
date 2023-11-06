using api_model;

namespace api_service
{
    public class MissleService
    {
        readonly Data _db;
        public MissleService(Data data)
        {
            this._db = data;
        }
        //מחזיר את מערך הטילים
        public IEnumerable<Missle> GetData()
        {
            return _db.data;
        }
        public bool add(Missle m)
        {
            if(_db.data.Contains(m))
            {
                return false;
            }
            else
            {
                _db.data.Add(m);
                return true;
            }
        }
        //החזרת טילים לפי מיקום
        public IEnumerable<Missle> GetDataByCity(string city)
        {
            return _db.data.Where(t => t.Location.City == city).ToList();
        }

        public IEnumerable<string> GetCities()
        {
            return _db.data.Select(x => x.Location.City).ToList().Distinct();

        }

    }
}
