using LoginRegistroUsuarios.BLL;
using LoginRegistroUsuarios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoginRegistroUsuarios.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cUsuarios.xaml
    /// </summary>
    public partial class cUsuarios : Window
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Usuarios>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = UsuariosBLL.GetList(e => e.Nombres.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                    case 1:
                        listado = UsuariosBLL.GetList(e => e.NombreUsuario.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = UsuariosBLL.GetList(c => true);
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

        }
    }
}
