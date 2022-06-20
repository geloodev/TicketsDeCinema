using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsDeCinema
{
    public partial class BuyTicket : UserControl
    {
        string connectionString;
        MySqlConnection connection;

        int movieToBuyId;
        string movieToBuyName;
        string movieDate;
        string movieTime;
        int movieToBuyRoom;
        bool isSubtitled;
        bool is3d;

        List<string> selectedChairs = new List<string>();

        int boughtTicketsAmout = 0;
        float total = 0;

        string[,] matriz;
        int linhas = 5;
        int colunas = 20;

        char[] alf = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public BuyTicket()
        {
            InitializeComponent();

            connectionString = @"server=localhost;uid=root;pwd=admin;database=cinema;ConnectionTimeout=2";
            connection = new MySqlConnection(connectionString);

            dgChairs.ColumnCount = colunas;
            dgChairs.RowCount = linhas;

            inicilizarMatriz();
            desenhaMatriz();
        }

        public void inicilizarMatriz()
        {
            this.matriz = new String[linhas, colunas];

            for (int i = 0; i < this.linhas; i++)
            {
                for (int j = 0; j < this.colunas; j++)
                {
                    if (j < 10)
                    {
                        this.matriz[i, j] = alf[i] + "0" + j;
                    } else
                    {
                        this.matriz[i, j] = $"{alf[i]}{j}";
                    }
                }
            }

        }

        public void define_valor_celula(int linha, int coluna, String valor)
        {
            this.matriz[linha, coluna] = valor;
        }

        public String obtem_valor(int linha, int coluna)
        {
            return this.matriz[linha, coluna];
        }

        private void desenhaMatriz()
        {
            for (int i = 0; i < linhas; i++)
            {
                //definir altura (linha)
                dgChairs.Rows[i].Height = 15;

                for (int j = 0; j < colunas; j++)
                {
                    //definir largura (coluna)
                    dgChairs.Columns[j].Width = 15;

                    switch (obtem_valor(i, j).ToCharArray()[obtem_valor(i, j).ToCharArray().Count() - 1])
                    {
                        case 'O':
                            dgChairs.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            break;

                        case 'S':
                            dgChairs.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                            break;

                        default:
                            dgChairs.Rows[i].Cells[j].Style.BackColor = Color.Green;
                            break;
                    }
                }
            }
        }

        public void setMovieNameLabel(string movieName)
        {
            lbMovieName.Text = movieName;
        }

        public void setMovieInfoLabel(string date, string time, int movieRoom)
        {
            lbSessionInfo.Text = date + " | " + time + " | Sala " + movieRoom;
        }

        public void setMovieToBuyId(int movieToBuyId) { this.movieToBuyId = movieToBuyId; }

        public void setMovieToBuyName(string movieToBuyName) { this.movieToBuyName = movieToBuyName; }

        public void setMovieDate(string movieDate) { this.movieDate = movieDate; }

        public void setMovieTime(string movieTime) { this.movieTime = movieTime; }

        public void setMovieToBuyRoom(int movieToBuyRoom) { this.movieToBuyRoom = movieToBuyRoom; }

        public void setMovieIsSubtitled(bool isSubtitled) { this.isSubtitled = isSubtitled; }

        public void setMovieIs3d(bool is3d) { this.is3d = is3d; }

        private void dgChairs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgChairs.CurrentCell.RowIndex;
            int coluna = dgChairs.CurrentCell.ColumnIndex;

            switch (obtem_valor(linha, coluna).ToCharArray()[obtem_valor(linha, coluna).ToCharArray().Count() - 1])
            {
                case 'S':
                    define_valor_celula(linha, coluna, $"{alf[linha]}{coluna}");
                    boughtTicketsAmout--;
                    total = 14 * boughtTicketsAmout;
                    selectedChairs.Remove($"{alf[linha]}{coluna}");
                    break;

                case 'O':
                    MessageBox.Show("Assento ocupado, selecione outro");
                    break;

                default:
                    define_valor_celula(linha, coluna, $"{alf[linha]}{coluna}S");
                    boughtTicketsAmout++;
                    total = 14 * boughtTicketsAmout;
                    selectedChairs.Add(obtem_valor(linha, coluna).Replace("S", ""));
                    break;
            }

            desenhaMatriz();

            lbChairsSelectedAmount.Text = boughtTicketsAmout.ToString();
            lbTotal.Text = total.ToString();

            dgChairs.ClearSelection();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (selectedChairs.Count == 0)
            {
                MessageBox.Show("Nenhum assento selecionado");
                return;
            } else
            {
                foreach(string selectedChair in selectedChairs)
                {
                    try
                    {
                        connection.Open();

                        MySqlCommand insertTicket = new MySqlCommand();

                        insertTicket.Connection = connection;

                        insertTicket.CommandText = "insert into ticket values (default, @userId, @movieId, @movieRoom, @movieTime, @price, @selectedChair, @movieIs3d, @movieIsSubtitled, @movieIsHalfPriced)";
                        insertTicket.Parameters.AddWithValue("@userId", "12345678900");
                        insertTicket.Parameters.AddWithValue("@movieId", movieToBuyId);
                        insertTicket.Parameters.AddWithValue("@movieRoom", movieToBuyRoom);
                        insertTicket.Parameters.AddWithValue("@movieTime", movieDate + " " + movieTime + ":00");
                        insertTicket.Parameters.AddWithValue("@price", 14.00);
                        insertTicket.Parameters.AddWithValue("@selectedChair", selectedChair);
                        insertTicket.Parameters.AddWithValue("@movieIs3d", is3d == true ? 1 : 0);
                        insertTicket.Parameters.AddWithValue("@movieIsSubtitled", isSubtitled == true ? 1 : 0);
                        insertTicket.Parameters.AddWithValue("@movieIsHalfPriced", 1);

                        insertTicket.ExecuteNonQuery();

                        MessageBox.Show("Ingressos comprados com sucesso, verifique no menu 'Meus ingressos'");
                        this.Hide();
                    }
                    catch (MySqlException er)
                    {
                        MessageBox.Show(er.Message);
                    }
                    finally
                    {
                        if (connection != null) connection.Close();
                    }
                }
            }
        }
    }
}
