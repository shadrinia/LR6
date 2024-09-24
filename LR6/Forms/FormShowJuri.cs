using LR6.DBCon;
using System;
using System.Windows.Forms;

namespace LR6.Forms
{
    public partial class FormShowJuri : Form
    {
        public FormShowJuri()
        {
            InitializeComponent();
        }

        private void FormShowJuri_Load(object sender, EventArgs e)
        {
            int number = 1;

            foreach (int i in MainForm.JuriList)
            {
                User user = DBConst.model.User.Find(i);
                UserControJuri usercontr = new UserControJuri();
                usercontr.Fill(user, number);
                flowLayoutPanel1.Controls.Add(usercontr);
                number++;
            }
        }
    }
}
