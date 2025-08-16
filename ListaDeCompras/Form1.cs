namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)

        {
            // Verificar se txtProduto esta vazio 
            if (txtProduto.Text.Length == 0)
            {
                MessageBox.Show("o nome do produto não pode estar vazio!",
                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Mudar a cor de fundo e a cor da letra
                txtProduto.BackColor = Color.Red;
                txtProduto.ForeColor = Color.White;
            }
            else if (txtProduto.Text.Length < 2)
            {
                MessageBox.Show("o nome do produto precisa ter no minimo duas letras!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Adicionar o item na lista 
                libCompras.Items.Add(txtProduto.Text);

                // Verificar se o item esta na lista
                if (libCompras.Items.Contains(txtProduto.Text))
                {
                    MessageBox.Show($"Já Existe {txtProduto.Text} Na lista!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mostrar a messagem de sucesso 
                    MessageBox.Show("foi adicionado na lista de compras",
                "show", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Retornar o txbProduto a cor normal:
                    txtProduto.BackColor = Color.White;
                    txtProduto.ForeColor = Color.Black;

                    // Limpar o campo:
                    txtProduto.Text = "";

                }
            }
        }
        private void btnLimpar_click(object sender, EventArgs e)


        {
            // Perguntar se realmente quer apagar:
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar tudo?",
            "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se optar por "sim", apagar:
            if (resposta == DialogResult.Yes)
            {
                libCompras.Items.Clear();

            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            // verificar se o usuário nao selecionou nada 
            if (libCompras.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item pra remover!",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Salvar temporariamente o nome do item que será removido
                string itemRemovido = libCompras.SelectedItem.ToString();

                // remove o item Selecionado:
                libCompras.Items.RemoveAt(libCompras.SelectedIndex);

                MessageBox.Show($"{itemRemovido}foi removido da lista!",
                    "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar tudo?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se optar por "sim", apagar:
            if (resposta == DialogResult.Yes)
            {
                libCompras.Items.Clear();
            }
        }
    }
    }

   









