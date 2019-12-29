using System.Windows.Forms;

namespace CRManagmentSystem.Common
{
    /// <summary>
    /// Show message box
    /// </summary>
    public static class Dialog
    {
        /// <summary>
        /// Message box infomation
        /// </summary>
        /// <param name="text">Message</param>
        public static void Info(string text)
        {
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Message box warning
        /// </summary>
        /// <param name="text">Message</param>
        public static void Warning(string text)
        {
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Message box error
        /// </summary>
        /// <param name="text">Message</param>
        public static void Error(string text)
        {
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Message box confirm
        /// </summary>
        /// <param name="text">Message</param>
        public static bool Confirm(string text)
        {
            DialogResult confirm = MessageBox.Show(text, "", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (confirm == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
