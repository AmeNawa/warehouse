using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Classes
{
    public class Storehouse
    {
        List<Section> sections = new List<Section>();

        public Storehouse(int amount, int height, int width)
        {
            sections.Add(new Section(0,amount, height, width));
        }


        public void StrHouseDivide(List<Section> sections, Section section)    //TODO
        {
           var sec = sections.Find(s => s.sectionID == section.sectionID);
            sections.Add(new Section(sec));
            sections.Add(new Section(sec, 1));
            sections.Remove(section);

        }
        
    }
}
