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


        /*
        create a new trackable

        params: name of trackable
                latitude of device
                longitude of device

        return: true if succeeded
                false if not
                false if trackable already exists
         */
        public bool createTrackable(String name, double latCoord, double longCoord)
        {
            //if a trackable with BoardID exists return false
            if (getTrackableByBoardID() != null) return false;

            Trackable_Post trackable = new Trackable_Post();
            trackable.name = name;

            Geometry geometry = new Geometry(latCoord, longCoord);
            trackable.geometry = geometry;

            string serial = getBoardID();

       

            trackable.location_providers[0] = serial;
            return this.dhp.SetTrackable(trackable);  
        }


        /*
        get the MotherboardID for identifying the Device

        params: -

        return: MotherboardID
         */
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


        /*
        deete a trackable with given ID

        params: ID 

        return: true if succeeded
                false if not
         */
        public bool DeleteTrackable(string trackableID)
        {
            return dhp.DeleteTrackable(trackableID);
        }


        /*
        gets a Trackable by name

        params: name of trackable

        return: trackable if exists
                null if not
         */
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


        /*
        gets a Trackable by MotherboardID

        params: MotherboardID

        return: trackable if exists
                null if not
         */
        public Trackable getTrackableByBoardID()
        {
            string id = getBoardID();
            Trackable[] trackables = dhp.GetTrackableSummary();
            foreach (Trackable trackable in trackables)
            {
                if (trackable.location_providers[0].Equals(id))
                {
                    return trackable;
                }
            }
            return null;
        }






        /*
        get all trackables (not used)

        params: -

        return: String array
        */
        public String[] GetTrackables()
        {
            return dhp.GetTrackables();
        }


        /*
        gets all trackables

        params: -

        return: Trackable array
         */
        public Trackable[] GetTrackableSummary()
        {
            return dhp.GetTrackableSummary();
        }


        /*
        update trackable with given lat and lon

        params: name of trackable
                latitude
                longitude

        return: true if succeded
                false if not
         */
        public bool UpdateTrackableCoordinates(string id, double latCoord, double lonCoord)
        {
            Trackable trackable = dhp.GetTrackable(id);
            //if trackable is not yours
            //if (trackable.location_providers[0].Equals(getBoardID())) return false;

            trackable.geometry.AddLatLong(latCoord, lonCoord);
            return UpdateTrackable(trackable);
        }


        /*
        update trackable with given object

        params: updated trackable

        return: true if succeeded
                falde if not
         */
        public bool UpdateTrackable(Trackable trackable)
        {
            return dhp.PutTrackable(trackable);
        }


        /*
        get address by given lat and long from openstreetmap

        params: updated trackable

        return: true if succeeded
                false if not
         */
        public address GetAddressByIndex(Trackable trackable, int index)
        {
            double[] coordinates = trackable.geometry.getLatLon(index);
            return dhp.getAddressByCoordinates(coordinates[0], coordinates[1]);
        }

       public address GetAddressByCoordinates(double latitude, double longitude)
        {            
            return dhp.getAddressByCoordinates(latitude, longitude);
        }

        /*
        get address by given lat and long from openstreetmap

        params: updated trackable

        return: true if succeeded
                false if not
         */
        public address GetLatestAddress(Trackable trackable)
        {
            int last = (trackable.geometry.coordinates.Length / 2) -1;
            double[] coordinates = trackable.geometry.getLatLon(last);
            return dhp.getAddressByCoordinates(coordinates[0], coordinates[1]);
        }

        
        /*
        public static string Truncate(string value, int maxLength)
        {
            if (value.Length < maxLength)
            {
                for(int i = value.Length; i < maxLength; i++)
                {
                    value += " ";
                }
            }
            else
            {
                value = value.Substring(0, maxLength);
            }
            return value;
        }
        */


        /*
        get Geocoordinates by given address

        params: string street
                string housenumber
                string city
                string postalcode
                string country

        return: string[] with lat and lon
                null if address not found
         */
        public string[] GetCoordinatesByAddress(string street, string housenumber, string city, string postalcode, string country)
        {
            return dhp.getCoordinatesByAddress( street, housenumber, city, postalcode, country);
        }


        /*
        get Geocoordinates by IP

        return: double[] with lat and lon
         */
        public double[] GetGeocoordinates()
        {
            return dhp.getGeocoordinates();
        }
    }
}
