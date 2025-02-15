using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaCorporation
{
    public partial class FormPromotion : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        int currentSelectedRow;

        public FormPromotion()
        {
            InitializeComponent();

            dgvData.Columns["btnApply"].ReadOnly = true;
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

            var jobLevel = DataStorage.jobLevelId + 1;
            var query = db.jobs
                
                .Where(x => x.job_level_id == jobLevel && x.deleted_at == null)
                .Select(x => new {
                    Id = x.id,
                    Departement = x.department.name,
                    Position = x.name,
                    FilledPosition = db.positions.Count(y => y.job_id == x.id && x.deleted_at == null),
                    headCount = x.head_count
                })
                .Where(x => x.FilledPosition > x.headCount);

            foreach (var q in query)
            {
                dgvData.Rows.Add(q.Departement, q.Position, btnApply.Text = "Apply", q.Id);
            }
        }

        private void FormPromotion_Load(object sender, EventArgs e)
        {
            loadData();
            loadDgvData();
            tbName.Enabled = tbCurrentDepartement.Enabled = tbCurrentPosition.Enabled = tbCurrentJobLevel.Enabled = false;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["btnApply"].Index && e.RowIndex >= 0)
            {
                var queryPending = db.promotions.FirstOrDefault(x => x.employee_id == DataStorage.employeeId && x.job_id == Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[3].Value));

                if (queryPending != null)
                {
                    Support.MSI("Pending");
                }

                else
                {
                    var query = new promotion();
                    query.job_id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells[3].Value);
                    query.employee_id = DataStorage.employeeId;
                    query.status = "P";
                    query.created_at = DateTime.Now;
                    db.promotions.InsertOnSubmit(query);
                    db.SubmitChanges();
                    Support.MSI("berhasil");
                }
            }

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            Hide();
        }
    }
}
