﻿namespace HelloWorld.Interfaces
{
    public interface ISredstvoPlacanja : IInfo
    {
        double Stanje { get; }

        void Uplati(double iznos);

        void Isplati(double iznos);
    }
}
