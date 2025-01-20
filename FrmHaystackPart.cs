using Sphinx.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx
{
    public partial class FrmHaystack : IView
    {
        public void ShowListOfHaystacks(string[] names)
        {
            this.LstHaystacks.DataSource = names;
        }

        public void ShowHaystack(Riddle riddle)
        {
            throw new NotImplementedException();
        }

        public void ShowError(string error)
        {
            throw new NotImplementedException();
        }
    }
}
