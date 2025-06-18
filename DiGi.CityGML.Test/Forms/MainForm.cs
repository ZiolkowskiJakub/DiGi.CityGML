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

        private void OpenFile()
        {
            string path = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
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

            string yearString = Path.GetFileName(Path.GetDirectoryName(path));
            if (!string.IsNullOrWhiteSpace(yearString) && int.TryParse(yearString.Trim(), out int year_Temp))
            {
                year = year_Temp;
            }

            string lODString = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(path)));
            if (!string.IsNullOrWhiteSpace(lODString) && Enum.TryParse(lODString, out LOD lOD_Temp))
            {
                lOD = lOD_Temp;
            }

            CityModel cityModel = Create.CityModel(path, lOD, year);
        }

        private void OpenDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog(this);
            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            List<CityModel> cityModels = Create.CityModels(folderBrowserDialog.SelectedPath);
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            OpenDirectory();
        }
    }
}
