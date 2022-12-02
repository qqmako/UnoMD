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
    public partial class Raport_Suma : Form
    {
        public Raport_Suma()
        {
            InitializeComponent();
        }

        private void Raport_Suma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UnoMDDataSet.NrComenzi' table. You can move, or remove it, as needed.
            this.NrComenziTableAdapter.Fill(this.UnoMDDataSet.NrComenzi);
            // TODO: This line of code loads data into the 'UnoMD_Report.SumaFacuta' table. You can move, or remove it, as needed.
            this.SumaFacutaTableAdapter.Fill(this.UnoMD_Report.SumaFacuta);

            this.reportViewer1.RefreshReport();
        }
    }
}
