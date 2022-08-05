using System;
using System.Windows.Forms;
using System.Globalization;
using SOR4GameExplorer;

namespace SOR4_Swapper
{
    public partial class OwnerDetails : Form
    {
        private readonly MainWindow _mainwindow;
        ToolTip tooltip = new();
        string loadedAuthorDate = "";

        public OwnerDetails(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            txtDateCreated.Text = DateTime.Now.ToString();
            tooltipDiffDisplay.SetToolTip(chkAuthorDisplay, "Display in Difficulty selection\n(This will always be displayed in the credits scene regardless of this setting)");
            tooltipDiffDisplay.SetToolTip(chkTitleDisplay, "Display in Difficulty selection\n(This will always be displayed in the credits scene regardless of this setting)");
            tooltipDiffDisplay.SetToolTip(chkDateDisplay, "Display in Difficulty selection\n(This will always be displayed in the credits scene regardless of this setting)");
        }

        public void LoadSettings(Author author)
        {
            if (author != null)
            {
                txtAuthor.Text = author.name;
                txtModTitle.Text = author.title;
                txtDownloadURL.Text = author.address;
                txtRecoDiff.Text = author.difficulty;
                loadedAuthorDate = author.datecreated;
                chkAuthorDisplay.Checked = author.nameDisplay;
                chkTitleDisplay.Checked = author.titleDisplay;
                chkDateDisplay.Checked = author.dateDisplay;
                string dateCreatedString;
                try
                {
                    dateCreatedString = Convert.ToDateTime(author.datecreated).ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern);
                }
                catch
                {
                    dateCreatedString = author.datecreated;
                }
                txtDateCreated.Text = dateCreatedString;
                if (author.description != null)
                {
                    author.description = author.description.Replace("\n", Environment.NewLine);
                    txtModDesc.Text = author.description;
                }
                if (author.descShort != null)
                {
                    author.descShort = author.descShort.Replace("\n", Environment.NewLine);
                    txtModShortDesc.Text = author.descShort;
                }
            }
        }

        public Author GetValues(bool applyChanges = false)
        {
            Author author = new();
            author.name = txtAuthor.Text;
            author.title = txtModTitle.Text;
            author.address = txtDownloadURL.Text;
            author.difficulty = txtRecoDiff.Text;
            author.nameDisplay = chkAuthorDisplay.Checked;
            author.titleDisplay = chkTitleDisplay.Checked;
            author.dateDisplay = chkDateDisplay.Checked;
            if (loadedAuthorDate != "")
                author.datecreated = loadedAuthorDate;
            else
                author.datecreated = DateTime.Now.ToUniversalTime().ToString(CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat.FullDateTimePattern);

            author.description = txtModDesc.Text.Replace("\r\n", "\n");
            author.descShort = txtModShortDesc.Text.Replace("\r\n", "\n");

            // if saving into a swap file
            if (applyChanges == false)
            {
                author.datecreated = DateTime.Now.ToUniversalTime().ToString(CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat.FullDateTimePattern);
                txtDateCreated.Text = Convert.ToDateTime(author.datecreated).ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern);
            }
            return author;
        }

        private void txtAuthor_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("This will be visible in the credits after the player finishes Stage 12", txtAuthor, 10000);
        }

        private void txtModTitle_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("This will be visible in the credits after the player finishes Stage 12", txtModTitle, 10000);
        }

        private void txtDownloadURL_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("This is primarily to remind players where they can get updates for your mod", txtDownloadURL, 10000);
        }

        private void txtRecoDiff_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtModDesc_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("This will be shown in the introduction text before Stage 1", txtModDesc, 10000);
        }

        private void btnCopyURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDownloadURL.Text);
        }
    }
}
