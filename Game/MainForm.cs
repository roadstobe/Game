using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        TableLayoutPanel space;
        Random rnd;
        List<int> numerals = new List<int>();
        static int errorTry;
        static bool isPress;
        static int time;
        public MainForm()
        {
            InitializeComponent();
            State(checkBoxDefine, EventArgs.Empty);
            space  = new TableLayoutPanel();
            rnd = new Random();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            space.Name = "TableSpace";
            space.Parent = splitContainer.Panel1;
            space.Dock = DockStyle.Fill;
            space.ColumnCount = int.Parse(textBoxColums.Text);
            space.RowCount = int.Parse(textBoxRows.Text);
            int percent = 100 / space.ColumnCount;
            for (int i = 0; i < space.ColumnCount; i++)
            {
                space.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
            }
            percent = 100 / space.RowCount;
            for (int i = 0; i < space.RowCount; i++)
            {
                space.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
            }
            Label currentLabel;
            for (int i = 0; i < space.RowCount; i++)
            {
                for (int j = 0; j < space.ColumnCount; j++)
                {
                    currentLabel = new Label();
                    space.Controls.Add(currentLabel, j, i);
                    currentLabel.Text = $"{rnd.Next(0, 100)}";
                    numerals.Add(int.Parse(currentLabel.Text));
                    currentLabel.Dock = DockStyle.Fill;
                    currentLabel.BackColor = Color.Red;
                    currentLabel.TextAlign = ContentAlignment.MiddleCenter;
                    currentLabel.MouseClick += CurrentLabel_MouseClick;
                }
            }
            numerals.Sort();
        }

        private void CurrentLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (int.Parse((sender as Label).Text) <= numerals[0])
            {
                space.Controls.Remove(sender as Label);
                numerals.RemoveAt(0);
                if (numerals.Count == 0)
                {
                    if ((MessageBox.Show($"You win!!!Кількість невдалих спроб: {errorTry} Осталося знайти: {numerals.Count}", "Win", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        isPress = false;
                        buttonStart.Enabled = true;
                    }
                    else
                        this.Close();
                }
            }
            else
                errorTry++;

        }

        private void State(object sender, EventArgs e)
        {
            if((sender as CheckBox).CheckState == CheckState.Checked)
            {
                textBoxColums.Enabled = true;
                textBoxRows.Enabled = true;
            }
            else if((sender as CheckBox).CheckState == CheckState.Unchecked)
            {
                textBoxColums.Enabled = false;
                textBoxRows.Enabled = false;
            }
            
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (isPress == false)
            {
                Load += MainForm_Load;
                MainForm_Load(this, EventArgs.Empty);
                isPress = true;
                buttonStart.Enabled = false;
                timerTime.Enabled = true;
                radioButtonSlow.Enabled = false;
                radioButtonNormal.Enabled = false;
                radioButtonFast.Enabled = false;
                checkBoxDefine.Enabled = false;
            }
            else
                timerTime.Enabled = false;
        }

        private void TickTock(object sender, EventArgs e)
        {
            int timer = 0;
            if (radioButtonSlow.Checked)
            {
                timer = 5;
            }
            else if (radioButtonNormal.Checked)
            {
                timer = 10;
            }
            else if(radioButtonFast.Checked)
            {
                timer = 15;
            }
            if (time > timer && isPress == true)
            {
                timerTime.Enabled = false;
                if ((MessageBox.Show($"Time out!!!Кількість невдалих спроб: {errorTry} Осталося знайти: {numerals.Count}", "Lose", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    isPress = false;
                    buttonStart.Enabled = true;
                    time = 0;
                }
                else
                    this.Close();
            }
            else
                time++;
        }
    }
}
