using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const string WORKSPACE_FILE_NAME = "URM.Workspace.txt";

        private byte _lastIOStatus = 0;
        private byte _command = 0;
        private byte _lastCommand = 0;
        private bool _preventCheckedChangedEvent = false;

        private byte _timTarget = 0;
        private byte _timAction = 0;

        private void mnuPort_DropDownOpening(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();

            mnuPort.DropDownItems.Clear();

            mnuPort.DropDownItems.Add(mniPortClose);
            mnuPort.DropDownItems.Add(mniPortCloseSeparator);

            bool portClosed = !sp.IsOpen;

            mniPortClose.Enabled = !portClosed;

            foreach (var portName in availablePorts)
            {
                ToolStripItem m = mnuPort.DropDownItems.Add(portName);
                m.Click += mniPort_Click;
                m.Enabled = portClosed;
            }
        }

        private void mniPort_Click(object sender, EventArgs e)
        {
            ToolStripItem m = sender as ToolStripItem;
            sp.PortName = m.Text;

            try
            {
                sp.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtLog.Text = $"{DateTime.Now} Port {sp.PortName} has been opened\r\n" + txtLog.Text;
            bg.RunWorkerAsync();

            SetGroupsEnabled(true);
        }

        private void mniPortClose_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Close();
            }
            catch
            {
                // Nothing.
            }

            txtLog.Text = $"{DateTime.Now} Port has been closed\r\n" + txtLog.Text;
            SetGroupsEnabled(false);
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            for (;;)
            {
                byte response = 0;

                try
                {
                    int db = sp.ReadByte();

                    if (db == -1)
                    {
                        break; // Port closed.
                    }

                    response = (byte) db;
                }
                catch (TimeoutException exTimeout)
                {
                    Invoke(new Action(() => {
                        mniPortClose_Click(null, null);
                    }));
                }
                catch
                {
                    break; // Exit worker on any I/O error.
                }

                // Debug.Print(String.Format("> Data received: 0x{0:X2}", response));

                Invoke(new Action(() => {
                    setIOStatusOnGUI(response);
                }));

                _lastIOStatus = response;
            }

            Invoke(new Action(() => {
                mniPortClose_Click(null, null);
            }));
        }

        private void setIOStatusOnGUI(byte status)
        {
            UpdateCheckBoxStateProgram(chkO1, (bool)((status & 0x01) != 0), 1);
            UpdateCheckBoxStateProgram(chkO2, (bool)((status & 0x02) != 0), 2);
            UpdateCheckBoxStateProgram(chkO3, (bool)((status & 0x04) != 0), 3);
            UpdateCheckBoxStateProgram(chkO4, (bool)((status & 0x08) != 0), 4);

            SetInputStateOnGUI(lblI1, (bool)((status & 0x10) != 0), 1);
            SetInputStateOnGUI(lblI2, (bool)((status & 0x20) != 0), 2);
            SetInputStateOnGUI(lblI3, (bool)((status & 0x40) != 0), 3);
            SetInputStateOnGUI(lblI4, (bool)((status & 0x80) != 0), 4);
        }

        private void UpdateCheckBoxStateProgram(CheckBox chk, bool bChecked, int i)
        {
            bool previousChecked = chk.Checked;

            chk.CheckedChanged -= chkO1_CheckedChanged;
            chk.Checked = bChecked;
            chk.CheckedChanged += chkO1_CheckedChanged;

            if (chk.Checked != previousChecked)
            {
                string state = chk.Checked ? "activated" : "deactivated";
                txtLog.Text = $"{DateTime.Now} Output {i} has been {state}\r\n" + txtLog.Text;
            }
        }

        private void SetInputStateOnGUI(Label lbl, bool activated, int i)
        {
            string previousText = lbl.Text;

            lbl.ForeColor = activated ? Color.Green : DefaultForeColor;
            lbl.Text = activated ? "Active" : "Inactive";

            if (lbl.Text != previousText)
            {
                txtLog.Text = $"{DateTime.Now} Input {i} is {lbl.Text}\r\n" + txtLog.Text;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setIOStatusOnGUI(0);
            mniWorkspaceNew_Click(null, null);
            SetGroupsEnabled(false);
        }

        private void chkO1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (!sp.IsOpen)
            {
                return; // Ignore if port is not opened.
            }

            if (cb == chkO1)
            {
                if (cb.Checked)
                {
                    _command |= 0x01;
                }
                else
                {
                    _command &= byte.MaxValue ^ 0x01;
                }
            }
            else if (cb == chkO2)
            {
                if (cb.Checked)
                {
                    _command |= 0x02;
                }
                else
                {
                    _command &= byte.MaxValue ^ 0x02;
                }
            }
            else if (cb == chkO3)
            {
                if (cb.Checked)
                {
                    _command |= 0x04;
                }
                else
                {
                    _command &= byte.MaxValue ^ 0x04;
                }
            }
            else if (cb == chkO4)
            {
                if (cb.Checked)
                {
                    _command |= 0x08;
                }
                else
                {
                    _command &= byte.MaxValue ^ 0x08;
                }
            }

            _command &= byte.MaxValue ^ 0xF0;
            _command |= 0x80;

            sp.Write(new byte[] { _command }, 0, 1);
            // Debug.Print(String.Format("> Command sent: 0x{0:X2}", _command));
        }

        private void mniWorkspaceNew_Click(object sender, EventArgs e)
        {
            txtHintO1.Text = "";
            txtHintO1.BackColor = SystemColors.Window;
            txtHintO2.Text = "";
            txtHintO2.BackColor = SystemColors.Window;
            txtHintO3.Text = "";
            txtHintO3.BackColor = SystemColors.Window;
            txtHintO4.Text = "";
            txtHintO4.BackColor = SystemColors.Window;
            txtHintI1.Text = "";
            txtHintI1.BackColor = SystemColors.Window;
            txtHintI2.Text = "";
            txtHintI2.BackColor = SystemColors.Window;
            txtHintI3.Text = "";
            txtHintI3.BackColor = SystemColors.Window;
            txtHintI4.Text = "";
            txtHintI4.BackColor = SystemColors.Window;
        }

        private void mniWorkspaceSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(WORKSPACE_FILE_NAME))
            {
                if (MessageBox.Show(this, $"Do you want to save workspace to a file?\r\n\r\n{WORKSPACE_FILE_NAME}", "Save Workspace", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            List<string> list = new List<string>();

            list.Add(txtHintO1.Text);
            list.Add(txtHintO2.Text);
            list.Add(txtHintO3.Text);
            list.Add(txtHintO4.Text);

            list.Add(txtHintI1.Text);
            list.Add(txtHintI2.Text);
            list.Add(txtHintI3.Text);
            list.Add(txtHintI4.Text);

            list.Add(txtHintO1.BackColor.ToArgb().ToString());
            list.Add(txtHintO2.BackColor.ToArgb().ToString());
            list.Add(txtHintO3.BackColor.ToArgb().ToString());
            list.Add(txtHintO4.BackColor.ToArgb().ToString());

            list.Add(txtHintI1.BackColor.ToArgb().ToString());
            list.Add(txtHintI2.BackColor.ToArgb().ToString());
            list.Add(txtHintI3.BackColor.ToArgb().ToString());
            list.Add(txtHintI4.BackColor.ToArgb().ToString());

            try {
                string[] lines = list.ToArray();
                File.WriteAllLines(WORKSPACE_FILE_NAME, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Save Workspace", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mniWorkspaceReload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, $"Do you want to reload workspace from a file?\r\n\r\n{WORKSPACE_FILE_NAME}", "Reload Workspace", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string[] lines = File.ReadAllLines(WORKSPACE_FILE_NAME);

                    txtHintO1.Text = lines.Length > 0 ? lines[0] : "";
                    txtHintO2.Text = lines.Length > 1 ? lines[1] : "";
                    txtHintO3.Text = lines.Length > 2 ? lines[2] : "";
                    txtHintO4.Text = lines.Length > 3 ? lines[3] : "";

                    txtHintI1.Text = lines.Length > 4 ? lines[4] : "";
                    txtHintI2.Text = lines.Length > 5 ? lines[5] : "";
                    txtHintI3.Text = lines.Length > 6 ? lines[6] : "";
                    txtHintI4.Text = lines.Length > 7 ? lines[7] : "";

                    txtHintO1.BackColor = lines.Length >  8 ? Color.FromArgb(int.Parse(lines[ 8])) : SystemColors.Window;
                    txtHintO2.BackColor = lines.Length >  9 ? Color.FromArgb(int.Parse(lines[ 9])) : SystemColors.Window;
                    txtHintO3.BackColor = lines.Length > 10 ? Color.FromArgb(int.Parse(lines[10])) : SystemColors.Window;
                    txtHintO4.BackColor = lines.Length > 11 ? Color.FromArgb(int.Parse(lines[11])) : SystemColors.Window;

                    txtHintI1.BackColor = lines.Length > 12 ? Color.FromArgb(int.Parse(lines[12])) : SystemColors.Window;
                    txtHintI2.BackColor = lines.Length > 13 ? Color.FromArgb(int.Parse(lines[13])) : SystemColors.Window;
                    txtHintI3.BackColor = lines.Length > 14 ? Color.FromArgb(int.Parse(lines[14])) : SystemColors.Window;
                    txtHintI4.BackColor = lines.Length > 15 ? Color.FromArgb(int.Parse(lines[15])) : SystemColors.Window;
                } catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Reload Workspace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mniWorkspaceReload_DropDownOpening(object sender, EventArgs e)
        {
            mniWorkspaceReload.Enabled = File.Exists(WORKSPACE_FILE_NAME);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetGroupsEnabled(bool enabled)
        {
            grpO1.Enabled = enabled;
            grpO2.Enabled = enabled;
            grpO3.Enabled = enabled;
            grpO4.Enabled = enabled;
            grpI1.Enabled = enabled;
            grpI2.Enabled = enabled;
            grpI3.Enabled = enabled;
            grpI4.Enabled = enabled;
        }

        private void mniAutomationTimerSetInterval_Click(object sender, EventArgs e) {
            int currentInterval = tim.Interval;
            AutomationTimerDialog dlg = new AutomationTimerDialog();
            dlg.Interval = currentInterval;
            if (dlg.ShowDialog() == DialogResult.OK) {
                bool enabled = tim.Enabled;
                tim.Enabled = false;
                tim.Interval = dlg.Interval;
                tim.Enabled = enabled;
                mniAutomationTimerEnable.Enabled = true;
                log($"Timer is set to {tim.Interval} milliseconds");
            }
        }

        private void log(string msg) {
            txtLog.Text = $"[{DateTime.Now}] {msg}\r\n" + txtLog.Text;
        }

        private void tim_Tick(object sender, EventArgs e) {
            log("Timer event");

            byte outputMask = (byte)(1 << _timTarget);
            byte command = (byte)((chkO1.Checked ? 0x01 : 0) | (chkO2.Checked ? 0x02 : 0) | (chkO3.Checked ? 0x04 : 0) | (chkO4.Checked ? 0x08 : 0));

            switch (_timAction) {
                case 0:
                    command |= outputMask;
                    break;

                case 1:
                    command &= (byte)(byte.MaxValue ^ outputMask);
                    break;

                case 2:
                    command ^= outputMask;
                    break;
            }

            if (!sendCommand(command)) {
                mniAutomationTimerEnable.Checked = false; // Stop timer in case of IO error.
            }
        }

        private bool sendCommand(byte command) {
            command &= byte.MaxValue ^ 0xF0;
            command |= 0x80;

            try {
                sp.Write(new byte[] { command }, 0, 1);
            } catch {
                return false;
            }

            return true;
        }

        private void mniAutomationTimerTargetO1_Click(object sender, EventArgs e) {
            ToolStripMenuItem mni = (ToolStripMenuItem) sender;
            log($"Timer target is set to {mni.Text}");
            _timTarget = (byte) mni.GetCurrentParent().Items.IndexOf(mni);
        }

        private void mniAutomationTimerActionActivate_Click(object sender, EventArgs e) {
            ToolStripMenuItem mni = (ToolStripMenuItem) sender;
            log($"Timer action is set to {mni.Text.ToLower()}");
            _timAction = (byte) mni.GetCurrentParent().Items.IndexOf(mni);
        }

        private void mniAutomationTimerEnable_CheckedChanged(object sender, EventArgs e) {
            tim.Enabled = mniAutomationTimerEnable.Checked;
            if (tim.Enabled) {
                log("Timer is enabled");
            } else {
                log("Timer is disabled");
            }
        }

        private void txtHintO1_DoubleClick(object sender, EventArgs e) {
            TextBox txt = (TextBox) sender;
            colorDialog.Color = txt.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                txt.BackColor = colorDialog.Color;
            }
        }
    }
}
