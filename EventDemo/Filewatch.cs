using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    /// <summary>
    /// 事件构建步骤
    /// 1.新建标准格式委托FilewatchEnvetHandle(与类并行)
    /// 2.声明事件filewatchenevt（包含在类中）
    /// 3.声明一个可重写的事件调用函数(如onfilechange)
    /// 4.声明一个触发事件的函数如monitorfile
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void FilewatchEnvetHandle(object sender, PubEventArg e);
    public class Filewatch
    {
        public Filewatch()
        {

        }
        public event FilewatchEnvetHandle filewatchenevt;
        /// <summary>
        /// 创建方法，当时执行该方法时将触发事件
        /// </summary>
        /// <param name="e"></param>
        public virtual void onfilechange(PubEventArg e)
        {
            if (filewatchenevt != null)
            {
                filewatchenevt(this, e);
            }
        }
        //创建检查bin文件夹下是否存在文件的方法
        public void monitorfile(string pubbook)
        {
            onfilechange(new PubEventArg(pubbook));
        }
    }
}
