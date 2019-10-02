using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
        dbprojectsEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            db = new dbprojectsEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;
            projectBindingSource.DataSource = db.Projects.Include("Jobs").ToList();
            ShowJob();
        }

        private void ShowJob()
        {
            Project obj= projectBindingSource.Current as Project;
            if (obj != null)
            {
                if (obj.Jobs != null)
                {
                    jobBindingSource.DataSource = obj.Jobs.ToList();//error
                }
            }
        }

        private void ProjectsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ShowJob();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            panel1.Enabled = true;
            textProjectName.Focus();
            Project c = new Project();
            db.Projects.Add(c);
            projectBindingSource.Add(c);
            projectBindingSource.MoveLast();
            jobBindingSource = null;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            panel1.Enabled=true;
            textProjectName.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            projectBindingSource.ResetBindings(false);
            foreach(DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }

            }

        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panel1.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                MessageBox.Show("Data is saved successfully", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddJob_Click(object sender, EventArgs e)
        {
            Project c = projectBindingSource.Current as Project;
            if (c != null)
            {
                if (jobBindingSource.DataSource == null)//error
                    jobBindingSource.DataSource = c.Jobs.ToList();
                Job a = new Job() { Project = c };
                jobBindingSource.Add(a);
                db.Jobs.Add(a);
            }
        }

        private void ProjectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProjectsDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Delete this record ?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Projects.Remove(projectBindingSource.Current as Project);
                    projectBindingSource.RemoveCurrent();
                }
            }
        }

        private void JobDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JobDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Delete this record ?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Jobs.Remove(jobBindingSource.Current as Job);
                    jobBindingSource.RemoveCurrent();
                }
            }
        }

        private void TextSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textSearch.Text))
                {
                    projectBindingSource.DataSource = db.Projects.Include("Jobs").ToList();
                    ShowJob();
                }
                else
                {
                    var query = from o in db.Projects.Include("Jobs")
                                where o.projectName.Contains(textSearch.Text)
                                select o;
                    projectBindingSource.DataSource = query.ToList();
                    ShowJob();
                }
            }

        }
    }
}
