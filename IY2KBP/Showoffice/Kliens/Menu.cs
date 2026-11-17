using Event;

namespace Kliens;

public partial class Menu : Form
{
    public Menu()
    {
        InitializeComponent();
    }
    private void ViewStartlist_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
    private void CreateEvent_Click(object sender, EventArgs e)
    {
        using CreateEvent form = new();
        if (form.ShowDialog() == DialogResult.OK)
        {
            CompetitionNumber cn = form.CompetitionNumber;
        }
    }
}
