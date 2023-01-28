using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Tiedostojen_järjestely_ohjelma
{
    public partial class Form1 : Form
    {
        string source_path;
        string target_path;
        int pos;
        float bar_cnt;
        int panel_size;

        public Form1()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void transfer(string[] files)
        {
            float cnt = 0;
            int i = 0;
            float y = 1;
            while (cnt == 0)
            {
                i++;
                if (files.Count() < 400 * i)
                {
                    cnt = y;
                }
                y = y / 2;
            }
            progresbar1.BackColor = Color.FromArgb(0, 136, 214);
            if (copy_checkBox.Checked)
            {
                foreach (var file in files)
                {
                    bar_cnt = bar_cnt + cnt;
                    if (bar_cnt % 1 == 0)
                    {
                        progresbar1.Width = (int)bar_cnt;
                    }
                    string filename = Path.GetFileName(file);
                    string destFile = Path.Combine(target_path, filename);
                    if (System.IO.File.Exists(destFile) == false)
                    {
                        System.IO.File.Copy(file, destFile, true);
                    }
                    else if (System.IO.File.Exists(destFile) == true)
                    {
                        destFile = Path.Combine(target_path, "kopio." + filename);
                        if (System.IO.File.Exists(destFile) == false)
                        {
                            System.IO.File.Copy(file, destFile, true);
                        }
                        else if (System.IO.File.Exists(destFile) == true)
                        {
                            destFile = Path.Combine(target_path, "kopio(2)." + filename);
                            if (System.IO.File.Exists(destFile) == false)
                            {
                                System.IO.File.Copy(file, destFile, true);
                            }
                            else if (System.IO.File.Exists(destFile) == true)
                            {
                                destFile = Path.Combine(target_path, "kopio(3)." + filename);
                                System.IO.File.Copy(file, destFile, true);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var file in files)
                {
                    bar_cnt = bar_cnt + cnt;
                    if (bar_cnt % 1 == 0)
                    {
                        progresbar1.Width = (int)bar_cnt;
                    }
                    string filename = Path.GetFileName(file);
                    string destFile = Path.Combine(target_path, filename);
                    if (System.IO.File.Exists(destFile) == false)
                    {
                        System.IO.File.Move(file, destFile, true);
                    }
                    else if (System.IO.File.Exists(destFile) == true)
                    {
                        destFile = Path.Combine(target_path, "kopio." + filename);
                        if (System.IO.File.Exists(destFile) == false)
                        {
                            System.IO.File.Move(file, destFile, true);
                        }
                        else if (System.IO.File.Exists(destFile) == true)
                        {
                            destFile = Path.Combine(target_path, "kopio(2)." + filename);
                            if (System.IO.File.Exists(destFile) == false)
                            {
                                System.IO.File.Move(file, destFile, true);
                            }
                            else if (System.IO.File.Exists(destFile) == true)
                            {
                                destFile = Path.Combine(target_path, "kopio(3)." + filename);
                                System.IO.File.Move(file, destFile, true);
                            }
                        }
                    }
                }
            }
            progresbar1.Width = 400;
        }

        public void aikajakso(List<string> sorted_files)
        {
            List<string> delete_list = new List<string>();
            DateTime aloitus_pv = DateTime.Parse(aloitus_textBox.Text);
            DateTime lopetus_pv = DateTime.Parse(lopetus_textBox.Text);
            string path = target_path + "\\" + aloitus_pv.Year + "\\" + kansio_textBox.Text;
            Directory.CreateDirectory(path);
            foreach (string file in sorted_files)
            {
                string filename = Path.GetFileName(file);
                string destFile = Path.Combine(path, filename);
                DirectoryInfo info2 = new DirectoryInfo(file);
                if (info2.LastWriteTime > aloitus_pv && info2.LastWriteTime < lopetus_pv)
                {
                    System.IO.File.Move(file, destFile, true);
                    delete_list.Add(file);
                }
            }
            for (int i = 0; i < delete_list.Count(); i++)
            {
                if (sorted_files.Contains(delete_list[i]) == true)
                {
                    sorted_files.Remove(delete_list[i]);
                }
            }
        }
        
        public void create_scene(string name, List<string> folder_name)
        {
            int count = Directory.GetFiles(target_path + "\\" + name, "*.*", SearchOption.AllDirectories).Length;

            string[] a = Directory.GetFiles(target_path + "\\" + name, "*.*", SearchOption.AllDirectories);
            long b = 0;
            foreach (string x in a)
            {
                FileInfo info = new FileInfo(x);
                b += info.Length;
            }
            int size_kb = (int)b / 1000000;

            panel_size = 70;

            Panel panel = new Panel();
            panel.Visible = true;
            panel.Location = new Point(0, pos);
            panel.Size = new Size(691, panel_size);
            panel.BackColor = Color.WhiteSmoke;
            panel.SendToBack();
            scene_panel.Controls.Add(panel);

            Panel design_panel = new Panel();
            panel.Controls.Add(design_panel);
            design_panel.Visible = true;
            design_panel.Location = new Point(30, 0);
            design_panel.Size = new Size(611, 2);
            design_panel.BackColor = Color.DimGray;
            design_panel.BringToFront();

            Label name_label = new Label();
            panel.Controls.Add(name_label);
            name_label.ForeColor = Color.DimGray;
            name_label.Location = new Point(76, 25);
            name_label.Text = name;
            name_label.AutoSize = true;
            name_label.Font = new Font("Microsoft YaHei UI", 11, FontStyle.Bold);

            Label count_label = new Label();
            panel.Controls.Add(count_label);
            count_label.ForeColor = Color.DimGray;
            count_label.Location = new Point(310, 25);
            count_label.Text = count.ToString() + " files";
            count_label.AutoSize = true;
            count_label.Font = new Font("Microsoft YaHei UI", 11);

            Label size_label = new Label();
            panel.Controls.Add(size_label);
            size_label.ForeColor = Color.DimGray;
            size_label.Location = new Point(576, 25);
            size_label.Text = size_kb.ToString() + "MB";
            size_label.AutoSize = true;
            size_label.Font = new Font("Microsoft YaHei UI", 11);
            pos = pos + panel_size;
        }

        public void create_total_scene(List<string> folder_name)
        {
            int count = Directory.GetFiles(target_path, "*.*", SearchOption.AllDirectories).Length;

            string[] a = Directory.GetFiles(target_path, "*.*", SearchOption.AllDirectories);
            long b = 0;
            foreach (string x in a)
            {
                FileInfo info = new FileInfo(x);
                b += info.Length;
            }
            int size_kb = (int)b / 1000000;

            panel_size = 70;

            Panel panel = new Panel();
            panel.Visible = true;
            panel.Location = new Point(0, pos);
            panel.Size = new Size(691, panel_size);
            panel.BackColor = Color.WhiteSmoke;
            panel.SendToBack();
            scene_panel.Controls.Add(panel);

            Panel design_panel = new Panel();
            panel.Controls.Add(design_panel);
            design_panel.Visible = true;
            design_panel.Location = new Point(30, 0);
            design_panel.Size = new Size(611, 2);
            design_panel.BackColor = Color.DimGray;
            design_panel.BringToFront();

            Label name_label = new Label();
            panel.Controls.Add(name_label);
            name_label.ForeColor = Color.DimGray;
            name_label.Location = new Point(76, 25);
            name_label.Text = "TOTAL:";
            name_label.AutoSize = true;
            name_label.Font = new Font("Microsoft YaHei UI", 11, FontStyle.Bold);

            Label count_label = new Label();
            panel.Controls.Add(count_label);
            count_label.ForeColor = Color.DimGray;
            count_label.Location = new Point(310, 25);
            count_label.Text = count.ToString() + " files";
            count_label.AutoSize = true;
            count_label.Font = new Font("Microsoft YaHei UI", 11);

            Label size_label = new Label();
            panel.Controls.Add(size_label);
            size_label.ForeColor = Color.DimGray;
            size_label.Location = new Point(576, 25);
            size_label.Text = size_kb.ToString() + "MB";
            size_label.AutoSize = true;
            size_label.Font = new Font("Microsoft YaHei UI", 11);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbh = new FolderBrowserDialog();
            if (fbh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = fbh.SelectedPath.ToString();
            source_path = textBox1.Text;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbh = new FolderBrowserDialog();
            if (fbh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox2.Text = fbh.SelectedPath.ToString();
            target_path = textBox2.Text;
        }



        private void jarjestele_button_Click(object sender, EventArgs e)
        {
            List<string> folder_name = new List<string>();
            List<string> sorted_files = new List<string>();
            List<string> list2 = new List<string>();
            string[] files;
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };

            files = System.IO.Directory.GetFiles(source_path, "*.*", System.IO.SearchOption.AllDirectories);

            transfer(files);

            DirectoryInfo info = new DirectoryInfo(target_path);
            FileInfo[] x = info.GetFiles().OrderBy(p => p.LastWriteTime).ToArray();
            foreach (FileInfo file in x)
            {
                sorted_files.Add(file.ToString());
            }
            int list_counter = sorted_files.Count();
            DateTime start_date1 = File.GetLastWriteTime(sorted_files[0]); //vanhin
            DateTime stop_date1 = File.GetLastWriteTime(sorted_files[list_counter - 1]); //uusin
            string start_date = String.Format("{0:yyyy}", start_date1);
            string stop_date = String.Format("{0:yyyy}", stop_date1);
            int start_date_int = int.Parse(start_date);
            int stop_date_int = int.Parse(stop_date);
            int i = 0;
            while (start_date_int + i != stop_date_int + 1)
            {
                int number = start_date_int + i;
                folder_name.Add(number.ToString());
                i++;
            }
            for (int a = 0; a < folder_name.Count; a++)
            {
                Directory.CreateDirectory(target_path + '\\' + folder_name[a]);
            }
            if (checkBox1.Checked == true)
            {
               aikajakso(sorted_files);
            }
            i = 1;
            foreach (string file in sorted_files)
            {
                DateTime year_dt = new DateTime(start_date_int + i, 1, 1, 1, 1, 1);
                DirectoryInfo info2 = new DirectoryInfo(file);
                System.IO.File.Move(file, target_path + "\\" + info2.LastWriteTime.Year + "\\" + Path.GetFileName(file), true);
            }
            foreach (string name in folder_name)
            {
                create_scene(name, folder_name);
            }
            create_total_scene(folder_name);
            created_folder_label.Visible = true;

        }

        private void move_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (move_checkBox.CheckState == CheckState.Checked)
            {
                copy_checkBox.CheckState = CheckState.Unchecked;
            }
            else if (move_checkBox.CheckState == CheckState.Unchecked)
            {
                copy_checkBox.CheckState = CheckState.Checked;
            }
        }

        private void copy_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (copy_checkBox.CheckState == CheckState.Checked)
            {
                move_checkBox.CheckState = CheckState.Unchecked;
            }
            else if (copy_checkBox.CheckState == CheckState.Unchecked)
            {
                move_checkBox.CheckState = CheckState.Checked;
            }
        }

        private void aloitus_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lopetus_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                aloitus_textBox.ReadOnly = true;
                lopetus_textBox.ReadOnly = true;
                kansio_textBox.ReadOnly = true;
            }
            else
            {
                aloitus_textBox.ReadOnly = false;
                lopetus_textBox.ReadOnly = false;
                kansio_textBox.ReadOnly = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            aloitus_textBox.Clear();
            lopetus_textBox.Clear();
            kansio_textBox.Clear();

            checkBox1.CheckState = CheckState.Unchecked;

            created_folder_label.Visible = false;

            scene_panel.Controls.Clear();
            this.Refresh();

            progresbar1.Width = 0;

            source_path = "";
            target_path = "";
        }
    }
}
