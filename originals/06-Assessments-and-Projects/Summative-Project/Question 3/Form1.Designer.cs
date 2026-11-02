
namespace Question_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRables = new System.Windows.Forms.CheckBox();
            this.chkHeartworm = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdRoutine = new System.Windows.Forms.RadioButton();
            this.rdExtended = new System.Windows.Forms.RadioButton();
            this.rdCheckup = new System.Windows.Forms.RadioButton();
            this.chkHospitalizationNumberOfDays = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtHospitalizationNumberofdays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdExtended);
            this.groupBox1.Controls.Add(this.rdCheckup);
            this.groupBox1.Controls.Add(this.rdRoutine);
            this.groupBox1.Location = new System.Drawing.Point(64, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Office Visits";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkHeartworm);
            this.groupBox2.Controls.Add(this.chkRables);
            this.groupBox2.Location = new System.Drawing.Point(64, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VACATIONS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHospitalizationNumberofdays);
            this.groupBox3.Controls.Add(this.chkHospitalizationNumberOfDays);
            this.groupBox3.Location = new System.Drawing.Point(64, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HOSPITALIZATION";
            // 
            // chkRables
            // 
            this.chkRables.AutoSize = true;
            this.chkRables.Location = new System.Drawing.Point(23, 20);
            this.chkRables.Name = "chkRables";
            this.chkRables.Size = new System.Drawing.Size(59, 17);
            this.chkRables.TabIndex = 0;
            this.chkRables.Text = "Rables";
            this.chkRables.UseVisualStyleBackColor = true;
            // 
            // chkHeartworm
            // 
            this.chkHeartworm.AutoSize = true;
            this.chkHeartworm.Location = new System.Drawing.Point(157, 20);
            this.chkHeartworm.Name = "chkHeartworm";
            this.chkHeartworm.Size = new System.Drawing.Size(77, 17);
            this.chkHeartworm.TabIndex = 1;
            this.chkHeartworm.Text = "Heartworm";
            this.chkHeartworm.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(623, 124);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(623, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(623, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdRoutine
            // 
            this.rdRoutine.AutoSize = true;
            this.rdRoutine.Location = new System.Drawing.Point(6, 28);
            this.rdRoutine.Name = "rdRoutine";
            this.rdRoutine.Size = new System.Drawing.Size(62, 17);
            this.rdRoutine.TabIndex = 6;
            this.rdRoutine.TabStop = true;
            this.rdRoutine.Text = "Routine";
            this.rdRoutine.UseVisualStyleBackColor = true;
            // 
            // rdExtended
            // 
            this.rdExtended.AutoSize = true;
            this.rdExtended.Location = new System.Drawing.Point(208, 28);
            this.rdExtended.Name = "rdExtended";
            this.rdExtended.Size = new System.Drawing.Size(70, 17);
            this.rdExtended.TabIndex = 7;
            this.rdExtended.TabStop = true;
            this.rdExtended.Text = "Extended";
            this.rdExtended.UseVisualStyleBackColor = true;
            // 
            // rdCheckup
            // 
            this.rdCheckup.AutoSize = true;
            this.rdCheckup.Location = new System.Drawing.Point(97, 28);
            this.rdCheckup.Name = "rdCheckup";
            this.rdCheckup.Size = new System.Drawing.Size(68, 17);
            this.rdCheckup.TabIndex = 8;
            this.rdCheckup.TabStop = true;
            this.rdCheckup.Text = "Checkup";
            this.rdCheckup.UseVisualStyleBackColor = true;
            // 
            // chkHospitalizationNumberOfDays
            // 
            this.chkHospitalizationNumberOfDays.AutoSize = true;
            this.chkHospitalizationNumberOfDays.Location = new System.Drawing.Point(23, 32);
            this.chkHospitalizationNumberOfDays.Name = "chkHospitalizationNumberOfDays";
            this.chkHospitalizationNumberOfDays.Size = new System.Drawing.Size(171, 17);
            this.chkHospitalizationNumberOfDays.TabIndex = 6;
            this.chkHospitalizationNumberOfDays.Text = "Hospitalization Number of days";
            this.chkHospitalizationNumberOfDays.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pet Name";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(142, 86);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(187, 20);
            this.txtPetName.TabIndex = 9;
            // 
            // txtHospitalizationNumberofdays
            // 
            this.txtHospitalizationNumberofdays.Location = new System.Drawing.Point(193, 29);
            this.txtHospitalizationNumberofdays.Name = "txtHospitalizationNumberofdays";
            this.txtHospitalizationNumberofdays.Size = new System.Drawing.Size(96, 20);
            this.txtHospitalizationNumberofdays.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "We are\"The Vet for your Pet\"";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(142, 420);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(96, 20);
            this.txtDisplay.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdExtended;
        private System.Windows.Forms.RadioButton rdCheckup;
        private System.Windows.Forms.RadioButton rdRoutine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkHeartworm;
        private System.Windows.Forms.CheckBox chkRables;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHospitalizationNumberofdays;
        private System.Windows.Forms.CheckBox chkHospitalizationNumberOfDays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

