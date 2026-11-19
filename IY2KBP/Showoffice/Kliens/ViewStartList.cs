using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Kliens.SubForms;

namespace Kliens;

public partial class ViewStartList : Form
{
    public ViewStartList()
    {
        InitializeComponent();
    }

    private void ViewStartList_Load(object sender, EventArgs e)
    {
        dataGridView.DataSource = ApplicationState.Current.CompetitionNumber!.Competitors;
    }

    private void Add_Click(object sender, EventArgs e)
    {
        using AddCompetitor form = new();
        if (form.ShowDialog() == DialogResult.OK)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = ApplicationState.Current.CompetitionNumber!.Competitors;
        }

    }
}
