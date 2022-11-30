using Microsoft.Data.SqlClient;
using WFA221125_adapter.Properties;

namespace WFA221125_adapter
{
    public partial class FrmMain : Form
    {
        private int selectedID = -1;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void LoadDGV()
        {
            dgv.Rows.Clear();

            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                cmdText: "SELECT * FROM emberek;",
                connection: conn)
                .ExecuteReader();
            while (rdr.Read())
            {
                dgv.Rows.Add(
                    rdr[0], 
                    rdr[1], 
                    rdr.GetBoolean(2) ? "férfi" : "nõ", 
                    rdr.GetDateTime(3).ToString("yyyy-MM-dd"));
            }

            dgv.ClearSelection();
            selectedID = -1;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNev.Text))
            {
                SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();
                SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                    cmdText: "INSERT INTO emberek VALUES " +
                    $"('{tbNev.Text}', " +
                    $"{(rbFF.Checked ? 1 : 0)}, " +
                    $"'{dtpSzul.Value.ToString("yyyy-MM-dd")}');",
                    connection: conn),
                };
                sda.InsertCommand.ExecuteNonQuery();

                LoadDGV();
            }
            else
            {
                _ = MessageBox.Show(
                    caption: "HIBA",
                    text: "A 'név' mezõ kitöltése kötelezõ!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = (int)dgv[0, e.RowIndex].Value;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "FIGYELMEZTETÉS",
                text: "Biztosan törölni akarod a kijelölt rekordot?",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();
                SqlDataAdapter sda = new()
                {
                    DeleteCommand = new(
                        cmdText: "DELETE FROM emberek " +
                        $"WHERE id = {selectedID};",
                        connection: conn),
                };
                sda.DeleteCommand.ExecuteNonQuery();

                LoadDGV();
            }
        }
    }
}