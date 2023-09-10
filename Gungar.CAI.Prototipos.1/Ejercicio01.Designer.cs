namespace Gungar.CAI.Prototipos._1
{
    partial class Ejercicio01
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
            label1 = new Label();
            label2 = new Label();
            nombreText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            aceptarBtn = new Button();
            cancelBtn = new Button();
            documentoText = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            apellidoText = new TextBox();
            nacimientoDate = new DateTimePicker();
            resultadoText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // nombreText
            // 
            nombreText.Location = new Point(118, 27);
            nombreText.MaxLength = 50;
            nombreText.Name = "nombreText";
            nombreText.Size = new Size(100, 23);
            nombreText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 9);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 9);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Nacimiento";
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(353, 68);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(100, 34);
            aceptarBtn.TabIndex = 9;
            aceptarBtn.Text = "OK";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(459, 68);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 34);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // documentoText
            // 
            documentoText.Location = new Point(12, 27);
            documentoText.MaxLength = 8;
            documentoText.Name = "documentoText";
            documentoText.Size = new Size(100, 23);
            documentoText.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // apellidoText
            // 
            apellidoText.Location = new Point(224, 27);
            apellidoText.MaxLength = 50;
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(100, 23);
            apellidoText.TabIndex = 13;
            // 
            // nacimientoDate
            // 
            nacimientoDate.Location = new Point(330, 27);
            nacimientoDate.MaxDate = new DateTime(2100, 12, 12, 0, 0, 0, 0);
            nacimientoDate.Name = "nacimientoDate";
            nacimientoDate.Size = new Size(229, 23);
            nacimientoDate.TabIndex = 14;
            nacimientoDate.Value = new DateTime(2023, 9, 10, 0, 0, 0, 0);
            // 
            // resultadoText
            // 
            resultadoText.Location = new Point(12, 123);
            resultadoText.Name = "resultadoText";
            resultadoText.Size = new Size(547, 23);
            resultadoText.TabIndex = 15;
            // 
            // Ejercicio01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultadoText);
            Controls.Add(nacimientoDate);
            Controls.Add(apellidoText);
            Controls.Add(documentoText);
            Controls.Add(cancelBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nombreText);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Ejercicio01";
            Text = "Prototipos - Ejercicio 1";
            Load += Ejercicio01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox nombreText;
        private Label label3;
        private Label label4;
        private Button aceptarBtn;
        private Button cancelBtn;
        private TextBox documentoText;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox apellidoText;
        private DateTimePicker nacimientoDate;
        private TextBox resultadoText;
    }
}