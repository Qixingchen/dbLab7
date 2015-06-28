using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace lab7
{
    public partial class photoUploadForm : Form
    {
        private String filePath = null;
        private GoodsInsert mGoodsInsert = null;
        public photoUploadForm(GoodsInsert goodsInsert)
        {
            mGoodsInsert = goodsInsert;
            InitializeComponent();
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = @"image files (*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                textBox1.Text = filePath;
                pictureBox1.ImageLocation = filePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            String SQL = @"select top 1 goodsphotoid from goodsphoto order by goodsphotoid DESC ";
            SqlDataReader dateReader = goods_methods.ExecuteReader(SQL);
            dateReader.Read();
            String lastMax = dateReader.GetString(0);
            string goodsphotoid = (int.Parse(lastMax) + 1).ToString();
            String copyFolder = Directory.GetCurrentDirectory() + @"\pic";
            if (!Directory.Exists(copyFolder))
            {
                Directory.CreateDirectory(copyFolder);
            }


            String copyFilepath = copyFolder + @"\" + goodsphotoid + ".jpg";

            File.Copy(filePath, copyFilepath);
            SQL = @"insert into goodsphoto values('" + goodsphotoid + "','" + copyFilepath + "')";
            if (goods_methods.ExecuteSql(SQL) != 0)
            {
                mGoodsInsert.flush();
                mGoodsInsert.setPhotoID(goodsphotoid);
                Hide();
            }


        }
    }
}
