﻿namespace ReadCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxPathCSV = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.comboBoxAttributes = new System.Windows.Forms.ComboBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonBool = new System.Windows.Forms.RadioButton();
            this.radioButtonDateTime = new System.Windows.Forms.RadioButton();
            this.radioButtonInt32 = new System.Windows.Forms.RadioButton();
            this.radioButtonInt64 = new System.Windows.Forms.RadioButton();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonString = new System.Windows.Forms.RadioButton();
            this.dataGridTypes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIntervalDistance = new System.Windows.Forms.NumericUpDown();
            this.dataGridDistribution = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMeanValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.comboBoxAttributeCalc = new System.Windows.Forms.ComboBox();
            this.numericUpDownRowLimit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLoad.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(154, 24);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load CSV";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxPathCSV
            // 
            this.textBoxPathCSV.AllowDrop = true;
            this.textBoxPathCSV.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPathCSV.Location = new System.Drawing.Point(172, 13);
            this.textBoxPathCSV.Name = "textBoxPathCSV";
            this.textBoxPathCSV.Size = new System.Drawing.Size(856, 19);
            this.textBoxPathCSV.TabIndex = 1;
            this.textBoxPathCSV.Text = "Drop the CSV here";
            this.textBoxPathCSV.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxPathCSV_DragDrop);
            this.textBoxPathCSV.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxPathCSV_DragEnter);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 42);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(1237, 376);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.Text = "dataGridView1";
            // 
            // comboBoxAttributes
            // 
            this.comboBoxAttributes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAttributes.FormattingEnabled = true;
            this.comboBoxAttributes.Location = new System.Drawing.Point(6, 55);
            this.comboBoxAttributes.Name = "comboBoxAttributes";
            this.comboBoxAttributes.Size = new System.Drawing.Size(177, 20);
            this.comboBoxAttributes.TabIndex = 3;
            this.comboBoxAttributes.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttributes_SelectedIndexChanged);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxType.Controls.Add(this.label3);
            this.groupBoxType.Controls.Add(this.radioButtonBool);
            this.groupBoxType.Controls.Add(this.radioButtonDateTime);
            this.groupBoxType.Controls.Add(this.radioButtonInt32);
            this.groupBoxType.Controls.Add(this.radioButtonInt64);
            this.groupBoxType.Controls.Add(this.radioButtonDouble);
            this.groupBoxType.Controls.Add(this.radioButtonString);
            this.groupBoxType.Controls.Add(this.comboBoxAttributes);
            this.groupBoxType.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxType.Location = new System.Drawing.Point(13, 544);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(207, 302);
            this.groupBoxType.TabIndex = 5;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Change Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Attribute:";
            // 
            // radioButtonBool
            // 
            this.radioButtonBool.AutoSize = true;
            this.radioButtonBool.Location = new System.Drawing.Point(6, 225);
            this.radioButtonBool.Name = "radioButtonBool";
            this.radioButtonBool.Size = new System.Drawing.Size(51, 16);
            this.radioButtonBool.TabIndex = 15;
            this.radioButtonBool.TabStop = true;
            this.radioButtonBool.Text = "Bool";
            this.radioButtonBool.UseVisualStyleBackColor = true;
            this.radioButtonBool.Click += new System.EventHandler(this.radioButtonBool_Click);
            // 
            // radioButtonDateTime
            // 
            this.radioButtonDateTime.AutoSize = true;
            this.radioButtonDateTime.Location = new System.Drawing.Point(6, 200);
            this.radioButtonDateTime.Name = "radioButtonDateTime";
            this.radioButtonDateTime.Size = new System.Drawing.Size(79, 16);
            this.radioButtonDateTime.TabIndex = 14;
            this.radioButtonDateTime.TabStop = true;
            this.radioButtonDateTime.Text = "DateTime";
            this.radioButtonDateTime.UseVisualStyleBackColor = true;
            this.radioButtonDateTime.Click += new System.EventHandler(this.radioButtonDateTime_Click);
            // 
            // radioButtonInt32
            // 
            this.radioButtonInt32.AutoSize = true;
            this.radioButtonInt32.Location = new System.Drawing.Point(6, 175);
            this.radioButtonInt32.Name = "radioButtonInt32";
            this.radioButtonInt32.Size = new System.Drawing.Size(58, 16);
            this.radioButtonInt32.TabIndex = 13;
            this.radioButtonInt32.TabStop = true;
            this.radioButtonInt32.Text = "Int32";
            this.radioButtonInt32.UseVisualStyleBackColor = true;
            this.radioButtonInt32.Click += new System.EventHandler(this.radioButtonInt32_Click);
            // 
            // radioButtonInt64
            // 
            this.radioButtonInt64.AutoSize = true;
            this.radioButtonInt64.Location = new System.Drawing.Point(6, 150);
            this.radioButtonInt64.Name = "radioButtonInt64";
            this.radioButtonInt64.Size = new System.Drawing.Size(58, 16);
            this.radioButtonInt64.TabIndex = 12;
            this.radioButtonInt64.TabStop = true;
            this.radioButtonInt64.Text = "Int64";
            this.radioButtonInt64.UseVisualStyleBackColor = true;
            this.radioButtonInt64.Click += new System.EventHandler(this.radioButtonInt64_Click);
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Location = new System.Drawing.Point(6, 125);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(65, 16);
            this.radioButtonDouble.TabIndex = 11;
            this.radioButtonDouble.TabStop = true;
            this.radioButtonDouble.Text = "Double";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            this.radioButtonDouble.Click += new System.EventHandler(this.radioButtonDouble_Click);
            // 
            // radioButtonString
            // 
            this.radioButtonString.AutoSize = true;
            this.radioButtonString.Location = new System.Drawing.Point(6, 100);
            this.radioButtonString.Name = "radioButtonString";
            this.radioButtonString.Size = new System.Drawing.Size(65, 16);
            this.radioButtonString.TabIndex = 10;
            this.radioButtonString.TabStop = true;
            this.radioButtonString.Text = "String";
            this.radioButtonString.UseVisualStyleBackColor = true;
            this.radioButtonString.Click += new System.EventHandler(this.radioButtonString_Click);
            // 
            // dataGridTypes
            // 
            this.dataGridTypes.AllowUserToAddRows = false;
            this.dataGridTypes.AllowUserToDeleteRows = false;
            this.dataGridTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTypes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypes.Location = new System.Drawing.Point(12, 424);
            this.dataGridTypes.Name = "dataGridTypes";
            this.dataGridTypes.Size = new System.Drawing.Size(1237, 114);
            this.dataGridTypes.TabIndex = 6;
            this.dataGridTypes.Text = "dataGridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownIntervalDistance);
            this.groupBox1.Controls.Add(this.dataGridDistribution);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelMeanValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonExecute);
            this.groupBox1.Controls.Add(this.comboBoxAttributeCalc);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(226, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 301);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(744, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interval Distance:";
            // 
            // numericUpDownIntervalDistance
            // 
            this.numericUpDownIntervalDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownIntervalDistance.DecimalPlaces = 2;
            this.numericUpDownIntervalDistance.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownIntervalDistance.Location = new System.Drawing.Point(881, 39);
            this.numericUpDownIntervalDistance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownIntervalDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalDistance.Name = "numericUpDownIntervalDistance";
            this.numericUpDownIntervalDistance.Size = new System.Drawing.Size(120, 15);
            this.numericUpDownIntervalDistance.TabIndex = 6;
            this.numericUpDownIntervalDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridDistribution
            // 
            this.dataGridDistribution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDistribution.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridDistribution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDistribution.Location = new System.Drawing.Point(29, 83);
            this.dataGridDistribution.Name = "dataGridDistribution";
            this.dataGridDistribution.Size = new System.Drawing.Size(972, 194);
            this.dataGridDistribution.TabIndex = 5;
            this.dataGridDistribution.Text = "dataGridView1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attribute:";
            // 
            // labelMeanValue
            // 
            this.labelMeanValue.AutoSize = true;
            this.labelMeanValue.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMeanValue.Location = new System.Drawing.Point(553, 45);
            this.labelMeanValue.Name = "labelMeanValue";
            this.labelMeanValue.Size = new System.Drawing.Size(12, 12);
            this.labelMeanValue.TabIndex = 3;
            this.labelMeanValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(507, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mean:";
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecute.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExecute.Location = new System.Drawing.Point(352, 41);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(105, 23);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.Calcolate_Click);
            // 
            // comboBoxAttributeCalc
            // 
            this.comboBoxAttributeCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAttributeCalc.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAttributeCalc.FormattingEnabled = true;
            this.comboBoxAttributeCalc.Location = new System.Drawing.Point(110, 43);
            this.comboBoxAttributeCalc.Name = "comboBoxAttributeCalc";
            this.comboBoxAttributeCalc.Size = new System.Drawing.Size(224, 20);
            this.comboBoxAttributeCalc.TabIndex = 0;
            this.comboBoxAttributeCalc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDownRowLimit
            // 
            this.numericUpDownRowLimit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownRowLimit.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownRowLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRowLimit.Location = new System.Drawing.Point(1129, 16);
            this.numericUpDownRowLimit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownRowLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownRowLimit.Name = "numericUpDownRowLimit";
            this.numericUpDownRowLimit.Size = new System.Drawing.Size(120, 15);
            this.numericUpDownRowLimit.TabIndex = 6;
            this.numericUpDownRowLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1048, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Row Limit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 878);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownRowLimit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridTypes);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBoxPathCSV);
            this.Controls.Add(this.buttonLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CSV Reader - Alessio Mobilia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxPathCSV;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox comboBoxAttributes;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonInt64;
        private System.Windows.Forms.RadioButton radioButtonDouble;
        private System.Windows.Forms.RadioButton radioButtonString;
        private System.Windows.Forms.RadioButton radioButtonBool;
        private System.Windows.Forms.RadioButton radioButtonDateTime;
        private System.Windows.Forms.RadioButton radioButtonInt32;
        private System.Windows.Forms.DataGridView dataGridTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Calcolate;
        private System.Windows.Forms.ComboBox comboBoxAttributeCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMeanValue;
        private System.Windows.Forms.DataGridView dataGridDistribution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalDistance;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.NumericUpDown numericUpDownRowLimit;
        private System.Windows.Forms.Label label5;
    }
}

