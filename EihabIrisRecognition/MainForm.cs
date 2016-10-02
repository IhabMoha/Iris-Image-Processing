using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EihabIrisLib;

namespace EihabIrisRecognition
{
    public partial class MainForm : Form
    {
        // Iris Recognition (IR) Library
        private IrisLib IR;
        private Graphics resGraph;
        private int max = 7;
        // Image forms
        private ImgForm[] ifs;
        // Images
        private Bitmap[] imgs;

        public MainForm()
        {
            InitializeComponent();
            IR = new IrisLib();
            ifs = new ImgForm[max];
            imgs = new Bitmap[max];

            for (int i = 0; i < max; i++)
                ifs[i] = new ImgForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select the image file";
            fdlg.CheckFileExists = true;
            fdlg.CheckPathExists = true;

            fdlg.Filter = "Image Files (*.bmp; *.jpg; *.gif; *.png)|*.bmp; *.jpg; *.gif; *.png|All Files|*.*";
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                if (IR.initGray(fdlg.FileName) != 0)
                    MessageBox.Show("Error - Can't load file");
                else
                {
                    srcPicture.Image = IR.srcBitmap;
                    resPicture.Image = IR.resBitmap;
                    resGraph = Graphics.FromImage(IR.resBitmap);

                    for (int i = 0; i < max; i++)
                    {
                        if(imgs[i] == null)
                            imgs[i] = new Bitmap(IR.resBitmap);
                        else
                        {
                            imgs[i].Dispose();
                            imgs[i] = new Bitmap(IR.resBitmap);
                        }
                    }
                        
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.save("e:\\img1.bmp");
        }

        private void computerFractalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.computeFDI_v2(1);
            IR.computeQuantizedGray(1);
            IR.computeFGHistogram(1);
        }

        private void locateIrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ifs[0].picBox.Image = imgs[0];
            if (IR.locatePupil(imgs[0], 10, 3) == 0)
            {
                MessageBox.Show("Sorry, cant't find the pupil because the pupil radius is Zero");
                return;
            }

            ifs[0].Text = "Step 0: Locate the pupil";
            ifs[0].Top = 0;
            ifs[0].Left = 0;
            ifs[0].Show();

            IR.copyImage(IR.srcImg, IR.resImg);

            ifs[1].Text = "Step 1: Compute the iris radius";
            ifs[1].Top = 0;
            ifs[1].Left = ifs[0].Width;
            IR.computeIrisRadius(imgs[1], 40, 2, 7);
            ifs[1].picBox.Image = imgs[1];
            ifs[1].Show();

            ifs[2].Text = "Step 2: Locate iris pixels in rectangular area";
            ifs[2].Top = 0;
            ifs[2].Left = ifs[0].Width * 2;
            IR.locateIrisRectPixels(imgs[2], 1.6, 3);
            ifs[2].picBox.Image = imgs[2];
            ifs[2].Show();

            ifs[3].Text = "Step 3: Filter iris rectangular area pixels";
            ifs[3].Top = ifs[0].Height;
            ifs[3].Left = 0;
            IR.filterIrisRectPixels(imgs[3], 4, 3);
            ifs[3].picBox.Image = imgs[3];
            ifs[3].Show();

            ifs[4].Text = "Step 4: Locate the upper lid";
            ifs[4].Top = ifs[4].Height;
            ifs[4].Left = ifs[4].Width;
            //imgs[4] = imgs[3];
            ifs[4].picBox.Image = imgs[4];
            ifs[4].Show();
            IR.locateUpperLashesCurve(imgs[4], ifs[4].picBox, 3);

            ifs[5].Text = "Step 5: Locate iris pixels";
            ifs[5].Top = ifs[0].Height;
            ifs[5].Left = ifs[0].Width * 2;
            ifs[5].picBox.Image = imgs[5];
            ifs[5].Show();
            IR.locateIrisPixels(imgs[5], ifs[5].picBox, 3);

