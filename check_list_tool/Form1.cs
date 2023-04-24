using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_list_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCSVFile(string filePath)
        {
            int numControls = 1; // 记录已添加的控件数目
            int formWidth = 800; // 默认Form宽度
            int formHeight = 600; // 默认Form高度

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    // 检查是否存在对应的面板
                    if (!this.Controls.ContainsKey(values[0] + "Panel"))
                    {
                        // 创建一个新的面板
                        var panel = new Panel();
                        panel.Name = values[0] + "Panel";
                        panel.Location = new Point(10, 10 + (35 * numControls));
                        panel.Size = new Size(700, 30);
                        this.Controls.Add(panel);

                        // 创建一个新的标签
                        var label = new Label();
                        label.Text = values[0];
                        label.Location = new Point(0, 7);
                        label.AutoSize = true;
                        panel.Controls.Add(label);

                        _addtextbox(values, panel);
                        numControls++; // 添加控件计数器加1

                        // 检查是否需要调整Form的大小
                        if (numControls * 35 + 10 > formHeight)
                        {
                            formHeight = numControls * 35 + 10;
                        }
                    }
                }
            }

            // 调整Form的大小
            this.Size = new Size(formWidth, formHeight);
        }

        private void _addtextbox(string[] values, Panel panel)
        {
            var textBox1 = CreateTextBox(values[0] + "TextBox1", 50, 5);
            var textBox2 = CreateTextBox(values[0] + "TextBox2", 150, 5);
            var textBox3 = CreateTextBox(values[0] + "TextBox3", 250, 5);
            panel.Controls.AddRange(new Control[] { textBox1, textBox2, textBox3 });
        }

        private TextBox CreateTextBox(string name, int x, int y)
        {
            var textBox = new TextBox();
            textBox.Name = name;
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(80, 20);
            return textBox;
        }


        private void 讀取CSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadCSVFile(filePath);
            }
        }
    }
}
