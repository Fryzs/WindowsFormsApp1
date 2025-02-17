namespace WindowsFormsApp1
{
    partial class Target_audience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Target_audience));
            this.каталог_взуттяDataSet = new WindowsFormsApp1.Каталог_взуттяDataSet();
            this.цільова_аудиторіяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цільова_аудиторіяTableAdapter = new WindowsFormsApp1.Каталог_взуттяDataSetTableAdapters.Цільова_аудиторіяTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Каталог_взуттяDataSetTableAdapters.TableAdapterManager();
            this.цільова_аудиторіяBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.цільова_аудиторіяBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.цільова_аудиторіяDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_взуттяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цільова_аудиторіяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цільова_аудиторіяBindingNavigator)).BeginInit();
            this.цільова_аудиторіяBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.цільова_аудиторіяDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // каталог_взуттяDataSet
            // 
            this.каталог_взуттяDataSet.DataSetName = "Каталог_взуттяDataSet";
            this.каталог_взуттяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цільова_аудиторіяBindingSource
            // 
            this.цільова_аудиторіяBindingSource.DataMember = "Цільова аудиторія";
            this.цільова_аудиторіяBindingSource.DataSource = this.каталог_взуттяDataSet;
            // 
            // цільова_аудиторіяTableAdapter
            // 
            this.цільова_аудиторіяTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Каталог_взуттяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БрендTableAdapter = null;
            this.tableAdapterManager.Каталог_взуттяTableAdapter = null;
            this.tableAdapterManager.КраїнаTableAdapter = null;
            this.tableAdapterManager.Матеріал_верхаTableAdapter = null;
            this.tableAdapterManager.Матеріал_підошвиTableAdapter = null;
            this.tableAdapterManager.Цільова_аудиторіяTableAdapter = this.цільова_аудиторіяTableAdapter;
            // 
            // цільова_аудиторіяBindingNavigator
            // 
            this.цільова_аудиторіяBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.цільова_аудиторіяBindingNavigator.BindingSource = this.цільова_аудиторіяBindingSource;
            this.цільова_аудиторіяBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.цільова_аудиторіяBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.цільова_аудиторіяBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.цільова_аудиторіяBindingNavigatorSaveItem});
            this.цільова_аудиторіяBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.цільова_аудиторіяBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.цільова_аудиторіяBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.цільова_аудиторіяBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.цільова_аудиторіяBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.цільова_аудиторіяBindingNavigator.Name = "цільова_аудиторіяBindingNavigator";
            this.цільова_аудиторіяBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.цільова_аудиторіяBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.цільова_аудиторіяBindingNavigator.TabIndex = 0;
            this.цільова_аудиторіяBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // цільова_аудиторіяBindingNavigatorSaveItem
            // 
            this.цільова_аудиторіяBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.цільова_аудиторіяBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("цільова_аудиторіяBindingNavigatorSaveItem.Image")));
            this.цільова_аудиторіяBindingNavigatorSaveItem.Name = "цільова_аудиторіяBindingNavigatorSaveItem";
            this.цільова_аудиторіяBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.цільова_аудиторіяBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.цільова_аудиторіяBindingNavigatorSaveItem.Click += new System.EventHandler(this.цільова_аудиторіяBindingNavigatorSaveItem_Click);
            // 
            // цільова_аудиторіяDataGridView
            // 
            this.цільова_аудиторіяDataGridView.AutoGenerateColumns = false;
            this.цільова_аудиторіяDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.цільова_аудиторіяDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.цільова_аудиторіяDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.цільова_аудиторіяDataGridView.DataSource = this.цільова_аудиторіяBindingSource;
            this.цільова_аудиторіяDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.цільова_аудиторіяDataGridView.Location = new System.Drawing.Point(0, 25);
            this.цільова_аудиторіяDataGridView.Name = "цільова_аудиторіяDataGridView";
            this.цільова_аудиторіяDataGridView.Size = new System.Drawing.Size(800, 425);
            this.цільова_аудиторіяDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Стать";
            this.dataGridViewTextBoxColumn2.HeaderText = "Стать";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вік";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вік";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Target_audience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.цільова_аудиторіяDataGridView);
            this.Controls.Add(this.цільова_аудиторіяBindingNavigator);
            this.Name = "Target_audience";
            this.Text = "Цільова аудиторія";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.каталог_взуттяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цільова_аудиторіяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цільова_аудиторіяBindingNavigator)).EndInit();
            this.цільова_аудиторіяBindingNavigator.ResumeLayout(false);
            this.цільова_аудиторіяBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.цільова_аудиторіяDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Каталог_взуттяDataSet каталог_взуттяDataSet;
        private System.Windows.Forms.BindingSource цільова_аудиторіяBindingSource;
        private Каталог_взуттяDataSetTableAdapters.Цільова_аудиторіяTableAdapter цільова_аудиторіяTableAdapter;
        private Каталог_взуттяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator цільова_аудиторіяBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton цільова_аудиторіяBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView цільова_аудиторіяDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}