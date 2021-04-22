using System.Collections.Generic;
using Martinus.Outfitter.Source.Data;
using NLog;
using NWN.Services;

namespace Martinus.Outfitter
{
    [ServiceBinding(typeof(Outfitter))]
    public class Outfitter
    {
        public Outfitter()
        {
            // Your startup service code
            Log.Info("Outfitter Alpha Initializing...");
        }

        public Dictionary<string, Outfit> PlayerOutfits { get; } = new();

        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
    }
}
