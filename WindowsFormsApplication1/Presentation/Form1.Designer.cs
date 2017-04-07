namespace Presentation
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
            this.dGVData = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.radioBtnById = new System.Windows.Forms.RadioButton();
            this.radioBtnByName = new System.Windows.Forms.RadioButton();
            this.radioBtnByPhone = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVData)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVData
            // 
            this.dGVData.AllowUserToAddRows = false;
            this.dGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGVData.Location = new System.Drawing.Point(12, 76);
            this.dGVData.MultiSelect = false;
            this.dGVData.Name = "dGVData";
            this.dGVData.ReadOnly = true;
            this.dGVData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVData.ShowEditingIcon = false;
            this.dGVData.Size = new System.Drawing.Size(592, 287);
            this.dGVData.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSearch.Location = new System.Drawing.Point(358, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 22);
            this.textBoxSearch.TabIndex = 5;
            // 
            // radioBtnById
            // 
            this.radioBtnById.AutoSize = true;
            this.radioBtnById.Checked = true;
            this.radioBtnById.Location = new System.Drawing.Point(358, 45);
            this.radioBtnById.Name = "radioBtnById";
            this.radioBtnById.Size = new System.Drawing.Size(51, 17);
            this.radioBtnById.TabIndex = 7;
            this.radioBtnById.TabStop = true;
            this.radioBtnById.Text = "By ID";
            this.radioBtnById.UseVisualStyleBackColor = true;
            // 
            // radioBtnByName
            // 
            this.radioBtnByName.AutoSize = true;
            this.radioBtnByName.Location = new System.Drawing.Point(465, 45);
            this.radioBtnByName.Name = "radioBtnByName";
            this.radioBtnByName.Size = new System.Drawing.Size(68, 17);
            this.radioBtnByName.TabIndex = 8;
            this.radioBtnByName.TabStop = true;
            this.radioBtnByName.Text = "By Name";
            this.radioBtnByName.UseVisualStyleBackColor = true;
            // 
            // radioBtnByPhone
            // 
            this.radioBtnByPhone.AutoSize = true;
            this.radioBtnByPhone.Location = new System.Drawing.Point(570, 45);
            this.radioBtnByPhone.Name = "radioBtnByPhone";
            this.radioBtnByPhone.Size = new System.Drawing.Size(71, 17);
            this.radioBtnByPhone.TabIndex = 9;
            this.radioBtnByPhone.TabStop = true;
            this.radioBtnByPhone.Text = "By Phone";
            this.radioBtnByPhone.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::WindowsFormsApplication1.Properties.Resources._1489304975_Delete;
            this.btnCancel.Location = new System.Drawing.Point(610, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::WindowsFormsApplication1.Properties.Resources._1489304951_f_check_256;
            this.btnOK.Location = new System.Drawing.Point(610, 76);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 38);
            this.btnOK.TabIndex = 10;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::WindowsFormsApplication1.Properties.Resources._1489517505_Find01;
            this.btnSearch.Location = new System.Drawing.Point(633, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = global::WindowsFormsApplication1.Properties.Resources._1488888670_Streamline_22;
            this.btnModify.Location = new System.Drawing.Point(227, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(66, 45);
            this.btnModify.TabIndex = 4;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.Image = global::WindowsFormsApplication1.Properties.Resources._1488888610_Remove;
            this.btnDelStudent.Location = new System.Drawing.Point(117, 13);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(68, 45);
            this.btnDelStudent.TabIndex = 3;
            this.btnDelStudent.UseVisualStyleBackColor = true;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddStudent.Image = global::WindowsFormsApplication1.Properties.Resources._1488888301_More;
            this.btnAddStudent.Location = new System.Drawing.Point(12, 13);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(61, 45);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 375);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioBtnByPhone);
            this.Controls.Add(this.radioBtnByName);
            this.Controls.Add(this.radioBtnById);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelStudent);
            this.Controls.Add(this.dGVData);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView dGVData;
        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioBtnById;
        private System.Windows.Forms.RadioButton radioBtnByName;
        private System.Windows.Forms.RadioButton radioBtnByPhone;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

