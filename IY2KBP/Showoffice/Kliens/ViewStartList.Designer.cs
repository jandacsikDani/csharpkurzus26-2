namespace Kliens;

partial class ViewStartList
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
        dataGridView = new DataGridView();
        placementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        verificationNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        horseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        associationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        ageGroupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        startFeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        moneyPaidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        resultDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        competitorBindingSource = new BindingSource(components);
        panel1 = new Panel();
        MoveDown = new Button();
        MoveUp = new Button();
        Delete = new Button();
        Add = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)competitorBindingSource).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView
        // 
        dataGridView.AutoGenerateColumns = false;
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Columns.AddRange(new DataGridViewColumn[] { placementDataGridViewTextBoxColumn, verificationNumberDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, startNumberDataGridViewTextBoxColumn, horseDataGridViewTextBoxColumn, associationDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, ageGroupDataGridViewTextBoxColumn, startFeeDataGridViewTextBoxColumn, moneyPaidDataGridViewTextBoxColumn, resultDataGridViewTextBoxColumn });
        dataGridView.DataSource = competitorBindingSource;
        dataGridView.Dock = DockStyle.Top;
        dataGridView.Location = new Point(0, 0);
        dataGridView.Name = "dataGridView";
        dataGridView.Size = new Size(1029, 426);
        dataGridView.TabIndex = 0;
        // 
        // placementDataGridViewTextBoxColumn
        // 
        placementDataGridViewTextBoxColumn.DataPropertyName = "Placement";
        placementDataGridViewTextBoxColumn.HeaderText = "Helyezés";
        placementDataGridViewTextBoxColumn.Name = "placementDataGridViewTextBoxColumn";
        placementDataGridViewTextBoxColumn.Visible = false;
        // 
        // verificationNumberDataGridViewTextBoxColumn
        // 
        verificationNumberDataGridViewTextBoxColumn.DataPropertyName = "VerificationNumber";
        verificationNumberDataGridViewTextBoxColumn.HeaderText = "Ig. szám";
        verificationNumberDataGridViewTextBoxColumn.Name = "verificationNumberDataGridViewTextBoxColumn";
        // 
        // nameDataGridViewTextBoxColumn
        // 
        nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn.HeaderText = "Név";
        nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        // 
        // startNumberDataGridViewTextBoxColumn
        // 
        startNumberDataGridViewTextBoxColumn.DataPropertyName = "StartNumber";
        startNumberDataGridViewTextBoxColumn.HeaderText = "Startszám";
        startNumberDataGridViewTextBoxColumn.Name = "startNumberDataGridViewTextBoxColumn";
        // 
        // horseDataGridViewTextBoxColumn
        // 
        horseDataGridViewTextBoxColumn.DataPropertyName = "Horse";
        horseDataGridViewTextBoxColumn.HeaderText = "Ló";
        horseDataGridViewTextBoxColumn.Name = "horseDataGridViewTextBoxColumn";
        // 
        // associationDataGridViewTextBoxColumn
        // 
        associationDataGridViewTextBoxColumn.DataPropertyName = "Association";
        associationDataGridViewTextBoxColumn.HeaderText = "Egyesület";
        associationDataGridViewTextBoxColumn.Name = "associationDataGridViewTextBoxColumn";
        // 
        // categoryDataGridViewTextBoxColumn
        // 
        categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
        categoryDataGridViewTextBoxColumn.HeaderText = "Ketgória";
        categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
        // 
        // ageGroupDataGridViewTextBoxColumn
        // 
        ageGroupDataGridViewTextBoxColumn.DataPropertyName = "AgeGroup";
        ageGroupDataGridViewTextBoxColumn.HeaderText = "Korcsoport";
        ageGroupDataGridViewTextBoxColumn.Name = "ageGroupDataGridViewTextBoxColumn";
        ageGroupDataGridViewTextBoxColumn.Visible = false;
        // 
        // startFeeDataGridViewTextBoxColumn
        // 
        startFeeDataGridViewTextBoxColumn.DataPropertyName = "StartFee";
        startFeeDataGridViewTextBoxColumn.HeaderText = "Startdíj";
        startFeeDataGridViewTextBoxColumn.Name = "startFeeDataGridViewTextBoxColumn";
        startFeeDataGridViewTextBoxColumn.Visible = false;
        // 
        // moneyPaidDataGridViewTextBoxColumn
        // 
        moneyPaidDataGridViewTextBoxColumn.DataPropertyName = "MoneyPaid";
        moneyPaidDataGridViewTextBoxColumn.HeaderText = "Fizetett";
        moneyPaidDataGridViewTextBoxColumn.Name = "moneyPaidDataGridViewTextBoxColumn";
        moneyPaidDataGridViewTextBoxColumn.Visible = false;
        // 
        // resultDataGridViewTextBoxColumn
        // 
        resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
        resultDataGridViewTextBoxColumn.HeaderText = "Result";
        resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
        // 
        // competitorBindingSource
        // 
        competitorBindingSource.DataSource = typeof(Event.Competitor);
        // 
        // panel1
        // 
        panel1.Controls.Add(MoveDown);
        panel1.Controls.Add(MoveUp);
        panel1.Controls.Add(Delete);
        panel1.Controls.Add(Add);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 424);
        panel1.Name = "panel1";
        panel1.Size = new Size(1029, 50);
        panel1.TabIndex = 1;
        // 
        // MoveDown
        // 
        MoveDown.Location = new Point(385, 8);
        MoveDown.Name = "MoveDown";
        MoveDown.Size = new Size(75, 30);
        MoveDown.TabIndex = 3;
        MoveDown.Text = "Lemozgat";
        MoveDown.UseVisualStyleBackColor = true;
        // 
        // MoveUp
        // 
        MoveUp.Location = new Point(304, 8);
        MoveUp.Name = "MoveUp";
        MoveUp.Size = new Size(75, 30);
        MoveUp.TabIndex = 2;
        MoveUp.Text = "Felmozgat";
        MoveUp.UseVisualStyleBackColor = true;
        // 
        // Delete
        // 
        Delete.BackColor = Color.Red;
        Delete.FlatStyle = FlatStyle.Flat;
        Delete.Location = new Point(93, 8);
        Delete.Name = "Delete";
        Delete.Size = new Size(75, 30);
        Delete.TabIndex = 1;
        Delete.Text = "Törlés";
        Delete.UseVisualStyleBackColor = false;
        // 
        // Add
        // 
        Add.BackColor = Color.Lime;
        Add.FlatStyle = FlatStyle.Flat;
        Add.Location = new Point(12, 8);
        Add.Name = "Add";
        Add.Size = new Size(75, 30);
        Add.TabIndex = 0;
        Add.Text = "Hozzáadás";
        Add.UseVisualStyleBackColor = false;
        Add.Click += Add_Click;
        // 
        // ViewStartList
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1029, 474);
        Controls.Add(panel1);
        Controls.Add(dataGridView);
        Name = "ViewStartList";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Startlista";
        Load += ViewStartList_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)competitorBindingSource).EndInit();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView;
    private BindingSource competitorBindingSource;
    private DataGridViewTextBoxColumn placementDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn verificationNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn horseDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn associationDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ageGroupDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn startFeeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn moneyPaidDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    private Panel panel1;
    private Button MoveDown;
    private Button MoveUp;
    private Button Delete;
    private Button Add;
}