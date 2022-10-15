namespace DroneServiceApplication
{
    partial class FormDroneServiceApplication
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
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelDroneModel = new System.Windows.Forms.Label();
            this.labelServiceProblem = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxDroneModel = new System.Windows.Forms.TextBox();
            this.textBoxServiceProblem = new System.Windows.Forms.TextBox();
            this.labelServiceCost = new System.Windows.Forms.Label();
            this.textBoxServiceCost = new System.Windows.Forms.TextBox();
            this.labelServiceText = new System.Windows.Forms.Label();
            this.numericUpDownServiceTag = new System.Windows.Forms.NumericUpDown();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.groupBoxQueue = new System.Windows.Forms.GroupBox();
            this.radioButtonExpress = new System.Windows.Forms.RadioButton();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.listViewRegularQueue = new System.Windows.Forms.ListView();
            this.columnHeaderClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewExpressQueue = new System.Windows.Forms.ListView();
            this.listBoxFinishedList = new System.Windows.Forms.ListBox();
            this.labelFinishedList = new System.Windows.Forms.Label();
            this.buttonRemoveFromExpressQueue = new System.Windows.Forms.Button();
            this.buttonRemoveFromRegularQueue = new System.Windows.Forms.Button();
            this.labelRegularQueue = new System.Windows.Forms.Label();
            this.labelExpressQueue = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.columnHeaderDroneModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServiceTag)).BeginInit();
            this.groupBoxQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(12, 27);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(67, 13);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "Client Name:";
            // 
            // labelDroneModel
            // 
            this.labelDroneModel.AutoSize = true;
            this.labelDroneModel.Location = new System.Drawing.Point(463, 27);
            this.labelDroneModel.Name = "labelDroneModel";
            this.labelDroneModel.Size = new System.Drawing.Size(71, 13);
            this.labelDroneModel.TabIndex = 2;
            this.labelDroneModel.Text = "Drone Model:";
            // 
            // labelServiceProblem
            // 
            this.labelServiceProblem.AutoSize = true;
            this.labelServiceProblem.Location = new System.Drawing.Point(11, 53);
            this.labelServiceProblem.Name = "labelServiceProblem";
            this.labelServiceProblem.Size = new System.Drawing.Size(87, 13);
            this.labelServiceProblem.TabIndex = 4;
            this.labelServiceProblem.Text = "Service Problem:";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(106, 20);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(349, 20);
            this.textBoxClientName.TabIndex = 1;
            // 
            // textBoxDroneModel
            // 
            this.textBoxDroneModel.Location = new System.Drawing.Point(540, 20);
            this.textBoxDroneModel.Name = "textBoxDroneModel";
            this.textBoxDroneModel.Size = new System.Drawing.Size(287, 20);
            this.textBoxDroneModel.TabIndex = 3;
            // 
            // textBoxServiceProblem
            // 
            this.textBoxServiceProblem.Location = new System.Drawing.Point(106, 46);
            this.textBoxServiceProblem.Multiline = true;
            this.textBoxServiceProblem.Name = "textBoxServiceProblem";
            this.textBoxServiceProblem.Size = new System.Drawing.Size(349, 102);
            this.textBoxServiceProblem.TabIndex = 5;
            // 
            // labelServiceCost
            // 
            this.labelServiceCost.AutoSize = true;
            this.labelServiceCost.Location = new System.Drawing.Point(463, 53);
            this.labelServiceCost.Name = "labelServiceCost";
            this.labelServiceCost.Size = new System.Drawing.Size(70, 13);
            this.labelServiceCost.TabIndex = 6;
            this.labelServiceCost.Text = "Service Cost:";
            // 
            // textBoxServiceCost
            // 
            this.textBoxServiceCost.Location = new System.Drawing.Point(540, 46);
            this.textBoxServiceCost.Name = "textBoxServiceCost";
            this.textBoxServiceCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxServiceCost.TabIndex = 7;
            this.textBoxServiceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxServiceCost_KeyPress);
            // 
            // labelServiceText
            // 
            this.labelServiceText.AutoSize = true;
            this.labelServiceText.Location = new System.Drawing.Point(463, 78);
            this.labelServiceText.Name = "labelServiceText";
            this.labelServiceText.Size = new System.Drawing.Size(68, 13);
            this.labelServiceText.TabIndex = 8;
            this.labelServiceText.Text = "Service Tag:";
            // 
            // numericUpDownServiceTag
            // 
            this.numericUpDownServiceTag.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownServiceTag.Location = new System.Drawing.Point(540, 71);
            this.numericUpDownServiceTag.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numericUpDownServiceTag.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownServiceTag.Name = "numericUpDownServiceTag";
            this.numericUpDownServiceTag.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownServiceTag.TabIndex = 9;
            this.numericUpDownServiceTag.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Location = new System.Drawing.Point(802, 125);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(104, 23);
            this.buttonAddNewItem.TabIndex = 11;
            this.buttonAddNewItem.Text = "ADD NEW ITEM";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            this.buttonAddNewItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddNewItem);
            // 
            // groupBoxQueue
            // 
            this.groupBoxQueue.Controls.Add(this.radioButtonExpress);
            this.groupBoxQueue.Controls.Add(this.radioButtonRegular);
            this.groupBoxQueue.Location = new System.Drawing.Point(466, 106);
            this.groupBoxQueue.Name = "groupBoxQueue";
            this.groupBoxQueue.Size = new System.Drawing.Size(330, 43);
            this.groupBoxQueue.TabIndex = 10;
            this.groupBoxQueue.TabStop = false;
            this.groupBoxQueue.Text = "Queue:";
            // 
            // radioButtonExpress
            // 
            this.radioButtonExpress.AutoSize = true;
            this.radioButtonExpress.Location = new System.Drawing.Point(136, 19);
            this.radioButtonExpress.Name = "radioButtonExpress";
            this.radioButtonExpress.Size = new System.Drawing.Size(62, 17);
            this.radioButtonExpress.TabIndex = 1;
            this.radioButtonExpress.Text = "Express";
            this.radioButtonExpress.UseVisualStyleBackColor = true;
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Checked = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(19, 19);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRegular.TabIndex = 0;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "Regular";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // listViewRegularQueue
            // 
            this.listViewRegularQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClientName,
            this.columnHeaderDroneModel});
            this.listViewRegularQueue.HideSelection = false;
            this.listViewRegularQueue.Location = new System.Drawing.Point(15, 190);
            this.listViewRegularQueue.Name = "listViewRegularQueue";
            this.listViewRegularQueue.Size = new System.Drawing.Size(440, 207);
            this.listViewRegularQueue.TabIndex = 13;
            this.listViewRegularQueue.UseCompatibleStateImageBehavior = false;
            this.listViewRegularQueue.View = System.Windows.Forms.View.Details;
            this.listViewRegularQueue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewRegularQueue_MouseClick);
            // 
            // columnHeaderClientName
            // 
            this.columnHeaderClientName.Text = "Client Name";
            this.columnHeaderClientName.Width = 75;
            // 
            // listViewExpressQueue
            // 
            this.listViewExpressQueue.HideSelection = false;
            this.listViewExpressQueue.Location = new System.Drawing.Point(466, 190);
            this.listViewExpressQueue.Name = "listViewExpressQueue";
            this.listViewExpressQueue.Size = new System.Drawing.Size(440, 207);
            this.listViewExpressQueue.TabIndex = 16;
            this.listViewExpressQueue.UseCompatibleStateImageBehavior = false;
            this.listViewExpressQueue.View = System.Windows.Forms.View.Details;
            this.listViewExpressQueue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewExpressQueue_MouseClick);
            // 
            // listBoxFinishedList
            // 
            this.listBoxFinishedList.FormattingEnabled = true;
            this.listBoxFinishedList.Location = new System.Drawing.Point(15, 448);
            this.listBoxFinishedList.Name = "listBoxFinishedList";
            this.listBoxFinishedList.Size = new System.Drawing.Size(891, 199);
            this.listBoxFinishedList.TabIndex = 19;
            this.listBoxFinishedList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxFinishedList_MouseDoubleClick);
            // 
            // labelFinishedList
            // 
            this.labelFinishedList.AutoSize = true;
            this.labelFinishedList.Location = new System.Drawing.Point(15, 429);
            this.labelFinishedList.Name = "labelFinishedList";
            this.labelFinishedList.Size = new System.Drawing.Size(68, 13);
            this.labelFinishedList.TabIndex = 18;
            this.labelFinishedList.Text = "Finished List:";
            // 
            // buttonRemoveFromExpressQueue
            // 
            this.buttonRemoveFromExpressQueue.Location = new System.Drawing.Point(706, 403);
            this.buttonRemoveFromExpressQueue.Name = "buttonRemoveFromExpressQueue";
            this.buttonRemoveFromExpressQueue.Size = new System.Drawing.Size(201, 23);
            this.buttonRemoveFromExpressQueue.TabIndex = 17;
            this.buttonRemoveFromExpressQueue.Text = "REMOVE FROM EXPRESS QUEUE";
            this.buttonRemoveFromExpressQueue.UseVisualStyleBackColor = true;
            this.buttonRemoveFromExpressQueue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRemoveFromExpressQueue_MouseClick);
            // 
            // buttonRemoveFromRegularQueue
            // 
            this.buttonRemoveFromRegularQueue.Location = new System.Drawing.Point(255, 403);
            this.buttonRemoveFromRegularQueue.Name = "buttonRemoveFromRegularQueue";
            this.buttonRemoveFromRegularQueue.Size = new System.Drawing.Size(201, 23);
            this.buttonRemoveFromRegularQueue.TabIndex = 14;
            this.buttonRemoveFromRegularQueue.Text = "REMOVE FROM REGULAR QUEUE";
            this.buttonRemoveFromRegularQueue.UseVisualStyleBackColor = true;
            this.buttonRemoveFromRegularQueue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRemoveFromRegularQueue_MouseClick);
            // 
            // labelRegularQueue
            // 
            this.labelRegularQueue.AutoSize = true;
            this.labelRegularQueue.Location = new System.Drawing.Point(15, 174);
            this.labelRegularQueue.Name = "labelRegularQueue";
            this.labelRegularQueue.Size = new System.Drawing.Size(82, 13);
            this.labelRegularQueue.TabIndex = 12;
            this.labelRegularQueue.Text = "Regular Queue:";
            // 
            // labelExpressQueue
            // 
            this.labelExpressQueue.AutoSize = true;
            this.labelExpressQueue.Location = new System.Drawing.Point(466, 174);
            this.labelExpressQueue.Name = "labelExpressQueue";
            this.labelExpressQueue.Size = new System.Drawing.Size(82, 13);
            this.labelExpressQueue.TabIndex = 15;
            this.labelExpressQueue.Text = "Express Queue:";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 673);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(923, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 20;
            this.statusStrip.Text = "statusStrip";
            // 
            // columnHeaderDroneModel
            // 
            this.columnHeaderDroneModel.Text = "Drone Model";
            this.columnHeaderDroneModel.Width = 82;
            // 
            // FormDroneServiceApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 695);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelExpressQueue);
            this.Controls.Add(this.labelRegularQueue);
            this.Controls.Add(this.buttonRemoveFromRegularQueue);
            this.Controls.Add(this.listViewExpressQueue);
            this.Controls.Add(this.listViewRegularQueue);
            this.Controls.Add(this.buttonRemoveFromExpressQueue);
            this.Controls.Add(this.labelFinishedList);
            this.Controls.Add(this.listBoxFinishedList);
            this.Controls.Add(this.groupBoxQueue);
            this.Controls.Add(this.buttonAddNewItem);
            this.Controls.Add(this.numericUpDownServiceTag);
            this.Controls.Add(this.labelServiceText);
            this.Controls.Add(this.textBoxServiceCost);
            this.Controls.Add(this.labelServiceCost);
            this.Controls.Add(this.textBoxServiceProblem);
            this.Controls.Add(this.textBoxDroneModel);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelServiceProblem);
            this.Controls.Add(this.labelDroneModel);
            this.Controls.Add(this.labelClientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDroneServiceApplication";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Drone Service Application";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServiceTag)).EndInit();
            this.groupBoxQueue.ResumeLayout(false);
            this.groupBoxQueue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelDroneModel;
        private System.Windows.Forms.Label labelServiceProblem;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxDroneModel;
        private System.Windows.Forms.TextBox textBoxServiceProblem;
        private System.Windows.Forms.Label labelServiceCost;
        private System.Windows.Forms.TextBox textBoxServiceCost;
        private System.Windows.Forms.Label labelServiceText;
        private System.Windows.Forms.NumericUpDown numericUpDownServiceTag;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.GroupBox groupBoxQueue;
        private System.Windows.Forms.RadioButton radioButtonExpress;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.ListView listViewRegularQueue;
        private System.Windows.Forms.ListView listViewExpressQueue;
        private System.Windows.Forms.ListBox listBoxFinishedList;
        private System.Windows.Forms.Label labelFinishedList;
        private System.Windows.Forms.Button buttonRemoveFromExpressQueue;
        private System.Windows.Forms.ColumnHeader columnHeaderClientName;
        private System.Windows.Forms.Button buttonRemoveFromRegularQueue;
        private System.Windows.Forms.Label labelRegularQueue;
        private System.Windows.Forms.Label labelExpressQueue;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ColumnHeader columnHeaderDroneModel;
    }
}

