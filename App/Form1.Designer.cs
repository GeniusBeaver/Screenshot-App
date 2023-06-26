namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(493, 7);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(146, 35);
            button1.TabIndex = 0;
            button1.Text = "Сохранить в ...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 335);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(493, 56);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(146, 36);
            button2.TabIndex = 3;
            button2.Text = "Запустить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(9, 79);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 132);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(493, 108);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(146, 38);
            button5.TabIndex = 8;
            button5.Text = "Выделить область";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(494, 161);
            button6.Name = "button6";
            button6.Size = new Size(146, 34);
            button6.TabIndex = 9;
            button6.Text = "Выход";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 161);
            label1.Name = "label1";
            label1.Size = new Size(479, 140);
            label1.TabIndex = 10;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 303);
            label2.Name = "label2";
            label2.Size = new Size(270, 20);
            label2.TabIndex = 11;
            label2.Text = "Текущий путь сохранения скриншота";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 56);
            label3.Name = "label3";
            label3.Size = new Size(360, 20);
            label3.TabIndex = 12;
            label3.Text = "Выбор промежутка времени между скриншотами";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 108);
            label4.Name = "label4";
            label4.Size = new Size(227, 20);
            label4.TabIndex = 13;
            label4.Text = "Выбор количества скриншотов";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(9, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(154, 27);
            textBox4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 3);
            label5.Name = "label5";
            label5.Size = new Size(358, 20);
            label5.TabIndex = 15;
            label5.Text = "Выбор времени задержки для запуска скирнштов";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 368);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
    }
}