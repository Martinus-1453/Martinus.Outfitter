using System;
using System.Collections.Generic;
using System.Linq;
using NWN.API.Constants;

namespace Martinus.Outfitter.Source.Data
{
    public class ArmorMain
    {
        private Tuple<byte, ColorVector>[] AppearanceArray { get; } =
            new Tuple<byte, ColorVector>[Enum.GetNames(typeof(ItemAppearanceArmorModel)).Length];

        public Tuple<byte, ColorVector> this[ItemAppearanceArmorModel model]
        {
            get => AppearanceArray[(int)model];
            set => AppearanceArray[(int)model] = value;
        }
    }
}