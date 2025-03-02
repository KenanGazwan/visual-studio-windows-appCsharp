namespace FolderVisualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            directoryTree = new TreeView();
            visualizationPanel = new Panel();
            BrowseButton = new Button();
            BarChartButton = new Button();
            PieChartButton = new Button();
            messageWindow = new ErrorProvider(components);
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)messageWindow).BeginInit();
            SuspendLayout();
            // 
            // directoryTree
            // 
            directoryTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            directoryTree.BackColor = SystemColors.HighlightText;
            directoryTree.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            directoryTree.Indent = 30;
            directoryTree.ItemHeight = 25;
            directoryTree.Location = new Point(20, 22);
            directoryTree.Name = "directoryTree";
            directoryTree.Size = new Size(300, 600);
            directoryTree.TabIndex = 0;
            directoryTree.MouseClick += folderSelection;
            // 
            // visualizationPanel
            // 
            visualizationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            visualizationPanel.AutoScroll = true;
            visualizationPanel.AutoSize = true;
            visualizationPanel.BackColor = SystemColors.ControlLightLight;
            visualizationPanel.Location = new Point(337, 82);
            visualizationPanel.Name = "visualizationPanel";
            visualizationPanel.Size = new Size(1000, 600);
            visualizationPanel.TabIndex = 1;
            // 
            // BrowseButton
            // 
            BrowseButton.Anchor = AnchorStyles.Bottom;
            BrowseButton.AutoSize = true;
            BrowseButton.BackColor = SystemColors.ActiveCaption;
            BrowseButton.BackgroundImageLayout = ImageLayout.None;
            BrowseButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseButton.Location = new Point(67, 668);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(160, 40);
            BrowseButton.TabIndex = 2;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += Browse_Click;
            // 
            // BarChartButton
            // 
            BarChartButton.AutoSize = true;
            BarChartButton.BackColor = SystemColors.ActiveCaption;
            BarChartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BarChartButton.ForeColor = SystemColors.ControlText;
            BarChartButton.Location = new Point(337, 28);
            BarChartButton.Name = "BarChartButton";
            BarChartButton.Size = new Size(160, 40);
            BarChartButton.TabIndex = 3;
            BarChartButton.Text = "Bar Chart";
            BarChartButton.UseVisualStyleBackColor = false;
            BarChartButton.Click += BarChartButton_Click;
            // 
            // PieChartButton
            // 
            PieChartButton.AutoSize = true;
            PieChartButton.BackColor = SystemColors.ActiveCaption;
            PieChartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PieChartButton.Location = new Point(543, 28);
            PieChartButton.Name = "PieChartButton";
            PieChartButton.Size = new Size(160, 40);
            PieChartButton.TabIndex = 4;
            PieChartButton.Text = "Pie Chart";
            PieChartButton.UseVisualStyleBackColor = false;
            PieChartButton.Click += PieChartButton_Click;
            // 
            // messageWindow
            // 
            messageWindow.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(PieChartButton);
            Controls.Add(BarChartButton);
            Controls.Add(BrowseButton);
            Controls.Add(visualizationPanel);
            Controls.Add(directoryTree);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "Directory Visualizer";
            Load += Form_Load;
            Resize += Form_Resize;
            ((System.ComponentModel.ISupportInitialize)messageWindow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView directoryTree;
        private Panel visualizationPanel;
        private Button BrowseButton;
        private Button BarChartButton;
        private Button PieChartButton;
        private ErrorProvider messageWindow;
        private ToolTip toolTip;
    }
}
