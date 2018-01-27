using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // イベント処理メソッド
        private void GrayScaleButton_Click(object sender, EventArgs e)
        {
            this.GrayImage();
        }

        private void AveragingButton_Click(object sender, EventArgs e)
        {
            //１．指定したパスから画像を読み込む
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap img_out = new Bitmap(pictureBox1.Image);

            float[] karnel = new float[9];
            for (int i = 0; i < karnel.Length; i++)
                karnel[i] = 1.0f / 9.0f;

            for(int y = 0; y < img.Height; y++)
            {
                for(int x = 0; x < img.Width; x++)
                {
                    if (y < 1 || y > img.Height - 2 || x < 1 || x > img.Width - 2)
                        continue;

                    Byte value = this.Averaging(img, x, y, karnel);
                    img_out.SetPixel(x, y, Color.FromArgb(255, value, value, value));
                }
            }

            pictureBox1.Image = img_out;


        }

        private void GaussFilterButton_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap img_out = new Bitmap(pictureBox1.Image);

            double SIGMA = Convert.ToDouble(SIGMA_Value.Text);

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    if (y < 1 || y > img.Height - 2 || x < 1 || x > img.Width - 2)
                        continue;

                    Byte value = this.GaussCalc3(img, x, y, SIGMA);
                    img_out.SetPixel(x, y, Color.FromArgb(255, value, value, value));
                }
            }

            pictureBox1.Image = img_out;
        }

        private void GaussFilterButton5_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap img_out = new Bitmap(pictureBox1.Image);

            double SIGMA = Convert.ToDouble(SIGMA_Value.Text);

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    if (y < 2 || y > img.Height - 3 || x < 2 || x > img.Width - 3)
                        continue;

                    Byte value = this.GaussCalc5(img, x, y, SIGMA);
                    img_out.SetPixel(x, y, Color.FromArgb(255, value, value, value));
                }
            }

            pictureBox1.Image = img_out;

        }

        private void EdgeDetect4Button_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap img_out = new Bitmap(pictureBox1.Image);

            double[] karnel = new double[9];
            for (int i = 0; i < karnel.Length; i++)
            {
                int ix = (i % 3) - 1;
                int iy = Convert.ToInt32(i / 3) - 1;
                int value = ix * ix + iy * iy;
                switch (value)
                {
                    case 0:
                        karnel[i] = 5;
                        break;
                    case 1:
                        karnel[i] = -1;
                        break;
                    default:
                        karnel[i] = 0;
                        break;
                }
            }

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    if (y < 1 || y > img.Height - 2 || x < 1 || x > img.Width - 2)
                        continue;

                    Byte value = this.EdgeDetect(img, x, y, karnel);
                    img_out.SetPixel(x, y, Color.FromArgb(255, value, value, value));
                }
            }

            pictureBox1.Image = img_out;

        }

        private void EdgeDetect8Button_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap img_out = new Bitmap(pictureBox1.Image);

            double[] karnel = new double[9];
            for (int i = 0; i < karnel.Length; i++)
            {
                int ix = (i % 3) - 1;
                int iy = Convert.ToInt32(i / 3) - 1;
                int value = ix * ix + iy * iy;
                switch (value)
                {
                    case 0:
                        karnel[i] = 9;
                        break;
                    default:
                        karnel[i] = -1;
                        break;
                }
            }

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    if (y < 1 || y > img.Height - 2 || x < 1 || x > img.Width - 2)
                        continue;

                    Byte value = this.EdgeDetect(img, x, y, karnel);
                    img_out.SetPixel(x, y, Color.FromArgb(255, value, value, value));
                }
            }

            pictureBox1.Image = img_out;

        }

        private void GaussEdgeButton_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap img_out = new Bitmap(pictureBox1.Image);

            double SIGMA = Convert.ToDouble(SIGMA_Value.Text);

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    if (y < 1 || y > img.Height - 2 || x < 1 || x > img.Width - 2)
                        continue;

                    Byte value = this.GaussEdge(img, x, y, SIGMA);
                    img_out.SetPixel(x, y, Color.FromArgb(255, value, value, value));
                }
            }

            pictureBox1.Image = img_out;

        }

        private void ResetImageButton_Click(object sender, EventArgs e)
        {
            this.ResetImage();
        }

        private void ImageSaveButton_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            String str = FileNameBox.Text;
            String filename = str + Convert.ToString(".png");
            img.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void ResetImage()
        {
            try
            {
                //１．指定したパスから画像を読み込む
                Bitmap img = new Bitmap(Image.FromFile("lena.jpg"));

                pictureBox1.Image = img;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        // テスト用メソッド
        private void GrayImage()
        {
            try
            {
                Color[,] pixelData;

                //１．指定したパスから画像を読み込む
                Bitmap img = new Bitmap(Image.FromFile("lena.jpg"));
                Bitmap img_out = img;

                //ピクセルデータを取得
                pixelData = new Color[img.Width, img.Height];
                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        pixelData[x, y] = img.GetPixel(x, y);
                        Byte gray = Convert.ToByte((Convert.ToInt32(pixelData[x, y].R) + Convert.ToInt32(pixelData[x, y].G) + Convert.ToInt32(pixelData[x, y].B)) / 3);
                        img_out.SetPixel(x, y, Color.FromArgb(255, gray, gray, gray));
                    }
                }

                pictureBox1.Image = img_out;
            }
            catch(Exception e) {
                ErrorLavel.Text = "ファイル読み込みエラー";
            }
        }

        // 各種処理メソッド
        private Byte Averaging(Bitmap img, int x, int y, float[] karnel)
        {
            Byte[] area = new Byte[9];
            for (int i = 0; i < area.Length; i++)
            {
                int ix = (i % 3) - 1;
                int iy = Convert.ToInt32(i / 3) - 1;
                area[i] = img.GetPixel(x + ix, y + iy).R;
            }

            int update_value = 0;
            for(int i = 0; i < area.Length; i++)
            {
                update_value += Convert.ToInt32( Convert.ToInt32(area[i]) * karnel[i] );
            }
            return Convert.ToByte(update_value);
        }

        private Byte GaussCalc3(Bitmap img, int x, int y, double SIGMA)
        {
            double update_value = 0.0f;
            // カーネルの計算
            double[] karnel = new double[9];
            double K = 0;

            for (int i = 0; i < karnel.Length; i++)
            {
                int ix = (i % 3) - 1;
                int iy = Convert.ToInt32(i / 3) - 1;
                karnel[i] = Math.Exp(-1.0f * (ix * ix + iy * iy) / (2.0f * SIGMA * SIGMA));
            }
            for (int i = 0; i < karnel.Length; i++)
                K += karnel[i];
            K = 1.0f / K;

            // 画素値の計算
            for (int i = 0; i < 9; i++)
            {
                int ix = (i % 3) - 1;
                int iy = Convert.ToInt32(i / 3) - 1;
                //update_value += Convert.ToDouble( img.GetPixel(x + ix, y + iy).R ) * K * Math.Exp(- (ix * ix + iy * iy) / (2.0f * SIGMA * SIGMA));
                update_value += Convert.ToDouble(img.GetPixel(x + ix, y + iy).R) * karnel[i] * K;
            }

            return Convert.ToByte(update_value);
        }

        private Byte GaussCalc5(Bitmap img, int x, int y, double SIGMA)
        {
            double update_value = 0.0f;
            const int AREA = 5;
            // カーネルの計算
            double[] karnel = new double[AREA * AREA];
            double K = 0;

            for (int i = 0; i < karnel.Length; i++)
            {
                int ix = (i % AREA) - Convert.ToInt32(AREA / 2);
                int iy = Convert.ToInt32(i / AREA) - Convert.ToInt32(AREA / 2);
                karnel[i] = Math.Exp(-1.0f * (ix * ix + iy * iy) / (2.0f * SIGMA * SIGMA));
            }
            for (int i = 0; i < karnel.Length; i++)
                K += karnel[i];
            K = 1.0f / K;

            // 画素値の計算
            for (int i = 0; i < karnel.Length; i++)
            {
                int ix = (i % AREA) - Convert.ToInt32(AREA / 2);
                int iy = Convert.ToInt32(i / AREA) - Convert.ToInt32(AREA / 2);
                //update_value += Convert.ToDouble( img.GetPixel(x + ix, y + iy).R ) * K * Math.Exp(- (ix * ix + iy * iy) / (2.0f * SIGMA * SIGMA));
                update_value += Convert.ToDouble(img.GetPixel(x + ix, y + iy).R) * karnel[i] * K;
            }

            return Convert.ToByte(update_value);
        }

        private Byte EdgeDetect(Bitmap img, int x, int y, double[] karnel)
        {
            int[] area = new int[9];
            for (int i = 0; i < area.Length; i++)
            {
                int ix = (i % 3) - 1;
                int iy = (int)(i / 3) - 1;
                area[i] = (int)(img.GetPixel(x + ix, y + iy).R);
            }

            double update_value = 0;
            for (int i = 0; i < area.Length; i++)
                update_value += area[i] * karnel[i];

            if (update_value > 255)
                update_value = 255;
            else if (update_value < 0)
                update_value = 0;

            return Convert.ToByte(update_value);
        }

        private Byte GaussEdge(Bitmap img, int x, int y, double SIGMA)
        {
            double update_value = 0.0f;
            // カーネルの計算
            double[] karnel = new double[9];
            double[] karnel2 = new double[9];
            double K = 0;

            for (int i = 0; i < karnel.Length; i++)
            {
                int ix = (i % 3) - 1;
                int iy = Convert.ToInt32(i / 3) - 1;
                karnel[i] = Math.Exp(-1.0f * (ix * ix + iy * iy) / (2.0f * SIGMA * SIGMA));
            }
            for (int i = 0; i < karnel.Length; i++)
                K += karnel[i];
            K = 1.0f / K;

            // 画素値の計算
            for (int i = 0; i < 9; i++)
            {
                int ix = (i % 3) - 1;
                int iy = Convert.ToInt32(i / 3) - 1;
                int value = ix * ix + iy * iy;
                switch (value)
                {
                    case 0:
                        karnel[i] = 2.0f - K * karnel[i];
                        break;
                    default:
                        karnel[i] = 0.0f - K * karnel[i];
                        break;
                }
                update_value += Convert.ToDouble(img.GetPixel(x + ix, y + iy).R) * karnel[i];
            }

            if (update_value > 255)
                update_value = 255;
            else if (update_value < 0)
                update_value = 0;

            return Convert.ToByte(update_value);

        }

        // 表示関係のメソッド
        private void SIGMA_trackBar_Scroll(object sender, EventArgs e)
        {
            float value = SIGMA_trackBar.Value;
            SIGMA_Value.Text = Convert.ToString(value / 10.0f);
        }

        /* TO DO
         * エッジ検出
         */
    }
}
