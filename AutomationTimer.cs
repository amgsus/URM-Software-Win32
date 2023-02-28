using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URM {
    public partial class AutomationTimerDialog : Form {
        public AutomationTimerDialog() {
            InitializeComponent();
        }

        const int MS_IN_SECOND = 1000;
        const int MS_IN_MINUTE = MS_IN_SECOND * 60;
        const int MS_IN_HOUR = MS_IN_MINUTE * 60;

        public int Interval {
            get {
                return int.Parse(txtHours.Text) * MS_IN_HOUR + int.Parse(txtMinutes.Text) * MS_IN_MINUTE + int.Parse(txtSeconds.Text) * MS_IN_SECOND + int.Parse(txtMilliseconds.Text);
            }

            set {
                int ss = value / MS_IN_SECOND;
                value -= ss * MS_IN_SECOND;
                txtSeconds.Text = ss.ToString();
                int mm = value / MS_IN_MINUTE;
                value -= mm * MS_IN_MINUTE;
                txtMinutes.Text = mm.ToString();
                int hh = value / MS_IN_HOUR;
                value -= hh * MS_IN_HOUR;
                txtHours.Text = hh.ToString();
                txtMilliseconds.Text = value.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }
    }
}
