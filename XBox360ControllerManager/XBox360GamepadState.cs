namespace XBox360ControllerManager
{
    /// <summary>
    /// Represents the state of the gamepad when <see cref="XBox360.GetGamepad"/> is called
    /// </summary>
    public enum XBox360GamepadState : ushort
    {
        /// <summary>
        /// Gamepad is currently connected
        /// </summary>
        Connected = 0x0000,

        /// <summary>
        /// Gamepad is not currently connected
        /// </summary>
        NotConnected = 0x048F
    }
}
