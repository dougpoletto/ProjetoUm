﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
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
            CarregaComboBox();
        }

        private void CarregaComboBox()
        {
            comboBoxEstado.Items.Clear();
            using (var banco = new ContextoBancoDados())
            {
                var estados = banco.CadastroEstado
                    .ToList();
                foreach (var estado in estados)
                {
                    comboBoxEstado.Items.Add(estado.Estado.ToString());
                }
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            using (var pessoas = new ContextoBancoDados(false))
            {
                try
                {
                    pessoas.Add(new CadastroPessoas() {
                        Nome = textBoxNome.Text,
                        CpfCnpj = maskedTextBoxCpfCnpj.Text.Trim(new Char[] { '.', '-', ' ' }),
                        RgIe = textBoxRgIe.Text.Trim(),
                        Endereco = textBoxEndereco.Text.Trim(),
                        Numero = int.Parse(textBoxNumero.Text),
                        Complemento = textBoxComplemento.Text.Trim(),
                        Bairro = textBoxBairro.Text.Trim(),
                        Cidade = textBoxCidade.Text.Trim(),
                        Estado = comboBoxEstado.Text.Trim(),
                        Cep = maskedTextBoxCep.Text.Trim(new Char[] { '.', '-', ' ' }),
                    });
                    pessoas.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Erro ao gravar o registro na tabela. Erro: {ex.Message}", 
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Dispose();
            Close();
        }

        private void maskedTextBoxCpfCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                if (e.KeyCode != Keys.Back)
                {
                    TeclaNumerica += 1;
                }
                else
                {
                    maskedTextBoxCpfCnpj.ResetText();
                    TeclaNumerica = 0;
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
            Dispose();
            Close();
        }

        private async void buttonPesquisaCep_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCep.Text != null && maskedTextBoxCep.Text != "")
            {
                var dadosCep = await ConsultarCep.ConsultaCep(maskedTextBoxCep.Text);
                if (dadosCep != null)
                {
                    textBoxEndereco.Text = dadosCep.Logradouro.Trim();
                    textBoxComplemento.Text = dadosCep.Complemento.Trim();
                    textBoxBairro.Text = dadosCep.Bairro.Trim();
                    textBoxCidade.Text = dadosCep.Localidade.Trim();
                    comboBoxEstado.Text = dadosCep.Uf.Trim();
                }
            }
            else
            {
                MessageBox.Show("Informe o Cep para pesquisa!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
