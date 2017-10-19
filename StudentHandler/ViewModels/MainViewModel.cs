using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHandler.ViewModels
{
    class MainViewModel
    {
        public StudentVm Student { get; set; }
        public ObservableCollection<string> ProgramSelection { get; set; }
    }
}
