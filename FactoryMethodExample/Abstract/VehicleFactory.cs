﻿namespace FactoryMethodExample.Abstract;

public abstract class VehicleFactory
{
    public abstract IFactory GetVehicle(string Vehicle);

}
