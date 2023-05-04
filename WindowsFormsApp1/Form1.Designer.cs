namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TouristsPage = new System.Windows.Forms.TabPage();
            this.TouristInfoPage = new System.Windows.Forms.TabPage();
            this.ToursPage = new System.Windows.Forms.TabPage();
            this.SeasonsPage = new System.Windows.Forms.TabPage();
            this.PaidPage = new System.Windows.Forms.TabPage();
            this.TravelsPackagePage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImpDocument = new System.Windows.Forms.Button();
            this.ExpDocument = new System.Windows.Forms.Button();
            this.ImpReader = new System.Windows.Forms.Button();
            this.ExpWriter = new System.Windows.Forms.Button();
            this.ParamSelect = new System.Windows.Forms.RichTextBox();
            this.ConfigParamSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmAggrSelect = new System.Windows.Forms.Button();
            this.AggSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Trigger = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.AddBtn, "AddBtn");
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TouristsPage);
            this.tabControl1.Controls.Add(this.TouristInfoPage);
            this.tabControl1.Controls.Add(this.ToursPage);
            this.tabControl1.Controls.Add(this.SeasonsPage);
            this.tabControl1.Controls.Add(this.PaidPage);
            this.tabControl1.Controls.Add(this.TravelsPackagePage);
            this.tabControl1.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.IfSelected);
            // 
            // TouristsPage
            // 
            resources.ApplyResources(this.TouristsPage, "TouristsPage");
            this.TouristsPage.Name = "TouristsPage";
            this.TouristsPage.UseVisualStyleBackColor = true;
            // 
            // TouristInfoPage
            // 
            resources.ApplyResources(this.TouristInfoPage, "TouristInfoPage");
            this.TouristInfoPage.Name = "TouristInfoPage";
            this.TouristInfoPage.UseVisualStyleBackColor = true;
            // 
            // ToursPage
            // 
            resources.ApplyResources(this.ToursPage, "ToursPage");
            this.ToursPage.Name = "ToursPage";
            this.ToursPage.UseVisualStyleBackColor = true;
            // 
            // SeasonsPage
            // 
            resources.ApplyResources(this.SeasonsPage, "SeasonsPage");
            this.SeasonsPage.Name = "SeasonsPage";
            this.SeasonsPage.UseVisualStyleBackColor = true;
            // 
            // PaidPage
            // 
            resources.ApplyResources(this.PaidPage, "PaidPage");
            this.PaidPage.Name = "PaidPage";
            this.PaidPage.UseVisualStyleBackColor = true;
            // 
            // TravelsPackagePage
            // 
            resources.ApplyResources(this.TravelsPackagePage, "TravelsPackagePage");
            this.TravelsPackagePage.Name = "TravelsPackagePage";
            this.TravelsPackagePage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // ChangeBtn
            // 
            resources.ApplyResources(this.ChangeBtn, "ChangeBtn");
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteBtn
            // 
            resources.ApplyResources(this.DeleteBtn, "DeleteBtn");
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImpDocument);
            this.panel1.Controls.Add(this.ExpDocument);
            this.panel1.Controls.Add(this.ImpReader);
            this.panel1.Controls.Add(this.ExpWriter);
            this.panel1.Controls.Add(this.ParamSelect);
            this.panel1.Controls.Add(this.ConfigParamSelect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ConfirmAggrSelect);
            this.panel1.Controls.Add(this.AggSelect);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ImpDocument
            // 
            resources.ApplyResources(this.ImpDocument, "ImpDocument");
            this.ImpDocument.Name = "ImpDocument";
            this.ImpDocument.UseVisualStyleBackColor = true;
            this.ImpDocument.Click += new System.EventHandler(this.ImpDocument_Click);
            // 
            // ExpDocument
            // 
            resources.ApplyResources(this.ExpDocument, "ExpDocument");
            this.ExpDocument.Name = "ExpDocument";
            this.ExpDocument.UseVisualStyleBackColor = true;
            this.ExpDocument.Click += new System.EventHandler(this.ExpDocument_Click);
            // 
            // ImpReader
            // 
            resources.ApplyResources(this.ImpReader, "ImpReader");
            this.ImpReader.Name = "ImpReader";
            this.ImpReader.UseVisualStyleBackColor = true;
            this.ImpReader.Click += new System.EventHandler(this.ImpReader_Click);
            // 
            // ExpWriter
            // 
            resources.ApplyResources(this.ExpWriter, "ExpWriter");
            this.ExpWriter.Name = "ExpWriter";
            this.ExpWriter.UseVisualStyleBackColor = true;
            this.ExpWriter.Click += new System.EventHandler(this.ExpWriter_Click);
            // 
            // ParamSelect
            // 
            resources.ApplyResources(this.ParamSelect, "ParamSelect");
            this.ParamSelect.Name = "ParamSelect";
            // 
            // ConfigParamSelect
            // 
            resources.ApplyResources(this.ConfigParamSelect, "ConfigParamSelect");
            this.ConfigParamSelect.Name = "ConfigParamSelect";
            this.ConfigParamSelect.UseVisualStyleBackColor = true;
            this.ConfigParamSelect.Click += new System.EventHandler(this.ConfigParamSelect_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ConfirmAggrSelect
            // 
            resources.ApplyResources(this.ConfirmAggrSelect, "ConfirmAggrSelect");
            this.ConfirmAggrSelect.Name = "ConfirmAggrSelect";
            this.ConfirmAggrSelect.UseVisualStyleBackColor = true;
            this.ConfirmAggrSelect.Click += new System.EventHandler(this.ConfirmAggrSelect_Click);
            // 
            // AggSelect
            // 
            resources.ApplyResources(this.AggSelect, "AggSelect");
            this.AggSelect.Name = "AggSelect";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Trigger
            // 
            resources.ApplyResources(this.Trigger, "Trigger");
            this.Trigger.Name = "Trigger";
            this.Trigger.UseVisualStyleBackColor = true;
            this.Trigger.Click += new System.EventHandler(this.Trigger_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Trigger);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TouristsPage;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage TouristInfoPage;
        private System.Windows.Forms.TabPage ToursPage;
        private System.Windows.Forms.TabPage SeasonsPage;
        private System.Windows.Forms.TabPage PaidPage;
        private System.Windows.Forms.TabPage TravelsPackagePage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConfigParamSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmAggrSelect;
        private System.Windows.Forms.TextBox AggSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ParamSelect;
        private System.Windows.Forms.Button ImpDocument;
        private System.Windows.Forms.Button ExpDocument;
        private System.Windows.Forms.Button ImpReader;
        private System.Windows.Forms.Button ExpWriter;
        private System.Windows.Forms.Button Trigger;
    }
}

