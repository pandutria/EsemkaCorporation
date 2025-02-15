using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaCorporation
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            lblError.Visible = false;

            tbEmail.Text = "mmatthai4@unc.edu";
            tbPassword.Text = "WEJ7vX8KQfhR";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();
            var query = db.positions.FirstOrDefault(x => x.employee.email == tbEmail.Text && x.employee.password == tbPassword.Text);
            if (query != null)
            {
                DataStorage.positionId = query.id;
                DataStorage.employeeName = query.employee.name;
                DataStorage.employeeId = query.employee_id;
                DataStorage.departementId = query.job.department_id;
                DataStorage.jobLevelId = query.job.job_level_id;
                DataStorage.jobId = query.job_id;
                DataStorage.employeeEmail = query.employee.email;
                DataStorage.employeePhoneNumber = query.employee.phone_number;
                DataStorage.employeeHireDate = query.employee.hire_date.ToString();
                DataStorage.position = query.job.name;
                DataStorage.jobLevel = query.job.job_level.name;
                DataStorage.departementName = query.job.department.name;
                
                DataStorage.jobSupervisorId = Convert.ToInt32( query.job.supervisor_job_id);
                new FormMain().Show();
                Hide();
            } else
            {
                lblError.Visible = true;
                lblError.Text = "Your data is wrong";
            }
        }
    }
}
