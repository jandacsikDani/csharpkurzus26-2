using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Event;

namespace Kliens.SubForms;

public partial class AddCompetitor : Form
{
    public AddCompetitor()
    {
        InitializeComponent();
    }

    private void Save_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(vnum.Text, out int vnumValue))
        {
            errorProvider.SetError(vnum, "Csak szám érték lehet");
            return;
        }
        if (!int.TryParse(snum.Text, out int snumValue))
        {
            errorProvider.SetError(snum, "Csak szám érték lehet");
            return;
        }
        if (ageGroup.SelectedItem is not EnumItem<AgeGroup> selectedAgeGroup) return;
        Competitor c = new Competitor(
            vnumValue,
            name.Text,
            snumValue,
            horse.Text,
            assoc.Text,
            cat.Text,
            ((EnumItem<AgeGroup>)ageGroup.SelectedItem).Value
        );
        ApplicationState.Current.CompetitionNumber!.addCompetitor(c);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void AddCompetitor_Load(object sender, EventArgs e)
    {
        ageGroup.Enabled = ApplicationState.Current.CompetitionNumber!.IsAgeGroup;
        ageGroup.DataSource = Enum.GetValues<AgeGroup>()
            .Select(x => new EnumItem<AgeGroup>(x))
            .ToList();
        ageGroup.SelectedIndex = 0;
    }
}
