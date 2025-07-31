namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
    public class CustomAppContext : ApplicationContext
    {
        private MuaVe muaVe;
        private FrmDatVe datVeForm;

        public CustomAppContext()
        {
            ShowMainForm();
        }

        private void ShowMainForm()
        {
            muaVe = new MuaVe();
            muaVe.FormClosed += (s, e) =>
            {
                string maSuat = muaVe.SelectedMaSuat;
                string tenPhim = muaVe.SelectedTenPhim;

                // Kiểm tra nếu có chọn suất thì mới mở form đặt vé
                if (!string.IsNullOrEmpty(maSuat) && !string.IsNullOrEmpty(tenPhim))
                {
                    ShowFrmDatVe(maSuat, tenPhim);
                }
                else
                {
                    ExitThread(); // Không chọn gì thì thoát chương trình
                }
            };
            muaVe.Show();
        }

        private void ShowFrmDatVe(string maSuat, string tenPhim)
        {
            datVeForm = new FrmDatVe(maSuat, tenPhim);
            datVeForm.StartPosition = FormStartPosition.CenterScreen;
            datVeForm.FormClosed += (s, e) =>
            {
                ShowMainForm(); // Khi đóng FrmDatVe thì quay lại form chính
            };
            datVeForm.Show();
        }
    }
}