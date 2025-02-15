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
    public partial class FormProfileLinkLable : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();

        string Name;
        string Email;
        string PhoneNumber;
        string HireDate;
        string Position;
        string JobLevel;
        string Departement;

        int JobLevelId;
        int JobId;
        int JobSupervisorId;
        int employeeId;

        public FormProfileLinkLable(string Name, string Email, string PhoneNumber, string HireDate, string Position, string JobLevel, string Departement, 
            int employeeId, int JobLevelId, int JobId, int JobSupervisorId)
        {
            InitializeComponent();
           
            this.Name = Name;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.HireDate = HireDate;
            this.Position = Position;
            this.JobLevel = JobLevel;
            this.Departement = Departement;

            this.JobId = JobId;
            this.employeeId = employeeId;
            this.JobSupervisorId = JobSupervisorId;
            this.JobLevelId = JobLevelId;

        }

        private void loadDgvDataJob()
        {
            var query = db.positions.Where(x => x.employee_id == employeeId && x.deleted_at == null && x.job.deleted_at == null && x.employee.deleted_at == null && x.job.job_level.deleted_at == null && x.job.department.deleted_at == null).OrderByDescending(x => x.job.job_level_id)
                .Select(x => new { 
                    Departement = x.job.department.name, 
                    Position = x.job.name,
                    Email = x.employee.email,
                    PhoneNumber = x.employee.phone_number,
                    HireDate = x.employee.hire_date,
                    JobLevel = x.job.job_level.name,
                    Name = x.employee.name,
                    EmployeeId = x.employee_id,
                    JobId = x.job_id,
                    JobSupervisorId = x.job.supervisor_job_id,
                    JobLevelId = x.job.job_level_id,
                });

            dgvDataJobHistory.DataSource = query;

            dgvDataJobHistory.Columns["Email"].Visible = false;
            dgvDataJobHistory.Columns["PhoneNumber"].Visible = false;
            dgvDataJobHistory.Columns["HireDate"].Visible = false;
            dgvDataJobHistory.Columns["JobLevel"].Visible = false;
            dgvDataJobHistory.Columns["Name"].Visible = false;
            dgvDataJobHistory.Columns["EmployeeId"].Visible = false;
            dgvDataJobHistory.Columns["JobId"].Visible = false;
            dgvDataJobHistory.Columns["JobSupervisorId"].Visible = false;
            dgvDataJobHistory.Columns["JobLevelId"].Visible = false;
        }

        private void loadDgvDataSubordinate()
        {
            var query = db.positions.Where(x => x.job.supervisor_job_id == JobId && x.employee_id != employeeId 
            && x.deleted_at == null && x.job.deleted_at == null && x.employee.deleted_at == null && x.job.job_level.deleted_at == null && x.job.department.deleted_at == null)
                .Select(x => new { 
                    Name = x.employee.name, 
                    Position = x.job.name,
                    Departement = x.job.department.name,
                    Email = x.employee.email,
                    PhoneNumber = x.employee.phone_number,
                    HireDate = x.employee.hire_date,
                    JobLevel = x.job.job_level.name,
                    EmployeeId = x.employee_id,
                    JobId = x.job_id,
                    JobSupervisorId = x.job.supervisor_job_id,
                    JobLevelId = x.job.job_level_id,
                });

            dgvdDataSubordinate.DataSource = query;

            dgvdDataSubordinate.Columns["Email"].Visible = false;
            dgvdDataSubordinate.Columns["PhoneNumber"].Visible = false;
            dgvdDataSubordinate.Columns["HireDate"].Visible = false;
            dgvdDataSubordinate.Columns["JobLevel"].Visible = false;
            dgvdDataSubordinate.Columns["Position"].Visible = false;
            dgvdDataSubordinate.Columns["EmployeeId"].Visible = false;
            dgvdDataSubordinate.Columns["JobId"].Visible = false;
            dgvdDataSubordinate.Columns["JobSupervisorId"].Visible = false;
            dgvdDataSubordinate.Columns["JobLevelId"].Visible = false;
        }

        private void loadDgvDataWork()
        {
            var query = db.positions.Where(x => x.job.supervisor_job_id == JobSupervisorId && x.employee_id != employeeId && x.job.supervisor_job_id != employeeId
            && x.deleted_at == null && x.job.deleted_at == null && x.employee.deleted_at == null && x.job.job_level.deleted_at == null && x.job.department.deleted_at == null)
                .Select(x => new {
                    Name = x.employee.name,
                    Position = x.job.name,
                    Departement = x.job.department.name,
                    Email = x.employee.email,
                    PhoneNumber = x.employee.phone_number,
                    HireDate = x.employee.hire_date,
                    JobLevel = x.job.job_level.name,
                    EmployeeId = x.employee_id,
                    JobId = x.job_id,
                    JobSupervisorId = x.job.supervisor_job_id,
                    JobLevelId = x.job.job_level_id,
                });

            dgvDataWorks.DataSource = query;

            dgvDataWorks.Columns["Email"].Visible = false;
            dgvDataWorks.Columns["PhoneNumber"].Visible = false;
            dgvDataWorks.Columns["HireDate"].Visible = false;
            dgvDataWorks.Columns["JobLevel"].Visible = false;
            dgvDataWorks.Columns["Position"].Visible = false;
            dgvDataWorks.Columns["EmployeeId"].Visible = false;
            dgvDataWorks.Columns["JobId"].Visible = false;
            dgvDataWorks.Columns["JobSupervisorId"].Visible = false;
            dgvDataWorks.Columns["JobLevelId"].Visible = false;
        }

        private void FormProfileLinkLable_Load(object sender, EventArgs e)
        {
            loadDgvDataJob();
            loadDgvDataSubordinate();
            loadDgvDataWork();

            tbName.Text = Name;
            tbEmail.Text = Email;
            tbPhoneNumber.Text = PhoneNumber;
            tbHireDate.Text = HireDate;
            tbPosition.Text = Position;
            tbJobLevel.Text = JobLevel;
            tbDepartement.Text = Departement;

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            Hide();
        }

        private bool validation()
        {
            if (tbName.Text == string.Empty || tbEmail.Text == string.Empty || tbPhoneNumber.Text == string.Empty
                || tbHireDate.Text == string.Empty || tbPosition.Text == string.Empty || tbJobLevel.Text == string.Empty
                || tbDepartement.Text == string.Empty)
            {
                Support.MSW("all field must be filled");
                return false;
            }

            return true;
        }

        private void lblDirectSupervisorName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (validation())
            {
                new FormProfileLinkLable(tbName.Text, tbEmail.Text, tbPhoneNumber.Text, tbHireDate.Text, tbPosition.Text, tbJobLevel.Text, tbDepartement.Text, employeeId, JobId, JobSupervisorId, JobLevelId).Show();
                Hide();
            }

        }

        private void dgvDataJobHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbName.Text = dgvDataJobHistory.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbEmail.Text = dgvDataJobHistory.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                tbPhoneNumber.Text = dgvDataJobHistory.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                tbHireDate.Text = dgvDataJobHistory.Rows[e.RowIndex].Cells["HireDate"].Value.ToString();
                tbPosition.Text = dgvDataJobHistory.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                tbJobLevel.Text = dgvDataJobHistory.Rows[e.RowIndex].Cells["JobLevel"].Value.ToString();
                tbDepartement.Text = dgvDataJobHistory.Rows[e.RowIndex].Cells["Departement"].Value.ToString();
                employeeId = Convert.ToInt32(dgvDataJobHistory.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                JobId = Convert.ToInt32(dgvDataJobHistory.Rows[e.RowIndex].Cells["JobId"].Value);
                JobSupervisorId = Convert.ToInt32(dgvDataJobHistory.Rows[e.RowIndex].Cells["JobSupervisorId"].Value);
                JobLevelId = Convert.ToInt32(dgvDataJobHistory.Rows[e.RowIndex].Cells["JobLevelId"].Value);
            }
        }

        private void dgvdDataSubordinate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbName.Text = dgvdDataSubordinate.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbEmail.Text = dgvdDataSubordinate.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                tbPhoneNumber.Text = dgvdDataSubordinate.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                tbHireDate.Text = dgvdDataSubordinate.Rows[e.RowIndex].Cells["HireDate"].Value.ToString();
                tbPosition.Text = dgvdDataSubordinate.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                tbJobLevel.Text = dgvdDataSubordinate.Rows[e.RowIndex].Cells["JobLevel"].Value.ToString();
                tbDepartement.Text = dgvdDataSubordinate.Rows[e.RowIndex].Cells["Departement"].Value.ToString();
                JobId = Convert.ToInt32(dgvdDataSubordinate.Rows[e.RowIndex].Cells["JobId"].Value);
                employeeId = Convert.ToInt32(dgvdDataSubordinate.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                JobSupervisorId = Convert.ToInt32(dgvdDataSubordinate.Rows[e.RowIndex].Cells["JobSupervisorId"].Value);
                JobLevelId = Convert.ToInt32(dgvdDataSubordinate.Rows[e.RowIndex].Cells["JobLevelId"].Value);
            }
        }

        private void dgvDataWorks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbName.Text = dgvDataWorks.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbEmail.Text = dgvDataWorks.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                tbPhoneNumber.Text = dgvDataWorks.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                tbHireDate.Text = dgvDataWorks.Rows[e.RowIndex].Cells["HireDate"].Value.ToString();
                tbPosition.Text = dgvDataWorks.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                tbJobLevel.Text = dgvDataWorks.Rows[e.RowIndex].Cells["JobLevel"].Value.ToString();
                tbDepartement.Text = dgvDataWorks.Rows[e.RowIndex].Cells["Departement"].Value.ToString();
                JobId = Convert.ToInt32(dgvDataWorks.Rows[e.RowIndex].Cells["JobId"].Value);
                employeeId = Convert.ToInt32(dgvDataWorks.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                JobSupervisorId = Convert.ToInt32(dgvDataWorks.Rows[e.RowIndex].Cells["JobSupervisorId"].Value);
                JobLevelId = Convert.ToInt32(dgvDataWorks.Rows[e.RowIndex].Cells["JobLevelId"].Value);
            }
        }
    }
}
