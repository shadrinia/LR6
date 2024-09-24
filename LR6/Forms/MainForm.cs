using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using LR6.DBCon;


namespace LR6.Forms
{
    public partial class MainForm : Form
    {
        public static List<int> JuriList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }

        private void buttonShowJuri_Click(object sender, EventArgs e)
        {
            JuriList = new List<int>();
            JuriList = JsonSerializer.Deserialize<List<int>>(activityDataGridView.CurrentRow.Cells[6].Value.ToString());
            FormShowJuri formShowJuri = new FormShowJuri();
            formShowJuri.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddActivity activity = new FormAddActivity();
            activity.ShowDialog();
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }
    }
}
