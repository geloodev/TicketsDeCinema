namespace TicketsDeCinema
{
    partial class BuyTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMovieName = new System.Windows.Forms.Label();
            this.lbSessionInfo = new System.Windows.Forms.Label();
            this.dgChairs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChairsSelectedAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgChairs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMovieName.Location = new System.Drawing.Point(10, 10);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(48, 14);
            this.lbMovieName.TabIndex = 0;
            this.lbMovieName.Text = "label1";
            // 
            // lbSessionInfo
            // 
            this.lbSessionInfo.AutoSize = true;
            this.lbSessionInfo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbSessionInfo.Location = new System.Drawing.Point(10, 30);
            this.lbSessionInfo.Name = "lbSessionInfo";
            this.lbSessionInfo.Size = new System.Drawing.Size(86, 12);
            this.lbSessionInfo.TabIndex = 1;
            this.lbSessionInfo.Text = "00:00 | Sala 1";
            // 
            // dgChairs
            // 
            this.dgChairs.AllowUserToResizeColumns = false;
            this.dgChairs.AllowUserToResizeRows = false;
            this.dgChairs.BackgroundColor = System.Drawing.Color.White;
            this.dgChairs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgChairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChairs.ColumnHeadersVisible = false;
            this.dgChairs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgChairs.Location = new System.Drawing.Point(13, 77);
            this.dgChairs.Name = "dgChairs";
            this.dgChairs.ReadOnly = true;
            this.dgChairs.RowHeadersVisible = false;
            this.dgChairs.Size = new System.Drawing.Size(561, 278);
            this.dgChairs.TabIndex = 2;
            this.dgChairs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChairs_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione seu(s) assento(s)";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnBuyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyTicket.FlatAppearance.BorderSize = 0;
            this.btnBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyTicket.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnBuyTicket.ForeColor = System.Drawing.Color.White;
            this.btnBuyTicket.Location = new System.Drawing.Point(374, 419);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(200, 30);
            this.btnBuyTicket.TabIndex = 8;
            this.btnBuyTicket.Text = "Confirmar pedido";
            this.btnBuyTicket.UseVisualStyleBackColor = false;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecionados:";
            // 
            // lbChairsSelectedAmount
            // 
            this.lbChairsSelectedAmount.AutoSize = true;
            this.lbChairsSelectedAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbChairsSelectedAmount.Location = new System.Drawing.Point(270, 60);
            this.lbChairsSelectedAmount.Name = "lbChairsSelectedAmount";
            this.lbChairsSelectedAmount.Size = new System.Drawing.Size(12, 12);
            this.lbChairsSelectedAmount.TabIndex = 10;
            this.lbChairsSelectedAmount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total: R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(365, 60);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(37, 12);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "00,00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(13, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ocupado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Livre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(91, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Selecionado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(145, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 17;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbChairsSelectedAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgChairs);
            this.Controls.Add(this.lbSessionInfo);
            this.Controls.Add(this.lbMovieName);
            this.Name = "BuyTicket";
            this.Size = new System.Drawing.Size(588, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgChairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.Label lbSessionInfo;
        private System.Windows.Forms.DataGridView dgChairs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChairsSelectedAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}
