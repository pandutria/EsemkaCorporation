using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EsemkaCorporation
{
    public partial class FormMutation : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        int currentSelectedRow = -1;

        public FormMutation()
        {
            InitializeComponent();
            loadData();
            tbName.Enabled = tbCurrentDepartement.Enabled = tbCurrentPosition.Enabled = tbCurrentJobLevel.Enabled  = false;
        }

        private void loadData()
        {
            var query = db.positions.FirstOrDefault(x => x.id == DataStorage.positionId && x.deleted_at == null);

            if (query != null)
            {
                tbName.Text = query.employee.name;
                tbCurrentDepartement.Text = query.job.department.name;
                tbCurrentPosition.Text = query.job.name;
                tbCurrentJobLevel.Text = query.job.job_level.name;

            }
        }

        private void loadDgvData()
        {
            dgvData.Rows.Clear();

            var query = db.jobs
                .Where(x => x.job_level_id == DataStorage.jobLevelId && x.deleted_at == null)
                .Select(x => new {
                    Id = x.id,
                    Departement = x.department.name, 
                    Position = x.name,
                    FilledPosition = db.positions.Count(y => y.job_id == x.id && x.deleted_at == null),
                    headCount = x.head_count
                })
                .Where(x => x.FilledPosition > x.headCount);

            foreach(var q in query)
            {
                dgvData.Rows.Add(q.Departement, q.Position, btnApply.Text = "Apply",q.Id);
            }



        }

        private bool validation()
       {
            //var query = db.positions.FirstOrDefault(x => x.employee.name == tbName.Text && x.job.department.name == tbCurrentDepartement.Text && x.job.job_level.name == tbCurrentDepartement.Text);
            var query = db.positions.FirstOrDefault(x => x.employee.name == tbName.Text);

            if  (tbName.Text == string.Empty || tbCurrentDepartement.Text == string.Empty ||
                tbCurrentPosition.Text == string.Empty || tbCurrentPosition.Text == string.Empty)
            {
                Support.MSW("all field must be filled");
                return false;
            }

            return true;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    currentSelectedRow = e.RowIndex;

            //    if (e.ColumnIndex == dgvData.Columns["btnApply"].Index && currentSelectedRow != -1)
            //    {

            //        var query = new mutation();
            //        query.job_id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[3].Value);
            //        query.employee_id = DataStorage.employeeId;
            //        query.status = "P";
            //        query.created_at = DateTime.Now;
            //        db.mutations.InsertOnSubmit(query);
            //        db.SubmitChanges();
            //        Support.MSI("berhasil");
            //    }
            //}

            //if (e.ColumnIndex == dgvData.Columns["btnApply"].Index && currentSelectedRow == -1)
            //{
            //    Support.MSW("select row");
            //    return;
            //} 

            if (e.ColumnIndex == dgvData.Columns["btnApply"].Index && e.RowIndex >= 0)
            {
                var queryPending = db.mutations.FirstOrDefault(x => x.employee_id == DataStorage.employeeId && x.job_id == Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[3].Value));

                if (queryPending != null)
                {
                    Support.MSI("Pending");
                }

                else
                {
                    var query = new mutation();
                    query.job_id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[3].Value);
                    query.employee_id = DataStorage.employeeId;
                    query.status = "P";
                    query.created_at = DateTime.Now;
                    db.mutations.InsertOnSubmit(query);
                    db.SubmitChanges();
                    Support.MSI("berhasil");
                }
            }
            
            
        }

        //private void loadDgvData()
        //{
        //    var query = db.positions.Where(x => x.employee.name.Contains(tbName.Text))
        //        .Select(x => new {Departement = x.job.department.name, Position = x.job.name});

        //    dgvData.DataSource = query;

        //}

        private void FormMutation_Load(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void tbCurrentDepartement_TextChanged(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void tbCurrentPosition_TextChanged(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void tbCurrentJobLevel_TextChanged(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
