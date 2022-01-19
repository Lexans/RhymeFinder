
namespace RhymeFinder
{
    partial class FormMain
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
            this.flowLayoutPanelText = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownForward = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPage = new System.Windows.Forms.NumericUpDown();
            this.buttonGoPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetForward = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelText
            // 
            this.flowLayoutPanelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelText.AutoScroll = true;
            this.flowLayoutPanelText.Location = new System.Drawing.Point(12, 85);
            this.flowLayoutPanelText.Name = "flowLayoutPanelText";
            this.flowLayoutPanelText.Size = new System.Drawing.Size(1271, 415);
            this.flowLayoutPanelText.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ввестиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.файлToolStripMenuItem.Text = "Открыть";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // ввестиToolStripMenuItem
            // 
            this.ввестиToolStripMenuItem.Name = "ввестиToolStripMenuItem";
            this.ввестиToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.ввестиToolStripMenuItem.Text = "Ввести текст";
            this.ввестиToolStripMenuItem.Click += new System.EventHandler(this.ввестиToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDownForward
            // 
            this.numericUpDownForward.Location = new System.Drawing.Point(197, 44);
            this.numericUpDownForward.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownForward.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownForward.Name = "numericUpDownForward";
            this.numericUpDownForward.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownForward.TabIndex = 2;
            this.numericUpDownForward.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "сколько слов проверять";
            // 
            // numericUpDownPage
            // 
            this.numericUpDownPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDownPage.Location = new System.Drawing.Point(569, 525);
            this.numericUpDownPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPage.Name = "numericUpDownPage";
            this.numericUpDownPage.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPage.TabIndex = 4;
            this.numericUpDownPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonGoPage
            // 
            this.buttonGoPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGoPage.Location = new System.Drawing.Point(695, 525);
            this.buttonGoPage.Name = "buttonGoPage";
            this.buttonGoPage.Size = new System.Drawing.Size(75, 23);
            this.buttonGoPage.TabIndex = 5;
            this.buttonGoPage.Text = "Перейти";
            this.buttonGoPage.UseVisualStyleBackColor = true;
            this.buttonGoPage.Click += new System.EventHandler(this.buttonGoPage_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Страница";
            // 
            // buttonSetForward
            // 
            this.buttonSetForward.Location = new System.Drawing.Point(333, 44);
            this.buttonSetForward.Name = "buttonSetForward";
            this.buttonSetForward.Size = new System.Drawing.Size(75, 23);
            this.buttonSetForward.TabIndex = 7;
            this.buttonSetForward.Text = "Задать";
            this.buttonSetForward.UseVisualStyleBackColor = true;
            this.buttonSetForward.Click += new System.EventHandler(this.buttonSetForward_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 559);
            this.Controls.Add(this.buttonSetForward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGoPage);
            this.Controls.Add(this.numericUpDownPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownForward);
            this.Controls.Add(this.flowLayoutPanelText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "RhymeFinder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDownForward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPage;
        private System.Windows.Forms.Button buttonGoPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSetForward;
    }
}

