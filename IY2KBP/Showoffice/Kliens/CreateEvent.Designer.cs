namespace Kliens;

partial class CreateEvent
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        evaulation = new ComboBox();
        name = new TextBox();
        isAgeGroup = new CheckBox();
        baseTime = new TextBox();
        courseLenght = new TextBox();
        Create = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(53, 9);
        label1.Name = "label1";
        label1.Size = new Size(75, 15);
        label1.TabIndex = 0;
        label1.Text = "Verseny neve";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(78, 45);
        label2.Name = "label2";
        label2.Size = new Size(50, 15);
        label2.TabIndex = 1;
        label2.Text = "Elbírálás";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 87);
        label3.Name = "label3";
        label3.Size = new Size(116, 15);
        label3.TabIndex = 2;
        label3.Text = "Korcsoportos bontás";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(55, 167);
        label4.Name = "label4";
        label4.Size = new Size(73, 15);
        label4.TabIndex = 3;
        label4.Text = "Pálya hossza";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(80, 127);
        label5.Name = "label5";
        label5.Size = new Size(48, 15);
        label5.TabIndex = 4;
        label5.Text = "Alapidő";
        // 
        // evaulation
        // 
        evaulation.FormattingEnabled = true;
        evaulation.Location = new Point(152, 42);
        evaulation.Name = "evaulation";
        evaulation.Size = new Size(149, 23);
        evaulation.TabIndex = 2;
        // 
        // name
        // 
        name.Location = new Point(152, 6);
        name.Name = "name";
        name.Size = new Size(149, 23);
        name.TabIndex = 1;
        // 
        // isAgeGroup
        // 
        isAgeGroup.AutoSize = true;
        isAgeGroup.Location = new Point(152, 87);
        isAgeGroup.Name = "isAgeGroup";
        isAgeGroup.Size = new Size(15, 14);
        isAgeGroup.TabIndex = 3;
        isAgeGroup.UseVisualStyleBackColor = true;
        // 
        // baseTime
        // 
        baseTime.Location = new Point(152, 124);
        baseTime.Name = "baseTime";
        baseTime.Size = new Size(149, 23);
        baseTime.TabIndex = 4;
        // 
        // courseLenght
        // 
        courseLenght.Location = new Point(152, 164);
        courseLenght.Name = "courseLenght";
        courseLenght.Size = new Size(149, 23);
        courseLenght.TabIndex = 5;
        // 
        // Create
        // 
        Create.Location = new Point(226, 213);
        Create.Name = "Create";
        Create.Size = new Size(75, 23);
        Create.TabIndex = 6;
        Create.Text = "Létrehoz";
        Create.UseVisualStyleBackColor = true;
        Create.Click += Create_Click;
        // 
        // CreateEvent
        // 
        AcceptButton = Create;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(313, 248);
        Controls.Add(Create);
        Controls.Add(courseLenght);
        Controls.Add(baseTime);
        Controls.Add(isAgeGroup);
        Controls.Add(name);
        Controls.Add(evaulation);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "CreateEvent";
        Text = "Verseny létrehozása";
        Load += CreateEvent_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private ComboBox evaulation;
    private TextBox name;
    private CheckBox isAgeGroup;
    private TextBox baseTime;
    private TextBox courseLenght;
    private Button Create;
}