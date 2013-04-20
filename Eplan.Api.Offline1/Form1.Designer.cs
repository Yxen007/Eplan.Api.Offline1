using Eplan.EplApi.System;
using System;
namespace Eplan.Api.Offline1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private EplApplication m_oEplApp = new EplApplication();
        private bool m_bIsP8AlreadyInitialized = false;
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
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Name = "btnStart";
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";


            /*this.components = new System.ComponentModel.Container();
            this.Size = new System.Drawing.Size(300,300);*/
            this.Text = "Form1";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.form1_Closing);
            this.ResumeLayout(false);


        }

        #endregion
    }
}

