using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void sexoLabel_Click(object sender, EventArgs e)
        {

        }
        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
         

        }
        Pessoa[] bancoDeDados = new Pessoa[100];
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        

            //validações
            if(cmbSexo.Text == "" || txtIdade.Text == "" || cmbSexo.Text == null || txtIdade.Text == null || cmbSexo.Text == "Selecione")
            {
                 MessageBox.Show("Preencha todos os campos...", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else if(Convert.ToInt32(txtIdade.Text) > 120 || Convert.ToInt32(txtIdade.Text) < 0)
            {
                MessageBox.Show("Idade Irregualar! ", "Atencão!", MessageBoxButtons.OK);

            }
            else if(cmbSexo.Text == "M" || cmbSexo.Text =="F")
            {

                // Capturei os valores digitados pelo usuário nos inputs
                string sexo = cmbSexo.Text;
                int idade = Convert.ToInt16(txtIdade.Text);

                // Crei um novo objeto Pessoa com as informações que a pessoa digitou
                Pessoa novaPessoa = new Pessoa { sexo = sexo, idade = idade };

                // Adicionei um novo objeto Pessoa ao array bancoDeDados
                for (int i = 0; i < bancoDeDados.Length; i++)
                {
                    if (bancoDeDados[i] == null)
                    {
                        bancoDeDados[i] = novaPessoa;
                        break;
                    }
                }

                //Se o ChecBox "M" estiver habilitado ele vai acrescentar diretamente no ListView 
                if (chbMasculino.Checked)
                {
                    lstPessoas.Clear();
                    foreach (Pessoa pessoa in bancoDeDados)
                    {
                        if (pessoa != null && pessoa.sexo == "M")
                        {
                            lstPessoas.Items.Add($"Sexo: {pessoa.sexo}, Idade: {pessoa.idade}");
                        }
                    }
                }
                //Se o ChecBox "F" estiver habilitado ele vai acrescentar diretamente no ListView 
                if (chbFeminino.Checked)
                {
                    lstPessoas.Clear();
                    foreach (Pessoa pessoa in bancoDeDados)
                    {
                        if (pessoa != null && pessoa.sexo == "F")
                        {
                            lstPessoas.Items.Add($"Sexo: {pessoa.sexo}, Idade: {pessoa.idade}");
                        }
                    }
                }
                //Se o ChecBox "Todos" estiver habilitado ele vai acrescentar diretamente no ListView 
                if (chbTodos.Checked)
                {

                    lstPessoas.Clear();
                    foreach (Pessoa pessoa in bancoDeDados)
                    {
                        if (pessoa != null)
                        {
                            lstPessoas.Items.Add($"Sexo: {pessoa.sexo}, Idade: {pessoa.idade}");
                        }
                    }
                }


                // Aqui eu vou atualizar o tanto total de cadastros, de M e de F
                lbTotalCad.Text = bancoDeDados.Count(p => p != null).ToString();
                lbTotalM.Text = bancoDeDados.Count(p => p != null && p.sexo == "M").ToString();
                lbTotalF.Text = bancoDeDados.Count(p => p != null && p.sexo == "F").ToString();
            }
            else
            {
                MessageBox.Show("Escolha 'M' ou  'F'! ", "Atencão!", MessageBoxButtons.OK);
            }




        }


        private void chbMasculino_CheckedChanged(object sender, EventArgs e)
        {

            if (chbMasculino.Checked)
            {
                chbFeminino.Checked = false;
                chbTodos.Checked = false;
            }

            // Limpar o ListView
            lstPessoas.Clear();

            // Percorrer o array bancoDeDados e se for M ele filtra no ListView os M
            foreach (Pessoa pessoa in bancoDeDados)
            {
                if (pessoa != null && pessoa.sexo == "M")
                {
                    lstPessoas.Items.Add($"Sexo: {pessoa.sexo}, Idade: {pessoa.idade}");
                }
            }
        }

        private void chbFeminino_CheckedChanged(object sender, EventArgs e)
        {

            if (chbFeminino.Checked)
            {
                chbMasculino.Checked = false;
                chbTodos.Checked = false;
            }

            // Limpar o ListView
            lstPessoas.Clear();

            // Percorrer o array bancoDeDados e se for M ele filtra no ListView os M
            foreach (Pessoa pessoa in bancoDeDados)
            {
                if (pessoa != null && pessoa.sexo == "F")
                {
                    lstPessoas.Items.Add($"Sexo: {pessoa.sexo}, Idade: {pessoa.idade}");
                }
            }
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {

            if (chbTodos.Checked)
            {
                chbFeminino.Checked = false;
                chbMasculino.Checked = false;
            }

            // Limpar o ListView
            lstPessoas.Clear();

            // Percorrer o array bancoDeDados e se for M ele filtra no ListView os M
            foreach (Pessoa pessoa in bancoDeDados)
            {
                if (pessoa != null)
                {
                    lstPessoas.Items.Add($"Sexo: {pessoa.sexo}, Idade: {pessoa.idade}");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           Array.Clear(bancoDeDados, 0, bancoDeDados.Length);
            lstPessoas.Items.Clear();
            lbTotalCad.Text = "0";
            lbTotalM.Text = "0"; 
            lbTotalF.Text = "0";  
        }
    }
 
}
