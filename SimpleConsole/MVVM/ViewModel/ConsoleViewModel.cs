using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleConsole.MVVM.Model;

namespace SimpleConsole.MVVM.ViewModel
{
    public class ConsoleViewModel : ObservableObject
    {
        public ObservableCollection<ConsoleModel> ConsoleMessages { get; set; }

        public ConsoleViewModel()
        {
            ConsoleMessages = new ObservableCollection<ConsoleModel>();
            ConsoleMessages.Add(new ConsoleModel {Message = "Started..."});
        }
    }
}
