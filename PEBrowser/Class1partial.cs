using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEBrowser
{
    partial class Class1
    {
        private TabPage tabPage;
        private WebBrowser webBrowser1;
        private Button button1;
        private TextBox textBox1;

        /// <summary>
        /// 寻找tabcontrol
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        private TabControl searchTabControl(Form form)
        {
            foreach (System.Windows.Forms.Control control in form.Controls)
            {
                if (control is TabControl)
                {

                    return (TabControl)control;

                }
            }
            return null;
        }

        private void addTabPage(Form form)
        {
            TabControl tabControl = searchTabControl(form);
            Console.WriteLine("control");

            // 
            // 创建新button1
            // 
            this.button1=new Button();
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(463, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "转到-》";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += button1_Click;
            // 
            // 创建新textBox1
            // 
            this.textBox1=new TextBox();
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(207, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 21);
            this.textBox1.TabIndex = 2;

            // 
            // 创建新webBrowser
            // 
            webBrowser1 = new WebBrowser();
            webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;//覆盖满父容器
            webBrowser1.Location = new System.Drawing.Point(3, 3);//距离父容器左上角
            webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);//最小尺寸
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(363, 221);
            webBrowser1.TabIndex = 0;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://fanyi.baidu.com/");
            //
            //创建新tabpage
            //
            tabPage = new TabPage();
            tabPage.Controls.Add(webBrowser1);//添加控件
            tabPage.Controls.Add(button1);
            tabPage.Controls.Add(textBox1);
            tabPage.Location = new System.Drawing.Point(4, 22);
            tabPage.Name = "tabPage2";
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(369, 227);
            tabPage.TabIndex = 1;
            tabPage.Text = "百度翻译";
            tabPage.UseVisualStyleBackColor = true;
            tabPage.MouseDoubleClick += tabPage_MouseDoubleClick;


            tabControl.Controls.Add(tabPage);
        }

        void tabPage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            webBrowser1.Navigate("http://fanyi.baidu.com/");
        }

        void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}
