using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exam
{ 
    public partial class Form1 : Form
    {
        List<TagsCount> tags = new List<TagsCount>(); 
        public Form1()
        {
            InitializeComponent();
            btnControll(false);
        }
        private void btnConn_Click(object sender, EventArgs e)
        {
            tags = WriteTags.SetTags(tbLink.Text);
            btnControll(true);
        }
        private void btnControll(bool marker)
        {
            btnAllTegs.Enabled = marker;
            btnMaxCouTeg.Enabled = marker;
            btnSearchTag.Enabled = marker;
            btnSaveF.Enabled = marker;
            tbNameTeg.Enabled = marker;
            btnConn.Enabled = !marker;
        }
        private void btnAllTegs_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            foreach (var item in tags)
            {
                richTextBox1.Text += ($"Tag - {item.NameTag} : {item.Count}\n");
            }
        }
        private void btnMaxCouTeg_Click(object sender, EventArgs e)
        {
            int max = -1;
            for (int i = 0, j = 0; i < tags.Count; i++)
            {
                if (tags[i].Count > j)
                {
                    j = tags[i].Count;
                    max = i;
                }
            }
            richTextBox1.Text = ($"Самый популярный тег : {tags[max].NameTag}  \n Встречается: {tags[max].Count} р.");
        }
        private void btnSearchTag_Click(object sender, EventArgs e)
        {
            foreach (var item in tags)
            {
                if (item.NameTag == tbNameTeg.Text)
                    richTextBox1.Text = ($"Tag - {item.NameTag} : {item.Count}\n");
            }
        }
        private void btnSaveF_Click(object sender, EventArgs e)
        {
            SaveFile.Save(tbLink.Text);
        }
    }
}
