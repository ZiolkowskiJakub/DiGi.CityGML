using DiGi.CityGML.Classes;
using DiGi.CityGML.Enums;

namespace DiGi.CityGML.Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private static void OpenFile()
        {
            string? path = null;

            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Title = "Select GML File";
                openFileDialog.Filter = "GML File (*.gml)|*.gml|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                path = openFileDialog.FileName;
            }

            if (string.IsNullOrWhiteSpace(path) || !Path.Exists(path))
            {
                return;
            }

            LOD? lOD = null;
            int? year = null;

            string? yearString = Path.GetFileName(Path.GetDirectoryName(path));
            if (!string.IsNullOrWhiteSpace(yearString) && int.TryParse(yearString.Trim(), out int year_Temp))
            {
                year = year_Temp;
            }

            string? lODString = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(path)));
            if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, out LOD lOD_Temp))
            {
                lOD = lOD_Temp;
            }

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            CityModel? cityModel = Create.CityModel(path, lOD, year);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }

        private void OpenDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog(this);
            if (dialogResult != DialogResult.OK)
            {
                return;
            }

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            List<CityModel>? cityModels = Create.CityModels(folderBrowserDialog.SelectedPath);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            OpenDirectory();
        }
    }
}