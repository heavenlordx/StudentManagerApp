using GradeLibrary;
using ReportLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagerApp
{
    public partial class Form1 : Form
    {
        private TextBox txtName;
        private TextBox txtMark1;
        private TextBox txtMark2;
        private TextBox txtMark3;
        private Label lblResult;
        private Button btnCalculate;

        public Form1()
        {
            InitializeComponent();

            Text = "Student Manager App";

            Label lbl1 = new Label()
            {
                Text = "Student Name",
                Left = 20,
                Top = 20,
                Width = 100
            };

            txtName = new TextBox()
            {
                Left = 140,
                Top = 20,
                Width = 200
            };

            Label lbl2 = new Label()
            {
                Text = "Mark 1",
                Left = 20,
                Top = 60
            };

            txtMark1 = new TextBox()
            {
                Left = 140,
                Top = 60
            };

            Label lbl3 = new Label()
            {
                Text = "Mark 2",
                Left = 20,
                Top = 100
            };

            txtMark2 = new TextBox()
            {
                Left = 140,
                Top = 100
            };

            Label lbl4 = new Label()
            {
                Text = "Mark 3",
                Left = 20,
                Top = 140
            };

            txtMark3 = new TextBox()
            {
                Left = 140,
                Top = 140
            };

            btnCalculate = new Button()
            {
                Text = "Calculate",
                Left = 140,
                Top = 180
            };

            btnCalculate.Click += btnCalculate_Click;

            lblResult = new Label()
            {
                Left = 20,
                Top = 230,
                Width = 400,
                Height = 100
            };

            Controls.Add(lbl1);
            Controls.Add(txtName);
            Controls.Add(lbl2);
            Controls.Add(txtMark1);
            Controls.Add(lbl3);
            Controls.Add(txtMark2);
            Controls.Add(lbl4);
            Controls.Add(txtMark3);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double m1 = Convert.ToDouble(txtMark1.Text);
            double m2 = Convert.ToDouble(txtMark2.Text);
            double m3 = Convert.ToDouble(txtMark3.Text);

            double average = (m1 + m2 + m3) / 3;

            GradeCalculator calc = new GradeCalculator();

            string grade = calc.GetGrade(average);

            ReportGenerator report = new ReportGenerator();

            lblResult.Text =
                report.GenerateReport(
                    txtName.Text,
                    average,
                    grade);
        }
    }
}