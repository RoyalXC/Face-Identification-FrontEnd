using System;
using System.Threading;
using System.Windows;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Face_Identification_FrontEnd
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            Image<Bgr, Byte> image1 = new Image<Bgr, byte>("H:\\壁纸\\1.jpg");
            // CvInvoke.PutText(image1, "Hello, world", new System.Drawing.Point(image1.Width / 2, image1.Height / 2), Emgu.CV.CvEnum.FontFace.HersheyComplex, 3.0, new Bgr(255.0, 255.0, 255.0).MCvScalar);
            // CvInvoke.PutText(mat, "Hello1, world", new System.Drawing.Point(image1.Width / 2, image1.Height / 2), Emgu.CV.CvEnum.FontFace.HersheyComplex, 3.0, new Bgr(255.0, 255.0, 255.0).MCvScalar);
            // CvInvoke.WaitKey(100);
            Back.Source = BitmapSourceConvert.ToBitmapSource(image1);

            ShowVedio();



        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ShowVedio()
        {
            VideoCapture capture = new VideoCapture("E:\\1\\1.mp4");

            Mat Frame = new Mat();

            while (capture.Grab())
            {
                capture.Read(Frame);
                CvInvoke.Imshow("1", Frame);
                CvInvoke.WaitKey(35);
                Back.Source = BitmapSourceConvert.ToBitmapSource(Frame);
            }
            capture.Dispose();
        }
    }
}
