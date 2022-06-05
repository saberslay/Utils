using System.Windows.Forms;

namespace Utils.Windows {
    public class Forms {
        #region Message Box Error
            public static void MessageBox_Error_OK(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            public static void MessageBox_Error_OK_Cancel(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            public static void MessageBox_Error_Yes_No_Cancel(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
            public static void MessageBox_Error_Retry_Cancel(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            public static void MessageBox_Error_Yes_No(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            public static void MessageBox_Error_Abort_Retry_Ignore(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        #endregion

        #region Message Box Warning
            public static void MessageBox_Warning_OK(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            public static void MessageBox_Warning_OK_Cancel(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            public static void MessageBox_Warning_Yes_No_Cancel(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
            public static void MessageBox_Warning_Retry_Cancel(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            public static void MessageBox_Warning_Yes_No(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            public static void MessageBox_Warning_Abort_Retry_Ignore(string Title, string Message) {
                MessageBox.Show(Message, Title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
        #endregion

        #region Message Box Information
        public static void MessageBox_Information_OK(string Title, string Message) {
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MessageBox_Information_OK_Cancel(string Title, string Message) {
            MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public static void MessageBox_Information_Yes_No_Cancel(string Title, string Message) {
            MessageBox.Show(Message, Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
        public static void MessageBox_Information_Retry_Cancel(string Title, string Message) {
            MessageBox.Show(Message, Title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
        }
        public static void MessageBox_Information_Yes_No(string Title, string Message) {
            MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        public static void MessageBox_Information_Abort_Retry_Ignore(string Title, string Message) {
            MessageBox.Show(Message, Title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }
        #endregion
    }
}
