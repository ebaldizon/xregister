namespace xregister.Presentation
{
    partial class RegisterFrm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.dtmBirth = new System.Windows.Forms.DateTimePicker();
            this.lblBirth = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblObservations = new System.Windows.Forms.Label();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.OFDPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.chckbxActive = new System.Windows.Forms.CheckBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.rtxtObservations = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 425);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 432);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(344, 425);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 627);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(77, 598);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 5;
            this.lblURL.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(112, 591);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(365, 20);
            this.txtURL.TabIndex = 6;
            // 
            // dtmBirth
            // 
            this.dtmBirth.Location = new System.Drawing.Point(115, 460);
            this.dtmBirth.Name = "dtmBirth";
            this.dtmBirth.Size = new System.Drawing.Size(134, 20);
            this.dtmBirth.TabIndex = 7;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(78, 466);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(31, 13);
            this.lblBirth.TabIndex = 8;
            this.lblBirth.Text = "Birth:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(307, 627);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(402, 627);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(210, 627);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(614, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 342);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(611, 459);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(72, 13);
            this.lblObservations.TabIndex = 13;
            this.lblObservations.Text = "Observations:";
            // 
            // pnlPicture
            // 
            this.pnlPicture.Location = new System.Drawing.Point(161, 57);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(258, 240);
            this.pnlPicture.TabIndex = 15;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(118, 376);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(68, 20);
            this.txtRank.TabIndex = 16;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(121, 357);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 13);
            this.lblRank.TabIndex = 17;
            this.lblRank.Text = "Rank";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(344, 376);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 18;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // OFDPicture
            // 
            this.OFDPicture.FileName = "OFDPicture";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(210, 303);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(300, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // chckbxActive
            // 
            this.chckbxActive.AutoSize = true;
            this.chckbxActive.Location = new System.Drawing.Point(344, 465);
            this.chckbxActive.Name = "chckbxActive";
            this.chckbxActive.Size = new System.Drawing.Size(56, 17);
            this.chckbxActive.TabIndex = 21;
            this.chckbxActive.Text = "Active";
            this.chckbxActive.UseVisualStyleBackColor = true;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(344, 499);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(133, 20);
            this.txtWork.TabIndex = 22;
            // 
            // txtEducation
            // 
            this.txtEducation.Location = new System.Drawing.Point(112, 498);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(137, 20);
            this.txtEducation.TabIndex = 23;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(297, 502);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(36, 13);
            this.lblWork.TabIndex = 24;
            this.lblWork.Text = "Work:";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(48, 505);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(58, 13);
            this.lblEducation.TabIndex = 25;
            this.lblEducation.Text = "Education:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(112, 539);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(365, 20);
            this.txtCity.TabIndex = 26;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(71, 542);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "City:";
            // 
            // rtxtObservations
            // 
            this.rtxtObservations.Location = new System.Drawing.Point(614, 475);
            this.rtxtObservations.Name = "rtxtObservations";
            this.rtxtObservations.Size = new System.Drawing.Size(364, 163);
            this.rtxtObservations.TabIndex = 28;
            this.rtxtObservations.Text = "";
            // 
            // RegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 716);
            this.Controls.Add(this.rtxtObservations);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.chckbxActive);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.dtmBirth);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "RegisterFrm";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.DateTimePicker dtmBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog OFDPicture;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox chckbxActive;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.RichTextBox rtxtObservations;
    }
}