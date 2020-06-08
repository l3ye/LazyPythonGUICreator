using System.Globalization;
using System.Runtime.CompilerServices;
namespace LazyPythonGUICreator
{
    partial class frmMainform
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "LazyPythonGUICreator";

            // dgvInformation
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.Dock = System.Windows.Forms.DockStyle.Fill;

            // btnCreate
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Text = "Create";
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreate.Height = 25;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            // Controls
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.btnCreate);
        }

        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Button btnCreate;

        #endregion
    }
}

