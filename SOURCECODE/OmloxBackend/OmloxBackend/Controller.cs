﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmloxBackend
{
    public class Controller
    {
        DeepHub dhp;

        public Controller()
        {
            dhp = new DeepHub();
        }

        public bool sendTrackable(String name)
        {
            Trackable_Post trackable = new Trackable_Post();
            trackable.name = name;

            double latCoord = 7.815694;
            double lonCoord = 48.13021599999995;

            Geometry geometry = new Geometry(latCoord, lonCoord);
            return true;
        }
    }
}