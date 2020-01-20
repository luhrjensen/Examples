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

            kClmtr.measureEvent += kClmtr_measureEvent;
        }

        void kClmtr_measureEvent(object sender, MeasureEventArgs e) {
            if (textBoxX.InvokeRequired) {
                EventHandler<MeasureEventArgs> printM = new EventHandler<MeasureEventArgs>(kClmtr_measureEvent);
                this.BeginInvoke(printM, new object[] { sender, e }); //Sends the data to the other tread by invoking this object to do it
            } else {
                wMeasurement measure = e.Measurement;
                if(KleinsErrorCodes.shouldStopMeasuring(measure.errorcode)) {
					kClmtr.stopMeasuring();
					MessageBox.Show(KleinsErrorCodes.errorCodesToString(measure.errorcode));
				} else {
                    textBoxX.Text = measure.CIE1931_x.ToString();
                    textBoxY.Text = measure.CIE1931_y.ToString();
                    textBoxBigY.Text = measure.BigY.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            kClmtr.connect(Convert.ToInt32(portNumber.Value));
        }

        private void MeasureButton_Click(object sender, EventArgs e) {
           kClmtr.startMeasuring();
        }

        private void HoldButton_Click(object sender, EventArgs e) {
            kClmtr.stopMeasuring();
        }
    }
}
