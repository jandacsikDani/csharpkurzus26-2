using Event;

using Kliens.SubForms;

namespace Kliens;

public partial class Menu : Form
{
    public Menu()
    {
        InitializeComponent();
    }
    private void ViewStartlist_Click(object sender, EventArgs e)
    {
        using ViewStartList form = new();
        form.ShowDialog();
    }
    private void CreateEvent_Click(object sender, EventArgs e)
    {
        using CreateEvent form = new();
        if (form.ShowDialog() == DialogResult.OK)
        {
            if (ApplicationState.Current.CompetitionNumber != null)
            { 
                ViewStartlist.Enabled = true;
                ViewResults.Enabled = true;
                ExportResults.Enabled = true;
                SaveEvent.Enabled = true;
            }
        }
    }
}
