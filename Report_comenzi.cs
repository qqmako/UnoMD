using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoMD
{
    public partial class Report_comenzi : Form
    {
        public Report_comenzi()
        {
            InitializeComponent();
        }

        private void Report_comenzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UnoMDDataSet.NrComenzi' table. You can move, or remove it, as needed.
            this.NrComenziTableAdapter.Fill(this.UnoMDDataSet.NrComenzi);

            this.reportViewer1.RefreshReport();
        }
    }
}
