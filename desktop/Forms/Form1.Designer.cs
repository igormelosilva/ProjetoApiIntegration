namespace desktop
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvImovel = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            district = new DataGridViewTextBoxColumn();
            dormitory = new DataGridViewTextBoxColumn();
            room = new DataGridViewTextBoxColumn();
            wc = new DataGridViewTextBoxColumn();
            parking = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImovel).BeginInit();
            SuspendLayout();
            // 
            // dgvImovel
            // 
            dgvImovel.AllowUserToAddRows = false;
            dgvImovel.AllowUserToDeleteRows = false;
            dgvImovel.AllowUserToResizeColumns = false;
            dgvImovel.AllowUserToResizeRows = false;
            dgvImovel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImovel.Columns.AddRange(new DataGridViewColumn[] { id, city, district, dormitory, room, wc, parking, type });
            dgvImovel.Location = new Point(53, 11);
            dgvImovel.Margin = new Padding(2);
            dgvImovel.MultiSelect = false;
            dgvImovel.Name = "dgvImovel";
            dgvImovel.ReadOnly = true;
            dgvImovel.RowHeadersVisible = false;
            dgvImovel.RowHeadersWidth = 62;
            dgvImovel.RowTemplate.Height = 25;
            dgvImovel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImovel.Size = new Size(854, 332);
            dgvImovel.TabIndex = 21;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "Identificador";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // city
            // 
            city.DataPropertyName = "cidade";
            city.HeaderText = "Cidade";
            city.Name = "city";
            city.ReadOnly = true;
            // 
            // district
            // 
            district.DataPropertyName = "bairro";
            district.HeaderText = "Bairro";
            district.Name = "district";
            district.ReadOnly = true;
            // 
            // dormitory
            // 
            dormitory.DataPropertyName = "dormitorio";
            dormitory.HeaderText = "Dormitórios";
            dormitory.Name = "dormitory";
            dormitory.ReadOnly = true;
            // 
            // room
            // 
            room.DataPropertyName = "sala";
            room.HeaderText = "Salas";
            room.Name = "room";
            room.ReadOnly = true;
            // 
            // wc
            // 
            wc.DataPropertyName = "banheiro";
            wc.HeaderText = "Banheiros";
            wc.Name = "wc";
            wc.ReadOnly = true;
            // 
            // parking
            // 
            parking.DataPropertyName = "vaga";
            parking.HeaderText = "Vagas de Garagem";
            parking.Name = "parking";
            parking.ReadOnly = true;
            // 
            // type
            // 
            type.DataPropertyName = "tipo";
            type.HeaderText = "Tipo";
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(404, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 23);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Incluir / Editar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 450);
            Controls.Add(btnAdd);
            Controls.Add(dgvImovel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImovel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvImovel;
        private Button btnAdd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn district;
        private DataGridViewTextBoxColumn dormitory;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn wc;
        private DataGridViewTextBoxColumn parking;
        private DataGridViewTextBoxColumn type;
    }
}