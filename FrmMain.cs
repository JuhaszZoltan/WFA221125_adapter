using Microsoft.Data.SqlClient;
using WFA221125_adapter.Properties;

namespace WFA221125_adapter
{
    public partial class FrmMain : Form
    {
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
            var rdr = new SqlCommand(
                "SELECT * FROM emberek;",
                conn)
                .ExecuteReader();
            while (rdr.Read())
            {
                dgv.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "FIGYELMEZTETÉS",
                text: "Biztosan hozzá akarod adni a sort a DB-hez????",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                var cmd = new SqlCommand(
                    "INSERT INTO emberek VALUES " +
                    $"('{tbNev.Text}', " +
                    $"{(rbFF.Checked ? 1 : 0)}, " +
                    $"'{dtpSzul.Value.ToString("yyyy-MM-dd")}');",
                    conn);

                SqlDataAdapter sda = new()
                {
                    InsertCommand = cmd,
                    UpdateCommand = null,
                    DeleteCommand = null,
                };
                sda.InsertCommand.ExecuteNonQuery();
                LoadDGV();
            }


        }
    }
}