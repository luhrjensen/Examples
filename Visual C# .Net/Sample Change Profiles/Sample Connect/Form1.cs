using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KClmtrBase;
using KClmtrBase.KClmtrWrapper;

namespace Sample_Connect {
    public partial class Form1 : Form {
        private KClmtrWrap kClmtr;

        public Form1() {
            InitializeComponent();
            kClmtr = new KClmtrWrap();
        }

        private void button1_Click(object sender, EventArgs e) {
            kClmtr.connect(Convert.ToInt32(portNumber.Value));
            profileList.DataSource = kClmtr.CalFileList;
            profileText.Text = kClmtr.CalFileName;
            profileIDNumber.Value = kClmtr.CalFileID;
        }

        private void MeasureButton_Click(object sender, EventArgs e) {
            wMeasurement measure = kClmtr.getNextMeasurement(-1);
            if(KleinsErrorCodes.shouldStopMeasuring(measure.errorcode)) {
                kClmtr.stopMeasuring();
				MessageBox.Show(KleinsErrorCodes.errorCodesToString(measure.errorcode));
			} else {
                textBoxX.Text = measure.CIE1931_x.ToString();
                textBoxY.Text = measure.CIE1931_y.ToString();
                textBoxBigY.Text = measure.BigY.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            kClmtr.CalFileID = Convert.ToInt32(profileIDNumber.Value);
            profileText.Text = kClmtr.CalFileName;
        }
    }
}
