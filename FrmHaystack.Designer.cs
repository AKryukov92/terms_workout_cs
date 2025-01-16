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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblCorrectAnswers = new System.Windows.Forms.Label();
            this.LblFinalResult = new System.Windows.Forms.Label();
            this.BtnSelectNew = new System.Windows.Forms.Button();
            this.LblPreVerdict = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblVerdict = new System.Windows.Forms.Label();
            this.LblPostVerdict = new System.Windows.Forms.Label();
            this.LblNeedToCorrect = new System.Windows.Forms.Label();
            this.LblIrrelevant = new System.Windows.Forms.Label();
            this.RtxtHaystack = new System.Windows.Forms.RichTextBox();
            this.LblPressEnter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LstHaystacks = new System.Windows.Forms.ListBox();
            this.LblError = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.LblProgress);
            this.flowLayoutPanel1.Controls.Add(this.LblCorrectAnswers);
            this.flowLayoutPanel1.Controls.Add(this.LblFinalResult);
            this.flowLayoutPanel1.Controls.Add(this.BtnSelectNew);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1047, 26);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LblPreVerdict);
            this.flowLayoutPanel2.Controls.Add(this.LblVerdict);
            this.flowLayoutPanel2.Controls.Add(this.LblPostVerdict);
            this.flowLayoutPanel2.Controls.Add(this.LblNeedToCorrect);
            this.flowLayoutPanel2.Controls.Add(this.LblIrrelevant);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(344, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(706, 38);
            this.flowLayoutPanel2.TabIndex = 4;
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
            // RtxtHaystack
            // 
            this.RtxtHaystack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtxtHaystack.Location = new System.Drawing.Point(344, 131);
            this.RtxtHaystack.Name = "RtxtHaystack";
            this.RtxtHaystack.ReadOnly = true;
            this.RtxtHaystack.Size = new System.Drawing.Size(706, 476);
            this.RtxtHaystack.TabIndex = 5;
            this.RtxtHaystack.Text = "";
            this.RtxtHaystack.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RtxtHaystack_KeyUp);
            // 
            // LblPressEnter
            // 
            this.LblPressEnter.AutoSize = true;
            this.LblPressEnter.Location = new System.Drawing.Point(344, 105);
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
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RtxtHaystack, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LstHaystacks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblError, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 648);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // LstHaystacks
            // 
            this.LstHaystacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstHaystacks.FormattingEnabled = true;
            this.LstHaystacks.ItemHeight = 16;
            this.LstHaystacks.Location = new System.Drawing.Point(3, 35);
            this.LstHaystacks.Name = "LstHaystacks";
            this.tableLayoutPanel1.SetRowSpan(this.LstHaystacks, 3);
            this.LstHaystacks.Size = new System.Drawing.Size(335, 90);
            this.LstHaystacks.TabIndex = 7;
            this.LstHaystacks.DoubleClick += new System.EventHandler(this.LbHaystacks_DoubleClick);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblError, 2);
            this.LblError.Location = new System.Drawing.Point(3, 610);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(744, 16);
            this.LblError.TabIndex = 8;
            this.LblError.Text = "ОШИБКА: Не удалось загрузить список заданий. В папке с приложением должен находит" +
    "ься файл haystacks.data";
            // 
            // FrmHaystack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmHaystack";
            this.Text = "Сфинкс";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblNeedle;
        private System.Windows.Forms.Label LblProgress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblCorrectAnswers;
        private System.Windows.Forms.Label LblFinalResult;
        private System.Windows.Forms.Button BtnSelectNew;
        private System.Windows.Forms.Label LblPreVerdict;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LblVerdict;
        private System.Windows.Forms.Label LblPostVerdict;
        private System.Windows.Forms.Label LblNeedToCorrect;
        private System.Windows.Forms.Label LblIrrelevant;
        private System.Windows.Forms.RichTextBox RtxtHaystack;
        private System.Windows.Forms.Label LblPressEnter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox LstHaystacks;
        private System.Windows.Forms.Label LblError;
    }
}

