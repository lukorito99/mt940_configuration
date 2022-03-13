
namespace mt940_configuration
{
    partial class mt_home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mt_image = new System.Windows.Forms.TableLayoutPanel();
            this.mt_upload = new System.Windows.Forms.Button();
            this.drop_box = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.LinkLabel();
            this.or = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.LinkLabel();
            this.export_as = new System.Windows.Forms.ComboBox();
            this.labelexp = new System.Windows.Forms.Label();
            this.cancel_request = new System.Windows.Forms.LinkLabel();
            this.mt_panel = new System.Windows.Forms.Panel();
            this.grid_row_delete = new System.Windows.Forms.Button();
            this.review = new System.Windows.Forms.TextBox();
            this.mt_dataGrid = new System.Windows.Forms.DataGridView();
            this.tablayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recover_del = new System.Windows.Forms.Button();
            this.mt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mt_dataGrid)).BeginInit();
            this.tablayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mt_image
            // 
            this.mt_image.BackgroundImage = global::mt940_configuration.Properties.Resources.image;
            this.mt_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mt_image.ColumnCount = 1;
            this.mt_image.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mt_image.Location = new System.Drawing.Point(-2, -11);
            this.mt_image.Name = "mt_image";
            this.mt_image.RowCount = 1;
            this.mt_image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mt_image.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.mt_image.Size = new System.Drawing.Size(227, 166);
            this.mt_image.TabIndex = 0;
            // 
            // mt_upload
            // 
            this.mt_upload.BackColor = System.Drawing.Color.Transparent;
            this.mt_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mt_upload.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_upload.ForeColor = System.Drawing.Color.Maroon;
            this.mt_upload.Location = new System.Drawing.Point(11, 235);
            this.mt_upload.Name = "mt_upload";
            this.mt_upload.Size = new System.Drawing.Size(198, 43);
            this.mt_upload.TabIndex = 1;
            this.mt_upload.Text = "REQUEST";
            this.mt_upload.UseVisualStyleBackColor = false;
            this.mt_upload.Click += new System.EventHandler(this.mt_upload_Click);
            // 
            // drop_box
            // 
            this.drop_box.AllowDrop = true;
            this.drop_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drop_box.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_box.Location = new System.Drawing.Point(11, 319);
            this.drop_box.Name = "drop_box";
            this.drop_box.Size = new System.Drawing.Size(198, 29);
            this.drop_box.TabIndex = 4;
            this.drop_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // link
            // 
            this.link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.White;
            this.link.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.Location = new System.Drawing.Point(159, 327);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(35, 14);
            this.link.TabIndex = 5;
            this.link.TabStop = true;
            this.link.Text = "open";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // or
            // 
            this.or.BackColor = System.Drawing.Color.Gainsboro;
            this.or.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.or.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or.ForeColor = System.Drawing.Color.Green;
            this.or.Location = new System.Drawing.Point(80, 284);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(63, 29);
            this.or.TabIndex = 6;
            this.or.Text = "OR";
            this.or.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancel
            // 
            this.cancel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.AutoSize = true;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(152, 359);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(49, 14);
            this.cancel.TabIndex = 7;
            this.cancel.TabStop = true;
            this.cancel.Text = "cancel";
            this.cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancel_LinkClicked);
            // 
            // export_as
            // 
            this.export_as.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.export_as.BackColor = System.Drawing.Color.White;
            this.export_as.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.export_as.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_as.ForeColor = System.Drawing.Color.Green;
            this.export_as.FormattingEnabled = true;
            this.export_as.Location = new System.Drawing.Point(8, 421);
            this.export_as.Name = "export_as";
            this.export_as.Size = new System.Drawing.Size(201, 45);
            this.export_as.TabIndex = 18;
            this.export_as.SelectedIndexChanged += new System.EventHandler(this.export_as_SelectedIndexChanged);
            // 
            // labelexp
            // 
            this.labelexp.AutoSize = true;
            this.labelexp.BackColor = System.Drawing.Color.Transparent;
            this.labelexp.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexp.ForeColor = System.Drawing.Color.Green;
            this.labelexp.Location = new System.Drawing.Point(54, 388);
            this.labelexp.Name = "labelexp";
            this.labelexp.Size = new System.Drawing.Size(111, 33);
            this.labelexp.TabIndex = 21;
            this.labelexp.Text = "Export As";
            // 
            // cancel_request
            // 
            this.cancel_request.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cancel_request.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_request.AutoSize = true;
            this.cancel_request.BackColor = System.Drawing.Color.Transparent;
            this.cancel_request.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_request.Location = new System.Drawing.Point(152, 285);
            this.cancel_request.Name = "cancel_request";
            this.cancel_request.Size = new System.Drawing.Size(49, 14);
            this.cancel_request.TabIndex = 22;
            this.cancel_request.TabStop = true;
            this.cancel_request.Text = "cancel";
            this.cancel_request.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancel_request_LinkClicked);
            // 
            // mt_panel
            // 
            this.mt_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.mt_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mt_panel.Controls.Add(this.cancel_request);
            this.mt_panel.Controls.Add(this.labelexp);
            this.mt_panel.Controls.Add(this.export_as);
            this.mt_panel.Controls.Add(this.cancel);
            this.mt_panel.Controls.Add(this.or);
            this.mt_panel.Controls.Add(this.link);
            this.mt_panel.Controls.Add(this.drop_box);
            this.mt_panel.Controls.Add(this.mt_upload);
            this.mt_panel.Controls.Add(this.mt_image);
            this.mt_panel.Location = new System.Drawing.Point(61, 39);
            this.mt_panel.Name = "mt_panel";
            this.mt_panel.Size = new System.Drawing.Size(217, 596);
            this.mt_panel.TabIndex = 0;
            // 
            // grid_row_delete
            // 
            this.grid_row_delete.BackColor = System.Drawing.Color.Transparent;
            this.grid_row_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grid_row_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grid_row_delete.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_row_delete.ForeColor = System.Drawing.Color.Maroon;
            this.grid_row_delete.Location = new System.Drawing.Point(256, 5);
            this.grid_row_delete.Name = "grid_row_delete";
            this.grid_row_delete.Size = new System.Drawing.Size(206, 49);
            this.grid_row_delete.TabIndex = 6;
            this.grid_row_delete.Text = "Delete Selected ";
            this.grid_row_delete.UseVisualStyleBackColor = false;
            this.grid_row_delete.Click += new System.EventHandler(this.grid_row_delete_Click);
            // 
            // review
            // 
            this.review.AllowDrop = true;
            this.review.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.review.BackColor = System.Drawing.Color.WhiteSmoke;
            this.review.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.review.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.ForeColor = System.Drawing.Color.Green;
            this.review.Location = new System.Drawing.Point(316, 494);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(355, 29);
            this.review.TabIndex = 5;
            this.review.Text = "A Review of The Statement,Edit As Desired";
            this.review.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mt_dataGrid
            // 
            this.mt_dataGrid.AllowUserToAddRows = false;
            this.mt_dataGrid.AllowUserToOrderColumns = true;
            this.mt_dataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mt_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mt_dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mt_dataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mt_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mt_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mt_dataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.mt_dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.mt_dataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mt_dataGrid.Location = new System.Drawing.Point(34, 20);
            this.mt_dataGrid.Name = "mt_dataGrid";
            this.mt_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mt_dataGrid.Size = new System.Drawing.Size(920, 450);
            this.mt_dataGrid.TabIndex = 0;
            this.mt_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGrid_CellContentClick);
            this.mt_dataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.mt_dataGrid_UserDeletingRow);
            // 
            // tablayout
            // 
            this.tablayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tablayout.ColumnCount = 1;
            this.tablayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablayout.Controls.Add(this.review, 0, 1);
            this.tablayout.Controls.Add(this.panel1, 0, 2);
            this.tablayout.Controls.Add(this.mt_dataGrid, 0, 0);
            this.tablayout.Location = new System.Drawing.Point(304, 39);
            this.tablayout.Name = "tablayout";
            this.tablayout.RowCount = 3;
            this.tablayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tablayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tablayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablayout.Size = new System.Drawing.Size(988, 596);
            this.tablayout.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recover_del);
            this.panel1.Controls.Add(this.grid_row_delete);
            this.panel1.Location = new System.Drawing.Point(3, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 65);
            this.panel1.TabIndex = 6;
            // 
            // recover_del
            // 
            this.recover_del.BackColor = System.Drawing.Color.Transparent;
            this.recover_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recover_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recover_del.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recover_del.ForeColor = System.Drawing.Color.Green;
            this.recover_del.Location = new System.Drawing.Point(488, 5);
            this.recover_del.Name = "recover_del";
            this.recover_del.Size = new System.Drawing.Size(206, 49);
            this.recover_del.TabIndex = 8;
            this.recover_del.Text = "Recover Deleted";
            this.recover_del.UseVisualStyleBackColor = false;
            this.recover_del.Click += new System.EventHandler(this.recover_del_Click);
            // 
            // mt_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.mt_panel);
            this.Controls.Add(this.tablayout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "mt_home";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MT 940";
            this.Load += new System.EventHandler(this.mt_home_Load);
            this.mt_panel.ResumeLayout(false);
            this.mt_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mt_dataGrid)).EndInit();
            this.tablayout.ResumeLayout(false);
            this.tablayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel mt_image;
        private System.Windows.Forms.Button mt_upload;
        private System.Windows.Forms.TextBox drop_box;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.TextBox or;
        private System.Windows.Forms.LinkLabel cancel;
        private System.Windows.Forms.ComboBox export_as;
        private System.Windows.Forms.Label labelexp;
        private System.Windows.Forms.LinkLabel cancel_request;
        private System.Windows.Forms.Panel mt_panel;
        private System.Windows.Forms.Button grid_row_delete;
        private System.Windows.Forms.TextBox review;
        private System.Windows.Forms.DataGridView mt_dataGrid;
        private System.Windows.Forms.TableLayoutPanel tablayout;
        private System.Windows.Forms.Button recover_del;
        private System.Windows.Forms.Panel panel1;
    }
}

