using Squirrel;
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
using static System.Windows.Forms.DataGridView;

namespace Test4
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        dbprojectsEntities db;
        DateTimePicker dtp = new DateTimePicker();
      //  DateTimePicker dto = new DateTimePicker();
        Rectangle _Rectangle;
        string toti;
        double totaltest;
        double totaltest2;
        public Form1()
        {
            InitializeComponent();
            //
          //  othersDataGridView.Controls.Add(dto);
            // ProjectsDataGridView.Controls.Add(dtp);
            projectsMetroGrid1.Controls.Add(dtp);
            dtp.Visible = false;
          //  dto.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
           // dto.Format = DateTimePickerFormat.Custom;
            //
            dtp.CloseUp += new EventHandler(dtp_CloseUp);
            //dto.CloseUp += new EventHandler(dto_CloseUp);
            //
            dtp.TextChanged += new EventHandler(dtp_TextChange);
            //  dto.TextChanged += new EventHandler(dto_TextChange);
            CheckForUpdates();

        }
        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"C:/Temp/Releases"))
            {
                await manager.UpdateApp();
            }


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
            projectBindingSource.DataSource = db.Projects.Include("Others").ToList();
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
                if (obj.Others != null)
                {
                    othersBindingSource.DataSource = obj.Others.ToList();//error
                }
            }
            caloOthersGridview();//calculates sum of others on startup
            caloJobssGridview();
        }

        private void ProjectsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if(e.RowIndex >= 0)
            {
                ShowJob();
            }
            
            switch (ProjectsDataGridView.Columns[e.ColumnIndex].Name)
            {
                case "deadline":

                    _Rectangle = ProjectsDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.Visible = true;




                    break;

            }
            */
        }

        private void ProjectsMetroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0)
            {
                ShowJob();
            }
            caloOthersGridview();// mo lazem
            caloJobssGridview();

            switch (projectsMetroGrid1.Columns[e.ColumnIndex].Name)
            {
                case "deadlineDataGridViewTextBoxColumn":

                    _Rectangle = projectsMetroGrid1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.Visible = true;




                    break;

            }
            //fix highlight
            // projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;

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
            jobBindingSource.DataSource = null;//maybe???
            othersBindingSource.DataSource = null;//maybe???

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
            //
            projectBindingSource.DataSource = db.Projects.Include("Jobs").ToList();
            ShowJob();
            //
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;
                //
                await db.SaveChangesAsync();
                panel1.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                //
                percentage();
                caloOthersGridview();
                caloJobssGridview();
                //
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



        private void JobDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JobDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

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
                ///////////check
            }

        }

        private void BtnAddOther_Click(object sender, EventArgs e)
        {
            Project c = projectBindingSource.Current as Project;
            if (c != null)
            {
                if (othersBindingSource.DataSource == null)//error
                    othersBindingSource.DataSource = c.Others.ToList();
                Others a = new Others() { Project = c };
                othersBindingSource.Add(a);
                db.Others.Add(a);
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Delete this record ?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Others.Remove(othersBindingSource.Current as Others);
                    othersBindingSource.RemoveCurrent();
                }
            }
        }

        private void OthersDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void dtp_TextChange(object sender, EventArgs e)
        {
            projectsMetroGrid1.CurrentCell.Value = dtp.Text.ToString();

            //  dtp.Visible = false;

        }

             
        void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }

       
        void caloOthersGridview()
        {
            double cal = 0;

            for(int i = 0;i<OthersMetroGrid1.Rows.Count;i++)
            {
                try
                {
                    cal = cal + double.Parse(OthersMetroGrid1.Rows[i].Cells[1].Value.ToString());
                }
                catch
                {

                }
            }

            othersTotal.Text = cal.ToString();
            totaltest = cal;
        }
        void caloJobssGridview()
        {
            double calc = 0;

            for(int i = 0;i<JobMetroGrid.Rows.Count;i++)
            {
                try
                {
                   calc = calc + double.Parse(JobMetroGrid.Rows[i].Cells[1].Value.ToString());
                }
                catch
                {

                }
            }

            JobsTotal.Text = calc.ToString();
            totaltest2 = calc;
        }

        void percentage()
        {
            int cell1 = Convert.ToInt32(projectsMetroGrid1.CurrentRow.Cells[1].Value);
            string percent = Convert.ToString(projectsMetroGrid1.CurrentRow.Cells[2].Value);


            if (cell1.ToString() != "" && percent.ToString() == "50/30/20%")

            {
                projectsMetroGrid1.CurrentRow.Cells[3].Value = Math.Truncate(cell1 * 0.5);
                projectsMetroGrid1.CurrentRow.Cells[4].Value = Math.Truncate(cell1 * 0.3);
                projectsMetroGrid1.CurrentRow.Cells[5].Value = Math.Truncate(cell1 * 0.2);
            }

            if (cell1.ToString() != "" && percent.ToString() == "50/40/10%")

            {
                projectsMetroGrid1.CurrentRow.Cells[3].Value = Math.Truncate(cell1 * 0.5);
                projectsMetroGrid1.CurrentRow.Cells[4].Value = Math.Truncate(cell1 * 0.4);
                projectsMetroGrid1.CurrentRow.Cells[5].Value = Math.Truncate(cell1 * 0.1);
            }
            if (cell1.ToString() != "" && percent.ToString() == "50/25/25%")

            {
                projectsMetroGrid1.CurrentRow.Cells[3].Value = Math.Truncate(cell1 * 0.5);
                projectsMetroGrid1.CurrentRow.Cells[4].Value = Math.Truncate(cell1 * 0.25);
                projectsMetroGrid1.CurrentRow.Cells[5].Value = Math.Truncate(cell1 * 0.25);
            }
            if (cell1.ToString() != "" && percent.ToString() == "50/20/30%")

            {
                projectsMetroGrid1.CurrentRow.Cells[3].Value = Math.Truncate(cell1 * 0.5);
                projectsMetroGrid1.CurrentRow.Cells[4].Value = Math.Truncate(cell1 * 0.2);
                projectsMetroGrid1.CurrentRow.Cells[5].Value = Math.Truncate(cell1 * 0.3);
            }
            if (cell1.ToString() != "" && percent.ToString() == "40/30/30%")

            {
                projectsMetroGrid1.CurrentRow.Cells[3].Value = Math.Truncate(cell1 * 0.4);
                projectsMetroGrid1.CurrentRow.Cells[4].Value = Math.Truncate(cell1 * 0.3);
                projectsMetroGrid1.CurrentRow.Cells[5].Value = Math.Truncate(cell1 * 0.3);
            }
            if (cell1.ToString() != "" && percent.ToString() == "50/50%")

            {
                projectsMetroGrid1.CurrentRow.Cells[3].Value = Math.Truncate(cell1 * 0.5);
                projectsMetroGrid1.CurrentRow.Cells[4].Value = Math.Truncate(cell1 * 0.5);
                projectsMetroGrid1.CurrentRow.Cells[5].Value = 0;
            }
        }

        private void JobDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MetroGrid1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;

        }

        private void MetroGrid1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtp.Visible = false;
          //  projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;


        }

        private void MetroGrid1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;

        }

        private void JobMetroGrid_KeyDown(object sender, KeyEventArgs e)
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

        private void ProjectsMetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (projectsMetroGrid1.Columns[e.ColumnIndex].Name == "DeleteRecord")
            {
                if (MessageBox.Show("Delete this record ?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Projects.Remove(projectBindingSource.Current as Project);
                    projectBindingSource.RemoveCurrent();
                }
            }
        }

        private void OthersMetroGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            caloOthersGridview();
          //  projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;

        }

        private void OthersMetroGrid1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            caloOthersGridview();
           // projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;

        }

        private void JobMetroGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
           JobMetroGrid.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the price column.
            if (!headerText.Equals("Price")) return;

            int output;

            // Confirm that the cell is an integer.
            if (!int.TryParse(e.FormattedValue.ToString(), out output))
            {
                JobMetroGrid.Rows[e.RowIndex].ErrorText =
                    "Price must be numeric";
                e.Cancel = true;
            }
        }


        private void JobMetroGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            JobMetroGrid.Rows[e.RowIndex].ErrorText = String.Empty;
            //
          //  projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;
            //

        }

        private void ProjectsMetroGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = projectsMetroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)projectsMetroGrid1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)projectsMetroGrid1.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void ProjectsMetroGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            percentage();
            projectsMetroGrid1.Rows[e.RowIndex].ErrorText = String.Empty;



        }

        private void JobMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (JobMetroGrid.Columns[e.ColumnIndex].Name == "DeleteJob")
            {
                if (MessageBox.Show("Delete this record ?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Jobs.Remove(jobBindingSource.Current as Job);
                    jobBindingSource.RemoveCurrent();
                }
            }
        }

        private void OthersMetroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
        private void JobMetroGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            caloJobssGridview();
           // projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;

        }

        private void JobMetroGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            caloJobssGridview();
         //   projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;

        }

        private void ProjectsMetroGrid1_MouseEnter(object sender, EventArgs e)
        {

             //   projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;

            
        }



        private void Button1_Click(object sender, EventArgs e)
        {
                    var query = from o in db.Projects.Include("Jobs")
                                where o.deadline >= fromSearchDateTime1.Value.Date && o.deadline <= toSearchDateTime1.Value.Date
                                select o;
                    projectBindingSource.DataSource = query.ToList();
                    ShowJob();
                
           
        }

        private void ProjectsMetroGrid1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
           projectsMetroGrid1.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the price column.
            if (!headerText.Equals("Cost")) return;

            int output;

            // Confirm that the cell is an integer.
            if (!int.TryParse(e.FormattedValue.ToString(), out output))
            {
                projectsMetroGrid1.Rows[e.RowIndex].ErrorText =
                    "Cost must be numeric";
                e.Cancel = true;
            }
        }

        private void ProjectsMetroGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;

        }

        private void OthersMetroGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            OthersMetroGrid1.Rows[e.RowIndex].ErrorText = String.Empty;

            //projectsMetroGrid1.CurrentRow.Cells[7].Value = totaltest + totaltest2;
            //
        }

        private void OthersMetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OthersMetroGrid1.Columns[e.ColumnIndex].Name == "DeleteOther")
            {
                if (MessageBox.Show("Delete this record ?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Others.Remove(othersBindingSource.Current as Others);
                    othersBindingSource.RemoveCurrent();
                }
            }
        }

        private void ProjectsMetroGrid1_SelectionChanged(object sender, EventArgs e)
        {
          //  this.projectsMetroGrid1.ClearSelection();
        }

        private void ProjectsMetroGrid1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void OthersMetroGrid1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
             OthersMetroGrid1.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the price column.
            if (!headerText.Equals("Price")) return;

            int output;

            // Confirm that the cell is an integer.
            if (!int.TryParse(e.FormattedValue.ToString(), out output))
            {
                OthersMetroGrid1.Rows[e.RowIndex].ErrorText =
                    "Price must be numeric";
                e.Cancel = true;
            }


        }

        private void ProjectsMetroGrid1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }











        //
    }
}
