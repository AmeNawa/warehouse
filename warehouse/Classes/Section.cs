using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Classes
{

    // Section provides information about part of storehouse
   public class Section : IEquatable<Section>
    {
        public struct Shelves
        {
            public int height;
            public int width;
            public int Space()
            {
                return height * width;
            }
        }

        public int sectionID { get; set; }
        public int shelvesAmount { get; set; }
        Shelves shelves;


        public Section(int ID, int amount, int height, int width)
        {
            sectionID = ID;
            shelvesAmount = amount;
            shelves.height = height;
            shelves.width = width;
        }

        public Section(Section preSection, int n = 1, int sA = 2)
        {
            sectionID = preSection.sectionID + n;
            shelvesAmount = preSection.shelvesAmount / sA;
            shelves.height = preSection.shelves.height;
            shelves.width = preSection.shelves.width;
        }

        public int SingleSpace(Shelves shelve)
        {
            return shelves.Space();
        }

        public int FullSpace(Shelves shelve)
        {
            return shelve.Space() * shelvesAmount;
        }

        public int DifferenceSpace(Shelves firstShelve, Shelves secondShelve)
        {
            int diff = FullSpace(firstShelve) - FullSpace(secondShelve);
            if (diff > 0) return diff;
            return diff * -1;
        }

        public override int GetHashCode()
        {
            return sectionID;
        }

        // Sections are equal only if amount of shelves are the same !

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Section objAsSection = obj as Section;
            if (objAsSection == null) return false;
            else return Equals(objAsSection);
        }

        public bool Equals(Section other)
        {
            if (other == null) return false;
            return (this.shelvesAmount.Equals(other.shelvesAmount));
        }
    }
}