            ifs[6].Text = "Step 6: Contrast Streach iris";
            ifs[6].Top = ifs[0].Height * 2;
            ifs[6].Left = 0;
            IR.createIrisArray();
            IR.contrastStreachIris(0);
            Graphics g = Graphics.FromImage(imgs[6]);
            g.Clear(Color.LightSkyBlue);
            ifs[6].picBox.Image = imgs[6];
            IR.displayIrisArray(imgs[6]);
            ifs[6].Show();
        }

        private void locatePupilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Graphics g;
            for (int co = 0; co < max; co++)
            {
                g = Graphics.FromImage(imgs[co]);
                g.Clear(Color.White);
            }

            IR.locatePupilVerbose(imgs, 10);

            ifs[0].Text = "Step 0: Create histogram";
            ifs[0].Top = 0;
            ifs[0].Left = 0;
            ifs[0].picBox.Image = imgs[0];
            ifs[0].Show();

            ifs[1].Text = "Step 1: Binarization";
            ifs[1].Top = 0;
            ifs[1].Left = ifs[0].Width;
            ifs[1].picBox.Image = imgs[1];
            ifs[1].Show();

            ifs[2].Text = "Step 2: Segmentation to locate pupil segment (Max segment)";
            ifs[2].Top = 0;
            ifs[2].Left = ifs[0].Width * 2;
            ifs[2].picBox.Image = imgs[2];
            ifs[2].Show();
            g = Graphics.FromImage(imgs[2]);
            g.DrawLine(Pens.Red, IR.pupilCenter.x, IR.pupilCenter.y - IR.pupilRadius, IR.pupilCenter.x, IR.pupilCenter.y + IR.pupilRadius);
            g.DrawLine(Pens.Red, IR.pupilCenter.x - IR.pupilRadius, IR.pupilCenter.y, IR.pupilCenter.x + IR.pupilRadius, IR.pupilCenter.y);

            ifs[3].Text = "Step 3: Filling pupil";
            ifs[3].Top = ifs[0].Height;
            ifs[3].Left = 0;
            ifs[3].picBox.Image = imgs[3];
            ifs[3].Show();

