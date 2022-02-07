namespace HW2_William_Parks
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
            this.btnAddGrader = new System.Windows.Forms.Button();
            this.lbxGraders = new System.Windows.Forms.ListBox();
            this.btnDeleteGrader = new System.Windows.Forms.Button();
            this.btnGradGrader = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddGrader
            // 
            this.btnAddGrader.Location = new System.Drawing.Point(506, 75);
            this.btnAddGrader.Name = "btnAddGrader";
            this.btnAddGrader.Size = new System.Drawing.Size(89, 34);
            this.btnAddGrader.TabIndex = 0;
            this.btnAddGrader.Text = "Add Grader";
            this.btnAddGrader.UseVisualStyleBackColor = true;
            this.btnAddGrader.Click += new System.EventHandler(this.btnAddGrader_Click);
            // 
            // lbxGraders
            // 
            this.lbxGraders.FormattingEnabled = true;
            this.lbxGraders.Location = new System.Drawing.Point(25, 33);
            this.lbxGraders.Name = "lbxGraders";
            this.lbxGraders.Size = new System.Drawing.Size(437, 303);
            this.lbxGraders.TabIndex = 1;
            // 
            // btnDeleteGrader
            // 
            this.btnDeleteGrader.Location = new System.Drawing.Point(506, 210);
            this.btnDeleteGrader.Name = "btnDeleteGrader";
            this.btnDeleteGrader.Size = new System.Drawing.Size(89, 31);
            this.btnDeleteGrader.TabIndex = 2;
            this.btnDeleteGrader.Text = "Delete";
            this.btnDeleteGrader.UseVisualStyleBackColor = true;
            this.btnDeleteGrader.Click += new System.EventHandler(this.btnDeleteGrader_Click);
            // 
            // btnGradGrader
            // 
            this.btnGradGrader.Location = new System.Drawing.Point(506, 144);
            this.btnGradGrader.Name = "btnGradGrader";
            this.btnGradGrader.Size = new System.Drawing.Size(89, 37);
            this.btnGradGrader.TabIndex = 3;
            this.btnGradGrader.Text = "Add Graduate Grader";
            this.btnGradGrader.UseVisualStyleBackColor = true;
            this.btnGradGrader.Click += new System.EventHandler(this.btnGradGrader_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(58, 13);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(47, 13);
            this.lblFN.TabIndex = 5;
            this.lblFN.Text = "F Name:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(108, 13);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(47, 13);
            this.lblLN.TabIndex = 6;
            this.lblLN.Text = "L Name:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(161, 13);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(61, 13);
            this.lblHP.TabIndex = 7;
            this.lblHP.Text = "Hourly Pay:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(218, 13);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(38, 13);
            this.lblH.TabIndex = 8;
            this.lblH.Text = "Hours:";
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(253, 13);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(55, 13);
            this.lblTP.TabIndex = 9;
            this.lblTP.Text = "Total Pay:";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(303, 13);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(46, 13);
            this.lblS.TabIndex = 10;
            this.lblS.Text = "Stipend:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnGradGrader);
            this.Controls.Add(this.btnDeleteGrader);
            this.Controls.Add(this.lbxGraders);
            this.Controls.Add(this.btnAddGrader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddGrader;
        private System.Windows.Forms.ListBox lbxGraders;
        private System.Windows.Forms.Button btnDeleteGrader;
        private System.Windows.Forms.Button btnGradGrader;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblS;
    }
}

