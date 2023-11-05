﻿using BuilderPattern.Builders;

namespace BuilderPattern.Clients;

/// <summary>
/// The 'Director' class
/// </summary>
class Shop
{
    // Builder uses a complex series of steps
    public void Construct(VehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildWheels();
        vehicleBuilder.BuildDoors();
    }
}