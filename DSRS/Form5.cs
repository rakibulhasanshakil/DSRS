using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DSRS
{
    public partial class Form5 : Form
    {
        private string userName, fromLocation, toLocation, journeyDate, trainName;
        public Form5()
        {
            InitializeComponent();
        }


        private string scheduleID, customerID, seatType;
        private int NumberOfSeats;
        private double totalPrice;
        public Form5(string scheduleID, string customerID, string seatType, int NumberOfSeats, double totalPrice) : this()
        {
            this.scheduleID = scheduleID;
            this.customerID = customerID;
            this.seatType = seatType;
            this.NumberOfSeats = NumberOfSeats;
            this.totalPrice = totalPrice;

            ticket_price_lvl.Text = $"Total Price: {totalPrice}";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4(this.customerID);  
            form4.Show();
        }

        private void ticket_price_lvl_Click(object sender, EventArgs e)
        {

        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            string error;
            string query = $@"INSERT INTO [Ticket Purchase] ([Schedule ID], [User ID], [Seat Type], [Number Of Seats], [Total Price])
                             VALUES ('{this.scheduleID}', '{this.customerID}', '{this.seatType}', {this.NumberOfSeats}, {this.totalPrice})";

            DataBase.ExecuteNonQuery(query, out error);
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Form5 Function: pay_btn_Click (1)\nError: {error}");
                return;
            }

            if (seatType == "Sitting")
                query = $@"UPDATE [dbo].[Train Schedule]
                        SET [Sitting Seat] = [Sitting Seat] - {this.NumberOfSeats}
                        WHERE [ID] = {this.scheduleID} AND [Sitting Seat] > 0";

            else
                query = $@"UPDATE [dbo].[Train Schedule]
                        SET [Standing Seat] = [Standing Seat] - {this.NumberOfSeats}
                        WHERE [ID] = {this.scheduleID} AND [Standing Seat] > 0";


            DataBase.ExecuteNonQuery(query, out error);
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Form5 Function: pay_btn_Click (2)\nError: {error}");
                return;
            }


            print(sender, e);
           

        }

        private void print(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
    "Do you want to print or save the ticket?",
    "Ticket Options",
    MessageBoxButtons.YesNoCancel,
    MessageBoxIcon.Question);

            // Handle the dialog result
            if (dialogResult == DialogResult.Yes)
            {
                // User clicked "Print"
                printButton_Click(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                // User clicked "Save"
                SaveAsPdf();
            }
            else if (dialogResult == DialogResult.Cancel)
            {

               
            }

            this.Hide();
            Form4 form4 = new Form4(this.customerID);
            form4.Show();
        }


        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
            
        }

        private void PrintDataCollection()
        {
            string error;
            string query = $@"SELECT 
                                u.[Name] AS [User Name], 
                                ts.[From] AS [From], 
                                ts.[To] AS [To], 
                                ts.[Train Name] AS [Train Name],
                                ts.[Date] AS [Date]
                            FROM 
                                [dbo].[User Information] u
                            INNER JOIN 
                                [dbo].[Train Schedule] ts
                            ON 
                                u.[Id] = {this.customerID}
                            WHERE 
                                ts.[ID] = {this.scheduleID}";

            DataSet dataSet = DataBase.DataAccess(query,out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Form5 Function: PrintDataCollection \nerror: {error}");
                return;
            }

            userName = dataSet.Tables[0].Rows[0]["User Name"].ToString();
            fromLocation = dataSet.Tables[0].Rows[0]["From"].ToString(); 
            toLocation = dataSet.Tables[0].Rows[0]["To"].ToString(); 
            journeyDate = dataSet.Tables[0].Rows[0]["Date"].ToString(); 
            trainName = dataSet.Tables[0].Rows[0]["Train Name"].ToString();

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDataCollection();
            // Set up font and brush for text
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            System.Drawing.Font normalFont = new System.Drawing.Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Draw watermark
            string watermarkText = "DSRS";
            System.Drawing.Font watermarkFont = new    System.Drawing.Font("Arial", 60, FontStyle.Bold | FontStyle.Italic);
            SizeF watermarkSize = e.Graphics.MeasureString(watermarkText, watermarkFont);
            float watermarkX = 300;
            float watermarkY = 120;

            // Draw watermark with light gray color and semi-transparent
            Color watermarkColor = Color.FromArgb(50, 200, 200, 200); // Semi-transparent
            using (SolidBrush watermarkBrush = new SolidBrush(watermarkColor))
                e.Graphics.DrawString(watermarkText, watermarkFont, watermarkBrush, new PointF(watermarkX, watermarkY));
            
            // Print ticket details below the watermark
            e.Graphics.DrawString("Ticket Information", titleFont, brush, new PointF(300, 50));
            e.Graphics.DrawString($"Owner Name: {userName}", normalFont, brush, new PointF(100, 100));
            e.Graphics.DrawString($"From: {fromLocation}", normalFont, brush, new PointF(100, 130));
            e.Graphics.DrawString($"To: {toLocation}", normalFont, brush, new PointF(100, 160));
            e.Graphics.DrawString($"Number of Seats: {this.NumberOfSeats}", normalFont, brush, new PointF(100, 190));
            e.Graphics.DrawString($"Journey Date: {journeyDate}", normalFont, brush, new PointF(100, 220));
            e.Graphics.DrawString($"Train Name: {trainName}", normalFont, brush, new PointF(100, 250));

        }
        private void SaveAsPdf()
        {
            PrintDataCollection();
            // Get the user's Downloads folder
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            // Set up the PDF file path to the Downloads folder
            string filePath = Path.Combine(downloadsPath, "TicketInfo.pdf");

            // Set up the PDF document and writer
            Document pdfDoc = new Document(PageSize.A4, 50f, 50f, 50f, 50f);

            // Create PDF writer to write to the file
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

            // Open the document
            pdfDoc.Open();

            // Set fonts
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font watermarkFont = new iTextSharp.text.Font(bf, 60, iTextSharp.text.Font.BOLDITALIC, new BaseColor(200, 200, 200, 50));

            // Add watermark
            PdfContentByte canvas = writer.DirectContent;
            ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, new Phrase("DSRS", watermarkFont),
                300, 250, 45); // Adjust positioning and rotation as necessary

            // Add Title
            Paragraph title = new Paragraph("Ticket Information", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(title);

            // Add ticket details
            Paragraph details = new Paragraph();
            details.Add(new Phrase($"\nOwner Name: {userName}\n", normalFont));
            details.Add(new Phrase($"From: {fromLocation}\n", normalFont));
            details.Add(new Phrase($"To: {toLocation}\n", normalFont));
            details.Add(new Phrase($"Number of Seats: {this.NumberOfSeats}\n", normalFont));
            details.Add(new Phrase($"Journey Date: {journeyDate}\n", normalFont));
            details.Add(new Phrase($"Train Name: {trainName}\n", normalFont));

            // Add details to the PDF
            pdfDoc.Add(details);

            // Close the document
            pdfDoc.Close();

            // Notify user that the PDF has been saved
            MessageBox.Show("PDF saved successfully in Downloads folder: " + filePath);
        }

    }
}
