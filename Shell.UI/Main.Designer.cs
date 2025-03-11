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
        SuspendLayout();
        // 
        // tbxInput
        // 
        tbxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        tbxInput.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tbxInput.Location = new System.Drawing.Point(0, 425);
        tbxInput.Name = "tbxInput";
        tbxInput.PlaceholderText = "Input";
        tbxInput.Size = new System.Drawing.Size(140, 25);
        tbxInput.TabIndex = 0;
        // 
        // rtbxOutput
        // 
        rtbxOutput.Dock = System.Windows.Forms.DockStyle.Right;
        rtbxOutput.Location = new System.Drawing.Point(468, 0);
        rtbxOutput.Name = "rtbxOutput";
        rtbxOutput.ReadOnly = true;
        rtbxOutput.Size = new System.Drawing.Size(332, 450);
        rtbxOutput.TabIndex = 1;
        rtbxOutput.Text = "Output";
        // 
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(rtbxOutput);
        Controls.Add(tbxInput);
        Text = "Shell";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.RichTextBox rtbxOutput;

    private System.Windows.Forms.TextBox tbxInput;

    #endregion
}