using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

using System.Windows.Forms;
using iText.Html2pdf;
using Python.Runtime;
using System.Data;
using System.Linq;
using iText.Kernel.Pdf;
using ClosedXML.Excel;


namespace mt940_configuration
{
    public partial class mt_home : Form
    {
        public mt_home()
        {
            InitializeComponent();

        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        

        private static extern IntPtr CreateRoundRectRgn(

           int nLeftRect, //x-coordinate of upper left conner
           int nTopRect,//y-coordinate of upper left conner
           int nRightRect, //x-coordinate of lower right conner
           int nBottomRect,//y-coordinate of lower right conner
           int nWidthEllipse,//width of ellipse
           int nHeightEllipse//height of ellipse
        );
       

        public DataTable ReadCsvFile(string file)
        {
            
            DataTable dt = new DataTable();
            using (StreamReader streamReader = new StreamReader(file))
            {
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadToEnd();
                    string[] rows = text.Split('\n');
                    if (rows.Length > 0)
                    {
                        //Add columns
                        string[] columns = rows[0].Split(',');
                        for (int j = 0; j < columns.Count(); j++)
                            if (dt.Columns.Contains(columns[j]) == false)
                            { dt.Columns.Add(columns[j]); }
                            
                        //Add rows
                        for (int i = 1; i < rows.Count() - 1; i++)
                        {
                            string[] data = rows[i].Split(',');
                            DataRow dr = dt.NewRow();
                            for (int k = 0; k < data.Count(); k++)
                                dr[k] = data[k];
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }

  

        private void populate()
        {
            List<string> options = new List<string> { " ", "PDF", "EXCEL", "CSV" };
            export_as.DataSource = options;
        }


        public void createPdf(string baseUri, string src, string dest)
        {

            ConverterProperties properties = new ConverterProperties();
            properties.SetBaseUri(baseUri);
            PdfWriter writer = new PdfWriter(dest, new WriterProperties().SetFullCompressionMode(true));
            HtmlConverter.ConvertToPdf(new FileStream(src, FileMode.Open), writer, properties);
            writer.Close();
        }



        private void user_changes(DataGridView dg)
        {
            string csv = string.Empty;

            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in dg.Columns)
            {
                csv += column.HeaderText + ',';
            }


            //Adding the Rows
            foreach (DataGridViewRow row in dg.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

             
            }

            File.WriteAllText("mt_with_possible_changes.csv", csv);
        }

        private void save_file(string opt)
        {
            
            SaveFileDialog svd = new SaveFileDialog();
            svd.Title = "Save File:";

            if (svd.ShowDialog() == DialogResult.OK)
            {

                if (opt == "pdf")
                {
                    svd.Filter = "pdf files | *.pdf";

                    using (Py.GIL())
                    {
                        PyScope scope = Py.CreateScope();

                        scope.Exec(File.ReadAllText("changes.py"));


                    }

                    StreamReader h_styles = new StreamReader("header.html");
                    var y = h_styles.ReadToEnd();
                    h_styles.Close();

                    StreamReader hr = new StreamReader("data_frame_in_html.html");
                    string html_table = y + hr.ReadToEnd();

                    hr.Close();

                    StreamWriter wr = new StreamWriter("full_table.html");

                    wr.Write(html_table);
                    wr.Close();


                    using (FileStream stream = new FileStream(svd.FileName + ".pdf", FileMode.Create))
                    {
                        createPdf("mt940_configuration", "full_table.html", svd.FileName);

                        MessageBox.Show("File :" + svd.FileName + " successfully saved!");

                    }
            }

                if (opt == "csv")
                {

                    svd.Filter = "csv files | *.csv";
                    using (FileStream stream = new FileStream(svd.FileName + ".csv", FileMode.Create))
                    {
                        File.WriteAllText(svd.FileName, File.ReadAllText("mt_with_possible_changes.csv"));

                        MessageBox.Show("File :" + svd.FileName + " successfully saved!");
                    }

                }

                if (opt == "xlsx")
                {
                    svd.Filter = "Excel workbook | *.xlsx";
                    using (FileStream stream = new FileStream(svd.FileName + ".xlsx", FileMode.Create))
                    {
                        XLWorkbook wb = new XLWorkbook();

                        wb.Worksheets.Add((DataTable)mt_dataGrid.DataSource, "STATEMENT");
                        wb.SaveAs(svd.FileName + ".xlsx");

                        MessageBox.Show("File :" + svd.FileName + " successfully saved!");
                    }
                    

                    
                    
                }

               
            }


        }
        private void mt_home_Load(object sender, EventArgs e)
        {
            mt_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mt_panel.Width, mt_panel.Height, 40, 40));
          
            //mt_dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mt_dataGrid.Width, mt_dataGrid.Height, 30, 30));
            tablayout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tablayout.Width, tablayout.Height, 40, 40));
            //grid_row_delete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, grid_row_delete.Width, grid_row_delete.Height, 20, 20));
            //recover_del.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, recover_del.Width, recover_del.Height, 20, 20));


