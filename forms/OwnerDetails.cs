using System;
using System.Windows.Forms;
using SOR4GameExplorer;

namespace SOR4_Swapper
{
    public partial class OwnerDetails : Form
    {
        private MainWindow _mainwindow;
        Library classlib;
        string authorTooltipString = "This will be visible in the credits after the player finishes Stage 12";
        string titleTooltipString = "This will be visible in the credits after the player finishes Stage 12";
        string urlTooltipString = "This is primarily to remind players where they can get updates for your mod";
        string recomTooltipString = "...";
        string descTooltipString = "This will be shown in the introduction text before Stage 1";
        ToolTip tooltipAuthor = new();
        ToolTip tooltipTitle = new();
        ToolTip tooltipURL = new();
        ToolTip tooltipDesc = new();
        string loadedAuthorDate = "";

        public OwnerDetails(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            txtDateCreated.Text = DateTime.Now.ToString();
        }

        public void LoadSettings(Author author)
        {
            if (author != null)
            {
                txtAuthor.Text = author.name;
                txtModTitle.Text = author.title;
                txtDownloadURL.Text = author.address;
                txtRecoDiff.Text = author.difficulty;
                string dateCreatedString;
                try
                {
                    dateCreatedString = Convert.ToDateTime(author.datecreated).ToLocalTime().ToString(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern);
                }
                catch
                {
                    dateCreatedString = author.datecreated;
                }
                loadedAuthorDate = dateCreatedString;
                txtDateCreated.Text = dateCreatedString;
                if (author.description != null)
                {
                    author.description = author.description.Replace("\n", Environment.NewLine);
                    txtModDesc.Text = author.description;
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
            if (loadedAuthorDate != "")
            {
                author.datecreated = loadedAuthorDate;
            }
            else
            {
                author.datecreated = DateTime.Now.ToUniversalTime().ToString(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern);
            }
            author.description = txtModDesc.Text.Replace("\r\n", "\n");
            if (applyChanges == false)
            {
                author.datecreated = DateTime.Now.ToUniversalTime().ToString(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern);
                txtDateCreated.Text = Convert.ToDateTime(author.datecreated).ToLocalTime().ToString(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern);
            }
            return author;
        }

        private void txtAuthor_MouseHover(object sender, EventArgs e)
        {
            tooltipAuthor.Show(authorTooltipString, this.txtAuthor, 10000);
        }

        private void txtModTitle_MouseHover(object sender, EventArgs e)
        {
            tooltipTitle.Show(titleTooltipString, this.txtModTitle, 10000);
        }

        private void txtDownloadURL_MouseHover(object sender, EventArgs e)
        {
            tooltipURL.Show(urlTooltipString, this.txtDownloadURL, 10000);
        }

        private void txtRecoDiff_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtModDesc_MouseHover(object sender, EventArgs e)
        {
            tooltipDesc.Show(descTooltipString, this.txtModDesc, 10000);
        }
    }
}
