using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ProjetoUm
{
    public partial class FormCadastroPessoa : Form
    {
        private string TextoAuxiliar = "";
        private string Operacao = "";
        private int IdPessoa = 0;
        private int TeclaNumerica = 0;
        public FormCadastroPessoa(string operacao, int id)
        {
            InitializeComponent();
            CarregaComboBoxEstado();
            CarregaComboBoxPessoa();
            Operacao = operacao;
            IdPessoa = id;
        }

        private void CarregaComboBoxPessoa()
        {
            ArrayList arrayPessoa = new ArrayList();
            arrayPessoa.Add("Física");
            arrayPessoa.Add("Jurídica");
            comboBoxPessoa.DataSource = arrayPessoa;
        }

        private void CarregaComboBoxEstado()
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
            using (var banco = new ContextoBancoDados(false))
            {
                try
                {
                    if (IdPessoa == 0)
                    {
                        int idPessoa = banco.CadastroPessoas
                            .Select(x => x.Id)
                            .DefaultIfEmpty()
                            .Max() + 1;

                        banco.Add(new CadastroPessoas() {
                            Id = idPessoa,
                            Nome = textBoxNome.Text,
                            CpfCnpj = maskedTextBoxCpfCnpj.Text.Trim(new Char[] { '.', '-', ' ' }),
                            TipoPessoa = comboBoxPessoa.Text.Trim(),
                            RgIe = textBoxRgIe.Text.Trim(),
                            Endereco = textBoxEndereco.Text.Trim(),
                            Numero = int.Parse(textBoxNumero.Text),
                            Complemento = textBoxComplemento.Text.Trim(),
                            Bairro = textBoxBairro.Text.Trim(),
                            Cidade = textBoxCidade.Text.Trim(),
                            Estado = comboBoxEstado.Text.Trim(),
                            Cep = maskedTextBoxCep.Text.Trim(new Char[] { '.', '-', ' ' }),
                        });
                    }
                    else
                    {
                        var pessoa = banco.CadastroPessoas
                            .Where(x => x.Id == IdPessoa)
                            .FirstOrDefault();

                        pessoa.Nome = textBoxNome.Text;
                        pessoa.CpfCnpj = maskedTextBoxCpfCnpj.Text.Trim(new Char[] { '.', '-', ' ' });
                        pessoa.TipoPessoa = comboBoxPessoa.Text.Trim();
                        pessoa.RgIe = textBoxRgIe.Text.Trim();
                        pessoa.Endereco = textBoxEndereco.Text.Trim();
                        pessoa.Numero = int.Parse(textBoxNumero.Text);
                        pessoa.Complemento = textBoxComplemento.Text.Trim();
                        pessoa.Bairro = textBoxBairro.Text.Trim();
                        pessoa.Cidade = textBoxCidade.Text.Trim();
                        pessoa.Estado = comboBoxEstado.Text.Trim();
                        pessoa.Cep = maskedTextBoxCep.Text.Trim(new Char[] { '.', '-', ' ' });
                        banco.CadastroPessoas.Update(pessoa);
                    }
                    banco.SaveChanges();
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
                    TextoAuxiliar = "";
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

        private void FormCadastroPessoa_Load(object sender, EventArgs e)
        {
            if (Operacao == "Modificar")
            {
                using (var banco = new ContextoBancoDados())
                {
                    var pessoa = banco.CadastroPessoas
                        .Where(x => x.Id == IdPessoa)
                        .FirstOrDefault();

                    textBoxNome.Text = pessoa.Nome.Trim();
                    maskedTextBoxCpfCnpj.Text = pessoa.CpfCnpj.Trim();
                    textBoxRgIe.Text = pessoa.RgIe.Trim();
                    maskedTextBoxCep.Text = pessoa.Cep.Trim();
                    textBoxEndereco.Text = pessoa.Endereco.Trim();
                    textBoxNumero.Text = pessoa.Numero.ToString().Trim();
                    textBoxComplemento.Text = pessoa.Complemento.Trim();
                    textBoxBairro.Text = pessoa.Bairro.Trim();
                    textBoxCidade.Text = pessoa.Cidade.Trim();
                    comboBoxEstado.Text = pessoa.Estado.Trim();
                }
            }
        }
    }
}
