using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace XBox360ControllerManager
{
    /// <summary>
    /// Struct that represents an XBox360 gamepad
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct XBox360Gamepad
    {
        /// <summary>
        /// Event count for gamepad
        /// </summary>
        public uint EventCount;

        /// <summary>
        /// Bitmask of the device digital buttons, as follows. A set bit indicates that the corresponding button is pressed.
        /// </summary>
        public XBox360GamepadButton WButtons;

        /// <summary>
        /// The current value of the left trigger analog control. The value is between 0 and 255.
        /// </summary>
        public byte BLeftTrigger;

        /// <summary>
        /// The current value of the right trigger analog control. The value is between 0 and 255.
        /// </summary>
        public byte BRightTrigger;

        /// <summary>
        /// Left thumbstick x-axis value. The value is between -32768 and 32767.
        /// </summary>
        public short SThumbLX;

        /// <summary>
        /// Left thumbstick y-axis value. The value is between -32768 and 32767.
        /// </summary>
        public short SThumbLY;

        /// <summary>
        /// Right thumbstick x-axis value. The value is between -32768 and 32767.
        /// </summary>
        public short SThumbRX;

        /// <summary>
        /// Right thumbstick y-axis value. The value is between -32768 and 32767.
        /// </summary>
        public short SThumbRY;

        /// <summary>
        /// Checks if a specific button is pressed
        /// </summary>
        /// <param name="button">Button to check</param>
        /// <returns>True if button is pressed, false otherwise</returns>
        private bool IsPressed(XBox360GamepadButton button)
        {
            return (ushort)(button & WButtons) != 0;
        }

        /// <summary>
        /// Get list of pressed buttons
        /// </summary>
        /// <returns>List of pressed button</returns>
        public List<XBox360GamepadButton> GetButtons()
        {
            return Enum.GetValues(typeof(XBox360GamepadButton))
                .Cast<XBox360GamepadButton>()
                .Where(IsPressed)
                .ToList();
        }
    }
}
