using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class User2 : UserControl
    {
        Class1 n = new Class1();
        public User2()
        {
            InitializeComponent();
        }

        private void User2_Load(object sender, EventArgs e)
        {
            video1.Hide();
            pic1.Hide();
            for (int i = 0; i < n.words.Length; i++)
            {
                lst1.Items.Add(n.words[i]);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //int i = lst1.SelectedIndex;
            string search = txt1.Text;
            int flag = 0;
            string pict, video;
            for (int i = 0; i < n.words.Length; i++)
            {
                if (search.Equals(n.words[i]))
                {
                    video1.Show();
                    pic1.Show();
                    flag = 1;
                    pict = "C:/Users/HP/Desktop/PROJECT/pic/"+n.pic[i];
                    pic1.Image = Image.FromFile(@pict);
                    //video = "C:/Users/HP/Desktop/PROJECT/video/" + n.video[i];
                    //video1.URL = @video;
                }
            }
            if(flag==0)
            {
                MessageBox.Show(search+" is not available");
            }
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lst1.SelectedIndex;
            string search = txt1.Text;
            // int flag = 0;
            string pict, video;
            video1.Show();
            pic1.Show();
            //flag = 1;
            pict = "C:/Users/HP/Desktop/PROJECT/pic/" + n.pic[i];
            pic1.Image = Image.FromFile(@pict);
            //video = "C:/Users/HP/Desktop/PROJECT/video/" + n.video[i];
            //video1.URL = @video;
            video1.currentPlaylist = video1.mediaCollection.getByName("ant");

        }
    }
}
