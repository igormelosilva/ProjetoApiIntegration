namespace desktop.Forms
{
    partial class FrmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCity = new TextBox();
            txtDistrict = new TextBox();
            txtDormitory = new TextBox();
            txtRoom = new TextBox();
            txtWc = new TextBox();
            txtParking = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 40);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cidade";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 68);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Bairro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 97);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Dormitórios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 126);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Salas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 155);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Banheiros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 184);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 5;
            label6.Text = "Vagas de Garagem";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(155, 37);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(213, 23);
            txtCity.TabIndex = 6;
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new Point(155, 65);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(213, 23);
            txtDistrict.TabIndex = 7;
            // 
            // txtDormitory
            // 
            txtDormitory.Location = new Point(155, 94);
            txtDormitory.Name = "txtDormitory";
            txtDormitory.Size = new Size(100, 23);
            txtDormitory.TabIndex = 8;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(155, 123);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(100, 23);
            txtRoom.TabIndex = 9;
            // 
            // txtWc
            // 
            txtWc.Location = new Point(155, 152);
            txtWc.Name = "txtWc";
            txtWc.Size = new Size(100, 23);
            txtWc.TabIndex = 10;
            // 
            // txtParking
            // 
            txtParking.Location = new Point(155, 181);
            txtParking.Name = "txtParking";
            txtParking.Size = new Size(100, 23);
            txtParking.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(155, 222);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Aluguel";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(155, 247);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 19);
            radioButton2.TabIndex = 13;
            radioButton2.Text = "Venda";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 235);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 15;
            label7.Text = "Tipo";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(180, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(293, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 356);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtParking);
            Controls.Add(txtWc);
            Controls.Add(txtRoom);
            Controls.Add(txtDormitory);
            Controls.Add(txtDistrict);
            Controls.Add(txtCity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAdd";
            Text = "FrmAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCity;
        private TextBox txtDistrict;
        private TextBox txtDormitory;
        private TextBox txtRoom;
        private TextBox txtWc;
        private TextBox txtParking;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
    }
}