namespace XBox360ControllerManager
{
    /// <summary>
    /// Enum to represent XBox 360 gamepad buttons
    /// For more info check: http://support.xbox.com/en-GB/xbox-360/accessories/controllers
    /// </summary>
    public enum XBox360GamepadButton : ushort
    {
        /// <summary>
        /// Directional pad up
        /// </summary>
        DPadUp = 0x0001,

        /// <summary>
        /// Directional pad down
        /// </summary>
        DPadDown = 0x0002,

        /// <summary>
        /// Directional pad left
        /// </summary>
        DPadLeft = 0x0004,

        /// <summary>
        /// Directional pad right
        /// </summary>
        DPadRight = 0x0008,

        /// <summary>
        /// Start
        /// </summary>
        Start = 0x0010,

        /// <summary>
        /// Back (options)
        /// </summary>
        Back = 0x0020,

        /// <summary>
        /// Left stick click
        /// </summary>
        LeftThumb = 0x0040,

        /// <summary>
        /// Right stick click
        /// </summary>
        RightThumb = 0x0080,

        /// <summary>
        /// Left bumper button (upper)
        /// </summary>
        LeftShoulder = 0x0100,

        /// <summary>
        /// Right bumper button (upper)
        /// </summary>
        RightShoulder = 0x0200,

        /// <summary>
        /// A button
        /// </summary>
        A = 0x1000,

        /// <summary>
        /// B button
        /// </summary>
        B = 0x2000,

        /// <summary>
        /// X button
        /// </summary>
        X = 0x4000,

        /// <summary>
        /// Y button
        /// </summary>
        Y = 0x8000,

        /// <summary>
        /// Guide button (main button)
        /// </summary>
        Guide = 0x0400
    }
}
