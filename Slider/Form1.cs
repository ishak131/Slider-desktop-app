using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace Slider
{
    public partial class Form1 : Form
    {
        bool isImage = false;
        string[] files;
        int imageIndex = 0;
        string mode = "single";
        List<string> pictuersContainer = new List<string>();
        System.Windows.Forms.Timer SlideTimer = new System.Windows.Forms.Timer();
       
        OpenFileDialog opnfd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            SlideTimer.Interval = 1500;
            SlideTimer.Tick += SlideTimer_Tick;
        }


        private bool handleAddAndDeleteImageToContainer(string imagePath)
        {
            int indexOfImage = pictuersContainer.IndexOf(imagePath);
            if (indexOfImage  == -1) { 
                pictuersContainer.Add(imagePath);
                return true;
            }
            else
            {
                pictuersContainer.RemoveAt(indexOfImage);
                return false;
            }

        }

        
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //////////////  handlImageSizeAndStyle start /////////////
        #region
        private TreeView HandlImageSizeAndStyle(int maxViewWidth,int maxViewHeight ,string imagePath , int x = 0, int y = 0)
        {

                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(imagePath);
                int Height = pic.Image.Height;
                int Width = pic.Image.Width;
                int maxWidth;
                int maxHeight;
            TreeView view = new TreeView
            {
                Size = new Size(maxViewWidth, maxViewHeight),
                Location = new Point(x, y)
            };
            if (Height > Width)
                {
                    maxHeight = maxViewHeight;
                    maxWidth = (Width * maxViewHeight) / Height;
                }
                else
                {
                    maxWidth = maxViewWidth;
                    maxHeight = (maxViewWidth * Height) / Width;
                }
                pic.Size = new Size(maxWidth, maxHeight);
                int imageX = (maxViewWidth - maxWidth) / 2,
                       imageY = (maxViewHeight - maxHeight) / 2;
                pic.Location = new Point(imageX, imageY);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                view.Controls.Add(pic);
                return view;
           
        }
        #endregion
        //////////////  handlImageSizeAndStyle start /////////////
        
        
        //////////////  handleShowMode /////////////
        #region
        private void HandleShowMode()

        {
            
            if (mode == "single" )
            {
                sideNavBarAsTextListBox.SelectionMode = SelectionMode.One;
                SlideTimer.Enabled = false;
                imageModesContainerPanel.Controls.Clear();
                string singleImagePath =  sideNavBarAsTextListBox.GetItemText(sideNavBarAsTextListBox.SelectedItem);
                try
                {
                    TreeView View = HandlImageSizeAndStyle(850, 480, singleImagePath);
                    imageModesContainerPanel.Controls.Add(View);
                }
                catch
                {
                    MessageBox.Show("please upload the images and select one first");
                }
                
            }
            else if (mode == "multi")
            {
                sideNavBarAsTextListBox.SelectionMode = SelectionMode.MultiSimple;
                SlideTimer.Enabled = false;
                int y = 17;
                int x = 0;
                int margin = 18;
                imageModesContainerPanel.Controls.Clear();
                foreach (var selectedItem in sideNavBarAsTextListBox.SelectedItems)
                {
                    string oneFile = sideNavBarAsTextListBox.GetItemText(selectedItem);
                    TreeView View = HandlImageSizeAndStyle(200, 113, oneFile , x, y);
                    if ((sideNavBarAsTextListBox.SelectedItems.IndexOf(selectedItem) + 1) % 4 == 0)
                    {
                        x = 0;
                        y += 113 + margin;
                    }
                    else
                    {
                        x += 200 + margin;
                    }
                    imageModesContainerPanel.Controls.Add(View);
                }
            }
            else if (mode == "slideShow")
            {
                sideNavBarAsTextListBox.SelectionMode = SelectionMode.MultiSimple;
                SlideTimer.Enabled = true;
               
            }
            else
            {
                mode = "single";
            }
           
        }
        #endregion
        /////////////// end of handleShowMode ///////////
        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            int length = sideNavBarAsTextListBox.SelectedItems.Count;
            if(length == 0)
            {
                return;
            }
            if (imageIndex >= length)
            {
                mode = "single";
                return;
            }
            if (length > 0)
            {
                string singleImagePath = sideNavBarAsTextListBox.GetItemText(sideNavBarAsTextListBox.SelectedItems[imageIndex]);
                imageName.Text = singleImagePath;
                int width = imageName.Size.Width;
                int xAxis = 465 - width / 2 + 220;
                imageName.Location = new Point(xAxis, 50);
                imageIndex++;
                imageModesContainerPanel.Controls.Clear();
                TreeView View = HandlImageSizeAndStyle(850, 480, singleImagePath);
                imageModesContainerPanel.Controls.Add(View);
            }
        }

        private void HandleShowImagesBarState()
        {
             files = opnfd.FileNames;

            if (isImage)
            {
                int y = 0;
                sideNavBarAsImagesPanel.Controls.Clear();
                foreach (string oneFile in files)
                {
                    TreeView View = HandlImageSizeAndStyle(200, 113, oneFile ,0, y);
                    
                        y += 113;
                        sideNavBarAsImagesPanel.Controls.Add(View);
                    
                  }
            }
            else
            {
                sideNavBarAsTextListBox.Items.Clear();
                foreach (string oneFile in files)
                {
                    sideNavBarAsTextListBox.Items.Add(oneFile);
                }

            }
        }


       private void HandleViewSize()
        {

            if (isImage)
            {
                /// sideNavBarAsImagesPanel
                sideNavBarAsImagesPanel.Location = new Point(0, 0);
                sideNavBarAsImagesPanel.Size = new Size(220, 655);

                /// sideNavBarAsTextListBox
                sideNavBarAsTextListBox.Location = new Point(1300, 0);
                sideNavBarAsTextListBox.Size = new Size(0, 0);
                sideNavBarAsTextListBox.Items.Clear();
            }
            else
            {
                /// sideNavBarAsImagesPanel
                sideNavBarAsImagesPanel.Location = new Point(1300, 0);
                sideNavBarAsImagesPanel.Size = new Size(0, 0);
                sideNavBarAsImagesPanel.Controls.Clear();

                /// sideNavBarAsTextListBox
                sideNavBarAsTextListBox.Location = new Point(0, 0);
                sideNavBarAsTextListBox.Size = new Size(220, 660);
            }

        }

        /// Uploading images to the program in array of strings
        private void uploadImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictuersContainer.Clear();
            opnfd.Multiselect = true;
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                HandleShowImagesBarState();
            }
        }

        private void showSideNavBarAsImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isImage = !isImage;
            sideNavBarAsImagesPanel.Visible = isImage;
            sideNavBarAsTextListBox.Visible = !isImage;
            HandleShowImagesBarState();
            HandleViewSize();
        }

        private void minmizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sideNavBarAsTextListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlideTimer.Enabled = false;
            if (sideNavBarAsTextListBox.SelectedItems.Count > 0)
                Console.WriteLine(sideNavBarAsTextListBox.SelectedItems[0]);
            string text = sideNavBarAsTextListBox.GetItemText(sideNavBarAsTextListBox.SelectedItem);
            imageName.Text = text;
            int width = imageName.Size.Width;
            int xAxis = 465 - width / 2 + 220;  
            imageName.Location = new Point(xAxis, 50);
            if ( mode == "multi" || mode == "slideShow") {
                handleAddAndDeleteImageToContainer(text);
            }
            else
            { 
                HandleShowMode();
            }
        }

       

       

        private void multiPicturesModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            mode = "multi";
            HandleShowMode();
        }

        private void onePictureModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            mode = "single";
            HandleShowMode();
        }

        private void slideShowModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            mode = "slideShow";
            imageIndex = 0;
            HandleShowMode();
        }

        private void sideNavBarAsTextListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
           
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.White);//Choose the color
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(sideNavBarAsTextListBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}
