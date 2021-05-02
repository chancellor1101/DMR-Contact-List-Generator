
namespace DMR_Contact_List_Generator
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbl_Radio_Select = new System.Windows.Forms.ToolStripLabel();
            this.select_RadioModel = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Generate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txt_Console = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Radio_Select,
            this.select_RadioModel,
            this.btn_Generate,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // lbl_Radio_Select
            // 
            this.lbl_Radio_Select.Name = "lbl_Radio_Select";
            this.lbl_Radio_Select.Size = new System.Drawing.Size(40, 22);
            this.lbl_Radio_Select.Text = "Radio:";
            // 
            // select_RadioModel
            // 
            this.select_RadioModel.Items.AddRange(new object[] {
            "Baofeng DM-1701"});
            this.select_RadioModel.Name = "select_RadioModel";
            this.select_RadioModel.Size = new System.Drawing.Size(121, 25);
            // 
            // btn_Generate
            // 
            this.btn_Generate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Generate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Generate.Image")));
            this.btn_Generate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(58, 22);
            this.btn_Generate.Text = "Generate";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 22);
            this.toolStripButton1.Text = "Export to CSV";
            // 
            // txt_Console
            // 
            this.txt_Console.BackColor = System.Drawing.Color.Black;
            this.txt_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Console.ForeColor = System.Drawing.Color.Lime;
            this.txt_Console.Location = new System.Drawing.Point(0, 25);
            this.txt_Console.Multiline = true;
            this.txt_Console.Name = "txt_Console";
            this.txt_Console.ReadOnly = true;
            this.txt_Console.Size = new System.Drawing.Size(800, 425);
            this.txt_Console.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Console);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "DMR Contact List Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbl_Radio_Select;
        private System.Windows.Forms.ToolStripComboBox select_RadioModel;
        private System.Windows.Forms.ToolStripButton btn_Generate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txt_Console;
    }
}

