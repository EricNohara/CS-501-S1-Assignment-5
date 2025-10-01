namespace BMI_Calculator_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.tbBMIOutput = new System.Windows.Forms.TextBox();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnDisplayAverageBMI = new System.Windows.Forms.Button();
            this.tbAverageBMI = new System.Windows.Forms.TextBox();
            this.lbSaveStatus = new System.Windows.Forms.Label();
            this.bMIDatabaseDataSet = new BMI_Calculator_3.BMIDatabaseDataSet();
            this.bmiCalculationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bmiCalculationsTableAdapter = new BMI_Calculator_3.BMIDatabaseDataSetTableAdapters.BmiCalculationsTableAdapter();
            this.tableAdapterManager = new BMI_Calculator_3.BMIDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bmiCalculationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bmiCalculationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bmiCalculationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculationsBindingNavigator)).BeginInit();
            this.bmiCalculationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWeight.Location = new System.Drawing.Point(263, 195);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(278, 37);
            this.lbWeight.TabIndex = 1;
            this.lbWeight.Text = "Weight in Pounds:";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHeight.Location = new System.Drawing.Point(263, 286);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(254, 37);
            this.lbHeight.TabIndex = 2;
            this.lbHeight.Text = "Height in Inches:";
            this.lbHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGender.Location = new System.Drawing.Point(263, 390);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(132, 37);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "Gender:";
            this.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudWeight
            // 
            this.nudWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudWeight.Location = new System.Drawing.Point(628, 193);
            this.nudWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(268, 44);
            this.nudWeight.TabIndex = 4;
            this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHeight.Location = new System.Drawing.Point(628, 286);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(268, 44);
            this.nudHeight.TabIndex = 5;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(628, 387);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(268, 45);
            this.cbGender.TabIndex = 6;
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculateBMI.Location = new System.Drawing.Point(270, 502);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(264, 89);
            this.btnCalculateBMI.TabIndex = 7;
            this.btnCalculateBMI.Text = "Calculate BMI";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // tbBMIOutput
            // 
            this.tbBMIOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBMIOutput.Location = new System.Drawing.Point(628, 525);
            this.tbBMIOutput.Name = "tbBMIOutput";
            this.tbBMIOutput.ReadOnly = true;
            this.tbBMIOutput.Size = new System.Drawing.Size(268, 44);
            this.tbBMIOutput.TabIndex = 8;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveToDB.Location = new System.Drawing.Point(270, 694);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(264, 89);
            this.btnSaveToDB.TabIndex = 9;
            this.btnSaveToDB.Text = "Save to DB";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnDisplayAverageBMI
            // 
            this.btnDisplayAverageBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDisplayAverageBMI.Location = new System.Drawing.Point(573, 694);
            this.btnDisplayAverageBMI.Name = "btnDisplayAverageBMI";
            this.btnDisplayAverageBMI.Size = new System.Drawing.Size(323, 89);
            this.btnDisplayAverageBMI.TabIndex = 10;
            this.btnDisplayAverageBMI.Text = "Display Average BMI";
            this.btnDisplayAverageBMI.UseVisualStyleBackColor = true;
            this.btnDisplayAverageBMI.Click += new System.EventHandler(this.btnDisplayAverageBMI_Click);
            // 
            // tbAverageBMI
            // 
            this.tbAverageBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAverageBMI.Location = new System.Drawing.Point(270, 842);
            this.tbAverageBMI.Name = "tbAverageBMI";
            this.tbAverageBMI.ReadOnly = true;
            this.tbAverageBMI.Size = new System.Drawing.Size(626, 44);
            this.tbAverageBMI.TabIndex = 11;
            this.tbAverageBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSaveStatus
            // 
            this.lbSaveStatus.AutoSize = true;
            this.lbSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSaveStatus.Location = new System.Drawing.Point(265, 648);
            this.lbSaveStatus.Name = "lbSaveStatus";
            this.lbSaveStatus.Size = new System.Drawing.Size(0, 31);
            this.lbSaveStatus.TabIndex = 12;
            // 
            // bMIDatabaseDataSet
            // 
            this.bMIDatabaseDataSet.DataSetName = "BMIDatabaseDataSet";
            this.bMIDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bmiCalculationsBindingSource
            // 
            this.bmiCalculationsBindingSource.DataMember = "BmiCalculations";
            this.bmiCalculationsBindingSource.DataSource = this.bMIDatabaseDataSet;
            // 
            // bmiCalculationsTableAdapter
            // 
            this.bmiCalculationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BmiCalculationsTableAdapter = this.bmiCalculationsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BMI_Calculator_3.BMIDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bmiCalculationsBindingNavigator
            // 
            this.bmiCalculationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bmiCalculationsBindingNavigator.BindingSource = this.bmiCalculationsBindingSource;
            this.bmiCalculationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bmiCalculationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bmiCalculationsBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bmiCalculationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bmiCalculationsBindingNavigatorSaveItem});
            this.bmiCalculationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bmiCalculationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bmiCalculationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bmiCalculationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bmiCalculationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bmiCalculationsBindingNavigator.Name = "bmiCalculationsBindingNavigator";
            this.bmiCalculationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bmiCalculationsBindingNavigator.Size = new System.Drawing.Size(1723, 50);
            this.bmiCalculationsBindingNavigator.TabIndex = 13;
            this.bmiCalculationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // bmiCalculationsBindingNavigatorSaveItem
            // 
            this.bmiCalculationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bmiCalculationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bmiCalculationsBindingNavigatorSaveItem.Image")));
            this.bmiCalculationsBindingNavigatorSaveItem.Name = "bmiCalculationsBindingNavigatorSaveItem";
            this.bmiCalculationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.bmiCalculationsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bmiCalculationsDataGridView
            // 
            this.bmiCalculationsDataGridView.AutoGenerateColumns = false;
            this.bmiCalculationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bmiCalculationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bmiCalculationsDataGridView.DataSource = this.bmiCalculationsBindingSource;
            this.bmiCalculationsDataGridView.Location = new System.Drawing.Point(1014, 193);
            this.bmiCalculationsDataGridView.Name = "bmiCalculationsDataGridView";
            this.bmiCalculationsDataGridView.RowHeadersWidth = 40;
            this.bmiCalculationsDataGridView.RowTemplate.Height = 33;
            this.bmiCalculationsDataGridView.Size = new System.Drawing.Size(485, 693);
            this.bmiCalculationsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Bmi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bmi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 1098);
            this.Controls.Add(this.bmiCalculationsDataGridView);
            this.Controls.Add(this.bmiCalculationsBindingNavigator);
            this.Controls.Add(this.lbSaveStatus);
            this.Controls.Add(this.tbAverageBMI);
            this.Controls.Add(this.btnDisplayAverageBMI);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.tbBMIOutput);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculationsBindingNavigator)).EndInit();
            this.bmiCalculationsBindingNavigator.ResumeLayout(false);
            this.bmiCalculationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.TextBox tbBMIOutput;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnDisplayAverageBMI;
        private System.Windows.Forms.TextBox tbAverageBMI;
        private System.Windows.Forms.Label lbSaveStatus;
        private BMIDatabaseDataSet bMIDatabaseDataSet;
        private System.Windows.Forms.BindingSource bmiCalculationsBindingSource;
        private BMIDatabaseDataSetTableAdapters.BmiCalculationsTableAdapter bmiCalculationsTableAdapter;
        private BMIDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bmiCalculationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bmiCalculationsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bmiCalculationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

