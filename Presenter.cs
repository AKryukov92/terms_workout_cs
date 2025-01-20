using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx
{
    internal class Presenter
    {
        private readonly IView view;
        private readonly RiddleLoaderService RiddleLoaderService;
        public Presenter(IView view)
        {
            this.view = view;
            RiddleLoaderService = new RiddleLoaderService();
        }
        public void Init()
        {
            view.ShowListOfHaystacks(RiddleLoaderService.LoadHaystackNames());
        }
    }
}
