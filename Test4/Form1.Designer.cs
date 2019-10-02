namespace Test4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textProjectName = new System.Windows.Forms.TextBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPayments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.JobDataGridView = new System.Windows.Forms.DataGridView();
            this.jobTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agreedPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textProjectID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project name";
            // 
            // textProjectName
            // 
            this.textProjectName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "projectName", true));
            this.textProjectName.Location = new System.Drawing.Point(130, 53);
            this.textProjectName.Name = "textProjectName";
            this.textProjectName.Size = new System.Drawing.Size(182, 22);
            this.textProjectName.TabIndex = 1;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(Test4.Project);
            // 
            // textCost
            // 
            this.textCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "cost", true));
            this.textCost.Location = new System.Drawing.Point(130, 91);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(182, 22);
            this.textCost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textPayments
            // 
            this.textPayments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "payments", true));
            this.textPayments.Location = new System.Drawing.Point(130, 130);
            this.textPayments.Name = "textPayments";
            this.textPayments.Size = new System.Drawing.Size(182, 22);
            this.textPayments.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payments";
            // 
            // textNotes
            // 
            this.textNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "notes", true));
            this.textNotes.Location = new System.Drawing.Point(130, 167);
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(182, 22);
            this.textNotes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notes";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(562, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // JobDataGridView
            // 
            this.JobDataGridView.AllowUserToAddRows = false;
            this.JobDataGridView.AllowUserToDeleteRows = false;
            this.JobDataGridView.AutoGenerateColumns = false;
            this.JobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobTypeDataGridViewTextBoxColumn,
            this.agreedPriceDataGridViewTextBoxColumn,
            this.paymentsDataGridViewTextBoxColumn1,
            this.notesDataGridViewTextBoxColumn1});
            this.JobDataGridView.DataSource = this.jobBindingSource;
            this.JobDataGridView.Location = new System.Drawing.Point(130, 195);
            this.JobDataGridView.Name = "JobDataGridView";
            this.JobDataGridView.RowHeadersWidth = 51;
            this.JobDataGridView.RowTemplate.Height = 24;
            this.JobDataGridView.Size = new System.Drawing.Size(630, 136);
            this.JobDataGridView.TabIndex = 9;
            this.JobDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobDataGridView_CellContentClick);
            this.JobDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JobDataGridView_KeyDown);
            // 
            // jobTypeDataGridViewTextBoxColumn
            // 
            this.jobTypeDataGridViewTextBoxColumn.DataPropertyName = "jobType";
            this.jobTypeDataGridViewTextBoxColumn.HeaderText = "jobType";
            this.jobTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTypeDataGridViewTextBoxColumn.Name = "jobTypeDataGridViewTextBoxColumn";
            this.jobTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // agreedPriceDataGridViewTextBoxColumn
            // 
            this.agreedPriceDataGridViewTextBoxColumn.DataPropertyName = "agreedPrice";
            this.agreedPriceDataGridViewTextBoxColumn.HeaderText = "agreedPrice";
            this.agreedPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agreedPriceDataGridViewTextBoxColumn.Name = "agreedPriceDataGridViewTextBoxColumn";
            this.agreedPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentsDataGridViewTextBoxColumn1
            // 
            this.paymentsDataGridViewTextBoxColumn1.DataPropertyName = "payments";
            this.paymentsDataGridViewTextBoxColumn1.HeaderText = "payments";
            this.paymentsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.paymentsDataGridViewTextBoxColumn1.Name = "paymentsDataGridViewTextBoxColumn1";
            this.paymentsDataGridViewTextBoxColumn1.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn1
            // 
            this.notesDataGridViewTextBoxColumn1.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn1.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn1.Name = "notesDataGridViewTextBoxColumn1";
            this.notesDataGridViewTextBoxColumn1.Width = 125;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(Test4.Job);
            // 
            // ProjectsDataGridView
            // 
            this.ProjectsDataGridView.AllowUserToAddRows = false;
            this.ProjectsDataGridView.AllowUserToDeleteRows = false;
            this.ProjectsDataGridView.AutoGenerateColumns = false;
            this.ProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.paymentsDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.Delete});
            this.ProjectsDataGridView.DataSource = this.projectBindingSource;
            this.ProjectsDataGridView.Location = new System.Drawing.Point(49, 429);
            this.ProjectsDataGridView.Name = "ProjectsDataGridView";
            this.ProjectsDataGridView.RowHeadersWidth = 51;
            this.ProjectsDataGridView.RowTemplate.Height = 24;
            this.ProjectsDataGridView.Size = new System.Drawing.Size(796, 150);
            this.ProjectsDataGridView.TabIndex = 10;
            this.ProjectsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsDataGridView_CellClick);
            this.ProjectsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsDataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "projectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "projectName";
            this.projectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentsDataGridViewTextBoxColumn
            // 
            this.paymentsDataGridViewTextBoxColumn.DataPropertyName = "payments";
            this.paymentsDataGridViewTextBoxColumn.HeaderText = "payments";
            this.paymentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentsDataGridViewTextBoxColumn.Name = "paymentsDataGridViewTextBoxColumn";
            this.paymentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 120;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(439, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 44);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(316, 598);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 44);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 598);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(766, 195);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(51, 31);
            this.btnAddJob.TabIndex = 14;
            this.btnAddJob.Text = "+";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.BtnAddJob_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(130, 391);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(157, 22);
            this.textSearch.TabIndex = 16;
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearch_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Job details:";
            // 
            // textProjectID
            // 
            this.textProjectID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "id", true));
            this.textProjectID.Location = new System.Drawing.Point(130, 15);
            this.textProjectID.Name = "textProjectID";
            this.textProjectID.ReadOnly = true;
            this.textProjectID.Size = new System.Drawing.Size(100, 22);
            this.textProjectID.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Project ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textProjectName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textProjectID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAddJob);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textCost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textPayments);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.JobDataGridView);
            this.panel1.Controls.Add(this.textNotes);
            this.panel1.Location = new System.Drawing.Point(28, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 348);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ProjectsDataGridView);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProjectName;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPayments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView JobDataGridView;
        private System.Windows.Forms.DataGridView ProjectsDataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textProjectID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agreedPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}