            ifs[4].Text = "Step 4: Apply pupil circular fitting";
            ifs[4].Top = ifs[4].Height;
            ifs[4].Left = ifs[4].Width;
            IR.byteToBmp(IR.srcImg, imgs[4]);
            g = Graphics.FromImage(imgs[4]);
            g.DrawEllipse(Pens.Red, IR.pupilCenter.x - IR.pupilRadius, IR.pupilCenter.y - IR.pupilRadius, IR.pupilRadius * 2, IR.pupilRadius * 2);
            ifs[4].picBox.Image = imgs[4];
            ifs[4].Show();
        }

        private void detectPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resPicture.Image = IR.resBitmap;
            IR.locatePupil(IR.resBitmap, 10, 2);
        }

        private void detectIrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.locateIris();
            resPicture.Refresh();
        }

        private void locatePupilInFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.locatePupilInFiles("e:\\Research\\Source\\selected");
            MessageBox.Show("Finish");
        }

        private void computeNumberOfPixelsInPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select the image file";
            fdlg.CheckFileExists = true;
            fdlg.CheckPathExists = true;

            fdlg.Filter = "Image Files (*.bmp; *.jpg; *.gif; *.png)|*.bmp; *.jpg; *.gif; *.png|All Files|*.*";
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                int pixelCo = 0;
                int x1 = 0, y1 = 0;
                double xAvg = 0, yAvg = 0;
                double radius;

                Bitmap tmp = (Bitmap)Bitmap.FromFile(fdlg.FileName);
                resPicture.Image = tmp;
                Color c;
                bool flag = false;

                for(int y=0; y<tmp.Height; y++)
                    for (int x = 0; x < tmp.Width; x++)
                    {
                        c = tmp.GetPixel(x, y);
                        if (c.R == 255 && c.G == 0 && c.B == 0)
                        {
                            ++pixelCo;
                            tmp.SetPixel(x, y, Color.Cyan);
                            xAvg += x;
                            yAvg += y;
                            if (flag == false)
                            {
                                x1 = x;
                                y1 = y;
                                flag = true;
                            }
                        }
                    }
                
                xAvg /= pixelCo;
                yAvg /= pixelCo;

                tmp.SetPixel((int)xAvg, (int)yAvg, Color.Black);
                tmp.SetPixel(x1, y1, Color.Black);
                radius = Math.Sqrt( Math.Pow((x1 - xAvg),2) + Math.Pow((y1 - yAvg),2) );

                MessageBox.Show("Number of Pupil Pixels = " + pixelCo +
                                "\nXc= " + xAvg + " Yc= " + yAvg + " R= " + radius);
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select the image file";
            fdlg.CheckFileExists = true;
            fdlg.CheckPathExists = true;

            fdlg.Filter = "Image Files (*.bmp; *.jpg; *.gif; *.png)|*.bmp; *.jpg; *.gif; *.png|All Files|*.*";
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                int pixelCo = 0;

                Bitmap tmp = (Bitmap)Bitmap.FromFile(fdlg.FileName);
                resPicture.Image = tmp;
                Color c;
                for (int y = 0; y < tmp.Height; y++)
                    for (int x = 0; x < tmp.Width; x++)
                    {
                        c = tmp.GetPixel(x, y);
                        if (c.R == 0 && c.G == 255 && c.B == 0)
                        {
                            ++pixelCo;
                            tmp.SetPixel(x, y, Color.Cyan);
                        }
                    }
                MessageBox.Show("Radius= " + pixelCo);
            }
        }

        private void computeRunLengthFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.computeRunLengthFeatures(1);
        }

        private void locateIrisInFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.locateIrisInFiles("f:\\selected images");
            MessageBox.Show("Finish");
        }

        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.expFilter(IR.srcImg, IR.resImg);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.logFilter(IR.srcImg, IR.resImg);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.createHistogram(IR.resImg);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImgForm tmpFrm = new ImgForm();
            Bitmap tmpBmp = new Bitmap(resPicture.Image);
            tmpFrm.picBox.Image = tmpBmp;
            IR.showHistogram(tmpBmp, 10);
            tmpFrm.Show();
        }

        private void normalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.histogramNormalization(IR.resImg, 0, 255);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.histogramEquilization(IR.resImg, 0, 255);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.medianFilter(IR.srcImg, IR.resImg);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.basicEdgeFilter(IR.srcImg, IR.resImg);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void robertCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.robertsCrossEdgeFilter(IR.srcImg, IR.resImg);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void computeIrisRadiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.computeIrisRadius(IR.resBitmap, 40, 2, 3);
            resPicture.Refresh();
        }

        private void locatePupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.locatePupil(IR.resBitmap, 10, 1);
            resPicture.Refresh();
        }

        private void locateIrisRectangularAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.locateIrisRectPixels(IR.resBitmap, 1.6, 3);
            resPicture.Refresh();
        }

        private void filterIrisRectangularAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.filterIrisRectPixels(IR.resBitmap, 4, 1);
            resPicture.Refresh();
        }

        private void displayIrisRectangularAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.displayIrisArea(IR.resBitmap);
            resPicture.Refresh();
        }

        private void locateTheCurveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.locateUpperLashesCurveEnh(IR.resBitmap, resPicture, 1);
        }

        private void locateIsolatedIrisPixelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.locateIrisPixels(IR.resBitmap, resPicture, 1);
        }

        private void isolateUpperLashesbasedOnTheFlagArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.isolateUpperLashes(IR.resBitmap, resPicture, 1);
        }

        private void globalBinarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.globalBinarization(IR.resImg);
            IR.byteToBmp(IR.resImg, IR.resBitmap);
            resPicture.Refresh();
        }

        private void contrastStrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.contrastStreachIris(1);
            IR.displayIrisArray(IR.resBitmap);
            resPicture.Refresh();
        }

        private void createIrisArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IR.createIrisArray();
        }

     }
}