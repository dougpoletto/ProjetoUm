using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUm
{
    public partial class FormCadastroPessoa : Form
    {
        private int TeclaNumerica = 0;
        private string TextoAuxiliar = "";
        public FormCadastroPessoa()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            using (var pessoas = new ContextoBancoDados(false))
            {
                try
                {
                    pessoas.Add(new CadastroPessoas() {
                        Nome = textBoxNome.Text,
                        CpfCnpj = maskedTextBoxCpfCnpj.Text,
                        RgIe = "",
                        Endereco = "",
                        Numero = 0,
                        Complemento = "",
                        Bairro = "",
                        Cidade = "",
                        Estado = "",
                        Cep = ""
                    });
                    pessoas.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Erro ao gravar o registro na tabela. Erro: {ex.Message}", 
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }

        private void maskedTextBoxCpfCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 || e.KeyCode <= Keys.D9)
            {
                if (e.KeyCode >= Keys.NumPad0 || e.KeyCode <= Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        TeclaNumerica += 1;
                    }
                    else
                    {
                        TeclaNumerica = 0;
                    }
                }
            }
        }

        private void maskedTextBoxCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TeclaNumerica > 11)
            {
                TextoAuxiliar = maskedTextBoxCpfCnpj.Text;
                maskedTextBoxCpfCnpj.Mask = @"00\.000\.000\/0000\-00";
                maskedTextBoxCpfCnpj.ResetText();
                maskedTextBoxCpfCnpj.Text = TextoAuxiliar;
            }
            else
            {
                maskedTextBoxCpfCnpj.Mask = @"000\.000\.000\-00";
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
