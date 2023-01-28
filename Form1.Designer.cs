
namespace Tiedostojen_järjestely_ohjelma
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
            this.jarjestele_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.move_checkBox = new System.Windows.Forms.CheckBox();
            this.copy_checkBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progresbar1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.progresbar = new System.Windows.Forms.Panel();
            this.progressbar_layout = new System.Windows.Forms.Panel();
            this.scene_panel = new System.Windows.Forms.Panel();
            this.created_folder_label = new System.Windows.Forms.Label();
            this.counter_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aloitus_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lopetus_textBox = new System.Windows.Forms.TextBox();
            this.kansio_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // jarjestele_button
            // 
            this.jarjestele_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(214)))));
            this.jarjestele_button.FlatAppearance.BorderSize = 0;
            this.jarjestele_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jarjestele_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jarjestele_button.Location = new System.Drawing.Point(558, 715);
            this.jarjestele_button.Name = "jarjestele_button";
            this.jarjestele_button.Size = new System.Drawing.Size(121, 30);
            this.jarjestele_button.TabIndex = 4;
            this.jarjestele_button.Text = "Start";
            this.jarjestele_button.UseVisualStyleBackColor = false;
            this.jarjestele_button.Click += new System.EventHandler(this.jarjestele_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Browse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(373, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "määränpää kansio";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(121, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // move_checkBox
            // 
            this.move_checkBox.AutoSize = true;
            this.move_checkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.move_checkBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.move_checkBox.ForeColor = System.Drawing.Color.White;
            this.move_checkBox.Location = new System.Drawing.Point(33, 149);
            this.move_checkBox.Name = "move_checkBox";
            this.move_checkBox.Size = new System.Drawing.Size(68, 25);
            this.move_checkBox.TabIndex = 22;
            this.move_checkBox.Text = "Move";
            this.move_checkBox.UseVisualStyleBackColor = true;
            this.move_checkBox.CheckedChanged += new System.EventHandler(this.move_checkBox_CheckedChanged);
            // 
            // copy_checkBox
            // 
            this.copy_checkBox.AutoSize = true;
            this.copy_checkBox.Checked = true;
            this.copy_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copy_checkBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copy_checkBox.ForeColor = System.Drawing.Color.White;
            this.copy_checkBox.Location = new System.Drawing.Point(33, 118);
            this.copy_checkBox.Name = "copy_checkBox";
            this.copy_checkBox.Size = new System.Drawing.Size(65, 25);
            this.copy_checkBox.TabIndex = 23;
            this.copy_checkBox.Text = "Copy";
            this.copy_checkBox.UseVisualStyleBackColor = true;
            this.copy_checkBox.CheckedChanged += new System.EventHandler(this.copy_checkBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.progresbar1);
            this.panel2.Controls.Add(this.jarjestele_button);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.progresbar);
            this.panel2.Controls.Add(this.progressbar_layout);
            this.panel2.Controls.Add(this.scene_panel);
            this.panel2.Controls.Add(this.created_folder_label);
            this.panel2.Controls.Add(this.counter_label);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(276, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 758);
            this.panel2.TabIndex = 24;
            // 
            // progresbar1
            // 
            this.progresbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progresbar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progresbar1.Location = new System.Drawing.Point(12, 715);
            this.progresbar1.Name = "progresbar1";
            this.progresbar1.Size = new System.Drawing.Size(0, 30);
            this.progresbar1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(431, 715);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progresbar
            // 
            this.progresbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progresbar.Location = new System.Drawing.Point(95, 726);
            this.progresbar.Name = "progresbar";
            this.progresbar.Size = new System.Drawing.Size(0, 19);
            this.progresbar.TabIndex = 22;
            // 
            // progressbar_layout
            // 
            this.progressbar_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressbar_layout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressbar_layout.Location = new System.Drawing.Point(12, 715);
            this.progressbar_layout.Name = "progressbar_layout";
            this.progressbar_layout.Size = new System.Drawing.Size(400, 30);
            this.progressbar_layout.TabIndex = 21;
            // 
            // scene_panel
            // 
            this.scene_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scene_panel.AutoScroll = true;
            this.scene_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scene_panel.Location = new System.Drawing.Point(0, 141);
            this.scene_panel.Name = "scene_panel";
            this.scene_panel.Size = new System.Drawing.Size(691, 560);
            this.scene_panel.TabIndex = 20;
            // 
            // created_folder_label
            // 
            this.created_folder_label.AutoSize = true;
            this.created_folder_label.BackColor = System.Drawing.Color.Transparent;
            this.created_folder_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.created_folder_label.ForeColor = System.Drawing.Color.DimGray;
            this.created_folder_label.Location = new System.Drawing.Point(15, 95);
            this.created_folder_label.Name = "created_folder_label";
            this.created_folder_label.Size = new System.Drawing.Size(120, 21);
            this.created_folder_label.TabIndex = 19;
            this.created_folder_label.Text = "Created folder";
            this.created_folder_label.Visible = false;
            // 
            // counter_label
            // 
            this.counter_label.AutoSize = true;
            this.counter_label.BackColor = System.Drawing.Color.Transparent;
            this.counter_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.counter_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.counter_label.Location = new System.Drawing.Point(15, 726);
            this.counter_label.Name = "counter_label";
            this.counter_label.Size = new System.Drawing.Size(0, 19);
            this.counter_label.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(376, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(373, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Save to:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(15, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Oganization App";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Options";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Add custom";
            // 
            // aloitus_textBox
            // 
            this.aloitus_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.aloitus_textBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aloitus_textBox.Location = new System.Drawing.Point(33, 277);
            this.aloitus_textBox.Name = "aloitus_textBox";
            this.aloitus_textBox.ReadOnly = true;
            this.aloitus_textBox.Size = new System.Drawing.Size(100, 23);
            this.aloitus_textBox.TabIndex = 27;
            this.aloitus_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aloitus_textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(30, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Start day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(153, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "End day";
            // 
            // lopetus_textBox
            // 
            this.lopetus_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lopetus_textBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lopetus_textBox.Location = new System.Drawing.Point(156, 277);
            this.lopetus_textBox.Name = "lopetus_textBox";
            this.lopetus_textBox.ReadOnly = true;
            this.lopetus_textBox.Size = new System.Drawing.Size(100, 23);
            this.lopetus_textBox.TabIndex = 29;
            this.lopetus_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lopetus_textBox_KeyPress);
            // 
            // kansio_textBox
            // 
            this.kansio_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kansio_textBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kansio_textBox.Location = new System.Drawing.Point(33, 331);
            this.kansio_textBox.Name = "kansio_textBox";
            this.kansio_textBox.ReadOnly = true;
            this.kansio_textBox.Size = new System.Drawing.Size(223, 23);
            this.kansio_textBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(30, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Folder name";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(965, 800);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kansio_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lopetus_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aloitus_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.copy_checkBox);
            this.Controls.Add(this.move_checkBox);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Oganization App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button jarjestele_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox move_checkBox;
        private System.Windows.Forms.CheckBox copy_checkBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aloitus_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lopetus_textBox;
        private System.Windows.Forms.TextBox kansio_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label counter_label;
        private System.Windows.Forms.Label created_folder_label;
        private System.Windows.Forms.Panel scene_panel;
        private System.Windows.Forms.Panel progresbar;
        private System.Windows.Forms.Panel progressbar_layout;
        private System.Windows.Forms.Panel progresbar1;
    }
}

