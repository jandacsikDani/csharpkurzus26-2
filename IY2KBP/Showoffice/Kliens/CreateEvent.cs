using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Event;
using Event.Evaluation;

namespace Kliens;

public partial class CreateEvent : Form
{
    public CompetitionNumber CompetitionNumber { get; private set; }
    public CreateEvent()
    {
        InitializeComponent();
    }

    private void Create_Click(object sender, EventArgs e)
    {
        if (evaulation.SelectedItem == null) return;
        CompetitionNumber = new CompetitionNumber(name.Text, (EvaluationType)evaulation.SelectedItem, isAgeGroup.Checked, Convert.ToDouble(baseTime.Text), Convert.ToDouble(courseLenght.Text));
        DialogResult = DialogResult.OK;
        Close();
    }

    private void CreateEvent_Load(object sender, EventArgs e)
    {
        evaulation.DataSource = Enum.GetValues(typeof(EvaluationType));
    }
}
