﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System;
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="ClassStyles"/> nested type.
    /// </content>
    public partial class User32
    {
        [Flags]
        public enum ClassStyles : uint
        {
            /// <summary>
            /// Aligns the window's client area on a byte boundary (in the x direction). This style
            /// affects the width of the window and its horizontal placement on the display.
            /// </summary>
            CS_BYTEALIGNCLIENT = 0x1000,

            /// <summary>
            /// Aligns the window on a byte boundary (in the x direction). This style affects the width
            /// of the window and its horizontal placement on the display.
            /// </summary>
            CS_BYTEALIGNWINDOW = 0x2000,

            /// <summary>
            /// Allocates one device context to be shared by all windows in the class. Because window
            /// classes are process specific, it is possible for multiple threads of an application to
            /// create a window of the same class. It is also possible for the threads to attempt to use
            /// the device context simultaneously. When this happens, the system allows only one thread
            /// to successfully finish its drawing operation.
            /// </summary>
            CS_CLASSDC = 0x0040,

            /// <summary>
            /// Sends a double-click message to the window procedure when the user double-clicks the
            /// mouse while the cursor is within a window belonging to the class.
            /// </summary>
            CS_DBLCLKS = 0x0008,

            /// <summary>
            /// Enables the drop shadow effect on a window. The effect is turned on and off through
            /// SPI_SETDROPSHADOW. Typically, this is enabled for small, short-lived windows such as
            /// menus to emphasize their Z order relationship to other windows.
            /// </summary>
            CS_DROPSHADOW = 0x00020000,

            /// <summary>
            /// Indicates that the window class is an application global class.
            /// </summary>
            CS_GLOBALCLASS = 0x4000,

            /// <summary>
            /// Redraws the entire window if a movement or size adjustment changes the width of the
            /// client area.
            /// </summary>
            CS_HREDRAW = 0x0002,

            /// <summary>
            /// Disables Close on the window menu.
            /// </summary>
            CS_NOCLOSE = 0x0200,

            /// <summary>
            /// Allocates a unique device context for each window in the class.
            /// </summary>
            CS_OWNDC = 0x0020,

            /// <summary>
            /// Sets the clipping rectangle of the child window to that of the parent window so that the
            /// child can draw on the parent. A window with the CS_PARENTDC style bit receives a regular
            /// device context from the system's cache of device contexts. It does not give the child the
            /// parent's device context or device context settings. Specifying CS_PARENTDC enhances an
            /// application's performance.
            /// </summary>
            CS_PARENTDC = 0x0080,

            /// <summary>
            /// Saves, as a bitmap, the portion of the screen image obscured by a window of this class.
            /// When the window is removed, the system uses the saved bitmap to restore the screen image,
            /// including other windows that were obscured. Therefore, the system does not send WM_PAINT
            /// messages to windows that were obscured if the memory used by the bitmap has not been
            /// discarded and if other screen actions have not invalidated the stored image. This style
            /// is useful for small windows (for example, menus or dialog
            /// boxes) that are displayed briefly and then removed before other screen activity takes
            /// place. This style increases the time required to display the window, because the system
            /// must first allocate memory to store the bitmap.
            /// </summary>
            CS_SAVEBITS = 0x0800,

            /// <summary>
            /// Redraws the entire window if a movement or size adjustment changes the height of the
            /// client area.
            /// </summary>
            CS_VREDRAW = 0x0001
        }
    }
}