namespace Kliens;

partial class Menu
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
        ViewStartlist = new Button();
        ViewResults = new Button();
        OpenEvent = new Button();
        SaveEvent = new Button();
        ExportResults = new Button();
        ExitApplication = new Button();
        CreateEvent = new Button();
        SuspendLayout();
        // 
        // ViewStartlist
        // 
        ViewStartlist.Location = new Point(12, 69);
        ViewStartlist.Name = "ViewStartlist";
        ViewStartlist.Size = new Size(97, 40);
        ViewStartlist.TabIndex = 0;
        ViewStartlist.Text = "Startlista";
        ViewStartlist.UseVisualStyleBackColor = true;
        ViewStartlist.Click += this.ViewStartlist_Click;
        // 
        // ViewResults
        // 
        ViewResults.Location = new Point(132, 69);
        ViewResults.Name = "ViewResults";
        ViewResults.Size = new Size(97, 40);
        ViewResults.TabIndex = 1;
        ViewResults.Text = "Eredmények";
        ViewResults.UseVisualStyleBackColor = true;
        // 
        // OpenEvent
        // 
        OpenEvent.Location = new Point(12, 129);
        OpenEvent.Name = "OpenEvent";
        OpenEvent.Size = new Size(97, 40);
        OpenEvent.TabIndex = 2;
        OpenEvent.Text = "Versenyszám megnyitása";
        OpenEvent.UseVisualStyleBackColor = true;
        // 
        // SaveEvent
        // 
        SaveEvent.Location = new Point(12, 185);
        SaveEvent.Name = "SaveEvent";
        SaveEvent.Size = new Size(97, 40);
        SaveEvent.TabIndex = 3;
        SaveEvent.Text = "Versenyszám mentése";
        SaveEvent.UseVisualStyleBackColor = true;
        // 
        // ExportResults
        // 
        ExportResults.Location = new Point(132, 129);
        ExportResults.Name = "ExportResults";
        ExportResults.Size = new Size(97, 40);
        ExportResults.TabIndex = 4;
        ExportResults.Text = "Eredmények exportálása";
        ExportResults.UseVisualStyleBackColor = true;
        // 
        // ExitApplication
        // 
        ExitApplication.Location = new Point(132, 259);
        ExitApplication.Name = "ExitApplication";
        ExitApplication.Size = new Size(97, 40);
        ExitApplication.TabIndex = 5;
        ExitApplication.Text = "Kilépés";
        ExitApplication.UseVisualStyleBackColor = true;
        // 
        // CreateEvent
        // 
        CreateEvent.Location = new Point(12, 12);
        CreateEvent.Name = "CreateEvent";
        CreateEvent.Size = new Size(97, 40);
        CreateEvent.TabIndex = 6;
        CreateEvent.Text = "Versenyszám létrehozása";
        CreateEvent.UseVisualStyleBackColor = true;
        CreateEvent.Click += this.CreateEvent_Click;
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(246, 311);
        Controls.Add(CreateEvent);
        Controls.Add(ExitApplication);
        Controls.Add(ExportResults);
        Controls.Add(SaveEvent);
        Controls.Add(OpenEvent);
        Controls.Add(ViewResults);
        Controls.Add(ViewStartlist);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "Menu";
        Text = "Showoffice - Menü";
        ResumeLayout(false);
    }
    #endregion

    private Button ViewStartlist;
    private Button ViewResults;
    private Button OpenEvent;
    private Button SaveEvent;
    private Button ExportResults;
    private Button ExitApplication;
    private Button CreateEvent;
}
