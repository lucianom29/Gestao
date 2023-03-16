using BLL;
using Models;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuarios : Form
    {
        public FormBuscarUsuarios()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, System.EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
        }

        private void buttonExcluirUsuario_Click(object sender, System.EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe regitro para ser excluido.");
                return;
            }

            if(MessageBox.Show("Deseja realmente excluir este registro?", "Atencão",MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);

            MessageBox.Show("Registro excluido com sucesso!");
            buttonBuscar_Click(null, null);
        }

        private void buttonAdicionarUsuario_Click(object sender, System.EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }

        private void buttonAlterar_Click(object sender, System.EventArgs e)
        {
            int Id = ((Usuario)usuarioBindingSource.Current).Id;

            using(FormCadastroUsuario frm = new FormCadastroUsuario(true,Id))
            {
                frm .ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }
    }
}
