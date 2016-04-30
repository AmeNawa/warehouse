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
            sections.Add(new Section(amount, height, width));
        }
        public void StrHouseDivide(Storehouse strhouse);    //TODO
        {
            
        }
        
    }
}
