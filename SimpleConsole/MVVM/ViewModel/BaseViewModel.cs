using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole.MVVM.ViewModel
{
    public class BaseViewModel
    {
        //Add all your view models here
        public ConsoleViewModel ConsoleViewModel { get; set; } = new ConsoleViewModel();
    }
}
