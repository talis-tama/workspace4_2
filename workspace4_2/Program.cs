using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workspace4
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form1());
        }

        public static void buckup()
        {
            StreamWriter buckup = new StreamWriter("buckup.dat", false, System.Text.Encoding.GetEncoding("shift_jis"));
            int[] bpoint = { form1.point11, form1.point12, form1.point13, form1.point21, form1.point22, form1.point23, form1.point31, form1.point32, form1.point33, form1.point1a, form1.point1b, form1.point1c, form1.point1d, form1.point1e, form1.point1f, form1.point1g, form1.point1h, form1.point2a, form1.point2b, form1.point2c, form1.point2d, form1.point2e, form1.point2f, form1.point2g, form1.point2h, form1.point3a, form1.point3b, form1.point3c, form1.point3d, form1.point3e, form1.point3f, form1.point3g, form1.point3h };
            for (int count = 0; count <= 32; count++)
            {
                buckup.Write(bpoint[count].ToString() + buckup.NewLine);
            }
            if (form1.b1 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b1 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b2 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b2 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b3 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b3 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b4 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b4 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b5 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b5 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b6 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b6 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b7 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b7 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b8 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b8 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b9 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b9 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b10 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b10 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b11 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b11 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b12 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b12 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b13 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b13 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b14 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b14 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b15 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b15 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b16 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b16 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b17 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b17 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b18 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b18 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b19 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b19 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b20 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b20 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b21 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b21 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b22 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b22 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b23 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b23 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b24 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b24 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b25 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b25 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b26 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b26 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b27 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b27 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b28 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b28 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b29 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b29 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b30 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b30 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b31 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b31 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b32 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b32 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b33 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b33 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b34 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b34 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b35 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b35 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b36 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b36 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b37 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b37 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b38 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b38 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b39 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b39 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b40 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b40 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b41 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b41 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b42 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b42 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            if (form1.b43 == true)
            {
                buckup.Write("1" + buckup.NewLine);
            }
            else if (form1.b43 == false)
            {
                buckup.Write("0" + buckup.NewLine);
            }
            buckup.Close();
        }
    }
    public partial class form1 : Form
    {
        public static TextBox textbox1;
        public static TextBox textbox2;
        public static TextBox textbox3;
        public static TextBox textbox4;
        public static TextBox textbox5;
        public static TextBox textbox6;
        public static TextBox textbox7;
        public static TextBox textbox8;
        public static TextBox textbox9;
        public static TextBox textbox10;
        public static TextBox textbox11;
        public static TextBox textbox12;
        public static TextBox textbox13;
        public static TextBox textbox14;
        public static TextBox textbox15;
        public static TextBox textbox16;
        public static TextBox textbox17;
        public static TextBox textbox18;
        public static TextBox textbox19;
        public static TextBox textbox20;
        public static TextBox textbox21;
        public static TextBox textbox22;
        public static TextBox textbox23;
        public static TextBox textbox24;
        public static TextBox textbox25;
        public static TextBox textbox26;
        public static TextBox textbox27;
        public static TextBox textbox28;
        public static TextBox textbox29;
        public static TextBox textbox30;
        public static TextBox textbox31;
        public static TextBox textbox32;
        public static TextBox textbox33;
        public static int point11 = 0;
        public static int point12 = 0;
        public static int point13 = 0;
        public static int point21 = 0;
        public static int point22 = 0;
        public static int point23 = 0;
        public static int point31 = 0;
        public static int point32 = 0;
        public static int point33 = 0;
        public static int point1a = 0;
        public static int point1b = 0;
        public static int point1c = 0;
        public static int point1d = 0;
        public static int point1e = 0;
        public static int point1f = 0;
        public static int point1g = 0;
        public static int point1h = 0;
        public static int point2a = 0;
        public static int point2b = 0;
        public static int point2c = 0;
        public static int point2d = 0;
        public static int point2e = 0;
        public static int point2f = 0;
        public static int point2g = 0;
        public static int point2h = 0;
        public static int point3a = 0;
        public static int point3b = 0;
        public static int point3c = 0;
        public static int point3d = 0;
        public static int point3e = 0;
        public static int point3f = 0;
        public static int point3g = 0;
        public static int point3h = 0;
        public static bool b1 = true;
        public static bool b2 = true;
        public static bool b3 = true;
        public static bool b4 = true;
        public static bool b5 = true;
        public static bool b6 = true;
        public static bool b7 = true;
        public static bool b8 = true;
        public static bool b9 = true;
        public static bool b10 = true;
        public static bool b11 = true;
        public static bool b12 = true;
        public static bool b13 = true;
        public static bool b14 = true;
        public static bool b15 = true;
        public static bool b16 = true;
        public static bool b17 = true;
        public static bool b18 = true;
        public static bool b19 = true;
        public static bool b20 = true;
        public static bool b21 = true;
        public static bool b22 = true;
        public static bool b23 = true;
        public static bool b24 = true;
        public static bool b25 = true;
        public static bool b26 = true;
        public static bool b27 = true;
        public static bool b28 = true;
        public static bool b29 = true;
        public static bool b30 = true;
        public static bool b31 = true;
        public static bool b32 = true;
        public static bool b33 = true;
        public static bool b34 = true;
        public static bool b35 = true;
        public static bool b36 = true;
        public static bool b37 = true;
        public static bool b38 = true;
        public static bool b39 = true;
        public static bool b40 = true;
        public static bool b41 = true;
        public static bool b42 = true;
        public static bool b43 = true;
        public form1()
        {
            this.Width = 640;
            this.Height = 360;
            this.Text = "体育祭得点計算プログラム";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Label label1 = new Label();
            label1.Location = new Point(15, 5);
            label1.Size = new Size(30, 15);
            label1.Text = "中学";
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Location = new Point(15, 25);
            label2.Size = new Size(60, 15);
            label2.Text = "1年1組";
            this.Controls.Add(label2);

            textbox1 = new TextBox();
            textbox1.Location = new Point(15, 45);
            textbox1.Size = new Size(60, 15);
            textbox1.ReadOnly = true;
            textbox1.Text = point11.ToString();
            this.Controls.Add(textbox1);

            Label label3 = new Label();
            label3.Location = new Point(90, 25);
            label3.Size = new Size(60, 15);
            label3.Text = "1年2組";
            this.Controls.Add(label3);

            textbox2 = new TextBox();
            textbox2.Location = new Point(90, 45);
            textbox2.Size = new Size(60, 15);
            textbox2.ReadOnly = true;
            textbox2.Text = point12.ToString();
            this.Controls.Add(textbox2);

            Label label4 = new Label();
            label4.Location = new Point(165, 25);
            label4.Size = new Size(60, 15);
            label4.Text = "1年3組";
            this.Controls.Add(label4);

            textbox3 = new TextBox();
            textbox3.Location = new Point(165, 45);
            textbox3.Size = new Size(60, 15);
            textbox3.ReadOnly = true;
            textbox3.Text = point13.ToString();
            this.Controls.Add(textbox3);

            Label label5 = new Label();
            label5.Location = new Point(240, 25);
            label5.Size = new Size(60, 15);
            label5.Text = "2年1組";
            this.Controls.Add(label5);

            textbox4 = new TextBox();
            textbox4.Location = new Point(240, 45);
            textbox4.Size = new Size(60, 15);
            textbox4.ReadOnly = true;
            textbox4.Text = point21.ToString();
            this.Controls.Add(textbox4);

            Label label6 = new Label();
            label6.Location = new Point(315, 25);
            label6.Size = new Size(60, 15);
            label6.Text = "2年2組";
            this.Controls.Add(label6);

            textbox5 = new TextBox();
            textbox5.Location = new Point(315, 45);
            textbox5.Size = new Size(60, 15);
            textbox5.ReadOnly = true;
            textbox5.Text = point22.ToString();
            this.Controls.Add(textbox5);

            Label label7 = new Label();
            label7.Location = new Point(390, 25);
            label7.Size = new Size(60, 15);
            label7.Text = "2年3組";
            this.Controls.Add(label7);

            textbox6 = new TextBox();
            textbox6.Location = new Point(390, 45);
            textbox6.Size = new Size(60, 15);
            textbox6.ReadOnly = true;
            textbox6.Text = point23.ToString();
            this.Controls.Add(textbox6);

            Label label8 = new Label();
            label8.Location = new Point(465, 25);
            label8.Size = new Size(60, 15);
            label8.Text = "3年1組";
            this.Controls.Add(label8);

            textbox7 = new TextBox();
            textbox7.Location = new Point(465, 45);
            textbox7.Size = new Size(60, 15);
            textbox7.ReadOnly = true;
            textbox7.Text = point31.ToString();
            this.Controls.Add(textbox7);

            Label label9 = new Label();
            label9.Location = new Point(540, 25);
            label9.Size = new Size(60, 15);
            label9.Text = "3年2組";
            this.Controls.Add(label9);

            textbox8 = new TextBox();
            textbox8.Location = new Point(540, 45);
            textbox8.Size = new Size(60, 15);
            textbox8.ReadOnly = true;
            textbox8.Text = point32.ToString();
            this.Controls.Add(textbox8);

            Label label10 = new Label();
            label10.Location = new Point(275, 70);
            label10.Size = new Size(60, 15);
            label10.Text = "3年3組";
            this.Controls.Add(label10);

            textbox9 = new TextBox();
            textbox9.Location = new Point(275, 90);
            textbox9.Size = new Size(60, 15);
            textbox9.ReadOnly = true;
            textbox9.Text = point33.ToString();
            this.Controls.Add(textbox9);

            Label label11 = new Label();
            label11.Location = new Point(15, 90);
            label11.Size = new Size(60, 15);
            label11.Text = "高校";
            this.Controls.Add(label11);

            Label label12 = new Label();
            label12.Location = new Point(15, 115);
            label12.Size = new Size(60, 15);
            label12.Text = "1年A組";
            this.Controls.Add(label12);

            textbox10 = new TextBox();
            textbox10.Location = new Point(15, 135);
            textbox10.Size = new Size(60, 15);
            textbox10.ReadOnly = true;
            textbox10.Text = point1a.ToString();
            this.Controls.Add(textbox10);

            Label label13 = new Label();
            label13.Location = new Point(90, 115);
            label13.Size = new Size(60, 15);
            label13.Text = "1年B組";
            this.Controls.Add(label13);

            textbox11 = new TextBox();
            textbox11.Location = new Point(90, 135);
            textbox11.Size = new Size(60, 15);
            textbox11.ReadOnly = true;
            textbox11.Text = point1b.ToString();
            this.Controls.Add(textbox11);

            Label label14 = new Label();
            label14.Location = new Point(165, 115);
            label14.Size = new Size(60, 15);
            label14.Text = "1年C組";
            this.Controls.Add(label14);

            textbox12 = new TextBox();
            textbox12.Location = new Point(165, 135);
            textbox12.Size = new Size(60, 15);
            textbox12.ReadOnly = true;
            textbox12.Text = point1c.ToString();
            this.Controls.Add(textbox12);

            Label label15 = new Label();
            label15.Location = new Point(240, 115);
            label15.Size = new Size(60, 15);
            label15.Text = "1年D組";
            this.Controls.Add(label15);

            textbox13 = new TextBox();
            textbox13.Location = new Point(240, 135);
            textbox13.Size = new Size(60, 15);
            textbox13.ReadOnly = true;
            textbox13.Text = point1d.ToString();
            this.Controls.Add(textbox13);

            Label label16 = new Label();
            label16.Location = new Point(315, 115);
            label16.Size = new Size(60, 15);
            label16.Text = "1年E組";
            this.Controls.Add(label16);

            textbox14 = new TextBox();
            textbox14.Location = new Point(315, 135);
            textbox14.Size = new Size(60, 15);
            textbox14.ReadOnly = true;
            textbox14.Text = point1e.ToString();
            this.Controls.Add(textbox14);

            Label label17 = new Label();
            label17.Location = new Point(390, 115);
            label17.Size = new Size(60, 15);
            label17.Text = "1年F組";
            this.Controls.Add(label17);

            textbox15 = new TextBox();
            textbox15.Location = new Point(390, 135);
            textbox15.Size = new Size(60, 15);
            textbox15.ReadOnly = true;
            textbox15.Text = point1f.ToString();
            this.Controls.Add(textbox15);

            Label label18 = new Label();
            label18.Location = new Point(465, 115);
            label18.Size = new Size(60, 15);
            label18.Text = "1年G組";
            this.Controls.Add(label18);

            textbox16 = new TextBox();
            textbox16.Location = new Point(465, 135);
            textbox16.Size = new Size(60, 15);
            textbox16.ReadOnly = true;
            textbox16.Text = point1g.ToString();
            this.Controls.Add(textbox16);

            Label label19 = new Label();
            label19.Location = new Point(540, 115);
            label19.Size = new Size(60, 15);
            label19.Text = "1年H組";
            this.Controls.Add(label19);

            textbox17 = new TextBox();
            textbox17.Location = new Point(540, 135);
            textbox17.Size = new Size(60, 15);
            textbox17.ReadOnly = true;
            textbox17.Text = point1h.ToString();
            this.Controls.Add(textbox17);

            Label label20 = new Label();
            label20.Location = new Point(15, 160);
            label20.Size = new Size(60, 15);
            label20.Text = "2年A組";
            this.Controls.Add(label20);

            textbox18 = new TextBox();
            textbox18.Location = new Point(15, 180);
            textbox18.Size = new Size(60, 15);
            textbox18.ReadOnly = true;
            textbox18.Text = point2a.ToString();
            this.Controls.Add(textbox18);

            Label label21 = new Label();
            label21.Location = new Point(90, 160);
            label21.Size = new Size(60, 15);
            label21.Text = "2年B組";
            this.Controls.Add(label21);

            textbox19 = new TextBox();
            textbox19.Location = new Point(90, 180);
            textbox19.Size = new Size(60, 15);
            textbox19.ReadOnly = true;
            textbox19.Text = point2b.ToString();
            this.Controls.Add(textbox19);

            Label label22 = new Label();
            label22.Location = new Point(165, 160);
            label22.Size = new Size(60, 15);
            label22.Text = "2年C組";
            this.Controls.Add(label22);

            textbox20 = new TextBox();
            textbox20.Location = new Point(165, 180);
            textbox20.Size = new Size(60, 15);
            textbox20.ReadOnly = true;
            textbox20.Text = point2c.ToString();
            this.Controls.Add(textbox20);

            Label label23 = new Label();
            label23.Location = new Point(240, 160);
            label23.Size = new Size(60, 15);
            label23.Text = "2年D組";
            this.Controls.Add(label23);

            textbox21 = new TextBox();
            textbox21.Location = new Point(240, 180);
            textbox21.Size = new Size(60, 15);
            textbox21.ReadOnly = true;
            textbox21.Text = point2d.ToString();
            this.Controls.Add(textbox21);

            Label label24 = new Label();
            label24.Location = new Point(315, 160);
            label24.Size = new Size(60, 15);
            label24.Text = "2年E組";
            this.Controls.Add(label24);

            textbox22 = new TextBox();
            textbox22.Location = new Point(315, 180);
            textbox22.Size = new Size(60, 15);
            textbox22.ReadOnly = true;
            textbox22.Text = point2e.ToString();
            this.Controls.Add(textbox22);

            Label label25 = new Label();
            label25.Location = new Point(390, 160);
            label25.Size = new Size(60, 15);
            label25.Text = "2年F組";
            this.Controls.Add(label25);

            textbox23 = new TextBox();
            textbox23.Location = new Point(390, 180);
            textbox23.Size = new Size(60, 15);
            textbox23.ReadOnly = true;
            textbox23.Text = point2f.ToString();
            this.Controls.Add(textbox23);

            Label label26 = new Label();
            label26.Location = new Point(465, 160);
            label26.Size = new Size(60, 15);
            label26.Text = "2年G組";
            this.Controls.Add(label26);

            textbox24 = new TextBox();
            textbox24.Location = new Point(465, 180);
            textbox24.Size = new Size(60, 15);
            textbox24.ReadOnly = true;
            textbox24.Text = point2g.ToString();
            this.Controls.Add(textbox24);

            Label label27 = new Label();
            label27.Location = new Point(540, 160);
            label27.Size = new Size(60, 15);
            label27.Text = "2年H組";
            this.Controls.Add(label27);

            textbox25 = new TextBox();
            textbox25.Location = new Point(540, 180);
            textbox25.Size = new Size(60, 15);
            textbox25.ReadOnly = true;
            textbox25.Text = point2h.ToString();
            this.Controls.Add(textbox25);

            Label label28 = new Label();
            label28.Location = new Point(15, 205);
            label28.Size = new Size(60, 15);
            label28.Text = "3年A組";
            this.Controls.Add(label28);

            textbox26 = new TextBox();
            textbox26.Location = new Point(15, 225);
            textbox26.Size = new Size(60, 15);
            textbox26.ReadOnly = true;
            textbox26.Text = point3a.ToString();
            this.Controls.Add(textbox26);

            Label label29 = new Label();
            label29.Location = new Point(90, 205);
            label29.Size = new Size(60, 15);
            label29.Text = "3年B組";
            this.Controls.Add(label29);

            textbox27 = new TextBox();
            textbox27.Location = new Point(90, 225);
            textbox27.Size = new Size(60, 15);
            textbox27.ReadOnly = true;
            textbox27.Text = point3b.ToString();
            this.Controls.Add(textbox27);

            Label label30 = new Label();
            label30.Location = new Point(165, 205);
            label30.Size = new Size(60, 15);
            label30.Text = "3年C組";
            this.Controls.Add(label30);

            textbox28 = new TextBox();
            textbox28.Location = new Point(165, 225);
            textbox28.Size = new Size(60, 15);
            textbox28.ReadOnly = true;
            textbox28.Text = point3c.ToString();
            this.Controls.Add(textbox28);

            Label label31 = new Label();
            label31.Location = new Point(240, 205);
            label31.Size = new Size(60, 15);
            label31.Text = "3年D組";
            this.Controls.Add(label31);

            textbox29 = new TextBox();
            textbox29.Location = new Point(240, 225);
            textbox29.Size = new Size(60, 15);
            textbox29.ReadOnly = true;
            textbox29.Text = point3d.ToString();
            this.Controls.Add(textbox29);

            Label label32 = new Label();
            label32.Location = new Point(315, 205);
            label32.Size = new Size(60, 15);
            label32.Text = "3年E組";
            this.Controls.Add(label32);

            textbox30 = new TextBox();
            textbox30.Location = new Point(315, 225);
            textbox30.Size = new Size(60, 15);
            textbox30.ReadOnly = true;
            textbox30.Text = point3e.ToString();
            this.Controls.Add(textbox30);

            Label label33 = new Label();
            label33.Location = new Point(390, 205);
            label33.Size = new Size(60, 15);
            label33.Text = "3年F組";
            this.Controls.Add(label33);

            textbox31 = new TextBox();
            textbox31.Location = new Point(390, 225);
            textbox31.Size = new Size(60, 15);
            textbox31.ReadOnly = true;
            textbox31.Text = point3f.ToString();
            this.Controls.Add(textbox31);

            Label label34 = new Label();
            label34.Location = new Point(465, 205);
            label34.Size = new Size(60, 15);
            label34.Text = "3年G組";
            this.Controls.Add(label34);

            textbox32 = new TextBox();
            textbox32.Location = new Point(465, 225);
            textbox32.Size = new Size(60, 15);
            textbox32.ReadOnly = true;
            textbox32.Text = point3g.ToString();
            this.Controls.Add(textbox32);

            Label label35 = new Label();
            label35.Location = new Point(540, 205);
            label35.Size = new Size(60, 15);
            label35.Text = "3年H組";
            this.Controls.Add(label35);

            textbox33 = new TextBox();
            textbox33.Location = new Point(540, 225);
            textbox33.Size = new Size(60, 15);
            textbox33.ReadOnly = true;
            textbox33.Text = point3h.ToString();
            this.Controls.Add(textbox33);

            Button button = new Button();
            button.Location = new Point(465, 260);
            button.Size = new Size(135, 40);
            button.Text = "メニュー";
            button.Click += new EventHandler(button_Click);
            this.Controls.Add(button);
        }

        void button_Click(object sender, EventArgs e)
        {
            form2 f2 = new form2();
            f2.StartPosition = FormStartPosition.CenterParent;
            f2.ShowDialog();
        }
    }

    public partial class form2 : Form
    {
        Button button6;
        public form2()
        {
            this.Width = 350;
            this.Height = 350;
            this.Text = "項目を選択";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Button button1 = new Button();
            button1.Location = new Point(30, 30);
            button1.Size = new Size(120, 40);
            button1.Text = "結果登録(中学)";
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(180, 30);
            button2.Size = new Size(120, 40);
            button2.Text = "結果登録(高校)";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Location = new Point(30, 170);
            button3.Size = new Size(120, 40);
            button3.Text = "順位判定";
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);

            Button button4 = new Button();
            button4.Location = new Point(180, 170);
            button4.Size = new Size(120, 40);
            button4.Text = "終了";
            button4.Click += new EventHandler(button4_Click);
            this.Controls.Add(button4);

            Button button5 = new Button();
            button5.Location = new Point(30, 100);
            button5.Size = new Size(120, 40);
            button5.Text = "結果登録(学年対抗系)";
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);

            this.button6 = new Button();
            this.button6.Location = new Point(180, 100);
            this.button6.Size = new Size(120, 40);
            this.button6.Text = "結果登録(全クラス対抗系)";
            this.button6.Click += new EventHandler(button6_Click);
            this.Controls.Add(button6);

            Button button8 = new Button();
            button8.Location = new Point(180, 240);
            button8.Size = new Size(120, 40);
            button8.Text = "得点リストア";
            button8.Click += new EventHandler(button8_Click);
            this.Controls.Add(button8);

            if (form1.b43 == false)
            {
                this.button6.Enabled = false;
                this.button6.Text = "登録済み";
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            form3 f3 = new form3();
            f3.ShowDialog();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            form4 f4 = new form4();
            f4.ShowDialog();
            this.Close();
        }

        void button3_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter("log.txt", false, System.Text.Encoding.GetEncoding("shift_jis"));
            string[] jhsclass = { "1年1組", "1年2組", "1年3組", "2年1組", "2年2組", "2年3組", "3年1組", "3年2組", "3年3組" };
            int[] jhs = { form1.point11, form1.point12, form1.point13, form1.point21, form1.point22, form1.point23, form1.point31, form1.point32, form1.point33 };
            var rankjhs = new SortedDictionary<int, int>();
            output.Write("中学部" + output.NewLine);
            foreach (var s in jhs)
            {
                if (rankjhs.ContainsKey(s))
                {
                    rankjhs[s] += 1;
                }
                else
                {
                    rankjhs.Add(s, 1);
                }
            }
            int order = 1;
            foreach (var s in rankjhs.Keys.Reverse())
            {
                int count = rankjhs[s];
                rankjhs[s] = order;
                order += count;
            }
            int jhscountcl = 0;
            int jhscountp = 0;
            foreach (var s in jhs)
            {
                output.Write("{0} {1}点->{2}", jhsclass[jhscountcl], jhs[jhscountp], rankjhs[s] + "位" + output.NewLine);
                jhscountcl += 1;
                jhscountp += 1;
            }
            string[] hsclass = { "1年A組", "1年B組", "1年C組", "1年D組", "1年E組", "1年F組", "1年G組", "1年H組", "2年A組", "2年B組", "2年C組", "2年D組", "2年E組", "2年F組", "2年G組", "2年H組", "3年A組", "3年B組", "3年C組", "3年D組", "3年E組", "3年F組", "3年G組", "3年H組" };
            int[] hs = { form1.point1a, form1.point1b, form1.point1c, form1.point1d, form1.point1e, form1.point1f, form1.point1g, form1.point1h, form1.point2a, form1.point2b, form1.point2c, form1.point2d, form1.point2e, form1.point2f, form1.point2g, form1.point2h, form1.point3a, form1.point3b, form1.point3c, form1.point3d, form1.point3e, form1.point3f, form1.point3g, form1.point3h };
            var rankhs = new SortedDictionary<int, int>();
            output.Write("高等部" + output.NewLine);
            foreach (var t in hs)
            {
                if (rankhs.ContainsKey(t))
                {
                    rankhs[t] += 1;
                }
                else
                {
                    rankhs.Add(t, 1);
                }
            }
            int order1 = 1;
            foreach (var t in rankhs.Keys.Reverse())
            {
                int counta = rankhs[t];
                rankhs[t] = order1;
                order1 += counta;
            }
            int hscountcl = 0;
            int hscountp = 0;
            foreach (var t in hs)
            {
                output.Write("{0} {1}点->{2}", hsclass[hscountcl], hs[hscountp], rankhs[t].ToString() + "位" + output.NewLine);
                hscountcl += 1;
                hscountp += 1;
            }
            output.Close();
            this.Close();
            Process.Start("log.txt");
        }

        void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void button5_Click(object sender, EventArgs e)
        {
            form11 f11 = new form11();
            f11.ShowDialog();
            this.Close();
        }

        void button6_Click(object sender, EventArgs e)
        {
            form12 f12 = new form12();
            f12.ShowDialog();
            this.Close();
        }
        void button8_Click(object sender, EventArgs e)
        {
            StreamReader restore = new StreamReader("buckup.dat",System.Text.Encoding.GetEncoding("shift_jis"));
            int count = 0;
            string data;
            while (restore.Peek() > -1)
            {
                data = restore.ReadLine();
                if (count == 0)
                {
                    form1.point11 = int.Parse(data);
                    form1.textbox1.Text = form1.point11.ToString();
                }
                else if (count == 1)
                {
                    form1.point12 = int.Parse(data);
                    form1.textbox2.Text = form1.point12.ToString();
                }
                else if (count == 2)
                {
                    form1.point13 = int.Parse(data);
                    form1.textbox3.Text = form1.point13.ToString();
                }
                else if (count == 3)
                {
                    form1.point21 = int.Parse(data);
                    form1.textbox4.Text = form1.point21.ToString();
                }
                else if (count == 4)
                {
                    form1.point22 = int.Parse(data);
                    form1.textbox5.Text = form1.point22.ToString();
                }
                else if(count == 5)
                {
                    form1.point23 = int.Parse(data);
                    form1.textbox6.Text = form1.point23.ToString();
                }
                else if(count == 6)
                {
                    form1.point31 = int.Parse(data);
                    form1.textbox7.Text = form1.point31.ToString();
                }
                else if(count == 7)
                {
                    form1.point32 = int.Parse(data);
                    form1.textbox8.Text = form1.point32.ToString();
                }
                else if(count == 8)
                {
                    form1.point33 = int.Parse(data);
                    form1.textbox9.Text = form1.point33.ToString();
                }
                else if(count == 9)
                {
                    form1.point1a = int.Parse(data);
                    form1.textbox10.Text = form1.point1a.ToString();
                }
                else if(count == 10)
                {
                    form1.point1b = int.Parse(data);
                    form1.textbox11.Text = form1.point1b.ToString();
                }
                else if(count == 11)
                {
                    form1.point1c = int.Parse(data);
                    form1.textbox12.Text = form1.point1c.ToString();
                }
                else if(count == 12)
                {
                    form1.point1d = int.Parse(data);
                    form1.textbox13.Text = form1.point1d.ToString();
                }
                else if(count == 13)
                {
                    form1.point1e = int.Parse(data);
                    form1.textbox14.Text = form1.point1e.ToString();
                }
                else if(count == 14)
                {
                    form1.point1f = int.Parse(data);
                    form1.textbox15.Text = form1.point1f.ToString();
                }
                else if(count == 15)
                {
                    form1.point1g = int.Parse(data);
                    form1.textbox16.Text = form1.point1g.ToString();
                }
                else if(count == 16)
                {
                    form1.point1h = int.Parse(data);
                    form1.textbox17.Text = form1.point1h.ToString();
                }
                else if(count == 17)
                {
                    form1.point2a = int.Parse(data);
                    form1.textbox18.Text = form1.point2a.ToString();
                }
                else if(count == 18)
                {
                    form1.point2b = int.Parse(data);
                    form1.textbox19.Text = form1.point2b.ToString();
                }
                else if(count == 19)
                {
                    form1.point2c = int.Parse(data);
                    form1.textbox20.Text = form1.point2c.ToString();
                }
                else if(count == 20)
                {
                    form1.point2d = int.Parse(data);
                    form1.textbox21.Text = form1.point2d.ToString();
                }
                else if(count == 21)
                {
                    form1.point2e = int.Parse(data);
                    form1.textbox22.Text = form1.point2e.ToString();
                }
                else if(count == 22)
                {
                    form1.point2f = int.Parse(data);
                    form1.textbox23.Text = form1.point2f.ToString();
                }
                else if(count == 23)
                {
                    form1.point2g = int.Parse(data);
                    form1.textbox24.Text = form1.point2g.ToString();
                }
                else if(count == 24)
                {
                    form1.point2h = int.Parse(data);
                    form1.textbox25.Text = form1.point2h.ToString();
                }
                else if(count == 25)
                {
                    form1.point3a = int.Parse(data);
                    form1.textbox26.Text = form1.point3a.ToString();
                }
                else if(count == 26)
                {
                    form1.point3b = int.Parse(data);
                    form1.textbox27.Text = form1.point3b.ToString();
                }
                else if(count == 27)
                {
                    form1.point3c = int.Parse(data);
                    form1.textbox28.Text = form1.point3c.ToString();
                }
                else if(count == 28)
                {
                    form1.point3d = int.Parse(data);
                    form1.textbox29.Text = form1.point3d.ToString();
                }
                else if(count == 29)
                {
                    form1.point3e = int.Parse(data);
                    form1.textbox30.Text = form1.point3e.ToString();
                }
                else if(count == 30)
                {
                    form1.point3f = int.Parse(data);
                    form1.textbox31.Text = form1.point3f.ToString();
                }
                else if(count == 31)
                {
                    form1.point3g = int.Parse(data);
                    form1.textbox32.Text = form1.point3g.ToString();
                }
                else if(count == 32)
                {
                    form1.point3h = int.Parse(data);
                    form1.textbox33.Text = form1.point3h.ToString();
                }
                else if (count == 33)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b1 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b1 = true;
                    }
                }
                else if (count == 34)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b2 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b2 = true;
                    }
                }
                else if (count == 35)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b3 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b3 = true;
                    }
                }
                else if (count == 36)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b4 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b4 = true;
                    }
                }
                else if (count == 37)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b5 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b5 = true;
                    }
                }
                else if (count == 38)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b6 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b6 = true;
                    }
                }
                else if (count == 39)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b7 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b7 = true;
                    }
                }
                else if (count == 40)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b8 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b8 = true;
                    }
                }
                else if (count == 41)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b9 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b9 = true;
                    }
                }
                else if (count == 42)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b10 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b10 = true;
                    }
                }
                else if (count == 43)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b11 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b11 = true;
                    }
                }
                else if (count == 44)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b12 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b12 = true;
                    }
                }
                else if (count == 45)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b13 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b13 = true;
                    }
                }
                else if (count == 46)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b14 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b14 = true;
                    }
                }
                else if (count == 47)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b15 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b15 = true;
                    }
                }
                else if (count == 48)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b16 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b16 = true;
                    }
                }
                else if (count == 49)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b17 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b17 = true;
                    }
                }
                else if (count == 50)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b18 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b18 = true;
                    }
                }
                else if (count == 51)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b19 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b19 = true;
                    }
                }
                else if (count == 52)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b20 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b20 = true;
                    }
                }
                else if (count == 53)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b21 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b21 = true;
                    }
                }
                else if (count == 54)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b22 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b22 = true;
                    }
                }
                else if (count == 55)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b23 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b23 = true;
                    }
                }
                else if (count == 56)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b24 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b24 = true;
                    }
                }
                else if (count == 57)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b25 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b25 = true;
                    }
                }
                else if (count == 58)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b26 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b26 = true;
                    }
                }
                else if (count == 59)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b27 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b27 = true;
                    }
                }
                else if (count == 60)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b28 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b28 = true;
                    }
                }
                else if (count == 61)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b29 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b29 = true;
                    }
                }
                else if (count == 62)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b30 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b30 = true;
                    }
                }
                else if (count == 63)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b31 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b31 = true;
                    }
                }
                else if (count == 64)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b32 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b32 = true;
                    }
                }
                else if (count == 65)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b33 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b33 = true;
                    }
                }
                else if (count == 66)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b34 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b34 = true;
                    }
                }
                else if (count == 67)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b35 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b35 = true;
                    }
                }
                else if (count == 68)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b36 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b36 = true;
                    }
                }
                else if (count == 69)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b37 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b37 = true;
                    }
                }
                else if (count == 70)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b38 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b38 = true;
                    }
                }
                else if (count == 71)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b39 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b39 = true;
                    }
                }
                else if (count == 72)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b40 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b40 = true;
                    }
                }
                else if (count == 73)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b41 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b41 = true;
                    }
                }
                else if (count == 74)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b42 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b42 = true;
                    }
                }
                else if (count == 75)
                {
                    int buff = int.Parse(data);
                    if (buff == 0)
                    {
                        form1.b43 = false;
                    }
                    else if(buff == 1)
                    {
                        form1.b43 = true;
                    }
                }
                count += 1;
            }
            if (form1.b43 == false)
            {
                this.button6.Enabled = false;
                this.button6.Text = "登録済み";
            }
            MessageBox.Show("完了しました", "", MessageBoxButtons.OK , MessageBoxIcon.Asterisk);
            this.Close();
        }
    }

    public partial class form3 : Form
    {
        public form3()
        {
            this.Width = 190;
            this.Height = 280;
            this.Text = "学年を選択";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Button button1 = new Button();
            button1.Location = new Point(30, 15);
            button1.Size = new Size(120, 40);
            button1.Text = "中学1年";
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(30, 70);
            button2.Size = new Size(120, 40);
            button2.Text = "中学2年";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Location = new Point(30, 125);
            button3.Size = new Size(120, 40);
            button3.Text = "中学3年";
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);

            Button button4 = new Button();
            button4.Location = new Point(30, 180);
            button4.Size = new Size(120, 40);
            button4.Text = "中止";
            button4.Click += new EventHandler(button4_Click);
            this.Controls.Add(button4);
        }

        void button1_Click(object sender, EventArgs e)
        {
            form5 f5 = new form5();
            f5.ShowDialog();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            form6 f6 = new form6();
            f6.ShowDialog();
            this.Close();
        }

        void button3_Click(object sender, EventArgs e)
        {
            form7 f7 = new form7();
            f7.ShowDialog();
            this.Close();
        }

        void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public partial class form4 : Form
    {
        public form4()
        {
            this.Width = 190;
            this.Height = 280;
            this.Text = "学年を選択";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;


            Button button1 = new Button();
            button1.Location = new Point(30, 15);
            button1.Size = new Size(120, 40);
            button1.Text = "高校1年";
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(30, 70);
            button2.Size = new Size(120, 40);
            button2.Text = "高校2年";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Location = new Point(30, 125);
            button3.Size = new Size(120, 40);
            button3.Text = "高校3年";
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);

            Button button4 = new Button();
            button4.Location = new Point(30, 180);
            button4.Size = new Size(120, 40);
            button4.Text = "中止";
            button4.Click += new EventHandler(button4_Click);
            this.Controls.Add(button4);
        }

        void button1_Click(object sender, EventArgs e)
        {
            form8 f8 = new form8();
            f8.ShowDialog();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            form9 f9 = new form9();
            f9.ShowDialog();
            this.Close();
        }

        void button3_Click(object sender, EventArgs e)
        {
            form10 f10 = new form10();
            f10.ShowDialog();
            this.Close();
        }

        void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public partial class form5 : Form
    {
        ComboBox combobox;
        Button button1;
        Label label4;
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        CheckBox checkbox1;
        CheckBox checkbox2;
        CheckBox checkbox3;
        public form5()
        {
            this.Width = 255;
            this.Height = 250;
            this.Text = "結果登録(中学1年)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.label4 = new Label();
            this.label4.Location = new Point(15, 40);
            this.label4.Size = new Size(210, 30);
            this.Controls.Add(this.label4);

            this.combobox = new ComboBox();
            this.combobox.Location = new Point(15, 15);
            this.combobox.Size = new Size(210, 20);
            this.combobox.Text = "競技を選択";
            this.combobox.Items.Add("70M走");
            this.combobox.Items.Add("障害物競走");
            this.combobox.Items.Add("菓子屋横丁");
            this.combobox.Items.Add("デカパン");
            this.combobox.Items.Add("F3");
            this.combobox.Items.Add("対抗綱引");
            this.combobox.SelectedIndexChanged += new EventHandler(combobox_Changed);
            this.Controls.Add(this.combobox);

            Label label1 = new Label();
            label1.Location = new Point(15, 80);
            label1.Size = new Size(60, 15);
            label1.Text = "1年1組";
            this.Controls.Add(label1);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 100);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.Text = "0";
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox1);

            this.checkbox1 = new CheckBox();
            this.checkbox1.Location = new Point(15, 120);
            this.checkbox1.Size = new Size(60, 15);
            this.checkbox1.Text = "参加点";
            this.Controls.Add(this.checkbox1);

            Label label2 = new Label();
            label2.Location = new Point(90, 80);
            label2.Size = new Size(60, 15);
            label2.Text = "1年2組";
            this.Controls.Add(label2);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 100);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.Text = "0";
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox2);

            this.checkbox2 = new CheckBox();
            this.checkbox2.Location = new Point(90, 120);
            this.checkbox2.Size = new Size(60, 15);
            this.checkbox2.Text = "参加点";
            this.Controls.Add(this.checkbox2);

            Label label3 = new Label();
            label3.Location = new Point(165, 80);
            label3.Size = new Size(60, 15);
            label3.Text = "1年3組";
            this.Controls.Add(label3);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 100);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.Text = "0";
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox3);

            this.checkbox3 = new CheckBox();
            this.checkbox3.Location = new Point(165, 120);
            this.checkbox3.Size = new Size(60, 15);
            this.checkbox3.Text = "参加点";
            this.Controls.Add(this.checkbox3);

            this.button1 = new Button();
            this.button1.Location = new Point(15, 140);
            this.button1.Size = new Size(95, 40);
            this.button1.Enabled = false;
            this.button1.Text = "登録";
            this.button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(125, 140);
            button2.Size = new Size(95, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Label label5 = new Label();
            label5.Location = new Point(15, 190);
            label5.Size = new Size(200, 15);
            label5.Text = "合計点を入力すること";
            this.Controls.Add(label5);
        }

        void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            string sa;
            string sb;
            string sc;
            sa = this.textbox1.Text;
            a = int.Parse(sa);
            sb = this.textbox2.Text;
            b = int.Parse(sb);
            sc = this.textbox3.Text;
            c = int.Parse(sc);
            if (this.checkbox1.Checked)
            {
                a += 3;
            }
            if (this.checkbox2.Checked)
            {
                b += 3;
            }
            if (this.checkbox3.Checked)
            {
                c += 3;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                form1.b1 = false;
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                form1.b2 = false;
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                form1.b3 = false;
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                form1.b4 = false;
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                form1.b5 = false;
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                form1.b6 = false;
            }
            form1.point11 = form1.point11 + a;
            form1.point12 = form1.point12 + b;
            form1.point13 = form1.point13 + c;
            form1.textbox1.Text = form1.point11.ToString();
            form1.textbox2.Text = form1.point12.ToString();
            form1.textbox3.Text = form1.point13.ToString();
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void combobox_Changed(object sender, EventArgs e)
        {
            if (this.combobox.SelectedIndex != -1)
            {
                this.button1.Enabled = true;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b1 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b2 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b3 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b4 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b5 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                this.label4.Text = "1位40点 2位30点 3位20点 4位10点" + Environment.NewLine + "参加点なし";
                if (form1.b6 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }

    public partial class form6 : Form
    {
        ComboBox combobox;
        Button button1;
        Label label4;
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        CheckBox checkbox1;
        CheckBox checkbox2;
        CheckBox checkbox3;
        public form6()
        {
            this.Width = 255;
            this.Height = 250;
            this.Text = "結果登録(中学2年)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.label4 = new Label();
            this.label4.Location = new Point(15, 40);
            this.label4.Size = new Size(210, 30);
            this.Controls.Add(this.label4);

            this.combobox = new ComboBox();
            this.combobox.Location = new Point(15, 15);
            this.combobox.Size = new Size(210, 20);
            this.combobox.Text = "競技を選択";
            this.combobox.Items.Add("障害物競走");
            this.combobox.Items.Add("台風の目");
            this.combobox.Items.Add("菓子屋横丁");
            this.combobox.Items.Add("デカパン");
            this.combobox.Items.Add("F3");
            this.combobox.Items.Add("対抗綱引");
            this.combobox.SelectedIndexChanged += new EventHandler(combobox_Changed);
            this.Controls.Add(this.combobox);

            Label label1 = new Label();
            label1.Location = new Point(15, 80);
            label1.Size = new Size(60, 15);
            label1.Text = "2年1組";
            this.Controls.Add(label1);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 100);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.Text = "0";
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox1);

            this.checkbox1 = new CheckBox();
            this.checkbox1.Location = new Point(15, 120);
            this.checkbox1.Size = new Size(60, 15);
            this.checkbox1.Text = "参加点";
            this.Controls.Add(this.checkbox1);

            Label label2 = new Label();
            label2.Location = new Point(90, 80);
            label2.Size = new Size(60, 15);
            label2.Text = "2年2組";
            this.Controls.Add(label2);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 100);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.Text = "0";
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox2);

            this.checkbox2 = new CheckBox();
            this.checkbox2.Location = new Point(90, 120);
            this.checkbox2.Size = new Size(60, 15);
            this.checkbox2.Text = "参加点";
            this.Controls.Add(this.checkbox2);

            Label label3 = new Label();
            label3.Location = new Point(165, 80);
            label3.Size = new Size(60, 15);
            label3.Text = "2年3組";
            this.Controls.Add(label3);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 100);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.Text = "0";
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox3);

            this.checkbox3 = new CheckBox();
            this.checkbox3.Location = new Point(165, 120);
            this.checkbox3.Size = new Size(60, 15);
            this.checkbox3.Text = "参加点";
            this.Controls.Add(this.checkbox3);

            this.button1 = new Button();
            this.button1.Location = new Point(15, 140);
            this.button1.Size = new Size(95, 40);
            this.button1.Enabled = false;
            this.button1.Text = "登録";
            this.button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(125, 140);
            button2.Size = new Size(95, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Label label5 = new Label();
            label5.Location = new Point(15, 190);
            label5.Size = new Size(200, 15);
            label5.Text = "合計点を入力すること";
            this.Controls.Add(label5);
        }

        void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            string sa;
            string sb;
            string sc;
            sa = this.textbox1.Text;
            a = int.Parse(sa);
            sb = this.textbox2.Text;
            b = int.Parse(sb);
            sc = this.textbox3.Text;
            c = int.Parse(sc);
            if (this.checkbox1.Checked)
            {
                a += 3;
            }
            if (this.checkbox2.Checked)
            {
                b += 3;
            }
            if (this.checkbox3.Checked)
            {
                c += 3;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                form1.b7 = false;
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                form1.b8 = false;
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                form1.b9 = false;
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                form1.b10 = false;
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                form1.b11 = false;
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                form1.b12 = false;
            }
            form1.point21 = form1.point21 + a;
            form1.point22 = form1.point22 + b;
            form1.point23 = form1.point23 + c;
            form1.textbox4.Text = form1.point21.ToString();
            form1.textbox5.Text = form1.point22.ToString();
            form1.textbox6.Text = form1.point23.ToString();
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void combobox_Changed(object sender, EventArgs e)
        {
            if (this.combobox.SelectedIndex != -1)
            {
                this.button1.Enabled = true;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b7 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                this.label4.Text = "1位40点 2位30点 3位20点" + Environment.NewLine + "参加点なし";
                if (form1.b8 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b9 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b10 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b11 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                this.label4.Text = "1位40点 2位30点 3位20点 4位10点" + Environment.NewLine + "参加点なし";
                if (form1.b12 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }

    public partial class form7 : Form
    {
        ComboBox combobox;
        Button button1;
        Label label4;
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        CheckBox checkbox1;
        CheckBox checkbox2;
        CheckBox checkbox3;
        public form7()
        {
            this.Width = 255;
            this.Height = 250;
            this.Text = "結果登録(中学3年)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.label4 = new Label();
            this.label4.Location = new Point(15, 40);
            this.label4.Size = new Size(210, 30);
            this.Controls.Add(this.label4);

            this.combobox = new ComboBox();
            this.combobox.Location = new Point(15, 15);
            this.combobox.Size = new Size(210, 20);
            this.combobox.Text = "競技を選択";
            this.combobox.Items.Add("障害物競走");
            this.combobox.Items.Add("菓子屋横丁");
            this.combobox.Items.Add("デカパン");
            this.combobox.Items.Add("大縄跳び");
            this.combobox.Items.Add("F3");
            this.combobox.Items.Add("対抗綱引");
            this.combobox.SelectedIndexChanged += new EventHandler(combobox_Changed);
            this.Controls.Add(this.combobox);

            Label label1 = new Label();
            label1.Location = new Point(15, 80);
            label1.Size = new Size(60, 15);
            label1.Text = "3年1組";
            this.Controls.Add(label1);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 100);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.Text = "0";
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox1);

            this.checkbox1 = new CheckBox();
            this.checkbox1.Location = new Point(15, 120);
            this.checkbox1.Size = new Size(60, 15);
            this.checkbox1.Text = "参加点";
            this.Controls.Add(this.checkbox1);

            Label label2 = new Label();
            label2.Location = new Point(90, 80);
            label2.Size = new Size(60, 15);
            label2.Text = "3年2組";
            this.Controls.Add(label2);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 100);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.Text = "0";
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox2);

            this.checkbox2 = new CheckBox();
            this.checkbox2.Location = new Point(90, 120);
            this.checkbox2.Size = new Size(60, 15);
            this.checkbox2.Text = "参加点";
            this.Controls.Add(this.checkbox2);

            Label label3 = new Label();
            label3.Location = new Point(165, 80);
            label3.Size = new Size(60, 15);
            label3.Text = "3年3組";
            this.Controls.Add(label3);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 100);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.Text = "0";
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox3);

            this.checkbox3 = new CheckBox();
            this.checkbox3.Location = new Point(165, 120);
            this.checkbox3.Size = new Size(60, 15);
            this.checkbox3.Text = "参加点";
            this.Controls.Add(this.checkbox3);

            this.button1 = new Button();
            this.button1.Location = new Point(15, 140);
            this.button1.Size = new Size(95, 40);
            this.button1.Enabled = false;
            this.button1.Text = "登録";
            this.button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(125, 140);
            button2.Size = new Size(95, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Label label5 = new Label();
            label5.Location = new Point(15, 190);
            label5.Size = new Size(200, 15);
            label5.Text = "合計点を入力すること";
            this.Controls.Add(label5);
        }

        void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            string sa;
            string sb;
            string sc;
            sa = this.textbox1.Text;
            a = int.Parse(sa);
            sb = this.textbox2.Text;
            b = int.Parse(sb);
            sc = this.textbox3.Text;
            c = int.Parse(sc);
            if (this.checkbox1.Checked)
            {
                a += 3;
            }
            if (this.checkbox2.Checked)
            {
                b += 3;
            }
            if (this.checkbox3.Checked)
            {
                c += 3;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                form1.b13 = false;
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                form1.b14 = false;
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                form1.b15 = false;
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                form1.b16 = false;
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                form1.b17 = false;
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                form1.b18 = false;
            }
            form1.point31 = form1.point31 + a;
            form1.point32 = form1.point32 + b;
            form1.point33 = form1.point33 + c;
            form1.textbox7.Text = form1.point31.ToString();
            form1.textbox8.Text = form1.point32.ToString();
            form1.textbox9.Text = form1.point33.ToString();
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void combobox_Changed(object sender, EventArgs e)
        {
            if (this.combobox.SelectedIndex != -1)
            {
                this.button1.Enabled = true;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b13 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b14 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b15 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                this.label4.Text = "1位40点 2位30点 3位20点" + Environment.NewLine + "参加点なし";
                if (form1.b16 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b17 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                this.label4.Text = "1位40点 2位30点 3位20点 4位10点" + Environment.NewLine + "参加点なし";
                if (form1.b18 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }

    public partial class form8 : Form
    {
        ComboBox combobox;
        Button button1;
        Label label4;
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        TextBox textbox4;
        TextBox textbox5;
        TextBox textbox6;
        TextBox textbox7;
        TextBox textbox8;
        CheckBox checkbox1;
        CheckBox checkbox2;
        CheckBox checkbox3;
        CheckBox checkbox4;
        CheckBox checkbox5;
        CheckBox checkbox6;
        CheckBox checkbox7;
        CheckBox checkbox8;
        public form8()
        {
            this.Width = 330;
            this.Height = 310;
            this.Text = "結果登録(高校1年)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.label4 = new Label();
            this.label4.Location = new Point(15, 40);
            this.label4.Size = new Size(210, 30);
            this.Controls.Add(this.label4);

            this.combobox = new ComboBox();
            this.combobox.Location = new Point(15, 15);
            this.combobox.Size = new Size(210, 20);
            this.combobox.Text = "競技を選択";
            this.combobox.Items.Add("100M予選");
            this.combobox.Items.Add("障害物競走");
            this.combobox.Items.Add("送球");
            this.combobox.Items.Add("菓子屋横丁");
            this.combobox.Items.Add("2人3脚リレー");
            this.combobox.Items.Add("増えるボール");
            this.combobox.Items.Add("100M決勝");
            this.combobox.SelectedIndexChanged += new EventHandler(combobox_Changed);
            this.Controls.Add(this.combobox);

            Label label1 = new Label();
            label1.Location = new Point(15, 80);
            label1.Size = new Size(60, 15);
            label1.Text = "1年A組";
            this.Controls.Add(label1);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 100);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.Text = "0";
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox1);

            this.checkbox1 = new CheckBox();
            this.checkbox1.Location = new Point(15, 120);
            this.checkbox1.Size = new Size(60, 15);
            this.checkbox1.Text = "参加点";
            this.Controls.Add(this.checkbox1);

            Label label2 = new Label();
            label2.Location = new Point(90, 80);
            label2.Size = new Size(60, 15);
            label2.Text = "1年B組";
            this.Controls.Add(label2);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 100);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.Text = "0";
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox2);

            this.checkbox2 = new CheckBox();
            this.checkbox2.Location = new Point(90, 120);
            this.checkbox2.Size = new Size(60, 15);
            this.checkbox2.Text = "参加点";
            this.Controls.Add(this.checkbox2);

            Label label3 = new Label();
            label3.Location = new Point(165, 80);
            label3.Size = new Size(60, 15);
            label3.Text = "1年C組";
            this.Controls.Add(label3);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 100);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.Text = "0";
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox3);

            this.checkbox3 = new CheckBox();
            this.checkbox3.Location = new Point(165, 120);
            this.checkbox3.Size = new Size(60, 15);
            this.checkbox3.Text = "参加点";
            this.Controls.Add(this.checkbox3);

            Label label4 = new Label();
            label4.Location = new Point(240, 80);
            label4.Size = new Size(60, 15);
            label4.Text = "1年D組";
            this.Controls.Add(label4);

            this.textbox4 = new TextBox();
            this.textbox4.Location = new Point(240, 100);
            this.textbox4.Size = new Size(60, 15);
            this.textbox4.Text = "0";
            this.textbox4.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox4);

            this.checkbox4 = new CheckBox();
            this.checkbox4.Location = new Point(240, 120);
            this.checkbox4.Size = new Size(60, 15);
            this.checkbox4.Text = "参加点";
            this.Controls.Add(this.checkbox4);

            Label label5 = new Label();
            label5.Location = new Point(15, 140);
            label5.Size = new Size(60, 15);
            label5.Text = "1年E組";
            this.Controls.Add(label5);

            this.textbox5 = new TextBox();
            this.textbox5.Location = new Point(15, 160);
            this.textbox5.Size = new Size(60, 15);
            this.textbox5.Text = "0";
            this.textbox5.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox5);

            this.checkbox5 = new CheckBox();
            this.checkbox5.Location = new Point(15, 180);
            this.checkbox5.Size = new Size(60, 15);
            this.checkbox5.Text = "参加点";
            this.Controls.Add(this.checkbox5);

            Label label6 = new Label();
            label6.Location = new Point(90, 140);
            label6.Size = new Size(60, 15);
            label6.Text = "1年F組";
            this.Controls.Add(label6);

            this.textbox6 = new TextBox();
            this.textbox6.Location = new Point(90, 160);
            this.textbox6.Size = new Size(60, 15);
            this.textbox6.Text = "0";
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox6);

            this.checkbox6 = new CheckBox();
            this.checkbox6.Location = new Point(90, 180);
            this.checkbox6.Size = new Size(60, 15);
            this.checkbox6.Text = "参加点";
            this.Controls.Add(this.checkbox6);

            Label label7 = new Label();
            label7.Location = new Point(165, 140);
            label7.Size = new Size(60, 15);
            label7.Text = "1年G組";
            this.Controls.Add(label7);

            this.textbox7 = new TextBox();
            this.textbox7.Location = new Point(165, 160);
            this.textbox7.Size = new Size(60, 15);
            this.textbox7.Text = "0";
            this.textbox7.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox7);

            this.checkbox7 = new CheckBox();
            this.checkbox7.Location = new Point(165, 180);
            this.checkbox7.Size = new Size(60, 15);
            this.checkbox7.Text = "参加点";
            this.Controls.Add(this.checkbox7);

            Label label8 = new Label();
            label8.Location = new Point(240, 140);
            label8.Size = new Size(60, 15);
            label8.Text = "1年H組";
            this.Controls.Add(label8);

            this.textbox8 = new TextBox();
            this.textbox8.Location = new Point(240, 160);
            this.textbox8.Size = new Size(60, 15);
            this.textbox8.Text = "0";
            this.textbox8.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox8);

            this.checkbox8 = new CheckBox();
            this.checkbox8.Location = new Point(240, 180);
            this.checkbox8.Size = new Size(60, 15);
            this.checkbox8.Text = "参加点";
            this.Controls.Add(this.checkbox8);

            this.button1 = new Button();
            this.button1.Location = new Point(15, 200);
            this.button1.Size = new Size(95, 40);
            this.button1.Enabled = false;
            this.button1.Text = "登録";
            this.button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(125, 200);
            button2.Size = new Size(95, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Label label9 = new Label();
            label9.Location = new Point(15, 250);
            label9.Size = new Size(200, 15);
            label9.Text = "合計点を入力すること";
            this.Controls.Add(label9);
        }

        void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            int ee;
            int f;
            int g;
            int h;
            string sa;
            string sb;
            string sc;
            string sd;
            string see;
            string sf;
            string sg;
            string sh;
            sa = this.textbox1.Text;
            a = int.Parse(sa);
            sb = this.textbox2.Text;
            b = int.Parse(sb);
            sc = this.textbox3.Text;
            c = int.Parse(sc);
            sd = this.textbox4.Text;
            d = int.Parse(sd);
            see = this.textbox5.Text;
            ee = int.Parse(see);
            sf = this.textbox6.Text;
            f = int.Parse(sf);
            sg = this.textbox7.Text;
            g = int.Parse(sg);
            sh = this.textbox8.Text;
            h = int.Parse(sh);
            if (this.checkbox1.Checked)
            {
                a += 3;
            }
            if (this.checkbox2.Checked)
            {
                b += 3;
            }
            if (this.checkbox3.Checked)
            {
                c += 3;
            }
            if (this.checkbox4.Checked)
            {
                d += 3;
            }
            if (this.checkbox5.Checked)
            {
                ee += 3;
            }
            if (this.checkbox6.Checked)
            {
                f += 3;
            }
            if (this.checkbox7.Checked)
            {
                g += 3;
            }
            if (this.checkbox8.Checked)
            {
                h += 3;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                form1.b19 = false;
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                form1.b20 = false;
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                form1.b21 = false;
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                form1.b22 = false;
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                form1.b23 = false;
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                form1.b24 = false;
            }
            else if (this.combobox.SelectedIndex == 6)
            {
                form1.b25 = false;
            }
            form1.point1a = form1.point1a + a;
            form1.point1b = form1.point1b + b;
            form1.point1c = form1.point1c + c;
            form1.point1d = form1.point1d + d;
            form1.point1e = form1.point1e + ee;
            form1.point1f = form1.point1f + f;
            form1.point1g = form1.point1g + g;
            form1.point1h = form1.point1h + h;
            form1.textbox10.Text = form1.point1a.ToString();
            form1.textbox11.Text = form1.point1b.ToString();
            form1.textbox12.Text = form1.point1c.ToString();
            form1.textbox13.Text = form1.point1d.ToString();
            form1.textbox14.Text = form1.point1e.ToString();
            form1.textbox15.Text = form1.point1f.ToString();
            form1.textbox16.Text = form1.point1g.ToString();
            form1.textbox17.Text = form1.point1h.ToString();
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void combobox_Changed(object sender, EventArgs e)
        {
            if (this.combobox.SelectedIndex != -1)
            {
                this.button1.Enabled = true;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b19 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b20 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b21 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b22 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b23 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b24 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 6)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b25 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }

    public partial class form9 : Form
    {
        ComboBox combobox;
        Button button1;
        Label label4;
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        TextBox textbox4;
        TextBox textbox5;
        TextBox textbox6;
        TextBox textbox7;
        TextBox textbox8;
        CheckBox checkbox1;
        CheckBox checkbox2;
        CheckBox checkbox3;
        CheckBox checkbox4;
        CheckBox checkbox5;
        CheckBox checkbox6;
        CheckBox checkbox7;
        CheckBox checkbox8;
        public form9()
        {
            this.Width = 330;
            this.Height = 310;
            this.Text = "結果登録(高校2年)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.label4 = new Label();
            this.label4.Location = new Point(15, 40);
            this.label4.Size = new Size(210, 30);
            this.Controls.Add(this.label4);

            this.combobox = new ComboBox();
            this.combobox.Location = new Point(15, 15);
            this.combobox.Size = new Size(210, 20);
            this.combobox.Text = "競技を選択";
            this.combobox.Items.Add("100M予選");
            this.combobox.Items.Add("障害物競走");
            this.combobox.Items.Add("送球");
            this.combobox.Items.Add("菓子屋横丁");
            this.combobox.Items.Add("増えるボール");
            this.combobox.Items.Add("100M決勝");
            this.combobox.Items.Add("F2");
            this.combobox.SelectedIndexChanged += new EventHandler(combobox_Changed);
            this.Controls.Add(this.combobox);

            Label label1 = new Label();
            label1.Location = new Point(15, 80);
            label1.Size = new Size(60, 15);
            label1.Text = "2年A組";
            this.Controls.Add(label1);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 100);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.Text = "0";
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox1);

            this.checkbox1 = new CheckBox();
            this.checkbox1.Location = new Point(15, 120);
            this.checkbox1.Size = new Size(60, 15);
            this.checkbox1.Text = "参加点";
            this.Controls.Add(this.checkbox1);

            Label label2 = new Label();
            label2.Location = new Point(90, 80);
            label2.Size = new Size(60, 15);
            label2.Text = "2年B組";
            this.Controls.Add(label2);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 100);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.Text = "0";
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox2);

            this.checkbox2 = new CheckBox();
            this.checkbox2.Location = new Point(90, 120);
            this.checkbox2.Size = new Size(60, 15);
            this.checkbox2.Text = "参加点";
            this.Controls.Add(this.checkbox2);

            Label label3 = new Label();
            label3.Location = new Point(165, 80);
            label3.Size = new Size(60, 15);
            label3.Text = "2年C組";
            this.Controls.Add(label3);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 100);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.Text = "0";
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox3);

            this.checkbox3 = new CheckBox();
            this.checkbox3.Location = new Point(165, 120);
            this.checkbox3.Size = new Size(60, 15);
            this.checkbox3.Text = "参加点";
            this.Controls.Add(this.checkbox3);

            Label label4 = new Label();
            label4.Location = new Point(240, 80);
            label4.Size = new Size(60, 15);
            label4.Text = "2年D組";
            this.Controls.Add(label4);

            this.textbox4 = new TextBox();
            this.textbox4.Location = new Point(240, 100);
            this.textbox4.Size = new Size(60, 15);
            this.textbox4.Text = "0";
            this.textbox4.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox4);

            this.checkbox4 = new CheckBox();
            this.checkbox4.Location = new Point(240, 120);
            this.checkbox4.Size = new Size(60, 15);
            this.checkbox4.Text = "参加点";
            this.Controls.Add(this.checkbox4);

            Label label5 = new Label();
            label5.Location = new Point(15, 140);
            label5.Size = new Size(60, 15);
            label5.Text = "2年E組";
            this.Controls.Add(label5);

            this.textbox5 = new TextBox();
            this.textbox5.Location = new Point(15, 160);
            this.textbox5.Size = new Size(60, 15);
            this.textbox5.Text = "0";
            this.textbox5.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox5);

            this.checkbox5 = new CheckBox();
            this.checkbox5.Location = new Point(15, 180);
            this.checkbox5.Size = new Size(60, 15);
            this.checkbox5.Text = "参加点";
            this.Controls.Add(this.checkbox5);

            Label label6 = new Label();
            label6.Location = new Point(90, 140);
            label6.Size = new Size(60, 15);
            label6.Text = "2年F組";
            this.Controls.Add(label6);

            this.textbox6 = new TextBox();
            this.textbox6.Location = new Point(90, 160);
            this.textbox6.Size = new Size(60, 15);
            this.textbox6.Text = "0";
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox6);

            this.checkbox6 = new CheckBox();
            this.checkbox6.Location = new Point(90, 180);
            this.checkbox6.Size = new Size(60, 15);
            this.checkbox6.Text = "参加点";
            this.Controls.Add(this.checkbox6);

            Label label7 = new Label();
            label7.Location = new Point(165, 140);
            label7.Size = new Size(60, 15);
            label7.Text = "2年G組";
            this.Controls.Add(label7);

            this.textbox7 = new TextBox();
            this.textbox7.Location = new Point(165, 160);
            this.textbox7.Size = new Size(60, 15);
            this.textbox7.Text = "0";
            this.textbox7.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox7);

            this.checkbox7 = new CheckBox();
            this.checkbox7.Location = new Point(165, 180);
            this.checkbox7.Size = new Size(60, 15);
            this.checkbox7.Text = "参加点";
            this.Controls.Add(this.checkbox7);

            Label label8 = new Label();
            label8.Location = new Point(240, 140);
            label8.Size = new Size(60, 15);
            label8.Text = "2年H組";
            this.Controls.Add(label8);

            this.textbox8 = new TextBox();
            this.textbox8.Location = new Point(240, 160);
            this.textbox8.Size = new Size(60, 15);
            this.textbox8.Text = "0";
            this.textbox8.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox8);

            this.checkbox8 = new CheckBox();
            this.checkbox8.Location = new Point(240, 180);
            this.checkbox8.Size = new Size(60, 15);
            this.checkbox8.Text = "参加点";
            this.Controls.Add(this.checkbox8);

            this.button1 = new Button();
            this.button1.Location = new Point(15, 200);
            this.button1.Size = new Size(95, 40);
            this.button1.Enabled = false;
            this.button1.Text = "登録";
            this.button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(125, 200);
            button2.Size = new Size(95, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Label label9 = new Label();
            label9.Location = new Point(15, 250);
            label9.Size = new Size(200, 15);
            label9.Text = "合計点を入力すること";
            this.Controls.Add(label9);
        }
        void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            int ee;
            int f;
            int g;
            int h;
            string sa;
            string sb;
            string sc;
            string sd;
            string see;
            string sf;
            string sg;
            string sh;
            sa = this.textbox1.Text;
            a = int.Parse(sa);
            sb = this.textbox2.Text;
            b = int.Parse(sb);
            sc = this.textbox3.Text;
            c = int.Parse(sc);
            sd = this.textbox4.Text;
            d = int.Parse(sd);
            see = this.textbox5.Text;
            ee = int.Parse(see);
            sf = this.textbox6.Text;
            f = int.Parse(sf);
            sg = this.textbox7.Text;
            g = int.Parse(sg);
            sh = this.textbox8.Text;
            h = int.Parse(sh);
            if (this.checkbox1.Checked)
            {
                a += 3;
            }
            if (this.checkbox2.Checked)
            {
                b += 3;
            }
            if (this.checkbox3.Checked)
            {
                c += 3;
            }
            if (this.checkbox4.Checked)
            {
                d += 3;
            }
            if (this.checkbox5.Checked)
            {
                ee += 3;
            }
            if (this.checkbox6.Checked)
            {
                f += 3;
            }
            if (this.checkbox7.Checked)
            {
                g += 3;
            }
            if (this.checkbox8.Checked)
            {
                h += 3;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                form1.b26 = false;
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                form1.b27 = false;
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                form1.b28 = false;
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                form1.b29 = false;
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                form1.b30 = false;
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                form1.b31 = false;
            }
            else if (this.combobox.SelectedIndex == 6)
            {
                form1.b32 = false;
            }
            form1.point2a = form1.point2a + a;
            form1.point2b = form1.point2b + b;
            form1.point2c = form1.point2c + c;
            form1.point2d = form1.point2d + d;
            form1.point2e = form1.point2e + ee;
            form1.point2f = form1.point2f + f;
            form1.point2g = form1.point2g + g;
            form1.point2h = form1.point2h + h;
            form1.textbox18.Text = form1.point2a.ToString();
            form1.textbox19.Text = form1.point2b.ToString();
            form1.textbox20.Text = form1.point2c.ToString();
            form1.textbox21.Text = form1.point2d.ToString();
            form1.textbox22.Text = form1.point2e.ToString();
            form1.textbox23.Text = form1.point2f.ToString();
            form1.textbox24.Text = form1.point2g.ToString();
            form1.textbox25.Text = form1.point2h.ToString();
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void combobox_Changed(object sender, EventArgs e)
        {
            if (this.combobox.SelectedIndex != -1)
            {
                this.button1.Enabled = true;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b26 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b27 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b28 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b29 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b30 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b31 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 6)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b32 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }

    public partial class form10 : Form
    {
        ComboBox combobox;
        Button button1;
        Label label4;
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        TextBox textbox4;
        TextBox textbox5;
        TextBox textbox6;
        TextBox textbox7;
        TextBox textbox8;
        CheckBox checkbox1;
        CheckBox checkbox2;
        CheckBox checkbox3;
        CheckBox checkbox4;
        CheckBox checkbox5;
        CheckBox checkbox6;
        CheckBox checkbox7;
        CheckBox checkbox8;
        public form10()
        {
            this.Width = 330;
            this.Height = 310;
            this.Text = "結果登録(高校3年)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.label4 = new Label();
            this.label4.Location = new Point(15, 40);
            this.label4.Size = new Size(210, 30);
            this.Controls.Add(this.label4);

            this.combobox = new ComboBox();
            this.combobox.Location = new Point(15, 15);
            this.combobox.Size = new Size(210, 20);
            this.combobox.Text = "競技を選択";
            this.combobox.Items.Add("100M予選");
            this.combobox.Items.Add("障害物競走");
            this.combobox.Items.Add("送球");
            this.combobox.Items.Add("菓子屋横丁");
            this.combobox.Items.Add("増えるボール");
            this.combobox.Items.Add("THE・リカちゃん");
            this.combobox.Items.Add("100M決勝");
            this.combobox.SelectedIndexChanged += new EventHandler(combobox_Changed);
            this.Controls.Add(this.combobox);

            Label label1 = new Label();
            label1.Location = new Point(15, 80);
            label1.Size = new Size(60, 15);
            label1.Text = "3年A組";
            this.Controls.Add(label1);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 100);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.Text = "0";
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox1);

            this.checkbox1 = new CheckBox();
            this.checkbox1.Location = new Point(15, 120);
            this.checkbox1.Size = new Size(60, 15);
            this.checkbox1.Text = "参加点";
            this.Controls.Add(this.checkbox1);

            Label label2 = new Label();
            label2.Location = new Point(90, 80);
            label2.Size = new Size(60, 15);
            label2.Text = "3年B組";
            this.Controls.Add(label2);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 100);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.Text = "0";
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox2);

            this.checkbox2 = new CheckBox();
            this.checkbox2.Location = new Point(90, 120);
            this.checkbox2.Size = new Size(60, 15);
            this.checkbox2.Text = "参加点";
            this.Controls.Add(this.checkbox2);

            Label label3 = new Label();
            label3.Location = new Point(165, 80);
            label3.Size = new Size(60, 15);
            label3.Text = "3年C組";
            this.Controls.Add(label3);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 100);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.Text = "0";
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox3);

            this.checkbox3 = new CheckBox();
            this.checkbox3.Location = new Point(165, 120);
            this.checkbox3.Size = new Size(60, 15);
            this.checkbox3.Text = "参加点";
            this.Controls.Add(this.checkbox3);

            Label label4 = new Label();
            label4.Location = new Point(240, 80);
            label4.Size = new Size(60, 15);
            label4.Text = "3年D組";
            this.Controls.Add(label4);

            this.textbox4 = new TextBox();
            this.textbox4.Location = new Point(240, 100);
            this.textbox4.Size = new Size(60, 15);
            this.textbox4.Text = "0";
            this.textbox4.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox4);

            this.checkbox4 = new CheckBox();
            this.checkbox4.Location = new Point(240, 120);
            this.checkbox4.Size = new Size(60, 15);
            this.checkbox4.Text = "参加点";
            this.Controls.Add(this.checkbox4);

            Label label5 = new Label();
            label5.Location = new Point(15, 140);
            label5.Size = new Size(60, 15);
            label5.Text = "3年E組";
            this.Controls.Add(label5);

            this.textbox5 = new TextBox();
            this.textbox5.Location = new Point(15, 160);
            this.textbox5.Size = new Size(60, 15);
            this.textbox5.Text = "0";
            this.textbox5.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox5);

            this.checkbox5 = new CheckBox();
            this.checkbox5.Location = new Point(15, 180);
            this.checkbox5.Size = new Size(60, 15);
            this.checkbox5.Text = "参加点";
            this.Controls.Add(this.checkbox5);

            Label label6 = new Label();
            label6.Location = new Point(90, 140);
            label6.Size = new Size(60, 15);
            label6.Text = "3年F組";
            this.Controls.Add(label6);

            this.textbox6 = new TextBox();
            this.textbox6.Location = new Point(90, 160);
            this.textbox6.Size = new Size(60, 15);
            this.textbox6.Text = "0";
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox6);

            this.checkbox6 = new CheckBox();
            this.checkbox6.Location = new Point(90, 180);
            this.checkbox6.Size = new Size(60, 15);
            this.checkbox6.Text = "参加点";
            this.Controls.Add(this.checkbox6);

            Label label7 = new Label();
            label7.Location = new Point(165, 140);
            label7.Size = new Size(60, 15);
            label7.Text = "3年G組";
            this.Controls.Add(label7);

            this.textbox7 = new TextBox();
            this.textbox7.Location = new Point(165, 160);
            this.textbox7.Size = new Size(60, 15);
            this.textbox7.Text = "0";
            this.textbox7.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox7);

            this.checkbox7 = new CheckBox();
            this.checkbox7.Location = new Point(165, 180);
            this.checkbox7.Size = new Size(60, 15);
            this.checkbox7.Text = "参加点";
            this.Controls.Add(this.checkbox7);

            Label label8 = new Label();
            label8.Location = new Point(240, 140);
            label8.Size = new Size(60, 15);
            label8.Text = "3年H組";
            this.Controls.Add(label8);

            this.textbox8 = new TextBox();
            this.textbox8.Location = new Point(240, 160);
            this.textbox8.Size = new Size(60, 15);
            this.textbox8.Text = "0";
            this.textbox8.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox8);

            this.checkbox8 = new CheckBox();
            this.checkbox8.Location = new Point(240, 180);
            this.checkbox8.Size = new Size(60, 15);
            this.checkbox8.Text = "参加点";
            this.Controls.Add(this.checkbox8);

            this.button1 = new Button();
            this.button1.Location = new Point(15, 200);
            this.button1.Size = new Size(95, 40);
            this.button1.Enabled = false;
            this.button1.Text = "登録";
            this.button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(125, 200);
            button2.Size = new Size(95, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Label label9 = new Label();
            label9.Location = new Point(15, 250);
            label9.Size = new Size(200, 15);
            label9.Text = "合計点を入力すること";
            this.Controls.Add(label9);
        }
        void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            int ee;
            int f;
            int g;
            int h;
            string sa;
            string sb;
            string sc;
            string sd;
            string see;
            string sf;
            string sg;
            string sh;
            sa = this.textbox1.Text;
            a = int.Parse(sa);
            sb = this.textbox2.Text;
            b = int.Parse(sb);
            sc = this.textbox3.Text;
            c = int.Parse(sc);
            sd = this.textbox4.Text;
            d = int.Parse(sd);
            see = this.textbox5.Text;
            ee = int.Parse(see);
            sf = this.textbox6.Text;
            f = int.Parse(sf);
            sg = this.textbox7.Text;
            g = int.Parse(sg);
            sh = this.textbox8.Text;
            h = int.Parse(sh);
            if (this.checkbox1.Checked)
            {
                a += 3;
            }
            if (this.checkbox2.Checked)
            {
                b += 3;
            }
            if (this.checkbox3.Checked)
            {
                c += 3;
            }
            if (this.checkbox4.Checked)
            {
                d += 3;
            }
            if (this.checkbox5.Checked)
            {
                ee += 3;
            }
            if (this.checkbox6.Checked)
            {
                f += 3;
            }
            if (this.checkbox7.Checked)
            {
                g += 3;
            }
            if (this.checkbox8.Checked)
            {
                h += 3;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                form1.b33 = false;
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                form1.b34 = false;
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                form1.b35 = false;
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                form1.b36 = false;
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                form1.b37 = false;
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                form1.b38 = false;
            }
            else if (this.combobox.SelectedIndex == 6)
            {
                form1.b39 = false;
            }
            form1.point3a = form1.point3a + a;
            form1.point3b = form1.point3b + b;
            form1.point3c = form1.point3c + c;
            form1.point3d = form1.point3d + d;
            form1.point3e = form1.point3e + ee;
            form1.point3f = form1.point3f + f;
            form1.point3g = form1.point3g + g;
            form1.point3h = form1.point3h + h;
            form1.textbox26.Text = form1.point3a.ToString();
            form1.textbox27.Text = form1.point3b.ToString();
            form1.textbox28.Text = form1.point3c.ToString();
            form1.textbox29.Text = form1.point3d.ToString();
            form1.textbox30.Text = form1.point3e.ToString();
            form1.textbox31.Text = form1.point3f.ToString();
            form1.textbox32.Text = form1.point3g.ToString();
            form1.textbox33.Text = form1.point3h.ToString();
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void combobox_Changed(object sender, EventArgs e)
        {
            if (this.combobox.SelectedIndex != -1)
            {
                this.button1.Enabled = true;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b33 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b34 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b35 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 3)
            {
                this.label4.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (form1.b36 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 4)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b37 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 5)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b38 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 6)
            {
                this.label4.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (form1.b39 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }

    public partial class form11 : Form
    {
        ComboBox combobox;
        Button button1;
        Label label4;
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        TextBox textbox4;
        TextBox textbox5;
        TextBox textbox6;
        public form11()
        {
            this.Width = 255;
            this.Height = 310;
            this.Text = "結果登録(学年対抗系)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.label4 = new Label();
            this.label4.Location = new Point(15, 40);
            this.label4.Size = new Size(210, 30);
            this.Controls.Add(this.label4);

            this.combobox = new ComboBox();
            this.combobox.Location = new Point(15, 15);
            this.combobox.Size = new Size(210, 20);
            this.combobox.Text = "競技を選択";
            this.combobox.Items.Add("学年対抗リレー");
            this.combobox.Items.Add("対抗綱引(高校のみ)");
            this.combobox.Items.Add("川島の合戦(高校のみ)");
            this.combobox.SelectedIndexChanged += new EventHandler(combobox_Changed);
            this.Controls.Add(this.combobox);

            Label label1 = new Label();
            label1.Location = new Point(15, 80);
            label1.Size = new Size(60, 15);
            label1.Text = "中学1年";
            this.Controls.Add(label1);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 100);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.Text = "0";
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox1);

            Label label2 = new Label();
            label2.Location = new Point(90, 80);
            label2.Size = new Size(60, 15);
            label2.Text = "中学2年";
            this.Controls.Add(label2);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 100);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.Text = "0";
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox2);

            Label label3 = new Label();
            label3.Location = new Point(165, 80);
            label3.Size = new Size(60, 15);
            label3.Text = "中学3年";
            this.Controls.Add(label3);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 100);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.Text = "0";
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox3);

            Label label4 = new Label();
            label4.Location = new Point(15, 140);
            label4.Size = new Size(60, 15);
            label4.Text = "高校1年";
            this.Controls.Add(label4);

            this.textbox4 = new TextBox();
            this.textbox4.Location = new Point(15, 160);
            this.textbox4.Size = new Size(60, 15);
            this.textbox4.Text = "0";
            this.textbox4.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox4);

            Label label5 = new Label();
            label5.Location = new Point(90, 140);
            label5.Size = new Size(60, 15);
            label5.Text = "高校2年";
            this.Controls.Add(label5);

            this.textbox5 = new TextBox();
            this.textbox5.Location = new Point(90, 160);
            this.textbox5.Size = new Size(60, 15);
            this.textbox5.Text = "0";
            this.textbox5.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox5);

            Label label6 = new Label();
            label6.Location = new Point(165, 140);
            label6.Size = new Size(60, 15);
            label6.Text = "高校3年";
            this.Controls.Add(label6);

            this.textbox6 = new TextBox();
            this.textbox6.Location = new Point(165, 160);
            this.textbox6.Size = new Size(60, 15);
            this.textbox6.Text = "0";
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.Controls.Add(this.textbox6);

            this.button1 = new Button();
            this.button1.Location = new Point(15, 200);
            this.button1.Size = new Size(95, 40);
            this.button1.Enabled = false;
            this.button1.Text = "登録";
            this.button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(125, 200);
            button2.Size = new Size(95, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Label label9 = new Label();
            label9.Location = new Point(15, 250);
            label9.Size = new Size(200, 15);
            label9.Text = "合計点を入力すること";
            this.Controls.Add(label9);
        }

        void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            int ee;
            int f;
            string sa;
            string sb;
            string sc;
            string sd;
            string see;
            string sf;
            sa = this.textbox1.Text;
            a = int.Parse(sa);
            sb = this.textbox2.Text;
            b = int.Parse(sb);
            sc = this.textbox3.Text;
            c = int.Parse(sc);
            sd = this.textbox4.Text;
            d = int.Parse(sd);
            see = this.textbox5.Text;
            ee = int.Parse(see);
            sf = this.textbox6.Text;
            f = int.Parse(sf);
            if (this.combobox.SelectedIndex == 0)
            {
                form1.b40 = false;
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                form1.b41 = false;
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                form1.b42 = false;
            }
            form1.point11 = form1.point11 + a;
            form1.point12 = form1.point12 + a;
            form1.point13 = form1.point13 + a;
            form1.point21 = form1.point21 + b;
            form1.point22 = form1.point22 + b;
            form1.point23 = form1.point23 + b;
            form1.point31 = form1.point31 + c;
            form1.point32 = form1.point32 + c;
            form1.point33 = form1.point33 + c;
            form1.point1a = form1.point1a + d;
            form1.point1b = form1.point1b + d;
            form1.point1c = form1.point1c + d;
            form1.point1d = form1.point1d + d;
            form1.point1e = form1.point1e + d;
            form1.point1f = form1.point1f + d;
            form1.point1g = form1.point1g + d;
            form1.point1h = form1.point1h + d;
            form1.point2a = form1.point2a + ee;
            form1.point2b = form1.point2b + ee;
            form1.point2c = form1.point2c + ee;
            form1.point2d = form1.point2d + ee;
            form1.point2e = form1.point2e + ee;
            form1.point2f = form1.point2f + ee;
            form1.point2g = form1.point2g + ee;
            form1.point2h = form1.point2h + ee;
            form1.point3a = form1.point3a + f;
            form1.point3b = form1.point3b + f;
            form1.point3c = form1.point3c + f;
            form1.point3d = form1.point3d + f;
            form1.point3e = form1.point3e + f;
            form1.point3f = form1.point3f + f;
            form1.point3g = form1.point3g + f;
            form1.point3h = form1.point3h + f;
            form1.textbox1.Text = form1.point11.ToString();
            form1.textbox2.Text = form1.point12.ToString();
            form1.textbox3.Text = form1.point13.ToString();
            form1.textbox4.Text = form1.point21.ToString();
            form1.textbox5.Text = form1.point22.ToString();
            form1.textbox6.Text = form1.point23.ToString();
            form1.textbox7.Text = form1.point31.ToString();
            form1.textbox8.Text = form1.point32.ToString();
            form1.textbox9.Text = form1.point33.ToString();
            form1.textbox10.Text = form1.point1a.ToString();
            form1.textbox11.Text = form1.point1b.ToString();
            form1.textbox12.Text = form1.point1c.ToString();
            form1.textbox13.Text = form1.point1d.ToString();
            form1.textbox14.Text = form1.point1e.ToString();
            form1.textbox15.Text = form1.point1f.ToString();
            form1.textbox16.Text = form1.point1g.ToString();
            form1.textbox17.Text = form1.point1h.ToString();
            form1.textbox18.Text = form1.point2a.ToString();
            form1.textbox19.Text = form1.point2b.ToString();
            form1.textbox20.Text = form1.point2c.ToString();
            form1.textbox21.Text = form1.point2d.ToString();
            form1.textbox22.Text = form1.point2e.ToString();
            form1.textbox23.Text = form1.point2f.ToString();
            form1.textbox24.Text = form1.point2g.ToString();
            form1.textbox25.Text = form1.point2h.ToString();
            form1.textbox26.Text = form1.point3a.ToString();
            form1.textbox27.Text = form1.point3b.ToString();
            form1.textbox28.Text = form1.point3c.ToString();
            form1.textbox29.Text = form1.point3d.ToString();
            form1.textbox30.Text = form1.point3e.ToString();
            form1.textbox31.Text = form1.point3f.ToString();
            form1.textbox32.Text = form1.point3g.ToString();
            form1.textbox33.Text = form1.point3h.ToString();
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void combobox_Changed(object sender, EventArgs e)
        {
            if (this.combobox.SelectedIndex != -1)
            {
                this.button1.Enabled = true;
            }
            if (this.combobox.SelectedIndex == 0)
            {
                this.label4.Text = "1位80点 2位70点 3位60点 4位50点 5位40点 6位30点";
                if (form1.b40 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 1)
            {
                this.label4.Text = "1位40点 2位30点 3位20点";
                if (form1.b41 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
            else if (this.combobox.SelectedIndex == 2)
            {
                this.label4.Text = "1位40点 2位30点 3位20点";
                if (form1.b42 == false)
                {
                    this.button1.Enabled = false;
                    this.label4.Text = "登録済み";
                }
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }

    public partial class form12 : Form
    {
        TextBox textbox1;
        TextBox textbox2;
        TextBox textbox3;
        TextBox textbox4;
        TextBox textbox5;
        TextBox textbox6;
        TextBox textbox7;
        TextBox textbox8;
        TextBox textbox9;
        TextBox textbox10;
        TextBox textbox11;
        TextBox textbox12;
        TextBox textbox13;
        TextBox textbox14;
        TextBox textbox15;
        TextBox textbox16;
        TextBox textbox17;
        TextBox textbox18;
        TextBox textbox19;
        TextBox textbox20;
        TextBox textbox21;
        TextBox textbox22;
        TextBox textbox23;
        TextBox textbox24;
        TextBox textbox25;
        TextBox textbox26;
        TextBox textbox27;
        TextBox textbox28;
        TextBox textbox29;
        TextBox textbox30;
        TextBox textbox31;
        TextBox textbox32;
        TextBox textbox33;
        public form12()
        {

            this.Width = 640;
            this.Height = 360;
            this.Text = "結果登録(クラス対抗リレー)";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Label label1 = new Label();
            label1.Location = new Point(15, 5);
            label1.Size = new Size(620, 15);
            label1.Text = "中学(全学年共通 1位80点 2位70点 3位60点 4位50点 5位40点 6位30点 7位20点 8位10点 9位5点)";
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Location = new Point(15, 25);
            label2.Size = new Size(60, 15);
            label2.Text = "1年1組";
            this.Controls.Add(label2);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(15, 45);
            this.textbox1.Size = new Size(60, 15);
            this.textbox1.TextChanged += new EventHandler(text_Changed);
            this.textbox1.Text = "0";
            this.Controls.Add(this.textbox1);

            Label label3 = new Label();
            label3.Location = new Point(90, 25);
            label3.Size = new Size(60, 15);
            label3.Text = "1年2組";
            this.Controls.Add(label3);

            this.textbox2 = new TextBox();
            this.textbox2.Location = new Point(90, 45);
            this.textbox2.Size = new Size(60, 15);
            this.textbox2.TextChanged += new EventHandler(text_Changed);
            this.textbox2.Text = "0";
            this.Controls.Add(this.textbox2);

            Label label4 = new Label();
            label4.Location = new Point(165, 25);
            label4.Size = new Size(60, 15);
            label4.Text = "1年3組";
            this.Controls.Add(label4);

            this.textbox3 = new TextBox();
            this.textbox3.Location = new Point(165, 45);
            this.textbox3.Size = new Size(60, 15);
            this.textbox3.TextChanged += new EventHandler(text_Changed);
            this.textbox3.Text = "0";
            this.Controls.Add(this.textbox3);

            Label label5 = new Label();
            label5.Location = new Point(240, 25);
            label5.Size = new Size(60, 15);
            label5.Text = "2年1組";
            this.Controls.Add(label5);

            this.textbox4 = new TextBox();
            this.textbox4.Location = new Point(240, 45);
            this.textbox4.Size = new Size(60, 15);
            this.textbox4.TextChanged += new EventHandler(text_Changed);
            this.textbox4.Text = "0";
            this.Controls.Add(this.textbox4);

            Label label6 = new Label();
            label6.Location = new Point(315, 25);
            label6.Size = new Size(60, 15);
            label6.Text = "2年2組";
            this.Controls.Add(label6);

            this.textbox5 = new TextBox();
            this.textbox5.Location = new Point(315, 45);
            this.textbox5.Size = new Size(60, 15);
            this.textbox5.TextChanged += new EventHandler(text_Changed);
            this.textbox5.Text = "0";
            this.Controls.Add(this.textbox5);

            Label label7 = new Label();
            label7.Location = new Point(390, 25);
            label7.Size = new Size(60, 15);
            label7.Text = "2年3組";
            this.Controls.Add(label7);

            this.textbox6 = new TextBox();
            this.textbox6.Location = new Point(390, 45);
            this.textbox6.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox6.Text = "0";
            this.Controls.Add(this.textbox6);

            Label label8 = new Label();
            label8.Location = new Point(465, 25);
            label8.Size = new Size(60, 15);
            label8.Text = "3年1組";
            this.Controls.Add(label8);

            this.textbox7 = new TextBox();
            this.textbox7.Location = new Point(465, 45);
            this.textbox7.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox7.Text = "0";
            this.Controls.Add(this.textbox7);

            Label label9 = new Label();
            label9.Location = new Point(540, 25);
            label9.Size = new Size(60, 15);
            label9.Text = "3年2組";
            this.Controls.Add(label9);

            this.textbox8 = new TextBox();
            this.textbox8.Location = new Point(540, 45);
            this.textbox8.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox8.Text = "0";
            this.Controls.Add(this.textbox8);

            Label label10 = new Label();
            label10.Location = new Point(540, 70);
            label10.Size = new Size(60, 15);
            label10.Text = "3年3組";
            this.Controls.Add(label10);

            this.textbox9 = new TextBox();
            this.textbox9.Location = new Point(540, 90);
            this.textbox9.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox9.Text = "0";
            this.Controls.Add(this.textbox9);

            Label label11 = new Label();
            label11.Location = new Point(15, 90);
            label11.Size = new Size(620, 15);
            label11.Text = "高校(学年別 1位80点 2位70点 3位60点 4位50点 5位40点 6位30点 7位20点 8位10点)";
            this.Controls.Add(label11);

            Label label12 = new Label();
            label12.Location = new Point(15, 115);
            label12.Size = new Size(60, 15);
            label12.Text = "1年A組";
            this.Controls.Add(label12);

            this.textbox10 = new TextBox();
            this.textbox10.Location = new Point(15, 135);
            this.textbox10.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox10.Text = "0";
            this.Controls.Add(this.textbox10);

            Label label13 = new Label();
            label13.Location = new Point(90, 115);
            label13.Size = new Size(60, 15);
            label13.Text = "1年B組";
            this.Controls.Add(label13);

            this.textbox11 = new TextBox();
            this.textbox11.Location = new Point(90, 135);
            this.textbox11.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox11.Text = "0";
            this.Controls.Add(this.textbox11);

            Label label14 = new Label();
            label14.Location = new Point(165, 115);
            label14.Size = new Size(60, 15);
            label14.Text = "1年C組";
            this.Controls.Add(label14);

            this.textbox12 = new TextBox();
            this.textbox12.Location = new Point(165, 135);
            this.textbox12.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox12.Text = "0";
            this.Controls.Add(this.textbox12);

            Label label15 = new Label();
            label15.Location = new Point(240, 115);
            label15.Size = new Size(60, 15);
            label15.Text = "1年D組";
            this.Controls.Add(label15);

            this.textbox13 = new TextBox();
            this.textbox13.Location = new Point(240, 135);
            this.textbox13.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox13.Text = "0";
            this.Controls.Add(this.textbox13);

            Label label16 = new Label();
            label16.Location = new Point(315, 115);
            label16.Size = new Size(60, 15);
            label16.Text = "1年E組";
            this.Controls.Add(label16);

            this.textbox14 = new TextBox();
            this.textbox14.Location = new Point(315, 135);
            this.textbox14.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox14.Text = "0";
            this.Controls.Add(this.textbox14);

            Label label17 = new Label();
            label17.Location = new Point(390, 115);
            label17.Size = new Size(60, 15);
            label17.Text = "1年F組";
            this.Controls.Add(label17);

            this.textbox15 = new TextBox();
            this.textbox15.Location = new Point(390, 135);
            this.textbox15.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox15.Text = "0";
            this.Controls.Add(this.textbox15);

            Label label18 = new Label();
            label18.Location = new Point(465, 115);
            label18.Size = new Size(60, 15);
            label18.Text = "1年G組";
            this.Controls.Add(label18);

            this.textbox16 = new TextBox();
            this.textbox16.Location = new Point(465, 135);
            this.textbox16.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox16.Text = "0";
            this.Controls.Add(this.textbox16);

            Label label19 = new Label();
            label19.Location = new Point(540, 115);
            label19.Size = new Size(60, 15);
            label19.Text = "1年H組";
            this.Controls.Add(label19);

            this.textbox17 = new TextBox();
            this.textbox17.Location = new Point(540, 135);
            this.textbox17.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox17.Text = "0";
            this.Controls.Add(this.textbox17);

            Label label20 = new Label();
            label20.Location = new Point(15, 160);
            label20.Size = new Size(60, 15);
            label20.Text = "2年A組";
            this.Controls.Add(label20);

            this.textbox18 = new TextBox();
            this.textbox18.Location = new Point(15, 180);
            this.textbox18.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox18.Text = "0";
            this.Controls.Add(this.textbox18);

            Label label21 = new Label();
            label21.Location = new Point(90, 160);
            label21.Size = new Size(60, 15);
            label21.Text = "2年B組";
            this.Controls.Add(label21);

            this.textbox19 = new TextBox();
            this.textbox19.Location = new Point(90, 180);
            this.textbox19.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox19.Text = "0";
            this.Controls.Add(this.textbox19);

            Label label22 = new Label();
            label22.Location = new Point(165, 160);
            label22.Size = new Size(60, 15);
            label22.Text = "2年C組";
            this.Controls.Add(label22);

            this.textbox20 = new TextBox();
            this.textbox20.Location = new Point(165, 180);
            this.textbox20.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox20.Text = "0";
            this.Controls.Add(this.textbox20);

            Label label23 = new Label();
            label23.Location = new Point(240, 160);
            label23.Size = new Size(60, 15);
            label23.Text = "2年D組";
            this.Controls.Add(label23);

            this.textbox21 = new TextBox();
            this.textbox21.Location = new Point(240, 180);
            this.textbox21.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox21.Text = "0";
            this.Controls.Add(this.textbox21);

            Label label24 = new Label();
            label24.Location = new Point(315, 160);
            label24.Size = new Size(60, 15);
            label24.Text = "2年E組";
            this.Controls.Add(label24);

            this.textbox22 = new TextBox();
            this.textbox22.Location = new Point(315, 180);
            this.textbox22.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox22.Text = "0";
            this.Controls.Add(this.textbox22);

            Label label25 = new Label();
            label25.Location = new Point(390, 160);
            label25.Size = new Size(60, 15);
            label25.Text = "2年F組";
            this.Controls.Add(label25);

            this.textbox23 = new TextBox();
            this.textbox23.Location = new Point(390, 180);
            this.textbox23.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox23.Text = "0";
            this.Controls.Add(this.textbox23);

            Label label26 = new Label();
            label26.Location = new Point(465, 160);
            label26.Size = new Size(60, 15);
            label26.Text = "2年G組";
            this.Controls.Add(label26);

            this.textbox24 = new TextBox();
            this.textbox24.Location = new Point(465, 180);
            this.textbox24.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox24.Text = "0";
            this.Controls.Add(this.textbox24);

            Label label27 = new Label();
            label27.Location = new Point(540, 160);
            label27.Size = new Size(60, 15);
            label27.Text = "2年H組";
            this.Controls.Add(label27);

            this.textbox25 = new TextBox();
            this.textbox25.Location = new Point(540, 180);
            this.textbox25.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox25.Text = "0";
            this.Controls.Add(this.textbox25);

            Label label28 = new Label();
            label28.Location = new Point(15, 205);
            label28.Size = new Size(60, 15);
            label28.Text = "3年A組";
            this.Controls.Add(label28);

            this.textbox26 = new TextBox();
            this.textbox26.Location = new Point(15, 225);
            this.textbox26.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox26.Text = "0";
            this.Controls.Add(this.textbox26);

            Label label29 = new Label();
            label29.Location = new Point(90, 205);
            label29.Size = new Size(60, 15);
            label29.Text = "3年B組";
            this.Controls.Add(label29);

            this.textbox27 = new TextBox();
            this.textbox27.Location = new Point(90, 225);
            this.textbox27.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox27.Text = "0";
            this.Controls.Add(this.textbox27);

            Label label30 = new Label();
            label30.Location = new Point(165, 205);
            label30.Size = new Size(60, 15);
            label30.Text = "3年C組";
            this.Controls.Add(label30);

            this.textbox28 = new TextBox();
            this.textbox28.Location = new Point(165, 225);
            this.textbox28.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox28.Text = "0";
            this.Controls.Add(this.textbox28);

            Label label31 = new Label();
            label31.Location = new Point(240, 205);
            label31.Size = new Size(60, 15);
            label31.Text = "3年D組";
            this.Controls.Add(label31);

            this.textbox29 = new TextBox();
            this.textbox29.Location = new Point(240, 225);
            this.textbox29.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox29.Text = "0";
            this.Controls.Add(this.textbox29);

            Label label32 = new Label();
            label32.Location = new Point(315, 205);
            label32.Size = new Size(60, 15);
            label32.Text = "3年E組";
            this.Controls.Add(label32);

            this.textbox30 = new TextBox();
            this.textbox30.Location = new Point(315, 225);
            this.textbox30.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox30.Text = "0";
            this.Controls.Add(this.textbox30);

            Label label33 = new Label();
            label33.Location = new Point(390, 205);
            label33.Size = new Size(60, 15);
            label33.Text = "3年F組";
            this.Controls.Add(label33);

            this.textbox31 = new TextBox();
            this.textbox31.Location = new Point(390, 225);
            this.textbox31.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox31.Text = "0";
            this.Controls.Add(this.textbox31);

            Label label34 = new Label();
            label34.Location = new Point(465, 205);
            label34.Size = new Size(60, 15);
            label34.Text = "3年G組";
            this.Controls.Add(label34);

            this.textbox32 = new TextBox();
            this.textbox32.Location = new Point(465, 225);
            this.textbox32.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox32.Text = "0";
            this.Controls.Add(this.textbox32);

            Label label35 = new Label();
            label35.Location = new Point(540, 205);
            label35.Size = new Size(60, 15);
            label35.Text = "3年H組";
            this.Controls.Add(label35);

            this.textbox33 = new TextBox();
            this.textbox33.Location = new Point(540, 225);
            this.textbox33.Size = new Size(60, 15);
            this.textbox6.TextChanged += new EventHandler(text_Changed);
            this.textbox33.Text = "0";
            this.Controls.Add(this.textbox33);

            Label label36 = new Label();
            label36.Location = new Point(15, 260);
            label36.Size = new Size(200, 15);
            label36.Text = "合計点を入力すること";
            this.Controls.Add(label36);

            Button button1 = new Button();
            button1.Location = new Point(315, 260);
            button1.Size = new Size(135, 40);
            button1.Text = "登録";
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Location = new Point(465, 260);
            button2.Size = new Size(135, 40);
            button2.Text = "中止";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);
        }

        void button1_Click(object sender, EventArgs e)
        {
            int j11;
            int j12;
            int j13;
            int j21;
            int j22;
            int j23;
            int j31;
            int j32;
            int j33;
            int a1;
            int b1;
            int c1;
            int d1;
            int e1;
            int f1;
            int g1;
            int h1;
            int a2;
            int b2;
            int c2;
            int d2;
            int e2;
            int f2;
            int g2;
            int h2;
            int a3;
            int b3;
            int c3;
            int d3;
            int e3;
            int f3;
            int g3;
            int h3;
            string sj11;
            string sj12;
            string sj13;
            string sj21;
            string sj22;
            string sj23;
            string sj31;
            string sj32;
            string sj33;
            string sa1;
            string sb1;
            string sc1;
            string sd1;
            string se1;
            string sf1;
            string sg1;
            string sh1;
            string sa2;
            string sb2;
            string sc2;
            string sd2;
            string se2;
            string sf2;
            string sg2;
            string sh2;
            string sa3;
            string sb3;
            string sc3;
            string sd3;
            string se3;
            string sf3;
            string sg3;
            string sh3;
            sj11 = this.textbox1.Text;
            j11 = int.Parse(sj11);
            sj12 = this.textbox2.Text;
            j12 = int.Parse(sj12);
            sj13 = this.textbox3.Text;
            j13 = int.Parse(sj13);
            sj21 = this.textbox4.Text;
            j21 = int.Parse(sj21);
            sj22 = this.textbox5.Text;
            j22 = int.Parse(sj22);
            sj23 = this.textbox6.Text;
            j23 = int.Parse(sj23);
            sj31 = this.textbox7.Text;
            j31 = int.Parse(sj31);
            sj32 = this.textbox8.Text;
            j32 = int.Parse(sj32);
            sj33 = this.textbox9.Text;
            j33 = int.Parse(sj33);
            sa1 = this.textbox10.Text;
            a1 = int.Parse(sa1);
            sb1 = this.textbox11.Text;
            b1 = int.Parse(sb1);
            sc1 = this.textbox12.Text;
            c1 = int.Parse(sc1);
            sd1 = this.textbox13.Text;
            d1 = int.Parse(sd1);
            se1 = this.textbox14.Text;
            e1 = int.Parse(se1);
            sf1 = this.textbox15.Text;
            f1 = int.Parse(sf1);
            sg1 = this.textbox16.Text;
            g1 = int.Parse(sg1);
            sh1 = this.textbox17.Text;
            h1 = int.Parse(sh1);
            sa2 = this.textbox18.Text;
            a2 = int.Parse(sa2);
            sb2 = this.textbox19.Text;
            b2 = int.Parse(sb2);
            sc2 = this.textbox20.Text;
            c2 = int.Parse(sc2);
            sd2 = this.textbox21.Text;
            d2 = int.Parse(sd2);
            se2 = this.textbox22.Text;
            e2 = int.Parse(se2);
            sf2 = this.textbox23.Text;
            f2 = int.Parse(sf2);
            sg2 = this.textbox24.Text;
            g2 = int.Parse(sg2);
            sh2 = this.textbox25.Text;
            h2 = int.Parse(sh2);
            sa3 = this.textbox26.Text;
            a3 = int.Parse(sa3);
            sb3 = this.textbox27.Text;
            b3 = int.Parse(sb3);
            sc3 = this.textbox28.Text;
            c3 = int.Parse(sc3);
            sd3 = this.textbox29.Text;
            d3 = int.Parse(sd3);
            se3 = this.textbox30.Text;
            e3 = int.Parse(se3);
            sf3 = this.textbox31.Text;
            f3 = int.Parse(sf3);
            sg3 = this.textbox32.Text;
            g3 = int.Parse(sg3);
            sh3 = this.textbox33.Text;
            h3 = int.Parse(sh3);
            form1.point11 = form1.point11 + j11;
            form1.point12 = form1.point12 + j12;
            form1.point13 = form1.point13 + j13;
            form1.point21 = form1.point21 + j21;
            form1.point22 = form1.point22 + j22;
            form1.point23 = form1.point23 + j23;
            form1.point31 = form1.point31 + j31;
            form1.point32 = form1.point32 + j32;
            form1.point33 = form1.point33 + j33;
            form1.point1a = form1.point1a + a1;
            form1.point1b = form1.point1b + b1;
            form1.point1c = form1.point1c + c1;
            form1.point1d = form1.point1d + d1;
            form1.point1e = form1.point1e + e1;
            form1.point1f = form1.point1f + f1;
            form1.point1g = form1.point1g + g1;
            form1.point1h = form1.point1h + h1;
            form1.point2a = form1.point2a + a2;
            form1.point2b = form1.point2b + b2;
            form1.point2c = form1.point2c + c2;
            form1.point2d = form1.point2d + d2;
            form1.point2e = form1.point2e + e2;
            form1.point2f = form1.point2f + f2;
            form1.point2g = form1.point2g + g2;
            form1.point2h = form1.point2h + h2;
            form1.point3a = form1.point3a + a3;
            form1.point3b = form1.point3b + b3;
            form1.point3c = form1.point3c + c3;
            form1.point3d = form1.point3d + d3;
            form1.point3e = form1.point3e + e3;
            form1.point3f = form1.point3f + f3;
            form1.point3g = form1.point3g + g3;
            form1.point3h = form1.point3h + h3;
            form1.textbox1.Text = form1.point11.ToString();
            form1.textbox2.Text = form1.point12.ToString();
            form1.textbox3.Text = form1.point13.ToString();
            form1.textbox4.Text = form1.point21.ToString();
            form1.textbox5.Text = form1.point22.ToString();
            form1.textbox6.Text = form1.point23.ToString();
            form1.textbox7.Text = form1.point31.ToString();
            form1.textbox8.Text = form1.point32.ToString();
            form1.textbox9.Text = form1.point33.ToString();
            form1.textbox10.Text = form1.point1a.ToString();
            form1.textbox11.Text = form1.point1b.ToString();
            form1.textbox12.Text = form1.point1c.ToString();
            form1.textbox13.Text = form1.point1d.ToString();
            form1.textbox14.Text = form1.point1e.ToString();
            form1.textbox15.Text = form1.point1f.ToString();
            form1.textbox16.Text = form1.point1g.ToString();
            form1.textbox17.Text = form1.point1h.ToString();
            form1.textbox18.Text = form1.point2a.ToString();
            form1.textbox19.Text = form1.point2b.ToString();
            form1.textbox20.Text = form1.point2c.ToString();
            form1.textbox21.Text = form1.point2d.ToString();
            form1.textbox22.Text = form1.point2e.ToString();
            form1.textbox23.Text = form1.point2f.ToString();
            form1.textbox24.Text = form1.point2g.ToString();
            form1.textbox25.Text = form1.point2h.ToString();
            form1.textbox26.Text = form1.point3a.ToString();
            form1.textbox27.Text = form1.point3b.ToString();
            form1.textbox28.Text = form1.point3c.ToString();
            form1.textbox29.Text = form1.point3d.ToString();
            form1.textbox30.Text = form1.point3e.ToString();
            form1.textbox31.Text = form1.point3f.ToString();
            form1.textbox32.Text = form1.point3g.ToString();
            form1.textbox33.Text = form1.point3h.ToString();
            form1.b43 = false;
            Program.buckup();
            this.Close();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_Changed(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }
    }
}