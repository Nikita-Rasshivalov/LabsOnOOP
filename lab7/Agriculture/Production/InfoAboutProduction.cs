using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Production
{
    enum KindOfVegetables
    {
        Carrots,
        Potatos,
        Tomatos,
        Peppers,
        Squashs,
        Beets,
        Cabbages,
        Cucumbers,
        Pumpkins,
        Spinachs
    }
    enum KindOfFruits
    {
        Apples,
        Apricots,
        Kiwis,
        Lemons,
        Oranges,
        Pears,
        Peachs,
        Tangerines,
        Mandarines,
        Banans
    }
    enum KindOfBerries
    {
       Bluberries,
       Strawberries,
       Grapes,
       Blackberries,
       Barberries,
       Watermelons,
       Melons,
       Cranberries,
       Raspberries,
       Lingonberries
    }

    enum KindTypes
    {
        Fruits,
        Vegetables,
        Berries
    }
    public abstract class InfoAboutProduction
    {
        public int PriceOnKillo { get { return GetPrice(); } }
        public bool Technology { get; set; }
        public abstract string[] Types { get; }

        public abstract int GetPrice();

        // метод стрин для переопределения вида

    }
}
