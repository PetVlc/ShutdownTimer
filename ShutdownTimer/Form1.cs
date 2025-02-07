namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        private int hours, minutes, timetotal;
        
        public Form1()
        {
            InitializeComponent();
            comboBoxHours.SelectedIndex = 0;
            comboBoxMinutes.SelectedIndex = 0;
        }

        private int CalculateTimeTotal()
        {
            int hours = Convert.ToInt32(comboBoxHours.SelectedItem);
            int minutes = Convert.ToInt32(comboBoxMinutes.SelectedItem);
            return hours * 3600 + minutes * 60;
        }

        private void buttonVypnout_Click(object sender, EventArgs e)
        {
            try {timetotal = CalculateTimeTotal(); System.Diagnostics.Process.Start("C:\\Windows\\System32\\shutdown.exe", " /s /t " + timetotal);}
            catch (Exception ex) {MessageBox.Show("An error occurred: " + ex.Message);}
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            try {timetotal = CalculateTimeTotal(); System.Diagnostics.Process.Start("C:\\Windows\\System32\\shutdown.exe", " /r /t " + timetotal);}
            catch (Exception ex) {MessageBox.Show("An error occurred: " + ex.Message);}
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            try {System.Diagnostics.Process.Start("C:\\Windows\\System32\\shutdown.exe", "/a");}
            catch (Exception ex) {MessageBox.Show("An error occurred: " + ex.Message);}
        }
    }
}
