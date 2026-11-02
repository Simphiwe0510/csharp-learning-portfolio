namespace Question_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDriedShrimp = new System.Windows.Forms.CheckBox();
            this.chkJalapeno = new System.Windows.Forms.CheckBox();
            this.chkGroundedBeef = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkSheddedChicken = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(19, 15);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(117, 24);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small(R 20)";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(151, 15);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(130, 24);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium(R35)";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(299, 15);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(115, 24);
            this.rdLarge.TabIndex = 2;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large(R55)";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDriedShrimp);
            this.groupBox1.Controls.Add(this.chkJalapeno);
            this.groupBox1.Controls.Add(this.chkGroundedBeef);
            this.groupBox1.Controls.Add(this.chkPineapple);
            this.groupBox1.Controls.Add(this.chkSheddedChicken);
            this.groupBox1.Controls.Add(this.chkSpinach);
            this.groupBox1.Controls.Add(this.chkMushroom);
            this.groupBox1.Controls.Add(this.chkExtraCheese);
            this.groupBox1.Controls.Add(this.chkPepperoni);
            this.groupBox1.Location = new System.Drawing.Point(49, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Topping (each @ R7)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkDriedShrimp
            // 
            this.chkDriedShrimp.AutoSize = true;
            this.chkDriedShrimp.Location = new System.Drawing.Point(221, 164);
            this.chkDriedShrimp.Name = "chkDriedShrimp";
            this.chkDriedShrimp.Size = new System.Drawing.Size(127, 24);
            this.chkDriedShrimp.TabIndex = 8;
            this.chkDriedShrimp.Text = "Dried Shrimp";
            this.chkDriedShrimp.UseVisualStyleBackColor = true;
            // 
            // chkJalapeno
            // 
            this.chkJalapeno.AutoSize = true;
            this.chkJalapeno.Location = new System.Drawing.Point(221, 41);
            this.chkJalapeno.Name = "chkJalapeno";
            this.chkJalapeno.Size = new System.Drawing.Size(100, 24);
            this.chkJalapeno.TabIndex = 7;
            this.chkJalapeno.Text = "Jalapeno";
            this.chkJalapeno.UseVisualStyleBackColor = true;
            // 
            // chkGroundedBeef
            // 
            this.chkGroundedBeef.AutoSize = true;
            this.chkGroundedBeef.Location = new System.Drawing.Point(396, 152);
            this.chkGroundedBeef.Name = "chkGroundedBeef";
            this.chkGroundedBeef.Size = new System.Drawing.Size(145, 24);
            this.chkGroundedBeef.TabIndex = 6;
            this.chkGroundedBeef.Text = "Grounded Beef";
            this.chkGroundedBeef.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(221, 98);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(105, 24);
            this.chkPineapple.TabIndex = 5;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkSheddedChicken
            // 
            this.chkSheddedChicken.AutoSize = true;
            this.chkSheddedChicken.Location = new System.Drawing.Point(396, 98);
            this.chkSheddedChicken.Name = "chkSheddedChicken";
            this.chkSheddedChicken.Size = new System.Drawing.Size(161, 24);
            this.chkSheddedChicken.TabIndex = 4;
            this.chkSheddedChicken.Text = "Shedded Chicken";
            this.chkSheddedChicken.UseVisualStyleBackColor = true;
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(396, 41);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(93, 24);
            this.chkSpinach.TabIndex = 3;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(38, 164);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(110, 24);
            this.chkMushroom.TabIndex = 2;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(38, 98);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(131, 24);
            this.chkExtraCheese.TabIndex = 1;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(38, 41);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(107, 24);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 78);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdLarge);
            this.panel1.Controls.Add(this.rdMedium);
            this.panel1.Controls.Add(this.rdSmall);
            this.panel1.Location = new System.Drawing.Point(49, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 54);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdThin);
            this.panel2.Controls.Add(this.rdThick);
            this.panel2.Location = new System.Drawing.Point(49, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 54);
            this.panel2.TabIndex = 6;
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(243, 15);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(95, 24);
            this.rdThin.TabIndex = 1;
            this.rdThin.TabStop = true;
            this.rdThin.Text = "Thin(R1)";
            this.rdThin.UseVisualStyleBackColor = true;
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(19, 15);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(102, 24);
            this.rdThick.TabIndex = 0;
            this.rdThick.TabStop = true;
            this.rdThick.Text = "Thick(R2)";
            this.rdThick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pizza Hut";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(119, 571);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(0, 25);
            this.lblAmountDue.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(531, 560);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 54);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 724);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDriedShrimp;
        private System.Windows.Forms.CheckBox chkJalapeno;
        private System.Windows.Forms.CheckBox chkGroundedBeef;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkSheddedChicken;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Button btnCalculate;
    }
}

