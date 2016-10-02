namespace EihabIrisRecognition
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertCrossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalBinarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pupilDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locatePupilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.locatePupilInFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.computeNumberOfPixelsInPupilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irisDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locatePupilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computeIrisRadiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locateIrisRectangularAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIrisRectangularAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterIrisRectangularAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locateTheCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locateIsolatedIrisPixelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.locateIrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locateIrisInFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectPupilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectIrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computeRunLengthFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srcPicture = new System.Windows.Forms.PictureBox();
            this.resPicture = new System.Windows.Forms.PictureBox();
            this.contrastStrechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createIrisArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preProcessToolStripMenuItem,
            this.pupilDetectionToolStripMenuItem,
            this.irisDetectionToolStripMenuItem,
            this.recognitionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preProcessToolStripMenuItem
            // 
            this.preProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicFiltersToolStripMenuItem,
            this.basicOperationsToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.binarizationToolStripMenuItem});
            this.preProcessToolStripMenuItem.Name = "preProcessToolStripMenuItem";
            this.preProcessToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.preProcessToolStripMenuItem.Text = "PreProcess";
            // 
            // basicFiltersToolStripMenuItem
            // 
            this.basicFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianFilterToolStripMenuItem});
            this.basicFiltersToolStripMenuItem.Name = "basicFiltersToolStripMenuItem";
            this.basicFiltersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.basicFiltersToolStripMenuItem.Text = "Basic Filters";
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.medianFilterToolStripMenuItem.Text = "Median Filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // basicOperationsToolStripMenuItem
            // 
            this.basicOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expToolStripMenuItem,
            this.logToolStripMenuItem});
            this.basicOperationsToolStripMenuItem.Name = "basicOperationsToolStripMenuItem";
            this.basicOperationsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.basicOperationsToolStripMenuItem.Text = "Basic Operations";
            // 
            // expToolStripMenuItem
            // 
            this.expToolStripMenuItem.Name = "expToolStripMenuItem";
            this.expToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.expToolStripMenuItem.Text = "Exp";
            this.expToolStripMenuItem.Click += new System.EventHandler(this.expToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.showToolStripMenuItem,
            this.normalizationToolStripMenuItem,
            this.equalizationToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // normalizationToolStripMenuItem
            // 
            this.normalizationToolStripMenuItem.Name = "normalizationToolStripMenuItem";
            this.normalizationToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.normalizationToolStripMenuItem.Text = "Normalization";
            this.normalizationToolStripMenuItem.Click += new System.EventHandler(this.normalizationToolStripMenuItem_Click);
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.robertCrossToolStripMenuItem});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.basicToolStripMenuItem.Text = "Basic";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click);
            // 
            // robertCrossToolStripMenuItem
            // 
            this.robertCrossToolStripMenuItem.Name = "robertCrossToolStripMenuItem";
            this.robertCrossToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.robertCrossToolStripMenuItem.Text = "Robert Cross";
            this.robertCrossToolStripMenuItem.Click += new System.EventHandler(this.robertCrossToolStripMenuItem_Click);
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalBinarizationToolStripMenuItem});
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.binarizationToolStripMenuItem.Text = "Binarization";
            // 
            // globalBinarizationToolStripMenuItem
            // 
            this.globalBinarizationToolStripMenuItem.Name = "globalBinarizationToolStripMenuItem";
            this.globalBinarizationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.globalBinarizationToolStripMenuItem.Text = "Global Binarization";
            this.globalBinarizationToolStripMenuItem.Click += new System.EventHandler(this.globalBinarizationToolStripMenuItem_Click);
            // 
            // pupilDetectionToolStripMenuItem
            // 
            this.pupilDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locatePupilToolStripMenuItem1,
            this.locatePupilInFilesToolStripMenuItem,
            this.toolStripSeparator4,
            this.computeNumberOfPixelsInPupilToolStripMenuItem,
            this.testToolStripMenuItem});
            this.pupilDetectionToolStripMenuItem.Name = "pupilDetectionToolStripMenuItem";
            this.pupilDetectionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.pupilDetectionToolStripMenuItem.Text = "Pupil Detection";
            // 
            // locatePupilToolStripMenuItem1
            // 
            this.locatePupilToolStripMenuItem1.Name = "locatePupilToolStripMenuItem1";
            this.locatePupilToolStripMenuItem1.Size = new System.Drawing.Size(260, 22);
            this.locatePupilToolStripMenuItem1.Text = "Locate Pupil by Steps";
            this.locatePupilToolStripMenuItem1.Click += new System.EventHandler(this.locatePupilToolStripMenuItem1_Click);
            // 
            // locatePupilInFilesToolStripMenuItem
            // 
            this.locatePupilInFilesToolStripMenuItem.Name = "locatePupilInFilesToolStripMenuItem";
            this.locatePupilInFilesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.locatePupilInFilesToolStripMenuItem.Text = "Locate Pupil in Files";
            this.locatePupilInFilesToolStripMenuItem.Click += new System.EventHandler(this.locatePupilInFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(257, 6);
            // 
            // computeNumberOfPixelsInPupilToolStripMenuItem
            // 
            this.computeNumberOfPixelsInPupilToolStripMenuItem.Name = "computeNumberOfPixelsInPupilToolStripMenuItem";
            this.computeNumberOfPixelsInPupilToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.computeNumberOfPixelsInPupilToolStripMenuItem.Text = "Compute Number of Pixels in Pupil";
            this.computeNumberOfPixelsInPupilToolStripMenuItem.Click += new System.EventHandler(this.computeNumberOfPixelsInPupilToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.testToolStripMenuItem.Text = "Count the pixels with specific color";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // irisDetectionToolStripMenuItem
            // 
            this.irisDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locatePupilToolStripMenuItem,
            this.computeIrisRadiusToolStripMenuItem,
            this.locateIrisRectangularAreaToolStripMenuItem,
            this.displayIrisRectangularAreaToolStripMenuItem,
            this.filterIrisRectangularAreaToolStripMenuItem,
            this.toolStripSeparator2,
            this.isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem,
            this.isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem,
            this.createIrisArrayToolStripMenuItem,
            this.contrastStrechToolStripMenuItem,
            this.toolStripSeparator3,
            this.locateIrisToolStripMenuItem,
            this.locateIrisInFilesToolStripMenuItem});
            this.irisDetectionToolStripMenuItem.Name = "irisDetectionToolStripMenuItem";
            this.irisDetectionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.irisDetectionToolStripMenuItem.Text = "Iris Detection";
            // 
            // locatePupilToolStripMenuItem
            // 
            this.locatePupilToolStripMenuItem.Name = "locatePupilToolStripMenuItem";
            this.locatePupilToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.locatePupilToolStripMenuItem.Text = "Locate Pupil";
            this.locatePupilToolStripMenuItem.Click += new System.EventHandler(this.locatePupilToolStripMenuItem_Click);
            // 
            // computeIrisRadiusToolStripMenuItem
            // 
            this.computeIrisRadiusToolStripMenuItem.Name = "computeIrisRadiusToolStripMenuItem";
            this.computeIrisRadiusToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.computeIrisRadiusToolStripMenuItem.Text = "Compute Iris Radius";
            this.computeIrisRadiusToolStripMenuItem.Click += new System.EventHandler(this.computeIrisRadiusToolStripMenuItem_Click);
            // 
            // locateIrisRectangularAreaToolStripMenuItem
            // 
            this.locateIrisRectangularAreaToolStripMenuItem.Name = "locateIrisRectangularAreaToolStripMenuItem";
            this.locateIrisRectangularAreaToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.locateIrisRectangularAreaToolStripMenuItem.Text = "Locate Iris Rectangular Area";
            this.locateIrisRectangularAreaToolStripMenuItem.Click += new System.EventHandler(this.locateIrisRectangularAreaToolStripMenuItem_Click);
            // 
            // displayIrisRectangularAreaToolStripMenuItem
            // 
            this.displayIrisRectangularAreaToolStripMenuItem.Name = "displayIrisRectangularAreaToolStripMenuItem";
            this.displayIrisRectangularAreaToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.displayIrisRectangularAreaToolStripMenuItem.Text = "Display Iris Rectangular Area";
            this.displayIrisRectangularAreaToolStripMenuItem.Click += new System.EventHandler(this.displayIrisRectangularAreaToolStripMenuItem_Click);
            // 
            // filterIrisRectangularAreaToolStripMenuItem
            // 
            this.filterIrisRectangularAreaToolStripMenuItem.Name = "filterIrisRectangularAreaToolStripMenuItem";
            this.filterIrisRectangularAreaToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.filterIrisRectangularAreaToolStripMenuItem.Text = "Filter Iris Rectangular Area";
            this.filterIrisRectangularAreaToolStripMenuItem.Click += new System.EventHandler(this.filterIrisRectangularAreaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(345, 6);
            // 
            // isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem
            // 
            this.isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem.Name = "isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem";
            this.isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem.Text = "Isolate Upper Lashes (based on the flag array)";
            this.isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem.Click += new System.EventHandler(this.isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem_Click);
            // 
            // isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem
            // 
            this.isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locateTheCurveToolStripMenuItem,
            this.locateIsolatedIrisPixelsToolStripMenuItem});
            this.isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem.Name = "isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem";
            this.isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem.Text = "Isolate Upper Lashes (based on finding lashes curve)";
            // 
            // locateTheCurveToolStripMenuItem
            // 
            this.locateTheCurveToolStripMenuItem.Name = "locateTheCurveToolStripMenuItem";
            this.locateTheCurveToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.locateTheCurveToolStripMenuItem.Text = "Locate the curve";
            this.locateTheCurveToolStripMenuItem.Click += new System.EventHandler(this.locateTheCurveToolStripMenuItem_Click);
            // 
            // locateIsolatedIrisPixelsToolStripMenuItem
            // 
            this.locateIsolatedIrisPixelsToolStripMenuItem.Name = "locateIsolatedIrisPixelsToolStripMenuItem";
            this.locateIsolatedIrisPixelsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.locateIsolatedIrisPixelsToolStripMenuItem.Text = "Locate isolated iris pixels";
            this.locateIsolatedIrisPixelsToolStripMenuItem.Click += new System.EventHandler(this.locateIsolatedIrisPixelsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(345, 6);
            // 
            // locateIrisToolStripMenuItem
            // 
            this.locateIrisToolStripMenuItem.Name = "locateIrisToolStripMenuItem";
            this.locateIrisToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.locateIrisToolStripMenuItem.Text = "Locate Iris by Steps";
            this.locateIrisToolStripMenuItem.Click += new System.EventHandler(this.locateIrisToolStripMenuItem_Click);
            // 
            // locateIrisInFilesToolStripMenuItem
            // 
            this.locateIrisInFilesToolStripMenuItem.Name = "locateIrisInFilesToolStripMenuItem";
            this.locateIrisInFilesToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.locateIrisInFilesToolStripMenuItem.Text = "Locate iris in files";
            this.locateIrisInFilesToolStripMenuItem.Click += new System.EventHandler(this.locateIrisInFilesToolStripMenuItem_Click);
            // 
            // recognitionToolStripMenuItem
            // 
            this.recognitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detectPupilToolStripMenuItem,
            this.detectIrisToolStripMenuItem,
            this.computerFractalToolStripMenuItem,
            this.computeRunLengthFeaturesToolStripMenuItem});
            this.recognitionToolStripMenuItem.Name = "recognitionToolStripMenuItem";
            this.recognitionToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.recognitionToolStripMenuItem.Text = "Iris Recognition";
            // 
            // detectPupilToolStripMenuItem
            // 
            this.detectPupilToolStripMenuItem.Name = "detectPupilToolStripMenuItem";
            this.detectPupilToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.detectPupilToolStripMenuItem.Text = "Detect Pupil";
            this.detectPupilToolStripMenuItem.Click += new System.EventHandler(this.detectPupilToolStripMenuItem_Click);
            // 
            // detectIrisToolStripMenuItem
            // 
            this.detectIrisToolStripMenuItem.Name = "detectIrisToolStripMenuItem";
            this.detectIrisToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.detectIrisToolStripMenuItem.Text = "Detect Iris";
            this.detectIrisToolStripMenuItem.Click += new System.EventHandler(this.detectIrisToolStripMenuItem_Click);
            // 
            // computerFractalToolStripMenuItem
            // 
            this.computerFractalToolStripMenuItem.Name = "computerFractalToolStripMenuItem";
            this.computerFractalToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.computerFractalToolStripMenuItem.Text = "Compute Fractal Quantization Histogram";
            this.computerFractalToolStripMenuItem.Click += new System.EventHandler(this.computerFractalToolStripMenuItem_Click);
            // 
            // computeRunLengthFeaturesToolStripMenuItem
            // 
            this.computeRunLengthFeaturesToolStripMenuItem.Name = "computeRunLengthFeaturesToolStripMenuItem";
            this.computeRunLengthFeaturesToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.computeRunLengthFeaturesToolStripMenuItem.Text = "Compute Run Length Features";
            this.computeRunLengthFeaturesToolStripMenuItem.Click += new System.EventHandler(this.computeRunLengthFeaturesToolStripMenuItem_Click);
            // 
            // srcPicture
            // 
            this.srcPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcPicture.Location = new System.Drawing.Point(12, 27);
            this.srcPicture.Name = "srcPicture";
            this.srcPicture.Size = new System.Drawing.Size(362, 379);
            this.srcPicture.TabIndex = 1;
            this.srcPicture.TabStop = false;
            // 
            // resPicture
            // 
            this.resPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resPicture.Location = new System.Drawing.Point(390, 27);
            this.resPicture.Name = "resPicture";
            this.resPicture.Size = new System.Drawing.Size(575, 436);
            this.resPicture.TabIndex = 2;
            this.resPicture.TabStop = false;
            // 
            // contrastStrechToolStripMenuItem
            // 
            this.contrastStrechToolStripMenuItem.Name = "contrastStrechToolStripMenuItem";
            this.contrastStrechToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.contrastStrechToolStripMenuItem.Text = "Contrast Streach";
            this.contrastStrechToolStripMenuItem.Click += new System.EventHandler(this.contrastStrechToolStripMenuItem_Click);
            // 
            // createIrisArrayToolStripMenuItem
            // 
            this.createIrisArrayToolStripMenuItem.Name = "createIrisArrayToolStripMenuItem";
            this.createIrisArrayToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.createIrisArrayToolStripMenuItem.Text = "Create Iris Array";
            this.createIrisArrayToolStripMenuItem.Click += new System.EventHandler(this.createIrisArrayToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 475);
            this.Controls.Add(this.resPicture);
            this.Controls.Add(this.srcPicture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Iris Recognition";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox srcPicture;
        private System.Windows.Forms.PictureBox resPicture;
        private System.Windows.Forms.ToolStripMenuItem recognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerFractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pupilDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irisDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateIrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatePupilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detectPupilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectIrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatePupilInFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computeNumberOfPixelsInPupilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computeRunLengthFeaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateIrisInFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertCrossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computeIrisRadiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatePupilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateIrisRectangularAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterIrisRectangularAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIrisRectangularAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isolateUpperLashesbasedOnFindingLashesCurveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateTheCurveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateIsolatedIrisPixelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalBinarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastStrechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIrisArrayToolStripMenuItem;
    }
}

