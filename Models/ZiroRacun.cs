﻿using HelloWorld.Interfaces;
using System;

namespace HelloWorld.Models
{
    internal class ZiroRacun : BankovniRacun, ISredstvoPlacanja, IBezgotovinskoPlacanje
    {
        public ZiroRacun(long broj, double stanje) : base(broj, "žiro-račun", stanje)
        {
            
        }

        public override void Isplati(double iznos)
        {
            if (Stanje - iznos < 0)
            {
                throw new Exception("Nije moguće ići u minus s računom!");
            }
            else
            {
                base.Isplati(iznos);
            }
        }
    }
}