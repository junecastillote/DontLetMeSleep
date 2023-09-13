using DontLetMeSleep.Properties;
using System;
using System.Windows.Forms;

namespace DontLetMeSleep
{
    public partial class MainForm : Form
    {
        private bool isSimulationRunning = false;
        private int intervalSeconds = 30; // Initial interval in seconds
        private Timer countdownTimer = new Timer();

        public MainForm()
        {
            InitializeComponent();

            // Initialize the countdown timer
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;

            // Set the initial value of the custom interval TextBox
            CustomIntervalTextBox.Text = intervalSeconds.ToString();
        }
        private void StartStopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isSimulationRunning = StartStopCheckBox.Checked;

            // Disable customIntervalTextBox when the simulation is running
            CustomIntervalTextBox.Enabled = !isSimulationRunning;

            if (isSimulationRunning)
            {
                StartSimulation();
                StartStopCheckBox.Image = Resources.STOP_BUTTON; // Change the button image to STOP
            }
            else
            {
                StopSimulation();
                StartStopCheckBox.Image = Resources.START_BUTTON; // Change the button image to START
            }
        }

        private void StartSimulation()
        {
            intervalSeconds = int.Parse(CustomIntervalTextBox.Text); // Get interval from TextBox
            ToolStripProgressBar1.Maximum = int.Parse(CustomIntervalTextBox.Text);
            countdownTimer.Start();
        }

        private void StopSimulation()
        {
            countdownTimer.Stop();
            UpdateCountdownLabel(0);
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (intervalSeconds > 0)
            {
                intervalSeconds--;
                UpdateCountdownLabel(intervalSeconds);
            }
            else
            {
                // Simulate key press when the countdown reaches 0
                SendKeys.SendWait("{F16}");
                intervalSeconds = int.Parse(CustomIntervalTextBox.Text); // Get interval from TextBox
                UpdateCountdownLabel(intervalSeconds);
            }
        }

        private void UpdateCountdownLabel(int seconds)
        {
            //CountdownLabel.Text = $"Next F16 key press in {seconds} seconds...";
            //CountdownLabel.Text = $"Key press in {seconds} seconds...";
            ToolStripProgressBar1.Value = seconds;
            ToolStripStatusLabel1.Text = seconds.ToString()+"s";
        }
    }
}
