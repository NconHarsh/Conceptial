using Conceptial.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Conceptial.Models.Constant;

namespace Conceptial
{
    public partial class LoadStatus : Form
    {
        public ConceptialEntities dbentity = new ConceptialEntities();
        public LoadStatus()
        {

          
            InitializeComponent();
            if (UserSessionModel.UserName != null)
            {
                label1.Text = UserSessionModel.UserName.ToString();
                Type enumType = typeof(Userrole);
                label2.Text = Convert.ToString(enumType.GetEnumName((UserSessionModel.UserRole)));


            }
            TankStatusGrid.DataSource = dbentity.Tank_Status.ToList();
            TankStatusGrid.Columns["Ship_ID"].Visible = false;
            TankStatusGrid.Columns["Tank_Sounding_Table"].Visible = false;
        }

        private void TankStatusGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal soundingvalue = Convert.ToDecimal(TankStatusGrid.Rows[e.RowIndex].Cells["Sounding__mm_"].Value);
            float tanknumber = Convert.ToInt32(TankStatusGrid.Rows[e.RowIndex].Cells["Tank_Id"].Value);

            var abc = dbentity.Tank_Sounding_Table.Where(x => x.Tank_Id == tanknumber && x.Sounding_mm == soundingvalue).FirstOrDefault();
            TankStatusGrid.Rows[e.RowIndex].Cells["Weight___te_"].Value = abc.Weight_of_fluid_te;
            TankStatusGrid.Rows[e.RowIndex].Cells["LCG__mm_"].Value = abc.LCG_of_fluid_mm;
            TankStatusGrid.Rows[e.RowIndex].Cells["TCG___mm_"].Value = abc.TCG_of_fluid_mm;
            TankStatusGrid.Rows[e.RowIndex].Cells["VCG_Fluid__mm_"].Value = abc.VCG_of_fluid_mm;
            TankStatusGrid.Rows[e.RowIndex].Cells["VCGT_Virtual__mm_"].Value = abc.Virtual_VCGt_mm;
            TankStatusGrid.Rows[e.RowIndex].Cells["Transverse_FSM___te_m_"].Value = abc.Transverse_FSM_te_m;
            TankStatusGrid.Rows[e.RowIndex].Cells["Longitudinal_FSM___te_m_"].Value = abc.Longitudinal_FSM_te_m;
            TankStatusGrid.Rows[e.RowIndex].Cells["Weight_X_LCG"].Value = abc.Weight_of_fluid_te * abc.LCG_of_fluid_mm;
            TankStatusGrid.Rows[e.RowIndex].Cells["Weight_X_TCG"].Value = abc.Weight_of_fluid_te * abc.TCG_of_fluid_mm;
            TankStatusGrid.Rows[e.RowIndex].Cells["Weight_X_VCG"].Value = abc.Weight_of_fluid_te * abc.VCG_of_fluid_mm;

                   }
    }
}
