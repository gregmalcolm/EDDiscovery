﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace EDDiscovery2
{
        partial class FormMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMap));
            this.glControl1 = new OpenTK.GLControl();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripShowAllStars = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLastKnownPosition = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDrawLines = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowAllStars = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStations = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGrid = new System.Windows.Forms.ToolStripButton();
            this.buttonSetDefault = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSystem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripShowAllStars.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 33);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(918, 496);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.OnMouseWheel);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // textBox_From
            // 
            this.textBox_From.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_From.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_From.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_From.Location = new System.Drawing.Point(365, 7);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(125, 20);
            this.textBox_From.TabIndex = 16;
            this.textBox_From.Text = "Sol";
            // 
            // buttonCenter
            // 
            this.buttonCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCenter.Location = new System.Drawing.Point(496, 5);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(75, 23);
            this.buttonCenter.TabIndex = 17;
            this.buttonCenter.Text = "Center";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // toolStripShowAllStars
            // 
            this.toolStripShowAllStars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLastKnownPosition,
            this.toolStripButtonDrawLines,
            this.toolStripButtonShowAllStars,
            this.toolStripButtonStations,
            this.toolStripButtonGrid});
            this.toolStripShowAllStars.Location = new System.Drawing.Point(0, 0);
            this.toolStripShowAllStars.Name = "toolStripShowAllStars";
            this.toolStripShowAllStars.Size = new System.Drawing.Size(918, 31);
            this.toolStripShowAllStars.TabIndex = 19;
            this.toolStripShowAllStars.Text = "toolStrip1";
            // 
            // toolStripButtonLastKnownPosition
            // 
            this.toolStripButtonLastKnownPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLastKnownPosition.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLastKnownPosition.Image")));
            this.toolStripButtonLastKnownPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLastKnownPosition.Name = "toolStripButtonLastKnownPosition";
            this.toolStripButtonLastKnownPosition.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonLastKnownPosition.Text = "Last known position";
            this.toolStripButtonLastKnownPosition.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonDrawLines
            // 
            this.toolStripButtonDrawLines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawLines.BackgroundImage")));
            this.toolStripButtonDrawLines.CheckOnClick = true;
            this.toolStripButtonDrawLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDrawLines.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDrawLines.Image")));
            this.toolStripButtonDrawLines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrawLines.Name = "toolStripButtonDrawLines";
            this.toolStripButtonDrawLines.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonDrawLines.Text = "Draw lines";
            this.toolStripButtonDrawLines.Click += new System.EventHandler(this.toolStripButtonDrawLines_Click);
            // 
            // toolStripButtonShowAllStars
            // 
            this.toolStripButtonShowAllStars.Checked = true;
            this.toolStripButtonShowAllStars.CheckOnClick = true;
            this.toolStripButtonShowAllStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowAllStars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowAllStars.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowAllStars.Image")));
            this.toolStripButtonShowAllStars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowAllStars.Name = "toolStripButtonShowAllStars";
            this.toolStripButtonShowAllStars.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonShowAllStars.Text = "Show all stars";
            this.toolStripButtonShowAllStars.Click += new System.EventHandler(this.toolStripButtonShowAllStars_Click);
            // 
            // toolStripButtonStations
            // 
            this.toolStripButtonStations.Checked = true;
            this.toolStripButtonStations.CheckOnClick = true;
            this.toolStripButtonStations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonStations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStations.Image")));
            this.toolStripButtonStations.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStations.Name = "toolStripButtonStations";
            this.toolStripButtonStations.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonStations.Text = "Stations";
            this.toolStripButtonStations.Click += new System.EventHandler(this.toolStripButtonStations_Click);
            // 
            // toolStripButtonGrid
            // 
            this.toolStripButtonGrid.CheckOnClick = true;
            this.toolStripButtonGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGrid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGrid.Image")));
            this.toolStripButtonGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGrid.Name = "toolStripButtonGrid";
            this.toolStripButtonGrid.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonGrid.Text = "Grid";
            this.toolStripButtonGrid.ToolTipText = "Show Grid";
            this.toolStripButtonGrid.Click += new System.EventHandler(this.toolStripButtonGrud_Click);
            // 
            // buttonSetDefault
            // 
            this.buttonSetDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetDefault.Location = new System.Drawing.Point(577, 5);
            this.buttonSetDefault.Name = "buttonSetDefault";
            this.buttonSetDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonSetDefault.TabIndex = 20;
            this.buttonSetDefault.Text = "Set Default";
            this.buttonSetDefault.UseCompatibleTextRendering = true;
            this.buttonSetDefault.UseVisualStyleBackColor = true;
            this.buttonSetDefault.Click += new System.EventHandler(this.buttonSetDefault_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSystem,
            this.toolStripStatusLabelCoordinates,
            this.toolStripStatusLabelZoom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSystem
            // 
            this.toolStripStatusLabelSystem.Name = "toolStripStatusLabelSystem";
            this.toolStripStatusLabelSystem.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelSystem.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelCoordinates
            // 
            this.toolStripStatusLabelCoordinates.Name = "toolStripStatusLabelCoordinates";
            this.toolStripStatusLabelCoordinates.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelCoordinates.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabelZoom
            // 
            this.toolStripStatusLabelZoom.Name = "toolStripStatusLabelZoom";
            this.toolStripStatusLabelZoom.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelZoom.Text = "toolStripStatusLabel1";
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSetDefault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.textBox_From);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.toolStripShowAllStars);
            this.Name = "FormMap";
            this.Text = "3D Star Map";
            this.Load += new System.EventHandler(this.FormMap_Load);
            this.toolStripShowAllStars.ResumeLayout(false);
            this.toolStripShowAllStars.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }


            #endregion

            private OpenTK.GLControl glControl1;
            internal TextBox textBox_From;
            private Button buttonCenter;
            private Label label1;
        private ToolStrip toolStripShowAllStars;
        private ToolStripButton toolStripButtonLastKnownPosition;
        private ToolStripButton toolStripButtonDrawLines;
        private Button buttonSetDefault;
        private ToolStripButton toolStripButtonShowAllStars;
        private ToolStripButton toolStripButtonStations;
        private ToolStripButton toolStripButtonGrid;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelSystem;
        private ToolStripStatusLabel toolStripStatusLabelCoordinates;
        private ToolStripStatusLabel toolStripStatusLabelZoom;
    }
    }