using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Device.Location;
using System.Net.Sockets;

namespace OmloxBackend
{
    public class Controller
    {
        DeepHub dhp;

        public Controller()
        {
            this.dhp = new DeepHub();
        }

        public GeoCoordinate getPosition()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.TryStart(false, TimeSpan.FromSeconds(3));
            GeoCoordinate coord = watcher.Position.Location;
            
            return coord;
        }

        public bool createTrackable(String name, double latCoord, double longCoord)
        {
            Trackable_Post trackable = new Trackable_Post();
            trackable.name = name;

            Geometry geometry = new Geometry(latCoord, longCoord);
            trackable.geometry = geometry;

            string serial = getBoardID();

       

            trackable.location_providers[0] = serial;
            this.dhp.SetTrackable(trackable);
            return true;    
        }

        private string getBoardID()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string serial = "";
            foreach (ManagementObject mo in moc)
            {
                serial = (string)mo["SerialNumber"];
            }
            return serial;
        }

        public void DeleteTrackable(string trackableID)
        {
            dhp.DeleteTrackable(trackableID);
        }

        public Trackable getTrackableByName(string name)
        {
            Trackable[] trackables = dhp.GetTrackableSummary();
            foreach (Trackable trackable in trackables)
            {
                if (trackable.name.Equals(name))
                {
                    return trackable;
                }
            }
            return null;
        }

        public String[] GetTrackables()
        {
            return dhp.GetTrackables();
        }

        public Trackable[] GetTrackableSummary()
        {
            return dhp.GetTrackableSummary();
        }

        public bool UpdateTrackableCoordinates(string id, double latCoord, double longCoord)
        {
            Trackable trackable = dhp.GetTrackable(id);
            //if trackable is not yours
            //if (trackable.location_providers[0].Equals(getBoardID())) return false;

            trackable.geometry.AddLatLong(latCoord, longCoord);
            bool status = dhp.PutTrackable(trackable);
            return status;
        }
        /*
        public void UpdateTrackable(Trackable trackable)
        {
            dhp.PutTrackable(trackable);
        }
        */
    }
}
