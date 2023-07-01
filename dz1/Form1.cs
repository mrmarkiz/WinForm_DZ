namespace dz1
{
    public partial class Form1 : Form
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        private DateTime _date;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxHours.Text, out _hours))
            {
                MessageBox.Show($"Incorrect or empty text in field: {label1.Text}");
                return;
            }
            if (!int.TryParse(textBoxMinutes.Text, out _hours))
            {
                MessageBox.Show($"Incorrect or empty text in field: {label2.Text}");
                return;
            }
            if (!int.TryParse(textBoxSeconds.Text, out _hours))
            {
                MessageBox.Show($"Incorrect or empty text in field: {label3.Text}");
                return;
            }
            _date = dateTimePicker1.Value;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (_date.ToShortDateString() != now.ToShortDateString())
                return;
            if (now.Hour == _hours && now.Minute == _minutes && now.Second == _seconds)
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                MessageBox.Show("Timer !!!", "Time's up!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}