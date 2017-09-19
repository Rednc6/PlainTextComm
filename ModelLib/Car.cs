using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Car
    {
        public String Model { get; set; }
        public String Color { get; set; }
        public String RegNo { get; set; }

        public Car(string mode, string color, string regNo)
        {
            this.Model = mode;
            this.Color = color;
            this.RegNo = regNo;
        }

        public override string ToString()
        {
            return $" Model: {Model}, Color: {Color}, Registration Nr. {RegNo}.";
        }
    }
}
