using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_app
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();

            Encoding enc8 = Encoding.GetEncoding("utf-8");
            Encoding encj = Encoding.GetEncoding("shift-jis");
            string msg = "ハロー";

            FileStream fs = new FileStream("test_utf8.txt", FileMode.Create);
            fs.Write(enc8.GetBytes(msg), 0, enc8.GetByteCount(msg));

            fs = new FileStream("test_shiftjis.txt", FileMode.Create);
            fs.Write(encj.GetBytes(msg), 0, encj.GetByteCount(msg));
        }
    }
}
