using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML01.Model;

namespace UML01
{
    public interface IGUIFactory
    {
        public Button createButton();
        public Checkbox createCheckBox();

    }
}
