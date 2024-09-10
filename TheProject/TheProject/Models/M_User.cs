using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject.Models
{
    public partial class M_User : ObservableObject
    {
        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private string genero;

        [ObservableProperty]
        private string correo;

        [ObservableProperty]
        private DateTime fechaNacimiento;

        [ObservableProperty]
        private string paisActual;

        [ObservableProperty]
        private string contraseña;
    }
}
