using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_9x9_Solver_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] sudoku = new string[10, 10];
        bool test = false;

        private void Scanning_Sudoku()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (sudoku[i, j].Length > 1)
                        test = true;
                }
            }
        }

        private void Search_Sudoku()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].Length != 1)
                    {
                        Edit_Sudoku(i, j);
                        Edit_Small_Sudoku(i, j);
                    }
                }
            }
        }

        private void Edit_Sudoku(int n, int m)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != n && sudoku[i, m].Length == 1)
                {
                    for (int j = 0; j < sudoku[n, m].Length; j++)
                    {
                        if (sudoku[n, m][j].ToString() == sudoku[i, m])
                        {
                            sudoku[n, m] = sudoku[n, m].Remove(j, 1);
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (i != m && sudoku[n, i].Length == 1)
                {
                    for (int j = 0; j < sudoku[n, m].Length; j++)
                    {
                        if (sudoku[n, m][j].ToString() == sudoku[n, i])
                        {
                            sudoku[n, m] = sudoku[n, m].Remove(j, 1);
                            break;
                        }
                    }
                }
            }
        }

        private void Edit_Small_Sudoku(int n, int m)
        {
            if (n <= 2 && m <= 2)
            {
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n <= 2 && m >= 3 && m <= 5)
            {
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 3; j <= 5; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n <= 2 && m >= 6)
            {
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 6; j <= 8; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n >= 3 && n <= 5 && m <= 2)
            {
                for (int i = 3; i <= 5; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n <= 5 && n >= 3 && m >= 3 && m <= 5)
            {
                for (int i = 3; i <= 5; i++)
                {
                    for (int j = 3; j <= 5; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n <= 5 && n >= 3 && m >= 6)
            {
                for (int i = 3; i <= 5; i++)
                {
                    for (int j = 6; j <= 8; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n >= 6 && m <= 2)
            {
                for (int i = 6; i <= 8; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n >= 6 && m >= 3 && m <= 5)
            {
                for (int i = 6; i <= 8; i++)
                {
                    for (int j = 3; j <= 5; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }

            else if (n >= 6 && m >= 6)
            {
                for (int i = 6; i <= 8; i++)
                {
                    for (int j = 6; j <= 8; j++)
                    {
                        if (i != n && j != m && sudoku[i, j].Length == 1)
                            for (int k = 0; k < sudoku[n, m].Length; k++)
                            {
                                if (sudoku[n, m][k].ToString() == sudoku[i, j])
                                    sudoku[n, m] = sudoku[n, m].Remove(k, 1);
                            }
                    }
                }
            }
        }

        private void Filling_Sudoku()
        {
            int i = 0, n, m;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        n = i / 9;
                        m = i % 9;
                        sudoku[n, m] = (control as TextBox).Text;
                        i++;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Filling_Empty_Sudoku()
        {
            string str = "123456789";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i, j].Length == 0)
                        sudoku[i, j] = str;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            test = false;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).Text = "";
                        (control as TextBox).ForeColor = Color.Black;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
            btnFind.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Filling_Sudoku();
            Filling_Empty_Sudoku();
            for (int t = 0; t < 200; t++)
                Search_Sudoku();

            Scanning_Sudoku();
            if (test)
                MessageBox.Show("This Sudoku is wrong or the difficulty of Sudoku can be high");
            else
            {
                int i = 0, n, m;
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                        {
                            n = i / 9;
                            m = i % 9;
                            i++;
                            if ((control as TextBox).Text.Length == 0)
                            {
                                (control as TextBox).ForeColor = Color.Blue;
                                (control as TextBox).Text = sudoku[n, m];
                            }
                        }
                        else
                            func(control.Controls);
                };

                func(Controls);
            }

            btnFind.Enabled = false;
        }
    }
}
