namespace Kliens.SubForms;

partial class AddCompetitor
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        vnum = new TextBox();
        name = new TextBox();
        snum = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        horse = new TextBox();
        label5 = new Label();
        assoc = new TextBox();
        label6 = new Label();
        cat = new ComboBox();
        Save = new Button();
        ageGroup = new ComboBox();
        label7 = new Label();
        errorProvider = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // vnum
        // 
        vnum.Location = new Point(12, 25);
        vnum.Name = "vnum";
        vnum.Size = new Size(187, 23);
        vnum.TabIndex = 0;
        // 
        // name
        // 
        name.Location = new Point(12, 72);
        name.Name = "name";
        name.Size = new Size(187, 23);
        name.TabIndex = 1;
        // 
        // snum
        // 
        snum.Location = new Point(12, 116);
        snum.Name = "snum";
        snum.Size = new Size(187, 23);
        snum.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 5);
        label1.Name = "label1";
        label1.Size = new Size(50, 15);
        label1.TabIndex = 3;
        label1.Text = "Ig. szám";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 52);
        label2.Name = "label2";
        label2.Size = new Size(28, 15);
        label2.TabIndex = 4;
        label2.Text = "Név";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(15, 98);
        label3.Name = "label3";
        label3.Size = new Size(58, 15);
        label3.TabIndex = 5;
        label3.Text = "Startszám";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(15, 143);
        label4.Name = "label4";
        label4.Size = new Size(20, 15);
        label4.TabIndex = 7;
        label4.Text = "Ló";
        // 
        // horse
        // 
        horse.Location = new Point(12, 161);
        horse.Name = "horse";
        horse.Size = new Size(187, 23);
        horse.TabIndex = 6;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(15, 188);
        label5.Name = "label5";
        label5.Size = new Size(57, 15);
        label5.TabIndex = 9;
        label5.Text = "Egyesület";
        // 
        // assoc
        // 
        assoc.Location = new Point(12, 206);
        assoc.Name = "assoc";
        assoc.Size = new Size(187, 23);
        assoc.TabIndex = 8;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(15, 278);
        label6.Name = "label6";
        label6.Size = new Size(57, 15);
        label6.TabIndex = 11;
        label6.Text = "Kategória";
        // 
        // cat
        // 
        cat.FormattingEnabled = true;
        cat.Items.AddRange(new object[] { "REV", "REV nélküli", "Nyitott" });
        cat.Location = new Point(12, 296);
        cat.Name = "cat";
        cat.Size = new Size(187, 23);
        cat.TabIndex = 12;
        // 
        // Save
        // 
        Save.Location = new Point(12, 340);
        Save.Name = "Save";
        Save.Size = new Size(187, 23);
        Save.TabIndex = 13;
        Save.Text = "Mentés";
        Save.UseVisualStyleBackColor = true;
        Save.Click += Save_Click;
        // 
        // ageGroup
        // 
        ageGroup.FormattingEnabled = true;
        ageGroup.Items.AddRange(new object[] { "I.kcs", "II.kcs", "III.kcs" });
        ageGroup.Location = new Point(12, 251);
        ageGroup.Name = "ageGroup";
        ageGroup.Size = new Size(187, 23);
        ageGroup.TabIndex = 15;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(15, 233);
        label7.Name = "label7";
        label7.Size = new Size(65, 15);
        label7.TabIndex = 14;
        label7.Text = "Korcsoport";
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // AddCompetitor
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(211, 381);
        Controls.Add(ageGroup);
        Controls.Add(label7);
        Controls.Add(Save);
        Controls.Add(cat);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(assoc);
        Controls.Add(label4);
        Controls.Add(horse);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(snum);
        Controls.Add(name);
        Controls.Add(vnum);
        MaximizeBox = false;
        Name = "AddCompetitor";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Új versenyző";
        Load += AddCompetitor_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox vnum;
    private TextBox name;
    private TextBox snum;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox horse;
    private Label label5;
    private TextBox assoc;
    private Label label6;
    private ComboBox cat;
    private Button Save;
    private ComboBox ageGroup;
    private Label label7;
    private ErrorProvider errorProvider;
}