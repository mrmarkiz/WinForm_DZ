namespace dz1
{
    public partial class Form1 : Form
    {
        int hours;
        int minutes;
        int seconds;
        DateTime date;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxHours.Text, out hours))
            {
                MessageBox.Show($"Incorrect or empty text in field: {label1.Text}");
                return;
            }
            if (!int.TryParse(textBoxMinutes.Text, out hours))
            {
                MessageBox.Show($"Incorrect or empty text in field: {label2.Text}");
                return;
            }
            if (!int.TryParse(textBoxSeconds.Text, out hours))
            {
                MessageBox.Show($"Incorrect or empty text in field: {label3.Text}");
                return;
            }
            date = dateTimePicker1.Value;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (date.ToShortDateString() != now.ToShortDateString())
                return;
            if (now.Hour == hours && now.Minute == minutes && now.Second == seconds)
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                MessageBox.Show("Timer !!!", "Time's up!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}