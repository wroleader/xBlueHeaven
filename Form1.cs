using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using FishyFlip;
using Microsoft.Extensions.Logging.Debug;

namespace xBlueHeaven
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Form1(string[] args)
        {
            InitializeComponent();
            if (args.Length > 0 && args[0].Equals("-debug"))
            {
                ConsoleDebugLogger.StartConsole();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pBar.Value = pBar.Value + 1;
        }

        private void chkAppPw_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAppPw.Checked)
            {
                //ConsoleDebug.WriteLine("Displaying App Password warning.");
                DialogResult dr = MessageBox.Show("Using your account password is not recommended.\nPlease consider using an App Password instead.\n\n" +
                    "Either click yes to be brought over to the App Passwords page\n" +
                    "or click no to continue.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr.Equals(DialogResult.Yes))
                {
                    Process.Start(
                        new ProcessStartInfo
                        {
                            FileName = @"https://bsky.app/settings/app-passwords",
                            UseShellExecute = true
                        });

                    chkAppPw.Checked = true;
                    txtPwd.PlaceholderText = "App Password";
                }
                else
                {
                    txtPwd.PlaceholderText = "Password";
                }
            }
            else
            {
                txtPwd.PlaceholderText = "App Password";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Soon
        }
    }
}