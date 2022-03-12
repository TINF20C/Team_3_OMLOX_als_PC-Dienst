using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OmloxBackend
{
    public class Controller
    {
        DeepHub dhp;

        public Controller()
        {
            this.dhp = new DeepHub();
        }
        public bool sendTrackable(String name)
        {
            Trackable_Post trackable = new Trackable_Post();
            trackable.name = name;

            double latCoord = 7.815694;
            double lonCoord = 48.13021599999995;

            Geometry geometry = new Geometry(latCoord, lonCoord);
            trackable.geometry = geometry;
            //NetworkInterface.GetAllNetworkInterfaces
            trackable.location_providers[0] = "sd:ss:ff:fd:ss";
            this.dhp.SetTrackable(trackable);
            return true;    
        }

        public void DeleteTrackable(string trackableID)
        {
            dhp.DeleteTrackable(trackableID);
        }

        public String[] GetTrackables()
        {
            return dhp.GetTrackables();
        }

        public Trackable[] GetTrackableSummary()
        {
            return dhp.GetTrackableSummary();
        }

        public void UpdateTrackableCoordinates(string id, double[] coordinates)
        {
            Trackable trackable = dhp.GetTrackable(id);
            trackable.geometry.AddLatLong(coordinates[0], coordinates[1]);
            dhp.PutTrackable(trackable);
        }

        public void UpdateTrackable(Trackable trackable)
        {
            dhp.PutTrackable(trackable);
        }
    }
}
