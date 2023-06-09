﻿using System;

namespace FormComplejos_2023_II
{
    internal class Complejo
    {
        private float real;
        private float imaginaria;

        public Complejo(float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;

        }

        public static Complejo operator +(Complejo c1,Complejo c2 )
        {
            Complejo c3 = new Complejo(c1.real+c2.real, c1.imaginaria+c2.imaginaria);

            return c3;
        }


        public override string ToString()
        {
            return String.Format("{0} + {1}i  ",real,imaginaria); 
        }


    }
}
