using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sphinx.dto;

namespace Sphinx
{
    internal interface IView
    {
        void ShowListOfHaystacks(string[] names);
        void ShowHaystack(Riddle riddle);
        void ShowError(string error);
    }
}
