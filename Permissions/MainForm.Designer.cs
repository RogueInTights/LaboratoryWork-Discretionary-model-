namespace Permissions
{
    partial class MainForm
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
            this.permissionsDGV = new System.Windows.Forms.DataGridView();
            this.usernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.permissionCB = new System.Windows.Forms.ComboBox();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.allowCheckBox = new System.Windows.Forms.CheckBox();
            this.sampleTextBox = new System.Windows.Forms.TextBox();
            this.sampleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // permissionsDGV
            // 
            this.permissionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissionsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameCol,
            this.readCol,
            this.changeCol,
            this.controlCol});
            this.permissionsDGV.Location = new System.Drawing.Point(271, 12);
            this.permissionsDGV.Name = "permissionsDGV";
            this.permissionsDGV.ReadOnly = true;
            this.permissionsDGV.Size = new System.Drawing.Size(443, 382);
            this.permissionsDGV.TabIndex = 0;
            this.permissionsDGV.SelectionChanged += new System.EventHandler(this.permissionsDGV_SelectionChanged);
            // 
            // usernameCol
            // 
            this.usernameCol.HeaderText = "Username";
            this.usernameCol.Name = "usernameCol";
            this.usernameCol.ReadOnly = true;
            this.usernameCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // readCol
            // 
            this.readCol.HeaderText = "Read permission";
            this.readCol.Name = "readCol";
            this.readCol.ReadOnly = true;
            this.readCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // changeCol
            // 
            this.changeCol.HeaderText = "Change permission";
            this.changeCol.Name = "changeCol";
            this.changeCol.ReadOnly = true;
            this.changeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // controlCol
            // 
            this.controlCol.HeaderText = "Control permission";
            this.controlCol.Name = "controlCol";
            this.controlCol.ReadOnly = true;
            this.controlCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(58, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username:";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(16, 30);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(235, 21);
            this.userComboBox.TabIndex = 2;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_TextUpdate);
            this.userComboBox.TextUpdate += new System.EventHandler(this.userComboBox_TextUpdate);
            // 
            // permissionCB
            // 
            this.permissionCB.FormattingEnabled = true;
            this.permissionCB.Items.AddRange(new object[] {
            "Read",
            "Change",
            "Control"});
            this.permissionCB.Location = new System.Drawing.Point(16, 80);
            this.permissionCB.Name = "permissionCB";
            this.permissionCB.Size = new System.Drawing.Size(235, 21);
            this.permissionCB.TabIndex = 4;
            this.permissionCB.SelectedIndexChanged += new System.EventHandler(this.userComboBox_TextUpdate);
            this.permissionCB.TextUpdate += new System.EventHandler(this.userComboBox_TextUpdate);
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Location = new System.Drawing.Point(13, 63);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(60, 13);
            this.permissionLabel.TabIndex = 3;
            this.permissionLabel.Text = "Permission:";
            // 
            // allowCheckBox
            // 
            this.allowCheckBox.AutoSize = true;
            this.allowCheckBox.Enabled = false;
            this.allowCheckBox.Location = new System.Drawing.Point(16, 117);
            this.allowCheckBox.Name = "allowCheckBox";
            this.allowCheckBox.Size = new System.Drawing.Size(50, 17);
            this.allowCheckBox.TabIndex = 5;
            this.allowCheckBox.Text = "allow";
            this.allowCheckBox.UseVisualStyleBackColor = true;
            this.allowCheckBox.Click += new System.EventHandler(this.allowCheckBox_CheckedChanged);
            // 
            // sampleTextBox
            // 
            this.sampleTextBox.Location = new System.Drawing.Point(13, 373);
            this.sampleTextBox.Name = "sampleTextBox";
            this.sampleTextBox.Size = new System.Drawing.Size(238, 20);
            this.sampleTextBox.TabIndex = 6;
            this.sampleTextBox.Text = "Sample text";
            // 
            // sampleLabel
            // 
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Location = new System.Drawing.Point(13, 354);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(45, 13);
            this.sampleLabel.TabIndex = 7;
            this.sampleLabel.Text = "Sample:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 406);
            this.Controls.Add(this.sampleLabel);
            this.Controls.Add(this.sampleTextBox);
            this.Controls.Add(this.allowCheckBox);
            this.Controls.Add(this.permissionCB);
            this.Controls.Add(this.permissionLabel);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.permissionsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Discretionary model";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permissionsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView permissionsDGV;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ComboBox permissionCB;
        private System.Windows.Forms.Label permissionLabel;
        private System.Windows.Forms.CheckBox allowCheckBox;
        private System.Windows.Forms.TextBox sampleTextBox;
        private System.Windows.Forms.Label sampleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn readCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlCol;
    }
}