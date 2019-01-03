using System;
using LogicGates.Common;

namespace LogicGates.Models.Elements
{
    public class LampOff : Lamp
    {
        protected override string FileName { get; set; } = "element_lamp_off.png";
        protected override string FileNameAlt { get; set; } = "element_lamp_on.png";

        public LampOff() : base()
        {
        }

        public LampOff(Size size) : base(size)
        {
        }

        public LampOff(Position position) : base(position)
        {
        }

        public LampOff(Size size, Position position) : base(size, position)
        {
        }

        public override void ClickedLeft(Position mousePosition, Position relativeMousePosition)
        {
            ChangeState();
        }
    }
}