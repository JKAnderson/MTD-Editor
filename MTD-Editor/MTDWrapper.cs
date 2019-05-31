using SoulsFormats;

namespace MTD_Editor
{
    internal class MTDWrapper
    {
        public MTD MTD { get; }

        public string Name { get; }

        public MTDWrapper(MTD mtd, string name)
        {
            MTD = mtd;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
