namespace Martinus.Outfitter.Source.Data
{
    public class Outfit
    {
        public ArmorMain ArmorMainAppearance { get; set; }
        public ArmorOther HelmetAppearance { get; set; }
        public ArmorOther CapeAppearance { get; set; }
        public Weapon[] WeaponAppearance { get; set; } = new Weapon[2];
    }
}
