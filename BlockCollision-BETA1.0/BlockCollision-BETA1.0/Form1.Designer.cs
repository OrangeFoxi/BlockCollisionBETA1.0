namespace BlockCollision_BETA1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.labelCollisionStatus = new System.Windows.Forms.Label();
            this.textBoxRedWeight = new System.Windows.Forms.TextBox();
            this.textBoxRedSpeed = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBlueWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBlueSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(31, 139);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(97, 97);
            this.panelRed.TabIndex = 0;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(442, 139);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(97, 97);
            this.panelBlue.TabIndex = 1;
            // 
            // labelCollisionStatus
            // 
            this.labelCollisionStatus.AutoSize = true;
            this.labelCollisionStatus.Location = new System.Drawing.Point(31, 18);
            this.labelCollisionStatus.Name = "labelCollisionStatus";
            this.labelCollisionStatus.Size = new System.Drawing.Size(38, 15);
            this.labelCollisionStatus.TabIndex = 2;
            this.labelCollisionStatus.Text = "label1";
            // 
            // textBoxRedWeight
            // 
            this.textBoxRedWeight.Location = new System.Drawing.Point(263, 15);
            this.textBoxRedWeight.Name = "textBoxRedWeight";
            this.textBoxRedWeight.Size = new System.Drawing.Size(100, 23);
            this.textBoxRedWeight.TabIndex = 3;
            // 
            // textBoxRedSpeed
            // 
            this.textBoxRedSpeed.Location = new System.Drawing.Point(440, 15);
            this.textBoxRedSpeed.Name = "textBoxRedSpeed";
            this.textBoxRedSpeed.Size = new System.Drawing.Size(100, 23);
            this.textBoxRedSpeed.TabIndex = 4;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(186, 18);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(71, 15);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Red Weight:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(369, 18);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(65, 15);
            this.labelSpeed.TabIndex = 6;
            this.labelSpeed.Text = "Red Speed:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Blue Weight:";
            // 
            // textBoxBlueWeight
            // 
            this.textBoxBlueWeight.Location = new System.Drawing.Point(263, 57);
            this.textBoxBlueWeight.Name = "textBoxBlueWeight";
            this.textBoxBlueWeight.Size = new System.Drawing.Size(100, 23);
            this.textBoxBlueWeight.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Blue Speed:";
            // 
            // textBoxBlueSpeed
            // 
            this.textBoxBlueSpeed.Location = new System.Drawing.Point(440, 60);
            this.textBoxBlueSpeed.Name = "textBoxBlueSpeed";
            this.textBoxBlueSpeed.Size = new System.Drawing.Size(100, 23);
            this.textBoxBlueSpeed.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBlueSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBlueWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxRedSpeed);
            this.Controls.Add(this.textBoxRedWeight);
            this.Controls.Add(this.labelCollisionStatus);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelRed;
        private Panel panelBlue;
        private Label labelCollisionStatus;
        private TextBox textBoxRedWeight;
        private TextBox textBoxRedSpeed;
        private Label labelWeight;
        private Label labelSpeed;
        private Button button1;
        private Label label1;
        private TextBox textBoxBlueWeight;
        private Label label2;
        private TextBox textBoxBlueSpeed;
    }
}