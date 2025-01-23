namespace Sphinx
{
    partial class FrmHaystack
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNeedle = new System.Windows.Forms.Label();
            this.LblProgress = new System.Windows.Forms.Label();
            this.FlpHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.LblCorrectAnswers = new System.Windows.Forms.Label();
            this.LblFinalResult = new System.Windows.Forms.Label();
            this.BtnSelectNew = new System.Windows.Forms.Button();
            this.LblPreVerdict = new System.Windows.Forms.Label();
            this.FlpFate = new System.Windows.Forms.FlowLayoutPanel();
            this.LblVerdict = new System.Windows.Forms.Label();
            this.LblPostVerdict = new System.Windows.Forms.Label();
            this.LblNeedToCorrect = new System.Windows.Forms.Label();
            this.LblIrrelevant = new System.Windows.Forms.Label();
            this.LblPressEnter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblError = new System.Windows.Forms.Label();
            this.TreeMeta = new System.Windows.Forms.TreeView();
            this.LblChooseHaystack = new System.Windows.Forms.Label();
            this.BtnSelectTask = new System.Windows.Forms.Button();
            this.RtxtHaystack = new Sphinx.FixedRichTextBox();
            this.FlpHeader.SuspendLayout();
            this.FlpFate.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNeedle
            // 
            this.LblNeedle.AutoSize = true;
            this.LblNeedle.Location = new System.Drawing.Point(344, 32);
            this.LblNeedle.Name = "LblNeedle";
            this.LblNeedle.Size = new System.Drawing.Size(133, 16);
            this.LblNeedle.TabIndex = 0;
            this.LblNeedle.Text = "Выделите в тексте:";
            // 
            // LblProgress
            // 
            this.LblProgress.AutoSize = true;
            this.LblProgress.Location = new System.Drawing.Point(3, 0);
            this.LblProgress.Name = "LblProgress";
            this.LblProgress.Size = new System.Drawing.Size(115, 16);
            this.LblProgress.TabIndex = 1;
            this.LblProgress.Text = "Решенных задач";
            // 
            // FlpHeader
            // 
            this.FlpHeader.Controls.Add(this.LblProgress);
            this.FlpHeader.Controls.Add(this.LblCorrectAnswers);
            this.FlpHeader.Controls.Add(this.LblFinalResult);
            this.FlpHeader.Controls.Add(this.BtnSelectNew);
            this.FlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpHeader.Location = new System.Drawing.Point(344, 3);
            this.FlpHeader.Name = "FlpHeader";
            this.FlpHeader.Size = new System.Drawing.Size(706, 26);
            this.FlpHeader.TabIndex = 2;
            // 
            // LblCorrectAnswers
            // 
            this.LblCorrectAnswers.AutoSize = true;
            this.LblCorrectAnswers.Location = new System.Drawing.Point(124, 0);
            this.LblCorrectAnswers.Name = "LblCorrectAnswers";
            this.LblCorrectAnswers.Size = new System.Drawing.Size(144, 16);
            this.LblCorrectAnswers.TabIndex = 2;
            this.LblCorrectAnswers.Text = "Правильных ответов";
            // 
            // LblFinalResult
            // 
            this.LblFinalResult.AutoSize = true;
            this.LblFinalResult.Location = new System.Drawing.Point(274, 0);
            this.LblFinalResult.Name = "LblFinalResult";
            this.LblFinalResult.Size = new System.Drawing.Size(205, 16);
            this.LblFinalResult.TabIndex = 3;
            this.LblFinalResult.Text = "Вы полностью решили задачу.";
            // 
            // BtnSelectNew
            // 
            this.BtnSelectNew.Location = new System.Drawing.Point(485, 3);
            this.BtnSelectNew.Name = "BtnSelectNew";
            this.BtnSelectNew.Size = new System.Drawing.Size(173, 23);
            this.BtnSelectNew.TabIndex = 4;
            this.BtnSelectNew.Text = "Выбрать новую задачу";
            this.BtnSelectNew.UseVisualStyleBackColor = true;
            this.BtnSelectNew.Click += new System.EventHandler(this.BtnSelectNew_Click);
            // 
            // LblPreVerdict
            // 
            this.LblPreVerdict.AutoSize = true;
            this.LblPreVerdict.Location = new System.Drawing.Point(3, 0);
            this.LblPreVerdict.Name = "LblPreVerdict";
            this.LblPreVerdict.Size = new System.Drawing.Size(57, 16);
            this.LblPreVerdict.TabIndex = 3;
            this.LblPreVerdict.Text = "Ответ - ";
            // 
            // FlpFate
            // 
            this.FlpFate.Controls.Add(this.LblPreVerdict);
            this.FlpFate.Controls.Add(this.LblVerdict);
            this.FlpFate.Controls.Add(this.LblPostVerdict);
            this.FlpFate.Controls.Add(this.LblNeedToCorrect);
            this.FlpFate.Controls.Add(this.LblIrrelevant);
            this.FlpFate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpFate.Location = new System.Drawing.Point(344, 58);
            this.FlpFate.Name = "FlpFate";
            this.FlpFate.Size = new System.Drawing.Size(706, 38);
            this.FlpFate.TabIndex = 4;
            // 
            // LblVerdict
            // 
            this.LblVerdict.AutoSize = true;
            this.LblVerdict.Location = new System.Drawing.Point(66, 0);
            this.LblVerdict.Name = "LblVerdict";
            this.LblVerdict.Size = new System.Drawing.Size(85, 16);
            this.LblVerdict.TabIndex = 4;
            this.LblVerdict.Text = "(НЕ)верный";
            // 
            // LblPostVerdict
            // 
            this.LblPostVerdict.AutoSize = true;
            this.LblPostVerdict.Location = new System.Drawing.Point(157, 0);
            this.LblPostVerdict.Name = "LblPostVerdict";
            this.LblPostVerdict.Size = new System.Drawing.Size(278, 16);
            this.LblPostVerdict.TabIndex = 5;
            this.LblPostVerdict.Text = "Для правильного ответа нужно выделить";
            // 
            // LblNeedToCorrect
            // 
            this.LblNeedToCorrect.AutoSize = true;
            this.LblNeedToCorrect.Location = new System.Drawing.Point(441, 0);
            this.LblNeedToCorrect.Name = "LblNeedToCorrect";
            this.LblNeedToCorrect.Size = new System.Drawing.Size(124, 16);
            this.LblNeedToCorrect.TabIndex = 6;
            this.LblNeedToCorrect.Text = "БОЛЬШЕ ТЕКСТА";
            // 
            // LblIrrelevant
            // 
            this.LblIrrelevant.AutoSize = true;
            this.LblIrrelevant.Location = new System.Drawing.Point(3, 16);
            this.LblIrrelevant.Name = "LblIrrelevant";
            this.LblIrrelevant.Size = new System.Drawing.Size(419, 16);
            this.LblIrrelevant.TabIndex = 7;
            this.LblIrrelevant.Text = "Фрагмент текста отсутствует в задании. Попробуйте еще раз.";
            // 
            // LblPressEnter
            // 
            this.LblPressEnter.AutoSize = true;
            this.LblPressEnter.Location = new System.Drawing.Point(344, 99);
            this.LblPressEnter.Name = "LblPressEnter";
            this.LblPressEnter.Size = new System.Drawing.Size(191, 16);
            this.LblPressEnter.TabIndex = 6;
            this.LblPressEnter.Text = "Для проверки нажмите Enter";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.39247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.60753F));
            this.tableLayoutPanel1.Controls.Add(this.LblNeedle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblPressEnter, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.FlpHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FlpFate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblError, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TreeMeta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblChooseHaystack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSelectTask, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RtxtHaystack, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 648);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(344, 610);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(653, 32);
            this.LblError.TabIndex = 8;
            this.LblError.Text = "ОШИБКА: Не удалось загрузить список заданий. В папке с приложением должен находит" +
    "ься файл haystacks.data";
            // 
            // TreeMeta
            // 
            this.TreeMeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeMeta.Location = new System.Drawing.Point(3, 35);
            this.TreeMeta.Name = "TreeMeta";
            this.tableLayoutPanel1.SetRowSpan(this.TreeMeta, 4);
            this.TreeMeta.Size = new System.Drawing.Size(335, 572);
            this.TreeMeta.TabIndex = 9;
            this.TreeMeta.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMeta_AfterSelect);
            this.TreeMeta.DoubleClick += new System.EventHandler(this.TreeMeta_DoubleClick);
            // 
            // LblChooseHaystack
            // 
            this.LblChooseHaystack.AutoSize = true;
            this.LblChooseHaystack.Location = new System.Drawing.Point(3, 0);
            this.LblChooseHaystack.Name = "LblChooseHaystack";
            this.LblChooseHaystack.Size = new System.Drawing.Size(123, 16);
            this.LblChooseHaystack.TabIndex = 10;
            this.LblChooseHaystack.Text = "Выберите задачу";
            // 
            // BtnSelectTask
            // 
            this.BtnSelectTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelectTask.Location = new System.Drawing.Point(3, 613);
            this.BtnSelectTask.Name = "BtnSelectTask";
            this.BtnSelectTask.Size = new System.Drawing.Size(335, 32);
            this.BtnSelectTask.TabIndex = 11;
            this.BtnSelectTask.Text = "Выбрать";
            this.BtnSelectTask.UseVisualStyleBackColor = true;
            this.BtnSelectTask.Click += new System.EventHandler(this.BtnSelectTask_Click);
            // 
            // RtxtHaystack
            // 
            this.RtxtHaystack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtHaystack.Location = new System.Drawing.Point(344, 125);
            this.RtxtHaystack.Name = "RtxtHaystack";
            this.RtxtHaystack.ReadOnly = true;
            this.RtxtHaystack.Size = new System.Drawing.Size(706, 482);
            this.RtxtHaystack.TabIndex = 12;
            this.RtxtHaystack.Text = "";
            this.RtxtHaystack.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RtxtHaystack_KeyUp);
            // 
            // FrmHaystack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmHaystack";
            this.Text = "Сфинкс";
            this.FlpHeader.ResumeLayout(false);
            this.FlpHeader.PerformLayout();
            this.FlpFate.ResumeLayout(false);
            this.FlpFate.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblNeedle;
        private System.Windows.Forms.Label LblProgress;
        private System.Windows.Forms.FlowLayoutPanel FlpHeader;
        private System.Windows.Forms.Label LblCorrectAnswers;
        private System.Windows.Forms.Label LblFinalResult;
        private System.Windows.Forms.Button BtnSelectNew;
        private System.Windows.Forms.Label LblPreVerdict;
        private System.Windows.Forms.FlowLayoutPanel FlpFate;
        private System.Windows.Forms.Label LblVerdict;
        private System.Windows.Forms.Label LblPostVerdict;
        private System.Windows.Forms.Label LblNeedToCorrect;
        private System.Windows.Forms.Label LblIrrelevant;
        private System.Windows.Forms.Label LblPressEnter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.TreeView TreeMeta;
        private System.Windows.Forms.Label LblChooseHaystack;
        private System.Windows.Forms.Button BtnSelectTask;
        private FixedRichTextBox RtxtHaystack;
    }
}

