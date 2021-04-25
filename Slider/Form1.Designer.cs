
using System.Drawing;
using System.Windows.Forms;

namespace Slider
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onePictureModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPicturesModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSideNavBarAsImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minmizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideNavBarAsImagesPanel = new System.Windows.Forms.Panel();
            this.sideNavBarAsTextListBox = new System.Windows.Forms.ListBox();
            this.imageModesContainerPanel = new System.Windows.Forms.Panel();
            this.imageName = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadImagesToolStripMenuItem,
            this.modesToolStripMenuItem,
            this.showSideNavBarAsImagesToolStripMenuItem,
            this.minmizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 124);
            // 
            // uploadImagesToolStripMenuItem
            // 
            this.uploadImagesToolStripMenuItem.Name = "uploadImagesToolStripMenuItem";
            this.uploadImagesToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.uploadImagesToolStripMenuItem.Text = "Upload images";
            this.uploadImagesToolStripMenuItem.Click += new System.EventHandler(this.uploadImagesToolStripMenuItem_Click);
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onePictureModeToolStripMenuItem,
            this.slideShowModeToolStripMenuItem,
            this.multiPicturesModeToolStripMenuItem});
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // onePictureModeToolStripMenuItem
            // 
            this.onePictureModeToolStripMenuItem.Name = "onePictureModeToolStripMenuItem";
            this.onePictureModeToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.onePictureModeToolStripMenuItem.Text = "One picture mode";
            this.onePictureModeToolStripMenuItem.Click += new System.EventHandler(this.onePictureModeToolStripMenuItem_Click);
            // 
            // slideShowModeToolStripMenuItem
            // 
            this.slideShowModeToolStripMenuItem.Name = "slideShowModeToolStripMenuItem";
            this.slideShowModeToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.slideShowModeToolStripMenuItem.Text = "Slide show mode";
            this.slideShowModeToolStripMenuItem.Click += new System.EventHandler(this.slideShowModeToolStripMenuItem_Click);
            // 
            // multiPicturesModeToolStripMenuItem
            // 
            this.multiPicturesModeToolStripMenuItem.Name = "multiPicturesModeToolStripMenuItem";
            this.multiPicturesModeToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.multiPicturesModeToolStripMenuItem.Text = "Multi pictures mode";
            this.multiPicturesModeToolStripMenuItem.Click += new System.EventHandler(this.multiPicturesModeToolStripMenuItem_Click);
            // 
            // showSideNavBarAsImagesToolStripMenuItem
            // 
            this.showSideNavBarAsImagesToolStripMenuItem.CheckOnClick = true;
            this.showSideNavBarAsImagesToolStripMenuItem.Name = "showSideNavBarAsImagesToolStripMenuItem";
            this.showSideNavBarAsImagesToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.showSideNavBarAsImagesToolStripMenuItem.Text = "side nav bar as images";
            this.showSideNavBarAsImagesToolStripMenuItem.Click += new System.EventHandler(this.showSideNavBarAsImagesToolStripMenuItem_Click);
            // 
            // minmizeToolStripMenuItem
            // 
            this.minmizeToolStripMenuItem.Name = "minmizeToolStripMenuItem";
            this.minmizeToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.minmizeToolStripMenuItem.Text = "Minimize";
            this.minmizeToolStripMenuItem.Click += new System.EventHandler(this.minmizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // sideNavBarAsImagesPanel
            // 
            this.sideNavBarAsImagesPanel.AutoScroll = true;
            this.sideNavBarAsImagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.sideNavBarAsImagesPanel.Location = new System.Drawing.Point(1300, 0);
            this.sideNavBarAsImagesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideNavBarAsImagesPanel.Name = "sideNavBarAsImagesPanel";
            this.sideNavBarAsImagesPanel.Size = new System.Drawing.Size(0, 0);
            this.sideNavBarAsImagesPanel.TabIndex = 5;
            this.sideNavBarAsImagesPanel.Visible = false;
            // 
            // sideNavBarAsTextListBox
            // 
            this.sideNavBarAsTextListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.sideNavBarAsTextListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sideNavBarAsTextListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sideNavBarAsTextListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideNavBarAsTextListBox.FormattingEnabled = true;
            this.sideNavBarAsTextListBox.HorizontalScrollbar = true;
            this.sideNavBarAsTextListBox.ItemHeight = 16;
            this.sideNavBarAsTextListBox.Location = new System.Drawing.Point(0, 0);
            this.sideNavBarAsTextListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideNavBarAsTextListBox.Name = "sideNavBarAsTextListBox";
            this.sideNavBarAsTextListBox.Size = new System.Drawing.Size(300, 820);
            this.sideNavBarAsTextListBox.TabIndex = 5;
            this.sideNavBarAsTextListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.sideNavBarAsTextListBox_DrawItem);
            this.sideNavBarAsTextListBox.SelectedIndexChanged += new System.EventHandler(this.sideNavBarAsTextListBox_SelectedIndexChanged);
            // 
            // imageModesContainerPanel
            // 
            this.imageModesContainerPanel.AutoScroll = true;
            this.imageModesContainerPanel.Location = new System.Drawing.Point(360, 100);
            this.imageModesContainerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageModesContainerPanel.Name = "imageModesContainerPanel";
            this.imageModesContainerPanel.Size = new System.Drawing.Size(1243, 594);
            this.imageModesContainerPanel.TabIndex = 7;
            // 
            // imageName
            // 
            this.imageName.AutoSize = true;
            this.imageName.Location = new System.Drawing.Point(885, 34);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(0, 17);
            this.imageName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1549, 805);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.imageModesContainerPanel);
            this.Controls.Add(this.sideNavBarAsTextListBox);
            this.Controls.Add(this.sideNavBarAsImagesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1549, 805);
            this.MinimumSize = new System.Drawing.Size(1533, 805);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem uploadImagesToolStripMenuItem;
        private ToolStripMenuItem modesToolStripMenuItem;
        private ToolStripMenuItem onePictureModeToolStripMenuItem;
        private ToolStripMenuItem slideShowModeToolStripMenuItem;
        private ToolStripMenuItem multiPicturesModeToolStripMenuItem;
        private ToolStripMenuItem showSideNavBarAsImagesToolStripMenuItem;
        private Panel sideNavBarAsImagesPanel;
        private ListBox sideNavBarAsTextListBox;
        private ToolStripMenuItem minmizeToolStripMenuItem;
        private Panel imageModesContainerPanel;
        private Label imageName;
    }
}

