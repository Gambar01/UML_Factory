using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML01.Model;

namespace UML01
{
    public class MacFactory
    {
        public Button createButton() => new WinButton();
        public Checkbox createCheckBox() => new WinCheckBox();
    }
}
