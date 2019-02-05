namespace Craps
{
    partial class FormUpdateName
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
            this.BtnAcceptNameUpdate = new System.Windows.Forms.Button();
            this.BtnCancelUpdateName = new System.Windows.Forms.Button();
            this.TextUpdateName = new System.Windows.Forms.TextBox();
            this.LblUpdateName = new System.Windows.Forms.Label();
            this.crapsDataSet = new Craps.CrapsDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Craps.CrapsDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new Craps.CrapsDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAcceptNameUpdate
            // 
            this.BtnAcceptNameUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAcceptNameUpdate.Location = new System.Drawing.Point(12, 54);
            this.BtnAcceptNameUpdate.Name = "BtnAcceptNameUpdate";
            this.BtnAcceptNameUpdate.Size = new System.Drawing.Size(129, 23);
            this.BtnAcceptNameUpdate.TabIndex = 0;
            this.BtnAcceptNameUpdate.Text = "Submit";
            this.BtnAcceptNameUpdate.UseVisualStyleBackColor = true;
            this.BtnAcceptNameUpdate.Click += new System.EventHandler(this.BtnAcceptNameUpdate_Click);
            // 
            // BtnCancelUpdateName
            // 
            this.BtnCancelUpdateName.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelUpdateName.Location = new System.Drawing.Point(147, 54);
            this.BtnCancelUpdateName.Name = "BtnCancelUpdateName";
            this.BtnCancelUpdateName.Size = new System.Drawing.Size(108, 23);
            this.BtnCancelUpdateName.TabIndex = 1;
            this.BtnCancelUpdateName.Text = "Cancel";
            this.BtnCancelUpdateName.UseVisualStyleBackColor = true;
            this.BtnCancelUpdateName.Click += new System.EventHandler(this.BtnCancelUpdateName_Click);
            // 
            // TextUpdateName
            // 
            this.TextUpdateName.Location = new System.Drawing.Point(12, 28);
            this.TextUpdateName.MaxLength = 25;
            this.TextUpdateName.Name = "TextUpdateName";
            this.TextUpdateName.Size = new System.Drawing.Size(243, 20);
            this.TextUpdateName.TabIndex = 1;
            this.TextUpdateName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextUpdateName_KeyDown);
            // 
            // LblUpdateName
            // 
            this.LblUpdateName.AutoSize = true;
            this.LblUpdateName.Location = new System.Drawing.Point(12, 9);
            this.LblUpdateName.Name = "LblUpdateName";
            this.LblUpdateName.Size = new System.Drawing.Size(91, 13);
            this.LblUpdateName.TabIndex = 3;
            this.LblUpdateName.Text = "Change name to?";
            // 
            // crapsDataSet
            // 
            this.crapsDataSet.DataSetName = "CrapsDataSet";
            this.crapsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.crapsDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.RollTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Craps.CrapsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // FormUpdateName
            // 
            this.AcceptButton = this.BtnAcceptNameUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelUpdateName;
            this.ClientSize = new System.Drawing.Size(276, 88);
            this.ControlBox = false;
            this.Controls.Add(this.LblUpdateName);
            this.Controls.Add(this.TextUpdateName);
            this.Controls.Add(this.BtnCancelUpdateName);
            this.Controls.Add(this.BtnAcceptNameUpdate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Name";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormUpdateName_Load);
            this.Shown += new System.EventHandler(this.FormUpdateName_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAcceptNameUpdate;
        private System.Windows.Forms.Button BtnCancelUpdateName;
        private System.Windows.Forms.Label LblUpdateName;
        private CrapsDataSet crapsDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private CrapsDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private CrapsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        internal System.Windows.Forms.TextBox TextUpdateName;
    }
}