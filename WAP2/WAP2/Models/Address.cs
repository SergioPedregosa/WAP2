namespace WAP2.Models
{
    public class Address
    {
        public Address()
        {

        }
        public Address(string name, string addressInfo, string floor, float lat, float lon, string userRID)
        {
            Name = name;
            AddressInfo = addressInfo;
            Floor = floor;
            Lat = lat;
            Lon = lon;
            UserRID = userRID;
        }

        public int AddressID { get; set; }
        public string Name { get; set; }
        public string AddressInfo { get; set; }
        public string Floor { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        public string UserRID { get; set; }
    }
}