            export_as.Enabled = false;
            recover_del.Enabled = false;

            populate();

            
        }


        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mt_upload.Enabled = false;
            export_as.Enabled = true;

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false;

          
            

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {

                string fpath = dialog.FileName; // get name of file

                StreamReader sr = new StreamReader(fpath);
                string data = sr.ReadToEnd();
               
                sr.Close();

                StreamWriter wr = new StreamWriter("mt_940.txt");

                wr.Write(data);
                wr.Close();

                //var pathToVirtualEnv = @"C:\Users\..\mt940_configuration";

                //be sure not to overwrite your existing "path" environmental variable.
                //var path = Environment.GetEnvironmentVariable("path").TrimEnd(';');
                //path = string.IsNullOrEmpty(path) ? pathToVirtualEnv : path + ";" + pathToVirtualEnv;
                //Environment.SetEnvironmentVariable("PATH", path, EnvironmentVariableTarget.Process);
                
                //Environment.SetEnvironmentVariable("PYTHONHOME", pathToVirtualEnv, EnvironmentVariableTarget.Process);
               
                //Environment.SetEnvironmentVariable("PYTHONPATH", $"{pathToVirtualEnv}\\Lib\\site-packages;{pathToVirtualEnv}\\Lib", EnvironmentVariableTarget.Process);

                //PythonEngine.PythonHome = pathToVirtualEnv;
                //PythonEngine.PythonPath = Environment.GetEnvironmentVariable("PYTHONPATH", EnvironmentVariableTarget.Process);


                
                grid_row_delete.Enabled = true;

               
                using (Py.GIL())
                {
                    PyScope scope = Py.CreateScope();

                    scope.Exec(File.ReadAllText("parse_st.py"));


                }
                mt_dataGrid.DataSource = ReadCsvFile("mt_in_csv.csv");


              


            }

        }
        private void mt_upload_Click(object sender, EventArgs e)
        {
            mt_upload.Enabled = false;
            export_as.Enabled = false;
            link.Enabled = false;
            cancel.Enabled = false;
            
        }

        private void cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export_as.Enabled = false;
            mt_upload.Enabled = true;
            link.Enabled = false;
        }

        private void export_as_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            export_as.Enabled = false;
            link.Enabled = true;
            cancel.Enabled = true;
            grid_row_delete.Enabled = false;
            grid_row_delete.Enabled = false;
            recover_del.Enabled = false;
            user_changes(mt_dataGrid);
         
            string Select = export_as.SelectedValue.ToString();

            if (Select != " ")
            {
                if (Select == "PDF")
                {
                    save_file("pdf");
                    grid_row_delete.Enabled = true;

                }

            
                if (Select == "CSV")
                {
                    save_file("csv");
                    grid_row_delete.Enabled = true;

                }

            
                if (Select == "EXCEL")
                {
                    save_file("xlsx");
                    grid_row_delete.Enabled = true;

                }
            }
        }

        private void cancel_request_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export_as.Enabled = false;
            mt_upload.Enabled = true;
            cancel_request.Enabled = false;
            link.Enabled = true;
            cancel.Enabled = true;
        }

        private void mt_dataGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
           
        }

        private void mt_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_row_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in mt_dataGrid.SelectedRows)
            {
                mt_dataGrid.Rows.RemoveAt(row.Index);
            }
            recover_del.Enabled = true;
        }

    
        
        private void recover_del_Click(object sender, EventArgs e)
        {
        

            mt_dataGrid.DataSource = null;
            MessageBox.Show("Operation will cancel any previous edits!");
            mt_dataGrid.DataSource = ReadCsvFile("mt_in_csv.csv");
            

        }
    }
}
