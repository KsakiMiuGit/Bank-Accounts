namespace BankAccounts
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
            label1 = new Label();
            CreateBtn = new Button();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            label2 = new Label();
            NameTxt = new TextBox();
            AmountTxt = new NumericUpDown();
            DataAcc = new DataGridView();
            SortNameBtn = new Button();
            SortBalanceBtn = new Button();
            SearchBtn = new Button();
            BackBtn = new Button();
            label3 = new Label();
            OldNameTxt = new TextBox();
            NewNameBtn = new TextBox();
            ChangeNameBtn = new Button();
            SaveBtn = new Button();
            UpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataAcc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // CreateBtn
            // 
            CreateBtn.Font = new Font("Segoe UI", 12F);
            CreateBtn.Location = new Point(24, 97);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(153, 31);
            CreateBtn.TabIndex = 1;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(24, 201);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(153, 32);
            DepositBtn.TabIndex = 2;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(183, 201);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(167, 32);
            WithdrawBtn.TabIndex = 3;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(24, 155);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 4;
            label2.Text = "Amount:";
            // 
            // NameTxt
            // 
            NameTxt.Font = new Font("Segoe UI", 12F);
            NameTxt.Location = new Point(106, 48);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(244, 29);
            NameTxt.TabIndex = 5;
            // 
            // AmountTxt
            // 
            AmountTxt.Font = new Font("Segoe UI", 12F);
            AmountTxt.Location = new Point(125, 156);
            AmountTxt.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(164, 29);
            AmountTxt.TabIndex = 7;
            // 
            // DataAcc
            // 
            DataAcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataAcc.Location = new Point(366, 44);
            DataAcc.Name = "DataAcc";
            DataAcc.Size = new Size(535, 405);
            DataAcc.TabIndex = 8;
            DataAcc.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SortNameBtn
            // 
            SortNameBtn.Location = new Point(366, 471);
            SortNameBtn.Name = "SortNameBtn";
            SortNameBtn.Size = new Size(129, 37);
            SortNameBtn.TabIndex = 9;
            SortNameBtn.Text = "Sort by Name";
            SortNameBtn.UseVisualStyleBackColor = true;
            SortNameBtn.Click += SortNameBtn_Click;
            // 
            // SortBalanceBtn
            // 
            SortBalanceBtn.Location = new Point(501, 471);
            SortBalanceBtn.Name = "SortBalanceBtn";
            SortBalanceBtn.Size = new Size(131, 37);
            SortBalanceBtn.TabIndex = 10;
            SortBalanceBtn.Text = "Sort by balance";
            SortBalanceBtn.UseVisualStyleBackColor = true;
            SortBalanceBtn.Click += SortBalanceBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(183, 97);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(167, 31);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(808, 471);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(93, 37);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(24, 275);
            label3.Name = "label3";
            label3.Size = new Size(147, 30);
            label3.TabIndex = 13;
            label3.Text = "Change name";
            // 
            // OldNameTxt
            // 
            OldNameTxt.Font = new Font("Segoe UI", 12F);
            OldNameTxt.Location = new Point(24, 308);
            OldNameTxt.Name = "OldNameTxt";
            OldNameTxt.Size = new Size(326, 29);
            OldNameTxt.TabIndex = 14;
            OldNameTxt.Text = "Old name";
            // 
            // NewNameBtn
            // 
            NewNameBtn.Font = new Font("Segoe UI", 12F);
            NewNameBtn.Location = new Point(24, 343);
            NewNameBtn.Name = "NewNameBtn";
            NewNameBtn.Size = new Size(326, 29);
            NewNameBtn.TabIndex = 15;
            NewNameBtn.Text = "New name";
            // 
            // ChangeNameBtn
            // 
            ChangeNameBtn.Location = new Point(252, 378);
            ChangeNameBtn.Name = "ChangeNameBtn";
            ChangeNameBtn.Size = new Size(98, 34);
            ChangeNameBtn.TabIndex = 16;
            ChangeNameBtn.Text = "Change";
            ChangeNameBtn.UseVisualStyleBackColor = true;
            ChangeNameBtn.Click += ChangeNameBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(24, 471);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(129, 37);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(159, 471);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(130, 37);
            UpdateBtn.TabIndex = 18;
            UpdateBtn.Text = "Update from file";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 536);
            Controls.Add(UpdateBtn);
            Controls.Add(SaveBtn);
            Controls.Add(ChangeNameBtn);
            Controls.Add(NewNameBtn);
            Controls.Add(OldNameTxt);
            Controls.Add(label3);
            Controls.Add(BackBtn);
            Controls.Add(SearchBtn);
            Controls.Add(SortBalanceBtn);
            Controls.Add(SortNameBtn);
            Controls.Add(DataAcc);
            Controls.Add(AmountTxt);
            Controls.Add(NameTxt);
            Controls.Add(label2);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(CreateBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataAcc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreateBtn;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Label label2;
        private TextBox NameTxt;
        private NumericUpDown AmountTxt;
        private DataGridView DataAcc;
        private Button SortNameBtn;
        private Button SortBalanceBtn;
        private Button SearchBtn;
        private Button BackBtn;
        private Label label3;
        private TextBox OldNameTxt;
        private TextBox NewNameBtn;
        private Button ChangeNameBtn;
        private Button SaveBtn;
        private Button UpdateBtn;
    }
}
