using DiGi.CityGML.Classes;

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

        private void Button_Open_Click(object sender, EventArgs e)
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

            CityModel cityModel = Create.CityModel(path);
        }
    }
}
