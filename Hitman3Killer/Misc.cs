using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Indieteur.GlobalHooks;

namespace Hitman3Killer
{
    public enum hookType
    {
        keyHook,
        mouseHook,
        All
    }
    static class Misc
    {
        public enum KeyEventType
        {
            OnKeyDown,
            OnKeyPress,
            OnKeyUp
        }

        public static string MakeKeyLog(GlobalKeyEventArgs e, KeyEventType keyEventType)
        {
            bool ModifierKeyPressed = false;

            StringBuilder logMessage = new StringBuilder(""); //  ("Keyboard: "); //Start creating our text

            switch (keyEventType) //Check which event called this method and set the appropriate text for it. The calling method passed on the event type to us via keyEventType argument.
            {
                case KeyEventType.OnKeyDown:
                    logMessage.Append($"KEY DOWN:  {e.KeyCode}");
                    break;
                case KeyEventType.OnKeyPress:
                    logMessage.Append($"KEY PRESS: {e.KeyCode}");
                    break;
                case KeyEventType.OnKeyUp:
                    logMessage.Append($"KEY UP:    {e.KeyCode}");
                    break;
                default:
                    logMessage.Append($"????       {e.KeyCode}");
                    break;
            }

            //Check if the resulting character is set to something or not (e.g. CharResult would be empty if the user presses Shift on it's own.)
            //if (!string.IsNullOrWhiteSpace(e.CharResult))
            //{
            //    logMessage.Append(" Resulting Character: " + e.CharResult + " -- ");
            //}

            logMessage.Append("\t[MOD: ");

            //Let's check which modifier keys are being pressed and append it to the log.
            if (e.Control != ModifierKeySide.None)
            {
                ModifierKeyPressed = true;
                logMessage.Append(e.Control.ToString() + " Control");
            }
            if (e.Shift != ModifierKeySide.None)
            {
                logMessage.Append((ModifierKeyPressed ? ", " : "") + e.Shift.ToString() + " Shift");
                ModifierKeyPressed = true;

            }
            if (e.Alt != ModifierKeySide.None)
            {
                logMessage.Append((ModifierKeyPressed ? ", " : "") + e.Alt.ToString() + " Alt");
                ModifierKeyPressed = true;

            }

            //If no modifier key was pressed, we append 'None' to the log to indicate that there was no modifier key being pressed.
            if (!ModifierKeyPressed)
                logMessage.Append("None");

            logMessage.Append("]");

            return logMessage.ToString(); //Build the log text and return it to the calling method.
        }

        public static string MousePositionToString(MousePosition mousePosition)
        {
            return "[Mouse Position: " + mousePosition.X.ToString() + "X, " + mousePosition.Y.ToString() + "Y]";
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }
    public static class Window
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowRect(IntPtr hwnd, out RECT rc);

        [DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private static Process GetProcessByHandle(IntPtr hwnd)
        {
            try
            {
                GetWindowThreadProcessId(hwnd, out uint processID);
                return Process.GetProcessById((int)processID);
            }
            catch { return null; }
        }

        public static Process GetActiveProcess()
        {
            IntPtr hwnd = GetForegroundWindow();
            return hwnd != null ? GetProcessByHandle(hwnd) : null;
        }
    }
}
