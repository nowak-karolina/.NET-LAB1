namespace App {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button_run = new Button();
            textBox_items = new TextBox();
            label_items = new Label();
            label_seed = new Label();
            textBox_seed = new TextBox();
            label_capacity = new Label();
            textBox_capacity = new TextBox();
            textBox_results = new TextBox();
            textBox_instance = new TextBox();
            label_results = new Label();
            label_instance = new Label();
            SuspendLayout();
            // 
            // button_run
            // 
            button_run.Location = new Point(42, 211);
            button_run.Name = "button_run";
            button_run.Size = new Size(100, 37);
            button_run.TabIndex = 0;
            button_run.Text = "Run";
            button_run.UseVisualStyleBackColor = true;
            button_run.Click += ButtonRun;
            // 
            // textBox_items
            // 
            textBox_items.Location = new Point(42, 38);
            textBox_items.Name = "textBox_items";
            textBox_items.Size = new Size(100, 23);
            textBox_items.TabIndex = 1;
            textBox_items.TextChanged += TextChanged_number;
            // 
            // label_items
            // 
            label_items.AutoSize = true;
            label_items.Location = new Point(42, 20);
            label_items.Name = "label_items";
            label_items.Size = new Size(97, 15);
            label_items.TabIndex = 2;
            label_items.Text = "Number of items";
            // 
            // label_seed
            // 
            label_seed.AutoSize = true;
            label_seed.Location = new Point(42, 82);
            label_seed.Name = "label_seed";
            label_seed.Size = new Size(31, 15);
            label_seed.TabIndex = 4;
            label_seed.Text = "seed";
            // 
            // textBox_seed
            // 
            textBox_seed.Location = new Point(42, 100);
            textBox_seed.Name = "textBox_seed";
            textBox_seed.Size = new Size(100, 23);
            textBox_seed.TabIndex = 3;
            textBox_seed.TextChanged += TextChanged_number;
            // 
            // label_capacity
            // 
            label_capacity.AutoSize = true;
            label_capacity.Location = new Point(42, 144);
            label_capacity.Name = "label_capacity";
            label_capacity.Size = new Size(53, 15);
            label_capacity.TabIndex = 6;
            label_capacity.Text = "Capacity";
            // 
            // textBox_capacity
            // 
            textBox_capacity.Location = new Point(42, 162);
            textBox_capacity.Name = "textBox_capacity";
            textBox_capacity.Size = new Size(100, 23);
            textBox_capacity.TabIndex = 5;
            textBox_capacity.TextChanged += TextChanged_number;
            // 
            // textBox_results
            // 
            textBox_results.Location = new Point(42, 297);
            textBox_results.Multiline = true;
            textBox_results.Name = "textBox_results";
            textBox_results.ReadOnly = true;
            textBox_results.ScrollBars = ScrollBars.Vertical;
            textBox_results.Size = new Size(279, 303);
            textBox_results.TabIndex = 7;
            // 
            // textBox_instance
            // 
            textBox_instance.CausesValidation = false;
            textBox_instance.Location = new Point(360, 38);
            textBox_instance.Multiline = true;
            textBox_instance.Name = "textBox_instance";
            textBox_instance.ReadOnly = true;
            textBox_instance.ScrollBars = ScrollBars.Vertical;
            textBox_instance.Size = new Size(326, 562);
            textBox_instance.TabIndex = 8;
            // 
            // label_results
            // 
            label_results.AutoSize = true;
            label_results.Location = new Point(277, 279);
            label_results.Name = "label_results";
            label_results.Size = new Size(44, 15);
            label_results.TabIndex = 9;
            label_results.Text = "Results";
            // 
            // label_instance
            // 
            label_instance.AutoSize = true;
            label_instance.Location = new Point(635, 20);
            label_instance.Name = "label_instance";
            label_instance.Size = new Size(51, 15);
            label_instance.TabIndex = 10;
            label_instance.Text = "Instance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(708, 624);
            Controls.Add(label_instance);
            Controls.Add(label_results);
            Controls.Add(textBox_instance);
            Controls.Add(textBox_results);
            Controls.Add(label_capacity);
            Controls.Add(textBox_capacity);
            Controls.Add(label_seed);
            Controls.Add(textBox_seed);
            Controls.Add(label_items);
            Controls.Add(textBox_items);
            Controls.Add(button_run);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_run;
        private TextBox textBox_items;
        private Label label_items;
        private Label label_seed;
        private TextBox textBox_seed;
        private Label label_capacity;
        private TextBox textBox_capacity;
        private TextBox textBox_results;
        private TextBox textBox_instance;
        private Label label_results;
        private Label label_instance;
    }
}
