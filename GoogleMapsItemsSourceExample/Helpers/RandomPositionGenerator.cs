﻿using System;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMapsItemsSourceExample.Helpers
{
    public class RandomPositionGenerator
    {
        static Random Random = new Random(Environment.TickCount);

        public static Position Next()
        {
            return new Position(
                latitude: Random.NextDouble() * 180 - 90,
                longitude: Random.NextDouble() * 360 - 180
            );
        }

        public static Position Next(Position position, double latitudeRange, double longitudeRange)
        {
            return new Position(
                latitude: position.Latitude + (Random.NextDouble() * 2 - 1) * latitudeRange,
                longitude: position.Longitude + (Random.NextDouble() * 2 - 1) * longitudeRange
            );
        }

    }
}
