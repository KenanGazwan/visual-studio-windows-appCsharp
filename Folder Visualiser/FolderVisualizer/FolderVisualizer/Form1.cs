using FolderVisualizer.Charts;
using FolderVisualizer.DirectoryClasses;

namespace FolderVisualizer
{
    public partial class Form1 : Form
    {
        Rectangle originalFormSize, originalTreeViewSize, originalPanelSize, originalBarChartButtonSize, originalPieCahrtButtonSize, originalBrowseButtonSize;
        Graphics graphics;

        Context context;

        MyDirectory currentDirectory;

        string currentDirectoryName;


        public Form1()
        {
            InitializeComponent();

            context = new Context();

            Show(); BringToFront();

            graphics = visualizationPanel.CreateGraphics();

            browsePopulate();

        }

        // Form Resize
        private void Form_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(
                this.Location.X,
                this.Location.Y,
                this.Width,
                this.Height);

            // DirectoryTreeView
            originalTreeViewSize = new Rectangle(
                directoryTree.Location.X,
                directoryTree.Location.Y,
                directoryTree.Width,
                directoryTree.Height
                );

            // VisualizationPanel
            originalPanelSize = new Rectangle(
                visualizationPanel.Location.X,
                visualizationPanel.Location.Y,
                visualizationPanel.Width,
                visualizationPanel.Height
                );

            // BarChartButton
            originalBarChartButtonSize = new Rectangle(
                BarChartButton.Location.X,
                BarChartButton.Location.Y,
                BarChartButton.Width,
                BarChartButton.Height
                );

            // PieChartButton
            originalPieCahrtButtonSize = new Rectangle(
                PieChartButton.Location.X,
                PieChartButton.Location.Y,
                PieChartButton.Width,
                PieChartButton.Height
                );

            // BrowseButton
            originalBrowseButtonSize = new Rectangle(
                BrowseButton.Location.X,
                BrowseButton.Location.Y,
                BrowseButton.Width,
                BrowseButton.Height
                );

        }

        private void Form_Resize(object sender, EventArgs e)
        {
            resizeControl(originalTreeViewSize, directoryTree);
            resizeControl(originalPanelSize, visualizationPanel);
            resizeControl(originalBarChartButtonSize, BarChartButton);
            resizeControl(originalPieCahrtButtonSize, PieChartButton);
            resizeControl(originalBrowseButtonSize, BrowseButton);

            drawChart(currentDirectoryName);
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }


        // Browsing Members
        private string borwseDiaglog()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return dialog.SelectedPath; // mainDirectory Path
                }

                return "";
            }
        }


        private void browsePopulate()
        {
            string directoryPath = borwseDiaglog();

            if (directoryPath != "") messageWindow.Clear();

            try
            {
                currentDirectory = MyDirectory.extractFiles(directoryPath);

                populateTreeView(currentDirectory);

                currentDirectoryName = currentDirectory.getName();
            }
            catch (UnauthorizedAccessException ex)
            {
                messageWindow.SetError(BrowseButton, "Try to browse again! " +
                    "\nYou may have been tried a file that needs a premision");
            }
            catch (Exception ex)
            {
                if (directoryPath == "")
                {
                    messageWindow.SetError(BrowseButton, "Try to browse again! " +
                     "\nIt seems that you have not choose a file");
                }
                else
                {
                    messageWindow.SetError(BrowseButton, "Try to browse again! " +
                     "\nIt seems that you behave in an irregular way");
                }

            }

            // return focusedDirectory; ? ? 
        }


        private void populateTreeView(MyDirectory directory, TreeNodeCollection parentNode)
        {

            if (directory is MyFolder)
            {
                TreeNode folderNode = new TreeNode(directory.getName());
                parentNode.Add(folderNode);

                foreach (MyDirectory file in ((MyFolder)directory).getFiles())
                {
                    populateTreeView(file, folderNode.Nodes);
                }
            }
            else if (directory is MyFile)
            {
                TreeNode fileNode = new TreeNode(directory.getName());
                parentNode.Add(fileNode);
            }

        }


        private void populateTreeView(MyDirectory directory)
        {
            // Helper Method

            directoryTree.Nodes.Clear();

            populateTreeView(directory, directoryTree.Nodes);
        }


        private void Browse_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            browsePopulate();
        }





        // BarChart Members
        private void BarChartButton_Click(object sender, EventArgs e)
        {
            context.setStrategy(new BarChart());

            drawChart(currentDirectoryName);
        }


        private void drawChart(string directoryName)
        {
            // Extract the needed information from the directory
            List<string> titles = new List<string>();
            List<int> values = new List<int>();

            (titles, values) = MyDirectory.extractInfo(currentDirectory, directoryName);

            context.drawChart(visualizationPanel, visualizationPanel.CreateGraphics(), titles, values);

            activateMouseWheelHndler();

            toolTip.SetToolTip(BarChartButton, "ClickTwice");
        }

        private void folderSelection(object sender, EventArgs e)
        {
            if (directoryTree.SelectedNode == null)
            {
                return;
            }

            currentDirectoryName = directoryTree.SelectedNode.Text;

            drawChart(currentDirectoryName);

            toolTip.SetToolTip(directoryTree, "Click Twice");

        }


        private void VisulaizationPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            drawChart(currentDirectoryName);
        }

        private void activateMouseWheelHndler()
        {
            visualizationPanel.MouseWheel += VisulaizationPanel_MouseWheel;
        }

        private void PieChartButton_Click(object sender, EventArgs e)
        {
            context.setStrategy(new PieChart());

            drawChart(currentDirectoryName);
        }
    }
}
