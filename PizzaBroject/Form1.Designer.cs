namespace PizzaBroject
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge_Size = new System.Windows.Forms.RadioButton();
            this.rbMedium_Size = new System.Windows.Forms.RadioButton();
            this.rbSmall_Size = new System.Windows.Forms.RadioButton();
            this.grbCrustType = new System.Windows.Forms.GroupBox();
            this.rbCrustType_Thick = new System.Windows.Forms.RadioButton();
            this.rbCrustType_Thin = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTommatos = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChess = new System.Windows.Forms.CheckBox();
            this.grbPlaseOfEating = new System.Windows.Forms.GroupBox();
            this.rbToEat_Inside = new System.Windows.Forms.RadioButton();
            this.rbToEat_OutSide = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.labPrise = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labToppingsSummary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labSizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbSize.SuspendLayout();
            this.grbCrustType.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbPlaseOfEating.SuspendLayout();
            this.grbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // grbSize
            // 
            this.grbSize.BackColor = System.Drawing.Color.Transparent;
            this.grbSize.Controls.Add(this.rbLarge_Size);
            this.grbSize.Controls.Add(this.rbMedium_Size);
            this.grbSize.Controls.Add(this.rbSmall_Size);
            this.grbSize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSize.ForeColor = System.Drawing.Color.Goldenrod;
            this.grbSize.Location = new System.Drawing.Point(135, 165);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(209, 192);
            this.grbSize.TabIndex = 1;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rbLarge_Size
            // 
            this.rbLarge_Size.AutoSize = true;
            this.rbLarge_Size.Location = new System.Drawing.Point(32, 135);
            this.rbLarge_Size.Name = "rbLarge_Size";
            this.rbLarge_Size.Size = new System.Drawing.Size(72, 25);
            this.rbLarge_Size.TabIndex = 2;
            this.rbLarge_Size.Tag = "40";
            this.rbLarge_Size.Text = "Large";
            this.rbLarge_Size.UseVisualStyleBackColor = true;
            this.rbLarge_Size.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbMedium_Size
            // 
            this.rbMedium_Size.AutoSize = true;
            this.rbMedium_Size.Location = new System.Drawing.Point(32, 81);
            this.rbMedium_Size.Name = "rbMedium_Size";
            this.rbMedium_Size.Size = new System.Drawing.Size(89, 25);
            this.rbMedium_Size.TabIndex = 1;
            this.rbMedium_Size.Tag = "30";
            this.rbMedium_Size.Text = "Medium";
            this.rbMedium_Size.UseVisualStyleBackColor = true;
            this.rbMedium_Size.CheckedChanged += new System.EventHandler(this.rbMedium_Size_CheckedChanged);
            // 
            // rbSmall_Size
            // 
            this.rbSmall_Size.AutoSize = true;
            this.rbSmall_Size.Checked = true;
            this.rbSmall_Size.Location = new System.Drawing.Point(32, 27);
            this.rbSmall_Size.Name = "rbSmall_Size";
            this.rbSmall_Size.Size = new System.Drawing.Size(71, 25);
            this.rbSmall_Size.TabIndex = 0;
            this.rbSmall_Size.TabStop = true;
            this.rbSmall_Size.Tag = "20";
            this.rbSmall_Size.Text = "Small";
            this.rbSmall_Size.UseVisualStyleBackColor = true;
            this.rbSmall_Size.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grbCrustType
            // 
            this.grbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.grbCrustType.Controls.Add(this.rbCrustType_Thick);
            this.grbCrustType.Controls.Add(this.rbCrustType_Thin);
            this.grbCrustType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrustType.ForeColor = System.Drawing.Color.Goldenrod;
            this.grbCrustType.Location = new System.Drawing.Point(135, 435);
            this.grbCrustType.Name = "grbCrustType";
            this.grbCrustType.Size = new System.Drawing.Size(209, 143);
            this.grbCrustType.TabIndex = 3;
            this.grbCrustType.TabStop = false;
            this.grbCrustType.Text = "Crust Type";
            // 
            // rbCrustType_Thick
            // 
            this.rbCrustType_Thick.AutoSize = true;
            this.rbCrustType_Thick.Location = new System.Drawing.Point(50, 81);
            this.rbCrustType_Thick.Name = "rbCrustType_Thick";
            this.rbCrustType_Thick.Size = new System.Drawing.Size(70, 25);
            this.rbCrustType_Thick.TabIndex = 1;
            this.rbCrustType_Thick.Tag = "10";
            this.rbCrustType_Thick.Text = "Thick";
            this.rbCrustType_Thick.UseVisualStyleBackColor = true;
            this.rbCrustType_Thick.CheckedChanged += new System.EventHandler(this.rbCrustType_Thick_CheckedChanged);
            // 
            // rbCrustType_Thin
            // 
            this.rbCrustType_Thin.AutoSize = true;
            this.rbCrustType_Thin.Checked = true;
            this.rbCrustType_Thin.Location = new System.Drawing.Point(50, 37);
            this.rbCrustType_Thin.Name = "rbCrustType_Thin";
            this.rbCrustType_Thin.Size = new System.Drawing.Size(63, 25);
            this.rbCrustType_Thin.TabIndex = 0;
            this.rbCrustType_Thin.TabStop = true;
            this.rbCrustType_Thin.Tag = "0";
            this.rbCrustType_Thin.Text = "Thin";
            this.rbCrustType_Thin.UseVisualStyleBackColor = true;
            this.rbCrustType_Thin.CheckedChanged += new System.EventHandler(this.rbCrustType_Thin_CheckedChanged);
            // 
            // grbToppings
            // 
            this.grbToppings.BackColor = System.Drawing.Color.Transparent;
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkOlives);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkTommatos);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkExtraChess);
            this.grbToppings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppings.ForeColor = System.Drawing.Color.Goldenrod;
            this.grbToppings.Location = new System.Drawing.Point(434, 165);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(429, 231);
            this.grbToppings.TabIndex = 4;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(222, 149);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(140, 25);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(222, 98);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 25);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(222, 52);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(75, 25);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTommatos
            // 
            this.chkTommatos.AutoSize = true;
            this.chkTommatos.Location = new System.Drawing.Point(58, 149);
            this.chkTommatos.Name = "chkTommatos";
            this.chkTommatos.Size = new System.Drawing.Size(111, 25);
            this.chkTommatos.TabIndex = 2;
            this.chkTommatos.Tag = "5";
            this.chkTommatos.Text = "Tommatos";
            this.chkTommatos.UseVisualStyleBackColor = true;
            this.chkTommatos.CheckedChanged += new System.EventHandler(this.chkTommatos_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(58, 98);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(117, 25);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChess
            // 
            this.chkExtraChess.AutoSize = true;
            this.chkExtraChess.Checked = true;
            this.chkExtraChess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExtraChess.Location = new System.Drawing.Point(58, 52);
            this.chkExtraChess.Name = "chkExtraChess";
            this.chkExtraChess.Size = new System.Drawing.Size(120, 25);
            this.chkExtraChess.TabIndex = 0;
            this.chkExtraChess.Tag = "5";
            this.chkExtraChess.Text = "Extra Chess";
            this.chkExtraChess.UseVisualStyleBackColor = true;
            this.chkExtraChess.CheckedChanged += new System.EventHandler(this.chkExtraChess_CheckedChanged);
            // 
            // grbPlaseOfEating
            // 
            this.grbPlaseOfEating.BackColor = System.Drawing.Color.Transparent;
            this.grbPlaseOfEating.Controls.Add(this.rbToEat_Inside);
            this.grbPlaseOfEating.Controls.Add(this.rbToEat_OutSide);
            this.grbPlaseOfEating.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPlaseOfEating.ForeColor = System.Drawing.Color.Goldenrod;
            this.grbPlaseOfEating.Location = new System.Drawing.Point(434, 461);
            this.grbPlaseOfEating.Name = "grbPlaseOfEating";
            this.grbPlaseOfEating.Size = new System.Drawing.Size(398, 117);
            this.grbPlaseOfEating.TabIndex = 4;
            this.grbPlaseOfEating.TabStop = false;
            this.grbPlaseOfEating.Text = "Where To Eat ?";
            // 
            // rbToEat_Inside
            // 
            this.rbToEat_Inside.AutoSize = true;
            this.rbToEat_Inside.Checked = true;
            this.rbToEat_Inside.Location = new System.Drawing.Point(70, 55);
            this.rbToEat_Inside.Name = "rbToEat_Inside";
            this.rbToEat_Inside.Size = new System.Drawing.Size(76, 25);
            this.rbToEat_Inside.TabIndex = 1;
            this.rbToEat_Inside.TabStop = true;
            this.rbToEat_Inside.Text = "Eat In";
            this.rbToEat_Inside.UseVisualStyleBackColor = true;
            this.rbToEat_Inside.CheckedChanged += new System.EventHandler(this.rbToEat_Inside_CheckedChanged);
            // 
            // rbToEat_OutSide
            // 
            this.rbToEat_OutSide.AutoSize = true;
            this.rbToEat_OutSide.Location = new System.Drawing.Point(186, 55);
            this.rbToEat_OutSide.Name = "rbToEat_OutSide";
            this.rbToEat_OutSide.Size = new System.Drawing.Size(99, 25);
            this.rbToEat_OutSide.TabIndex = 0;
            this.rbToEat_OutSide.Text = "Take Out";
            this.rbToEat_OutSide.UseVisualStyleBackColor = true;
            this.rbToEat_OutSide.CheckedChanged += new System.EventHandler(this.rbToEat_OutSide_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnOrder.Location = new System.Drawing.Point(444, 660);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(159, 45);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnReset.Location = new System.Drawing.Point(763, 660);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 45);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Order";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbSummary
            // 
            this.grbSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSummary.BackColor = System.Drawing.Color.Transparent;
            this.grbSummary.Controls.Add(this.labPrise);
            this.grbSummary.Controls.Add(this.label6);
            this.grbSummary.Controls.Add(this.labToppingsSummary);
            this.grbSummary.Controls.Add(this.label5);
            this.grbSummary.Controls.Add(this.labWhereToEat);
            this.grbSummary.Controls.Add(this.label4);
            this.grbSummary.Controls.Add(this.labCrustType);
            this.grbSummary.Controls.Add(this.label3);
            this.grbSummary.Controls.Add(this.labSizeLabel);
            this.grbSummary.Controls.Add(this.label2);
            this.grbSummary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSummary.ForeColor = System.Drawing.Color.Ivory;
            this.grbSummary.Location = new System.Drawing.Point(1222, 165);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(433, 540);
            this.grbSummary.TabIndex = 7;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Summary";
            // 
            // labPrise
            // 
            this.labPrise.AutoSize = true;
            this.labPrise.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrise.ForeColor = System.Drawing.Color.Chocolate;
            this.labPrise.Location = new System.Drawing.Point(139, 462);
            this.labPrise.Name = "labPrise";
            this.labPrise.Size = new System.Drawing.Size(108, 38);
            this.labPrise.TabIndex = 9;
            this.labPrise.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Prise :";
            // 
            // labToppingsSummary
            // 
            this.labToppingsSummary.AutoSize = true;
            this.labToppingsSummary.Location = new System.Drawing.Point(53, 168);
            this.labToppingsSummary.Name = "labToppingsSummary";
            this.labToppingsSummary.Size = new System.Drawing.Size(114, 24);
            this.labToppingsSummary.TabIndex = 7;
            this.labToppingsSummary.Text = "Extra Chess";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Toppings :";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Location = new System.Drawing.Point(189, 364);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(61, 24);
            this.labWhereToEat.TabIndex = 5;
            this.labWhereToEat.Text = "Eat in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Where To Eat ? ";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Location = new System.Drawing.Point(189, 270);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(49, 24);
            this.labCrustType.TabIndex = 3;
            this.labCrustType.Text = "Thin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crust Type : ";
            // 
            // labSizeLabel
            // 
            this.labSizeLabel.AutoSize = true;
            this.labSizeLabel.Location = new System.Drawing.Point(123, 62);
            this.labSizeLabel.Name = "labSizeLabel";
            this.labSizeLabel.Size = new System.Drawing.Size(59, 24);
            this.labSizeLabel.TabIndex = 1;
            this.labSizeLabel.Text = "Small";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size : ";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1812, 765);
            this.Controls.Add(this.grbSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grbPlaseOfEating);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbCrustType);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbCrustType.ResumeLayout(false);
            this.grbCrustType.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbPlaseOfEating.ResumeLayout(false);
            this.grbPlaseOfEating.PerformLayout();
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.RadioButton rbLarge_Size;
        private System.Windows.Forms.RadioButton rbMedium_Size;
        private System.Windows.Forms.RadioButton rbSmall_Size;
        private System.Windows.Forms.GroupBox grbCrustType;
        private System.Windows.Forms.RadioButton rbCrustType_Thick;
        private System.Windows.Forms.RadioButton rbCrustType_Thin;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTommatos;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChess;
        private System.Windows.Forms.GroupBox grbPlaseOfEating;
        private System.Windows.Forms.RadioButton rbToEat_Inside;
        private System.Windows.Forms.RadioButton rbToEat_OutSide;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.Label labSizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labToppingsSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPrise;
    }
}

