﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Semana2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Lab2"].ConnectionString);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaAnios();
        }


        //Crear un metodo para la lsita de los años en el combo box 
        public void ListaAnios() 
        {
            using (SqlCommand cmd = new SqlCommand("Usp_ListaAnios", cn))
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = cmd;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataSet df = new DataSet())
                {
                    //El metodo Fill cargara los datos del procedimiento almacenado
                    da.Fill(df, "ListaAnios");
                    //Enviar datos al combobox
                    cboAnios.DataSource = df.Tables["ListaAnios"];
                    cboAnios.DisplayMember = "Anios";
                    cboAnios.ValueMember = "Anios";
                }
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using(SqlCommand cmd = new SqlCommand("Usp_Lista_Pedidos_Anios", cn))
            {
                using (SqlDataAdapter Da = new SqlDataAdapter())
                {
                    Da.SelectCommand = cmd;
                    Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Da.SelectCommand.Parameters.AddWithValue("@anio", cboAnios.SelectedValue);
                    using(DataSet df = new DataSet())
                    {
                        Da.Fill(df.Tables["Pedidos"]);

                        DgPedidos.DataSource = df.Tables["Pedidos"];
                        LblNumero.Text = df.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }

        }

        private void DgPedidos_DoubleClick(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(DgPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Detalle_Pedido", cn))
            {
                using (SqlDataAdapter Da = new SqlDataAdapter())
                {
                    Da.SelectCommand = cmd;
                    Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Da.SelectCommand.Parameters.AddWithValue("@idpedido", Codigo);
                    using (DataSet df = new DataSet())
                    {
                        Da.Fill(df, "Detalles");
                        DgDetalles.DataSource = df.Tables["Detalles"];
                        LblMonto.Text = df.Tables["Detalles"].Compute("Sum(Monto)", "").ToString();
                    }
                }
            }
        }
    }

  
}
