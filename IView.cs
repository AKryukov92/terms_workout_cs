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
        void ShowMeta(Meta meta);
        void ShowRiddle(string wheat, string needle);
        void ShowError(string error);
        void ReportProgress(HaystackProgress progress);
        void ShowVerdict(Verdict verdict);
    }
}
