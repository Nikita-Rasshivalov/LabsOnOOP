using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
    enum KindFruits
    {
        Apple,
        Apricot,
        Oranges,
        Pear,
        Peach,
        Tangerines,
        Mango,
        Bananas,
        Lemon,
        Kiwi
    }

    enum KindVegetables
    {
        Carrots,
        Beets,
        Turnips,
        Cabbage,
        Tomato,
        Peppers,
        Cucumbers,
        Pumpkin,
        Squash,
        Spinach
    }
    enum KindBerries
    {
        Strawberry,
        Raspberry,
        Blackberry,
        Bluberry,
        Wildstrawberry,
        Lingonberries,
        Grapes,
        Watermelon,
        Melon,
        Barberry
    }
    public abstract class InfoAboutProduction
    {
        List<InfoAboutProduction> Productins = new List<InfoAboutProduction>();
        public int PriceOnKillo { get; set; }
        public bool Technology { get; set; }
        public abstract string[] Types { get; }

    }
}
