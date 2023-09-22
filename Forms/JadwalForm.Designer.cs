
namespace sekolahku_jude.Forms
{
    partial class JadwalForm
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
            this.KelasGrid = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.JadwalGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.KelasIdText = new System.Windows.Forms.TextBox();
            this.KelasNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HariCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.KelasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JadwalGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KelasGrid
            // 
            this.KelasGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.KelasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KelasGrid.Location = new System.Drawing.Point(12, 12);
            this.KelasGrid.Name = "KelasGrid";
            this.KelasGrid.RowHeadersWidth = 62;
            this.KelasGrid.RowTemplate.Height = 28;
            this.KelasGrid.Size = new System.Drawing.Size(299, 644);
            this.KelasGrid.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(818, 602);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 54);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewButton.Location = new System.Drawing.Point(317, 602);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(103, 54);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // JadwalGrid
            // 
            this.JadwalGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JadwalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JadwalGrid.Location = new System.Drawing.Point(317, 301);
            this.JadwalGrid.Name = "JadwalGrid";
            this.JadwalGrid.RowHeadersWidth = 62;
            this.JadwalGrid.RowTemplate.Height = 28;
            this.JadwalGrid.Size = new System.Drawing.Size(604, 285);
            this.JadwalGrid.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.HariCombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.KelasNameText);
            this.panel1.Controls.Add(this.KelasIdText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(317, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 283);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelas ID";
            // 
            // KelasIdText
            // 
            this.KelasIdText.Location = new System.Drawing.Point(78, 41);
            this.KelasIdText.Name = "KelasIdText";
            this.KelasIdText.ReadOnly = true;
            this.KelasIdText.Size = new System.Drawing.Size(47, 26);
            this.KelasIdText.TabIndex = 5;
            // 
            // KelasNameText
            // 
            this.KelasNameText.Location = new System.Drawing.Point(78, 73);
            this.KelasNameText.Name = "KelasNameText";
            this.KelasNameText.ReadOnly = true;
            this.KelasNameText.Size = new System.Drawing.Size(121, 26);
            this.KelasNameText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hari";
            // 
            // HariCombo
            // 
            this.HariCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HariCombo.FormattingEnabled = true;
            this.HariCombo.Location = new System.Drawing.Point(78, 105);
            this.HariCombo.Name = "HariCombo";
            this.HariCombo.Size = new System.Drawing.Size(121, 28);
            this.HariCombo.TabIndex = 8;
            // 
            // JadwalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.JadwalGrid);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.KelasGrid);
            this.Name = "JadwalForm";
            this.Text = "JadwalForm";
            ((System.ComponentModel.ISupportInitialize)(this.KelasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JadwalGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KelasGrid;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.DataGridView JadwalGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox KelasIdText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HariCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KelasNameText;
    }
}