using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Permissions
{
    partial class MainForm : Form
    {
        private Form rootForm;
        private User currentUser;

        public MainForm(Form root, User currentUser)
        {
            InitializeComponent();

            rootForm = root;
            this.currentUser = currentUser;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            permissionsDGV.ClearSelection();

            foreach (KeyValuePair<string, User> entry in User.Instances)
            {
                User user = entry.Value;

                permissionsDGV.Rows.Add(
                    user.Username, 
                    user.CanRead, 
                    user.CanChange, 
                    user.CanResolve
                );

                userComboBox.Items.Add(user.Username);
            }

            this.Text += " — " + currentUser.Username;

            checkPermissions();
        }

        private void userComboBox_TextUpdate(object sender, EventArgs e)
        {
            string username = userComboBox.Text;
            int rowIndex = userComboBox.Items.IndexOf(username);

            string permission = permissionCB.Text;
            int colIndex = permissionCB.Items.IndexOf(permission);

            permissionsDGV.ClearSelection();

            if (rowIndex != -1)
            {
                // Отписка обработчика события для dataGridView:
                permissionsDGV.SelectionChanged -= permissionsDGV_SelectionChanged;

                permissionsDGV.Rows[rowIndex].Selected = true;

                if (colIndex != -1)
                {
                    DataGridViewRow currentRow = permissionsDGV.CurrentRow;

                    permissionsDGV.ClearSelection();
                    currentRow.Cells[colIndex + 1].Selected = true;

                    setAllowValue(username, colIndex);
                }

                // Восстановление обработчика события для dataGridView:
                permissionsDGV.SelectionChanged += permissionsDGV_SelectionChanged;
            }
        }

        private void permissionsDGV_SelectionChanged(object sender, EventArgs e)
        {
            // Отписка обработчика событий для комбобоксов:
            foreach (ComboBox cb in new ComboBox[] { userComboBox, permissionCB })
            {
                cb.TextUpdate -= userComboBox_TextUpdate;
                cb.SelectedIndexChanged -= userComboBox_TextUpdate;
            }

            DataGridViewCell cell = permissionsDGV.CurrentCell;

            if (cell.ColumnIndex > 0 && permissionCB.Items.Count > cell.ColumnIndex - 1)
                permissionCB.SelectedIndex = cell.ColumnIndex - 1;

            if (userComboBox.Items.Count > cell.RowIndex)
                userComboBox.SelectedIndex = cell.RowIndex;

            setAllowValue(userComboBox.Text, cell.ColumnIndex - 1);

            // Восстановление обработчика событий для комбобоксов:
            foreach (ComboBox cb in new ComboBox[] { userComboBox, permissionCB })
            {
                cb.TextUpdate += userComboBox_TextUpdate;
                cb.SelectedIndexChanged += userComboBox_TextUpdate;
            }
        }

        private void allowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string username = userComboBox.Text;
            int rowIndex = userComboBox.Items.IndexOf(username);

            string permission = permissionCB.Text;
            int colIndex = permissionCB.Items.IndexOf(permission);

            DataGridViewCell cell = permissionsDGV.Rows[rowIndex].Cells[colIndex + 1];
            User user = User.Instances[username];

            if (colIndex == 0) cell.Value = user.CanRead = !user.CanRead;
            if (colIndex == 1) cell.Value = user.CanChange = !user.CanChange;
            if (colIndex == 2) cell.Value = user.CanResolve = !user.CanResolve;

            allowCheckBox.Enabled = false;
            checkPermissions();
        }

        private void setAllowValue(string username, int colIndex)
        {
            if (User.Instances.ContainsKey(username))
            {
                User selectedUser = User.Instances[username];

                bool check = false;
                if (colIndex == 0) check = selectedUser.CanRead;
                if (colIndex == 1) check = selectedUser.CanChange;
                if (colIndex == 2) check = selectedUser.CanResolve;

                allowCheckBox.Checked = check;
                allowCheckBox.Enabled = currentUser.CanResolve;
            }
        }

        private void checkPermissions()
        {
            userComboBox.Enabled = currentUser.CanResolve;
            permissionCB.Enabled = currentUser.CanResolve;

            sampleTextBox.Enabled = currentUser.CanChange;
            sampleLabel.Visible = currentUser.CanRead;
            sampleTextBox.Visible = currentUser.CanRead;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rootForm.Close();
        }
    }
}
