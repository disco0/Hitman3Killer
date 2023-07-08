using Indieteur.GlobalHooks;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hitman3Killer
{
    public partial class MainWindow : Form
    {
        const string INSTALL_KEY_HOOK = "Enable Hook";
        const string REMOVE_KEY_HOOK = "Disable Hook";
        const string STEAM_HITMAN_URI = "steam://rungameid/1659040";

        GlobalKeyHook globalKeyHook;

        public MainWindow()
        {
            InitializeComponent();
            checkDisableAltF4.Checked = true;
            btnKeyHook.Select();
            btnKeyHook_Click(null, null);
        }

        private void PushLog(object msg)
        {
            listLog.Items.Add(msg);
            listLog.TopIndex = listLog.Items.Count - 1;
        }

        private void PushKeyTrace(GlobalKeyEventArgs e, Misc.KeyEventType eventType)
        {
            if (checkTrace.Checked)
            {
                PushLog(Misc.MakeKeyLog(e, eventType));
            }
        }

        private void btnKeyHook_Click(object sender, EventArgs e)
        {
            if (globalKeyHook == null)
            {
                //If the globalKeyHook isn't created, we instantiate it and subscribe to the available events.
                globalKeyHook = new GlobalKeyHook();
                globalKeyHook.OnKeyDown += GlobalKeyHook_OnKeyDown;
                globalKeyHook.OnKeyPressed += GlobalKeyHook_OnKeyPressed;
                globalKeyHook.OnKeyUp += GlobalKeyHook_OnKeyUp;

                //We also need to change the text of the button itself to let the user know that he or she can remove the key hook by clicking it.
                btnKeyHook.Text = REMOVE_KEY_HOOK;

                PushLog("Registered key hook");
            }
            else
            {
                //If the globalKeyHook is already created, we dispose the instance.
                globalKeyHook.Dispose();
                globalKeyHook = null;

                //Change the text of the button itself to its defaults.
                btnKeyHook.Text = INSTALL_KEY_HOOK;

                PushLog("Removed key hook");
            }
        }

        private void GlobalKeyHook_OnKeyUp(object sender, GlobalKeyEventArgs e)
        {
            PushKeyTrace(e, Misc.KeyEventType.OnKeyUp);

            if (checkDisableAltF4.Checked && (e.Alt != ModifierKeySide.None && e.KeyCode == VirtualKeycodes.F4))
            {
                e.Handled = true;
                return;
            }
        }

        private void GlobalKeyHook_OnKeyPressed(object sender, GlobalKeyEventArgs e)
        {
            PushKeyTrace(e, Misc.KeyEventType.OnKeyPress);

            if (checkDisableAltF4.Checked && (e.Alt != ModifierKeySide.None && e.KeyCode == VirtualKeycodes.F4))
            {
                e.Handled = true;
                return;
            }
        }

        private void GlobalKeyHook_OnKeyDown(object sender, GlobalKeyEventArgs e)
        {
            PushKeyTrace(e, Misc.KeyEventType.OnKeyDown);

            if (e.KeyCode == VirtualKeycodes.K && (e.Control == ModifierKeySide.Right))
            {
                if (HITMAN3Active())
                {
                    //PushLog("KillHitman3Procs - Ctrl+K");

                    if (KillHitman3Procs())
                        e.Handled = true;
                }
                return;
            }

            if (checkDisableAltF4.Checked && (e.Alt != ModifierKeySide.None && e.KeyCode == VirtualKeycodes.F4))
            {
                if (HITMAN3Active())
                {
                    //PushLog("KillHitman3Procs - Alt+F4");

                    if(KillHitman3Procs())
                        e.Handled = true;
                }
                return;
            }
        }

        private bool KillHitman3Procs()
        {
            bool killed = false;

            foreach (Process proc in Process.GetProcessesByName("HITMAN3"))
            {
                PushLog($"Killing {proc.Id}");
                proc.Kill();
                killed = true;
            }

            return killed;
        }

        bool HITMAN3Active()
        {
            Process frontProc = Window.GetActiveProcess();
            if (frontProc == null) { return false; }

            //PushLog($"Foreground Process: {frontProc.ProcessName}");

            return frontProc.ProcessName == "HITMAN3";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listLog.Items.Clear();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(!HITMAN3Active())
            {
                System.Diagnostics.Process.Start(STEAM_HITMAN_URI);
            }
        }
    }
}
