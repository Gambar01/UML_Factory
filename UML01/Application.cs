using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML01.Model;

namespace UML01
{
    public class Application 
    {
        public IGUIFactory factory { get; set; }
        public Button button { get; set; }
        public void createUI() { }
        public void paint() { }
    }
}
