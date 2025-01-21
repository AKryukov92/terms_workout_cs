using Sphinx.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphinx
{
    public partial class FrmHaystack : Form, IView
    {
        private Presenter presenter;
        public FrmHaystack()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            presenter.Init();
        }
        #region Event handlers
        private void RtxtHaystack_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                presenter.Guess(RtxtHaystack.SelectedText, RtxtHaystack.SelectedText);
            }
        }

        private void BtnSelectNew_Click(object sender, EventArgs e)
        {

        }

        private void LbHaystacks_DoubleClick(object sender, EventArgs e)
        {

        }

        private void BtnSelectTask_Click(object sender, EventArgs e)
        {
            if (TreeMeta.SelectedNode != null && TreeMeta.SelectedNode.Parent != null && TreeMeta.SelectedNode.Tag != null)
            {
                var node = TreeMeta.SelectedNode;
                var haystack = (MetaHaystack)node.Tag;
                presenter.LoadHaystackById(haystack.id);
            }
        }

        private void TreeMeta_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TreeMeta.SelectedNode == null || TreeMeta.SelectedNode.Parent == null)
            {
                BtnSelectTask.Enabled = false;
            }
            else
            {
                BtnSelectTask.Enabled = true;
            }
        }

        private void TreeMeta_DoubleClick(object sender, EventArgs e)
        {
            if (TreeMeta.SelectedNode != null && TreeMeta.SelectedNode.Parent != null && TreeMeta.SelectedNode.Tag != null)
            {
                var node = TreeMeta.SelectedNode;
                var haystack = (MetaHaystack)node.Tag;
                presenter.LoadHaystackById(haystack.id);
            }
        }
        #endregion

        #region IView impl
        public void ShowRiddle(string wheat, string needle)
        {
            tableLayoutPanel1.RowStyles[0].Height = 32;
            tableLayoutPanel1.RowStyles[1].Height = 23;
            tableLayoutPanel1.RowStyles[2].Height = 32;
            tableLayoutPanel1.RowStyles[3].Height = 23;
            tableLayoutPanel1.RowStyles[4].Height = 100;
            tableLayoutPanel1.RowStyles[5].Height = 0;
            tableLayoutPanel1.ColumnStyles[0].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].Width = 100;
            TreeMeta.Visible = false;
            FlpHeader.Visible = true;
            FlpFate.Visible = true;
            RtxtHaystack.Text = wheat;
            RtxtHaystack.Visible = true;
            LblNeedle.Text = "Выделите в тексте: " + needle;
            LblNeedle.Visible = true;
            LblError.Visible = false;
            LblError.Text = "";
        }

        public void ShowError(string error)
        {
            TreeMeta.Visible = false;
            FlpHeader.Visible = false;
            FlpFate.Visible = false;
            RtxtHaystack.Visible = false;
            LblError.Text = error;
            LblError.Visible = true;
            LblNeedle.Visible = false;
            LblNeedle.Text = "";
            tableLayoutPanel1.RowStyles[0].Height = 0;
            tableLayoutPanel1.RowStyles[1].Height = 0;
            tableLayoutPanel1.RowStyles[2].Height = 0;
            tableLayoutPanel1.RowStyles[3].Height = 0;
            tableLayoutPanel1.RowStyles[4].Height = 0;
            tableLayoutPanel1.RowStyles[5].Height = 23;
            tableLayoutPanel1.ColumnStyles[0].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].Width = 100;
        }

        public void ShowMeta(Meta meta)
        {
            TreeMeta.BeginUpdate();
            foreach (var theme in meta.themes)
            {
                var node = TreeMeta.Nodes.Add(theme.name);
                node.Tag = theme;
                foreach (var haystack in theme.haystacks)
                {
                    var subnode = node.Nodes.Add(haystack.name);
                    subnode.Tag = haystack;
                }
            }
            TreeMeta.ExpandAll();
            TreeMeta.EndUpdate();
            TreeMeta.Visible = true;
            FlpHeader.Visible = false;
            FlpFate.Visible = false;
            RtxtHaystack.Visible = false;
            LblError.Visible = false;
            LblError.Text = "";
            LblNeedle.Visible = false;
            LblNeedle.Text = "";
            tableLayoutPanel1.RowStyles[0].Height = 0;
            tableLayoutPanel1.RowStyles[1].Height = 23;
            tableLayoutPanel1.RowStyles[2].Height = 32;
            tableLayoutPanel1.RowStyles[3].Height = 23;
            tableLayoutPanel1.RowStyles[4].Height = 0;
            tableLayoutPanel1.RowStyles[5].Height = 0;
            tableLayoutPanel1.ColumnStyles[0].Width = 100;
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
        }

        public void ReportProgress(HaystackProgress progress)
        {
            LblProgress.Text = "Решенных задач: " + progress.CurrentProgress + "/" + progress.MaxProgress;
            LblCorrectAnswers.Text = "Правильных ответов: " + progress.CurrentAnswerProgress + "/" + progress.MaxAnswerProgress;
            if (progress.CurrentAnswerProgress == progress.MaxAnswerProgress)
            {
                LblFinalResult.Visible = true;
                BtnSelectNew.Visible = true;
            } else
            {
                LblFinalResult.Visible = false;
                BtnSelectNew.Visible = false;
            }
        }

        public void ShowVerdict(Verdict verdict)
        {
            if (verdict.correct)
            {
                LblVerdict.Text = "верный";
            }
            if (verdict.incorrect)
            {
                LblVerdict.Text = "неправильный";
            }
            LblIrrelevant.Visible = !verdict.relevant;
        }
        #endregion
    }
}
