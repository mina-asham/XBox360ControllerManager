using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace XBox360ControllerManager
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XBox360Gamepad
    {
        public uint EventCount;
        public XBox360GamepadButton WButtons;
        public byte BLeftTrigger;
        public byte BRightTrigger;
        public short SThumbLX;
        public short SThumbLY;
        public short SThumbRX;
        public short SThumbRY;

        private bool IsPressed(XBox360GamepadButton button)
        {
            return (ushort)(button & WButtons) != 0;
        }

        public List<XBox360GamepadButton> GetButtons()
        {
            return Enum.GetValues(typeof(XBox360GamepadButton))
                .Cast<XBox360GamepadButton>()
                .Where(IsPressed)
                .ToList();
        }
    }
}
