namespace Shell.UI;

partial class Main
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tbxInput = new System.Windows.Forms.TextBox();
        rtbxOutput = new System.Windows.Forms.RichTextBox();
        btnRun = new System.Windows.Forms.Button();
        pnlInput = new System.Windows.Forms.Panel();
        pnlInput.SuspendLayout();
        SuspendLayout();
        // 
        // tbxInput
        // 
        tbxInput.Dock = System.Windows.Forms.DockStyle.Bottom;
        tbxInput.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tbxInput.Location = new System.Drawing.Point(0, 25);
        tbxInput.Name = "tbxInput";
        tbxInput.PlaceholderText = "Input";
        tbxInput.Size = new System.Drawing.Size(667, 25);
        tbxInput.TabIndex = 0;
        // 
        // rtbxOutput
        // 
        rtbxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
        rtbxOutput.Location = new System.Drawing.Point(0, 0);
        rtbxOutput.Name = "rtbxOutput";
        rtbxOutput.ReadOnly = true;
        rtbxOutput.Size = new System.Drawing.Size(800, 450);
        rtbxOutput.TabIndex = 1;
        rtbxOutput.Text = "Output";
        // 
        // btnRun
        // 
        btnRun.Dock = System.Windows.Forms.DockStyle.Right;
        btnRun.Location = new System.Drawing.Point(667, 0);
        btnRun.Name = "btnRun";
        btnRun.Size = new System.Drawing.Size(133, 50);
        btnRun.TabIndex = 2;
        btnRun.Text = "Run";
        btnRun.UseVisualStyleBackColor = true;
        btnRun.Click += btnRun_Click;
        // 
        // pnlInput
        // 
        pnlInput.Controls.Add(tbxInput);
        pnlInput.Controls.Add(btnRun);
        pnlInput.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlInput.Location = new System.Drawing.Point(0, 400);
        pnlInput.Name = "pnlInput";
        pnlInput.Size = new System.Drawing.Size(800, 50);
        pnlInput.TabIndex = 3;
        // 
        // Main
        // 
        AcceptButton = btnRun;
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(pnlInput);
        Controls.Add(rtbxOutput);
        Text = "Shell";
        pnlInput.ResumeLayout(false);
        pnlInput.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlInput;

    private System.Windows.Forms.Button btnRun;

    private System.Windows.Forms.RichTextBox rtbxOutput;

    private System.Windows.Forms.TextBox tbxInput;

    #endregion
}