using System;
using NWN.API.Constants;

namespace Martinus.Outfitter.Source.Data
{
    public class ColorVector
    {
        private byte[] ColorArray { get; } = new byte[Enum.GetNames(typeof(ItemAppearanceArmorColor)).Length];

        public byte this[ItemAppearanceArmorColor color]
        {
            get => ColorArray[(int)color];
            set => ColorArray[(int)color] = value;
        }
    }
}