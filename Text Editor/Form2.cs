using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form2 : Form
    {
        List<Control> textEditor;
        List<Control> Form1;
        List<Control> Settings;
        public Form2()
        {
            InitializeComponent();
        }

        void Initialize_Add()
        {
            textEditor = new List<Control>();
            Form1 = new List<Control>();
            Settings = new List<Control>();

            Settings.Add(tabPage1);
            Settings.Add(tabControl1);
            // Settings.Add(tabPage1);
            // Settings.Add(tabControl1);
            // Settings.Add(tabPage1);
            // Settings.Add(tabControl1);
            // Settings.Add(tabPage1);
            // Settings.Add(tabControl1);
            // Settings.Add(tabPage1);
            // Settings.Add(tabControl1);
            // Settings.Add(tabPage1);

        }

        void ApplyTheme(Color back, Color tbox, Color Tc, Color combox, Color TextColor)
        {
            this.BackColor = back;
            themeComboBox.BackColor = combox;

            foreach (Control item in Settings)
            {
                item.BackColor = back;
                item.BackColor = tbox;
                item.BackColor = Tc;
                item.ForeColor = TextColor;
            }
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themeComboBox.Text == "Light")
            {
                ApplyTheme(Color.White, zcolor(255, 255, 255), zcolor(240, 240, 220), Color.White, Color.Black);
            }

            else if (themeComboBox.Text == "Dark")
            {
                ApplyTheme(zcolor(255, 255, 255), zcolor(30, 30, 30), zcolor(104, 104, 104), zcolor(255, 255, 255), Color.White);
            }
        }

        Color zcolor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Initialize_Add();
        }
    }
}
