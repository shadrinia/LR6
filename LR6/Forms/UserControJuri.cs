using System.Windows.Forms;
using LR6.DBCon;

namespace LR6.Forms
{
    public partial class UserControJuri : UserControl
    {
        public UserControJuri()
        {
            InitializeComponent();
        }

        public void Fill(User user, int number)
        {
            label1.Text = "Жюри - " + number.ToString();
            userBindingSource.DataSource = user;
        }
    }
}
