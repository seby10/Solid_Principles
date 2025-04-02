using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Correct_2
{
    internal class Project
    {
        private List<IDeveloper> _developers;

        public Project(List<IDeveloper> developers)
        {
            _developers = developers;
        }

        public void ProjectDevelop()
        {
            foreach (IDeveloper developer in _developers)
            {
                developer.Develop();
            }
        }
    }
}
