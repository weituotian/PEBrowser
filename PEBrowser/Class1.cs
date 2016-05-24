using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEBrowser
{
    public partial class Class1 : PEPlugin.IPEPlugin, PEPlugin.IPEPluginOption
    {

        /// <summary>
        /// 保存pe运行参数
        /// </summary>
        private PEPlugin.IPERunArgs peArgs;


        /// <summary>
        /// 获取对这个插件的描述
        /// </summary>
        public string Description
        {
            get { return "您是否想改变pmxeditor的字体？"; }
        }

        /// <summary>
        /// 获取这个插件的名称
        /// </summary>
        public string Name
        {
            get { return "pmxeditor字体修改器"; }
        }

        /// <summary>
        /// 获取启动的选项
        /// </summary>
        public PEPlugin.IPEPluginOption Option
        {
            get { return this; }
        }



        /// <summary>
        /// 这个方法在插件启动时被调用。
        /// </summary>
        /// <param name="args"></param>
        public void Run(PEPlugin.IPERunArgs args)
        {
            Console.WriteLine("pe插件开始运行！");

            peArgs = args;//保存这个IPERunArgs


            Form mainForm = peArgs.Host.Connector.Form as Form;//主窗口

            addTabPage(mainForm);

        }


        /// <summary>
        /// 获取对这个插件版本的描述
        /// </summary>
        public string Version
        {
            get { return "1.0 by韦驮天"; }
        }

        /// <summary>
        /// 这个插件被销毁时被调用
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// 获取一个布尔值，表示插件是否随PE一起启动。取值为true或false
        /// </summary>
        public bool Bootup
        {
            get { return true; }
        }

        /// <summary>
        /// 获取一个布尔值，表示插件是否应该有菜单项。取值为true或false
        /// </summary>
        public bool RegisterMenu
        {
            get { return false; }
        }

        /// <summary>
        /// 获取一个字符串，表示插件菜单项上的文本。
        /// </summary>
        public string RegisterMenuText
        {
            get { return "修改字体 By 韦驮天"; }
        }
    }
}
