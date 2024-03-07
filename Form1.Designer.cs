namespace Asignatura_Profesor_Radio_13_7_3_24
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
            lbl_Asignatura=new Label();
            lbl_Profesor=new Label();
            lbl_Modalidad=new Label();
            txt_Asignatura=new TextBox();
            txt_Profesor=new TextBox();
            rb_Virtual=new RadioButton();
            rb_Presencial=new RadioButton();
            btn_Limpiar=new Button();
            btn_Salir=new Button();
            btn_Procesar=new Button();
            gb_Modalidad=new GroupBox();
            label1=new Label();
            gb_Modalidad.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Asignatura
            // 
            lbl_Asignatura.AutoSize=true;
            lbl_Asignatura.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Asignatura.Location=new Point(112, 113);
            lbl_Asignatura.Name="lbl_Asignatura";
            lbl_Asignatura.Size=new Size(82, 19);
            lbl_Asignatura.TabIndex=0;
            lbl_Asignatura.Text="Asignatura";
            // 
            // lbl_Profesor
            // 
            lbl_Profesor.AutoSize=true;
            lbl_Profesor.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Profesor.Location=new Point(112, 152);
            lbl_Profesor.Name="lbl_Profesor";
            lbl_Profesor.Size=new Size(66, 19);
            lbl_Profesor.TabIndex=1;
            lbl_Profesor.Text="Profesor";
            // 
            // lbl_Modalidad
            // 
            lbl_Modalidad.AutoSize=true;
            lbl_Modalidad.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Modalidad.Location=new Point(418, 96);
            lbl_Modalidad.Name="lbl_Modalidad";
            lbl_Modalidad.Size=new Size(0, 19);
            lbl_Modalidad.TabIndex=2;
            // 
            // txt_Asignatura
            // 
            txt_Asignatura.Location=new Point(200, 113);
            txt_Asignatura.Name="txt_Asignatura";
            txt_Asignatura.Size=new Size(115, 23);
            txt_Asignatura.TabIndex=3;
            // 
            // txt_Profesor
            // 
            txt_Profesor.Location=new Point(200, 152);
            txt_Profesor.Name="txt_Profesor";
            txt_Profesor.Size=new Size(115, 23);
            txt_Profesor.TabIndex=4;
            // 
            // rb_Virtual
            // 
            rb_Virtual.AutoSize=true;
            rb_Virtual.Location=new Point(6, 43);
            rb_Virtual.Name="rb_Virtual";
            rb_Virtual.Size=new Size(72, 23);
            rb_Virtual.TabIndex=6;
            rb_Virtual.TabStop=true;
            rb_Virtual.Text="Virtual";
            rb_Virtual.UseVisualStyleBackColor=true;
            // 
            // rb_Presencial
            // 
            rb_Presencial.AutoSize=true;
            rb_Presencial.Location=new Point(116, 43);
            rb_Presencial.Name="rb_Presencial";
            rb_Presencial.Size=new Size(96, 23);
            rb_Presencial.TabIndex=7;
            rb_Presencial.TabStop=true;
            rb_Presencial.Text="Presencial";
            rb_Presencial.UseVisualStyleBackColor=true;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=SystemColors.InactiveCaption;
            btn_Limpiar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(621, 124);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(98, 35);
            btn_Limpiar.TabIndex=9;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=SystemColors.InactiveCaption;
            btn_Salir.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(621, 165);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(98, 37);
            btn_Salir.TabIndex=10;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // btn_Procesar
            // 
            btn_Procesar.BackColor=SystemColors.InactiveCaption;
            btn_Procesar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Procesar.Location=new Point(621, 83);
            btn_Procesar.Name="btn_Procesar";
            btn_Procesar.Size=new Size(98, 35);
            btn_Procesar.TabIndex=11;
            btn_Procesar.Text="Procesar";
            btn_Procesar.UseVisualStyleBackColor=false;
            btn_Procesar.Click+=btn_Procesar_Click;
            // 
            // gb_Modalidad
            // 
            gb_Modalidad.Controls.Add(rb_Presencial);
            gb_Modalidad.Controls.Add(rb_Virtual);
            gb_Modalidad.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_Modalidad.Location=new Point(349, 88);
            gb_Modalidad.Name="gb_Modalidad";
            gb_Modalidad.Size=new Size(221, 100);
            gb_Modalidad.TabIndex=12;
            gb_Modalidad.TabStop=false;
            gb_Modalidad.Text="Modalidad";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(340, 19);
            label1.Name="label1";
            label1.Size=new Size(150, 24);
            label1.TabIndex=13;
            label1.Text="Datos_Profesor";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(gb_Modalidad);
            Controls.Add(btn_Procesar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(txt_Profesor);
            Controls.Add(txt_Asignatura);
            Controls.Add(lbl_Modalidad);
            Controls.Add(lbl_Profesor);
            Controls.Add(lbl_Asignatura);
            Name="Form1";
            Text="Form1";
       
            gb_Modalidad.ResumeLayout(false);
            gb_Modalidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Asignatura;
        private Label lbl_Profesor;
        private Label lbl_Modalidad;
        private TextBox txt_Asignatura;
        private TextBox txt_Profesor;
        private TextBox txt_Datos;
        private RadioButton rb_Virtual;
        private RadioButton rb_Presencial;
        private Label lbl_Datos;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Button btn_Procesar;
        private GroupBox gb_Modalidad;
        private Label label1;
    }
}