using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace XBox360ControllerManager
{
    /// <summary>
    /// Static class for managing XBox 360 controllers
    /// </summary>
    public static class XBox360
    {
        /// <summary>
        /// XInput DLL, this is compatible with Windows 8+, for previous versions we might need to change this one
        /// </summary>
        private const string XInputDll = "XInput1_4.dll";

        /// <summary>
        /// Secret entry point for GetGamepad function
        /// Other entry point mentioned in XInput documentations doesn't provide the Guide button
        /// </summary>
        /// <param name="playerIndex">Player/gamepad index</param>
        /// <param name="gamepad">Output gamepad info</param>
        /// <returns>Connected if gamepad is connected, NotConnected otherwise</returns>
        [DllImport(XInputDll, EntryPoint = "#100")]
        private static extern XBox360GamepadState GetGamepad(XBox360PlayerIndex playerIndex, out XBox360Gamepad gamepad);

        /// <summary>
        /// Secret entry point for PowerOffGamepad function
        /// </summary>
        /// <param name="playerIndex">Player/gamepad index</param>
        /// <returns>Connected if gamepad is connected, NotConnected otherwise</returns>
        [DllImport(XInputDll, EntryPoint = "#103")]
        public static extern XBox360GamepadState PowerOffGamepad(XBox360PlayerIndex playerIndex);

        /// <summary>
        /// Get gamepad given a player/gamepad index
        /// </summary>
        /// <param name="playerIndex">Player/gamepad index</param>
        /// <returns>The corresponding gamepad</returns>
        public static XBox360Gamepad GetGamepad(XBox360PlayerIndex playerIndex)
        {
            XBox360Gamepad gamepad;
            GetGamepad(playerIndex, out gamepad);
            return gamepad;
        }

        /// <summary>
        /// Get all four gamepads
        /// </summary>
        /// <returns>All four gamepads</returns>
        public static List<XBox360Gamepad> GetGamepads()
        {
            return Enum.GetValues(typeof(XBox360PlayerIndex))
                .Cast<XBox360PlayerIndex>()
                .Select(GetGamepad)
                .ToList();
        }

        /// <summary>
        /// Power off all connected gamepad
        /// </summary>
        public static void PowerOffGamepads()
        {
            foreach (XBox360PlayerIndex playerIndex in Enum.GetValues(typeof(XBox360PlayerIndex)))
            {
                PowerOffGamepad(playerIndex);
            }
        }
    }
}
