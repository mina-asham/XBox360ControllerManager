using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace XBox360ControllerManager
{
    public static class XBox360
    {
        //Might need to change on systems earlier to Windows 8
        private const String XInputDll = "XInput1_4.dll";

        [DllImport(XInputDll, EntryPoint = "#100")]
        private static extern XBox360GamepadState GetGamepad(XBox360PlayerIndex playerIndex, out XBox360Gamepad gamepad);

        [DllImport(XInputDll, EntryPoint = "#103")]
        public static extern XBox360GamepadState PowerOffGamepad(XBox360PlayerIndex playerIndex);

        public static XBox360Gamepad GetGamepad(XBox360PlayerIndex playerIndex)
        {
            XBox360Gamepad gamepad;
            GetGamepad(playerIndex, out gamepad);
            return gamepad;
        }

        public static List<XBox360Gamepad> GetGamepads()
        {
            return Enum.GetValues(typeof(XBox360PlayerIndex))
                .Cast<XBox360PlayerIndex>()
                .Select(GetGamepad)
                .ToList();
        }

        public static void PowerOffGamepads()
        {
            foreach (XBox360PlayerIndex playerIndex in Enum.GetValues(typeof(XBox360PlayerIndex)))
            {
                PowerOffGamepad(playerIndex);
            }
        }
    }
}
