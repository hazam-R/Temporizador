namespace Temporizador
{
    partial class Temporizador
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
            components = new System.ComponentModel.Container();
            lblTemp = new Label();
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            tmrTemporizador = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemp.Location = new Point(143, 21);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(388, 149);
            lblTemp.TabIndex = 0;
            lblTemp.Text = "00:00";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(37, 240);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(126, 49);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(222, 240);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(118, 49);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(393, 240);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(125, 49);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // tmrTemporizador
            // 
            tmrTemporizador.Tick += tmrTemporizador_Tick;
            // 
            // Temporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 357);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblTemp);
            Name = "Temporizador";
            Text = "Temporizador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemp;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReiniciar;
        private System.Windows.Forms.Timer tmrTemporizador;
    }
}
