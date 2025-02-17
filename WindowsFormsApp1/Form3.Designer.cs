namespace WindowsFormsApp1
{
    partial class Upper_material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upper_material));
            this.каталог_взуттяDataSet = new WindowsFormsApp1.Каталог_взуттяDataSet();
            this.матеріал_верхаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.матеріал_верхаTableAdapter = new WindowsFormsApp1.Каталог_взуттяDataSetTableAdapters.Матеріал_верхаTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Каталог_взуттяDataSetTableAdapters.TableAdapterManager();
            this.матеріал_верхаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.матеріал_верхаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.матеріал_верхаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_взуттяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.матеріал_верхаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.матеріал_верхаBindingNavigator)).BeginInit();
            this.матеріал_верхаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.матеріал_верхаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // каталог_взуттяDataSet
            // 
            this.каталог_взуттяDataSet.DataSetName = "Каталог_взуттяDataSet";
            this.каталог_взуттяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // матеріал_верхаBindingSource
            // 
            this.матеріал_верхаBindingSource.DataMember = "Матеріал верха";
            this.матеріал_верхаBindingSource.DataSource = this.каталог_взуттяDataSet;
            // 
            // матеріал_верхаTableAdapter
            // 
            this.матеріал_верхаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Каталог_взуттяDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БрендTableAdapter = null;
            this.tableAdapterManager.Каталог_взуттяTableAdapter = null;
            this.tableAdapterManager.КраїнаTableAdapter = null;
            this.tableAdapterManager.Матеріал_верхаTableAdapter = this.матеріал_верхаTableAdapter;
            this.tableAdapterManager.Матеріал_підошвиTableAdapter = null;
            this.tableAdapterManager.Цільова_аудиторіяTableAdapter = null;
            // 
            // матеріал_верхаBindingNavigator
            // 
            this.матеріал_верхаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.матеріал_верхаBindingNavigator.BindingSource = this.матеріал_верхаBindingSource;
            this.матеріал_верхаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.матеріал_верхаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.матеріал_верхаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.матеріал_верхаBindingNavigatorSaveItem});
            this.матеріал_верхаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.матеріал_верхаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.матеріал_верхаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.матеріал_верхаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.матеріал_верхаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.матеріал_верхаBindingNavigator.Name = "матеріал_верхаBindingNavigator";
            this.матеріал_верхаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.матеріал_верхаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.матеріал_верхаBindingNavigator.TabIndex = 0;
            this.матеріал_верхаBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // матеріал_верхаBindingNavigatorSaveItem
            // 
            this.матеріал_верхаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.матеріал_верхаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("матеріал_верхаBindingNavigatorSaveItem.Image")));
            this.матеріал_верхаBindingNavigatorSaveItem.Name = "матеріал_верхаBindingNavigatorSaveItem";
            this.матеріал_верхаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.матеріал_верхаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.матеріал_верхаBindingNavigatorSaveItem.Click += new System.EventHandler(this.матеріал_верхаBindingNavigatorSaveItem_Click);
            // 
            // матеріал_верхаDataGridView
            // 
            this.матеріал_верхаDataGridView.AutoGenerateColumns = false;
            this.матеріал_верхаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.матеріал_верхаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.матеріал_верхаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.матеріал_верхаDataGridView.DataSource = this.матеріал_верхаBindingSource;
            this.матеріал_верхаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.матеріал_верхаDataGridView.Location = new System.Drawing.Point(0, 25);
            this.матеріал_верхаDataGridView.Name = "матеріал_верхаDataGridView";
            this.матеріал_верхаDataGridView.Size = new System.Drawing.Size(800, 425);
            this.матеріал_верхаDataGridView.TabIndex = 1;
            this.матеріал_верхаDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.матеріал_верхаDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Upper_material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.матеріал_верхаDataGridView);
            this.Controls.Add(this.матеріал_верхаBindingNavigator);
            this.DoubleBuffered = true;
            this.Name = "Upper_material";
            this.Text = "Матеріал верха";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.каталог_взуттяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.матеріал_верхаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.матеріал_верхаBindingNavigator)).EndInit();
            this.матеріал_верхаBindingNavigator.ResumeLayout(false);
            this.матеріал_верхаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.матеріал_верхаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Каталог_взуттяDataSet каталог_взуттяDataSet;
        private System.Windows.Forms.BindingSource матеріал_верхаBindingSource;
        private Каталог_взуттяDataSetTableAdapters.Матеріал_верхаTableAdapter матеріал_верхаTableAdapter;
        private Каталог_взуттяDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator матеріал_верхаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton матеріал_верхаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView матеріал_верхаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}