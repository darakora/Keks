using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaKursach.ViewModel
{
    public class ProjectsListWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Project> Projects
        {
            get
            {
                using (var context = new KursachDBContext())
                {
                    return new ObservableCollection<Project>(context.Projects);
                }
            }
        }
    }
}
