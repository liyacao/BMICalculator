namespace WindowsFormsApp1
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.threebutton = new System.Windows.Forms.Button();
            this.twobutton = new System.Windows.Forms.Button();
            this.onebutton = new System.Windows.Forms.Button();
            this.sixbutton = new System.Windows.Forms.Button();
            this.fivebutton = new System.Windows.Forms.Button();
            this.fourbutton = new System.Windows.Forms.Button();
            this.ninebutton = new System.Windows.Forms.Button();
            this.eightbutton = new System.Windows.Forms.Button();
            this.sevenbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.zerobutton = new System.Windows.Forms.Button();
            this.donebutton = new System.Windows.Forms.Button();
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.myheightlabel = new System.Windows.Forms.Label();
            this.myheighttextbox = new System.Windows.Forms.TextBox();
            this.myWeightTextbox = new System.Windows.Forms.TextBox();
            this.myweightlabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heightUnit = new System.Windows.Forms.Label();
            this.weightUnit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.threebutton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.twobutton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.onebutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixbutton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fivebutton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fourbutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ninebutton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.eightbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sevenbutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zerobutton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 303);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // threebutton
            // 
            this.threebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.threebutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.threebutton.Location = new System.Drawing.Point(205, 67);
            this.threebutton.Name = "threebutton";
            this.threebutton.Size = new System.Drawing.Size(70, 26);
            this.threebutton.TabIndex = 10;
            this.threebutton.Text = "3";
            this.threebutton.UseVisualStyleBackColor = false;
            this.threebutton.Click += new System.EventHandler(this.Threebutton_Click);
            // 
            // twobutton
            // 
            this.twobutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.twobutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.twobutton.Location = new System.Drawing.Point(104, 67);
            this.twobutton.Name = "twobutton";
            this.twobutton.Size = new System.Drawing.Size(70, 26);
            this.twobutton.TabIndex = 9;
            this.twobutton.Text = "2";
            this.twobutton.UseVisualStyleBackColor = false;
            this.twobutton.Click += new System.EventHandler(this.Twobutton_Click);
            // 
            // onebutton
            // 
            this.onebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.onebutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.onebutton.Location = new System.Drawing.Point(3, 67);
            this.onebutton.Name = "onebutton";
            this.onebutton.Size = new System.Drawing.Size(70, 26);
            this.onebutton.TabIndex = 8;
            this.onebutton.Text = "1";
            this.onebutton.UseVisualStyleBackColor = false;
            this.onebutton.Click += new System.EventHandler(this.Onebutton_Click);
            // 
            // sixbutton
            // 
            this.sixbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sixbutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sixbutton.Location = new System.Drawing.Point(205, 35);
            this.sixbutton.Name = "sixbutton";
            this.sixbutton.Size = new System.Drawing.Size(70, 26);
            this.sixbutton.TabIndex = 6;
            this.sixbutton.Text = "6";
            this.sixbutton.UseVisualStyleBackColor = false;
            this.sixbutton.Click += new System.EventHandler(this.Sixbutton_Click);
            // 
            // fivebutton
            // 
            this.fivebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fivebutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fivebutton.Location = new System.Drawing.Point(104, 35);
            this.fivebutton.Name = "fivebutton";
            this.fivebutton.Size = new System.Drawing.Size(70, 26);
            this.fivebutton.TabIndex = 5;
            this.fivebutton.Text = "5";
            this.fivebutton.UseVisualStyleBackColor = false;
            this.fivebutton.Click += new System.EventHandler(this.Fivebutton_Click);
            // 
            // fourbutton
            // 
            this.fourbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fourbutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fourbutton.Location = new System.Drawing.Point(3, 35);
            this.fourbutton.Name = "fourbutton";
            this.fourbutton.Size = new System.Drawing.Size(70, 26);
            this.fourbutton.TabIndex = 4;
            this.fourbutton.Text = "4";
            this.fourbutton.UseVisualStyleBackColor = false;
            this.fourbutton.Click += new System.EventHandler(this.Fourbutton_Click);
            // 
            // ninebutton
            // 
            this.ninebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ninebutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ninebutton.Location = new System.Drawing.Point(205, 3);
            this.ninebutton.Name = "ninebutton";
            this.ninebutton.Size = new System.Drawing.Size(70, 26);
            this.ninebutton.TabIndex = 2;
            this.ninebutton.Text = "9";
            this.ninebutton.UseVisualStyleBackColor = false;
            this.ninebutton.Click += new System.EventHandler(this.Ninebutton_Click);
            // 
            // eightbutton
            // 
            this.eightbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.eightbutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eightbutton.Location = new System.Drawing.Point(104, 3);
            this.eightbutton.Name = "eightbutton";
            this.eightbutton.Size = new System.Drawing.Size(70, 26);
            this.eightbutton.TabIndex = 1;
            this.eightbutton.Text = "8";
            this.eightbutton.UseVisualStyleBackColor = false;
            this.eightbutton.Click += new System.EventHandler(this.Eightbutton_Click);
            // 
            // sevenbutton
            // 
            this.sevenbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sevenbutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sevenbutton.Location = new System.Drawing.Point(3, 3);
            this.sevenbutton.Name = "sevenbutton";
            this.sevenbutton.Size = new System.Drawing.Size(70, 26);
            this.sevenbutton.TabIndex = 0;
            this.sevenbutton.Text = "7";
            this.sevenbutton.UseVisualStyleBackColor = false;
            this.sevenbutton.Click += new System.EventHandler(this.Sevenbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Orange;
            this.clearbutton.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearbutton.Location = new System.Drawing.Point(16, 240);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(109, 58);
            this.clearbutton.TabIndex = 16;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // zerobutton
            // 
            this.zerobutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.zerobutton, 2);
            this.zerobutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zerobutton.Location = new System.Drawing.Point(104, 99);
            this.zerobutton.Name = "zerobutton";
            this.zerobutton.Size = new System.Drawing.Size(70, 26);
            this.zerobutton.TabIndex = 13;
            this.zerobutton.Text = "0";
            this.zerobutton.UseVisualStyleBackColor = false;
            this.zerobutton.Click += new System.EventHandler(this.Zerobutton_Click);
            // 
            // donebutton
            // 
            this.donebutton.BackColor = System.Drawing.Color.Lime;
            this.donebutton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.donebutton.Location = new System.Drawing.Point(131, 239);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(122, 61);
            this.donebutton.TabIndex = 15;
            this.donebutton.Text = "Calculate BMI";
            this.donebutton.UseVisualStyleBackColor = false;
            this.donebutton.Click += new System.EventHandler(this.Donebutton_Click);
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonMetric.Location = new System.Drawing.Point(169, 12);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(90, 24);
            this.radioButtonMetric.TabIndex = 1;
            this.radioButtonMetric.Text = "Metric";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            this.radioButtonMetric.CheckedChanged += new System.EventHandler(this.RadioButtonMetric_CheckedChanged);
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Checked = true;
            this.radioButtonImperial.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonImperial.Location = new System.Drawing.Point(22, 12);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(110, 24);
            this.radioButtonImperial.TabIndex = 2;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            this.radioButtonImperial.CheckedChanged += new System.EventHandler(this.RadioButtonImperial_CheckedChanged);
            // 
            // myheightlabel
            // 
            this.myheightlabel.AutoSize = true;
            this.myheightlabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myheightlabel.Location = new System.Drawing.Point(22, 49);
            this.myheightlabel.Name = "myheightlabel";
            this.myheightlabel.Size = new System.Drawing.Size(109, 20);
            this.myheightlabel.TabIndex = 3;
            this.myheightlabel.Text = "My Height:";
            // 
            // myheighttextbox
            // 
            this.myheighttextbox.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myheighttextbox.Location = new System.Drawing.Point(137, 42);
            this.myheighttextbox.Name = "myheighttextbox";
            this.myheighttextbox.Size = new System.Drawing.Size(69, 36);
            this.myheighttextbox.TabIndex = 4;
            this.myheighttextbox.Click += new System.EventHandler(this.Myheighttextbox_Click);
            this.myheighttextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Myheighttextbox_Click);
            this.myheighttextbox.TextChanged += new System.EventHandler(this.Myheighttextbox_TextChanged);
            this.myheighttextbox.DoubleClick += new System.EventHandler(this.Myheighttextbox_DoubleClick);
            this.myheighttextbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Myheighttextbox_MouseDoubleClick);
            // 
            // myWeightTextbox
            // 
            this.myWeightTextbox.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myWeightTextbox.Location = new System.Drawing.Point(138, 87);
            this.myWeightTextbox.Name = "myWeightTextbox";
            this.myWeightTextbox.Size = new System.Drawing.Size(68, 36);
            this.myWeightTextbox.TabIndex = 6;
            this.myWeightTextbox.Click += new System.EventHandler(this.MyWeightTextbox_Click);
            this.myWeightTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyWeightTextbox_MouseClick);
            this.myWeightTextbox.TextChanged += new System.EventHandler(this.MyWeightTextbox_TextChanged);
            this.myWeightTextbox.DoubleClick += new System.EventHandler(this.MyWeightTextbox_DoubleClick);
            this.myWeightTextbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyWeightTextbox_MouseDoubleClick);
            // 
            // myweightlabel
            // 
            this.myweightlabel.AutoSize = true;
            this.myweightlabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myweightlabel.Location = new System.Drawing.Point(23, 94);
            this.myweightlabel.Name = "myweightlabel";
            this.myweightlabel.Size = new System.Drawing.Size(109, 20);
            this.myweightlabel.TabIndex = 5;
            this.myweightlabel.Text = "My Weight:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Font = new System.Drawing.Font("SimSun", 8F);
            this.resultTextBox.Location = new System.Drawing.Point(137, 196);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(153, 23);
            this.resultTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "BMI Result:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // heightUnit
            // 
            this.heightUnit.AutoSize = true;
            this.heightUnit.Font = new System.Drawing.Font("SimSun", 12F);
            this.heightUnit.Location = new System.Drawing.Point(212, 49);
            this.heightUnit.Name = "heightUnit";
            this.heightUnit.Size = new System.Drawing.Size(0, 20);
            this.heightUnit.TabIndex = 17;
            // 
            // weightUnit
            // 
            this.weightUnit.AutoSize = true;
            this.weightUnit.Font = new System.Drawing.Font("SimSun", 12F);
            this.weightUnit.Location = new System.Drawing.Point(212, 94);
            this.weightUnit.Name = "weightUnit";
            this.weightUnit.Size = new System.Drawing.Size(0, 20);
            this.weightUnit.TabIndex = 18;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.weightUnit);
            this.Controls.Add(this.heightUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.myWeightTextbox);
            this.Controls.Add(this.myweightlabel);
            this.Controls.Add(this.myheighttextbox);
            this.Controls.Add(this.myheightlabel);
            this.Controls.Add(this.radioButtonImperial);
            this.Controls.Add(this.radioButtonMetric);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.donebutton);
            this.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.Text = "BMICalculator Form";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button donebutton;
        private System.Windows.Forms.Button threebutton;
        private System.Windows.Forms.Button twobutton;
        private System.Windows.Forms.Button onebutton;
        private System.Windows.Forms.Button sixbutton;
        private System.Windows.Forms.Button fivebutton;
        private System.Windows.Forms.Button fourbutton;
        private System.Windows.Forms.Button ninebutton;
        private System.Windows.Forms.Button eightbutton;
        private System.Windows.Forms.Button sevenbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button zerobutton;
        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.RadioButton radioButtonImperial;
        private System.Windows.Forms.Label myheightlabel;
        private System.Windows.Forms.TextBox myheighttextbox;
        private System.Windows.Forms.TextBox myWeightTextbox;
        private System.Windows.Forms.Label myweightlabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label heightUnit;
        private System.Windows.Forms.Label weightUnit;
    }
}

