using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Xml;
using System.IO;

using InvoicePDF;

namespace FAFOS
{
    public partial class InspectionForm : Form
    {
        string userid;

        public InspectionForm(string id)
        {

            InitializeComponent();
            userid = id;


            DataTable dt = new ServiceAddress().getAddresses();
            addressBox.DataSource = dt;
            addressBox.DisplayMember = "address";
            addressBox.ValueMember = "id";
        }

  

        private void generate_btn_Click(object sender, EventArgs e)
        {

            string uri ="";           

            uri = generateExtinguisher();


            pdfPreview.Navigate(uri);

        }
        private string generateExtinguisher()
        {
               


                //start creating the PDF

                //Create a Catalog Dictionary
                CatalogDict catalogDict = new CatalogDict();

                //Create a Page Tree Dictionary
                PageTreeDict pageTreeDict = new PageTreeDict();

                //Create a Font Dictionary - Only the standard fonts Time, Helvetica and courier etc can be created by this method.
                //See Adobe doco for more info on other fonts
                FontDict TimesRoman = new FontDict();
                FontDict TimesItalic = new FontDict();
                FontDict TimesBold = new FontDict();
                FontDict Courier = new FontDict();

                //Create the info Dictionary
                InfoDict infoDict = new InfoDict();
                Invoice invoice = new Invoice();
                //Create the font called Times Roman
                TimesRoman.CreateFontDict("T1", "Times-Roman");

                //Create the font called Times Italic
                TimesItalic.CreateFontDict("T2", "Times-Italic");

                //Create the font called Times Bold
                TimesBold.CreateFontDict("T3", "Times-Bold");

                //Create the font called Courier
                Courier.CreateFontDict("T4", "Times-Roman");

                //Set the info Dictionary. xxx will be the invoice number
                infoDict.SetInfo( inspectionType.Text, "System Generated", "Fire-Alert");

                //Create a utility object
                Utility pdfUtility = new Utility();
                String FilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "Resources\\" + inspectionType.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".pdf";

                //Open a file specifying the file name as the output pdf file
                //String FilePath = @"C:\Users\Hassan\Desktop\Preview.pdf";

                FileStream file = new FileStream(FilePath, FileMode.Create);
                int size = 0;
                file.Write(pdfUtility.GetHeader("1.5", out size), 0, size);
                file.Close();

                //Finished the first step



                //Create a Page Dictionary , this represents a visible page
                PageDict page = new PageDict();
                ContentDict content = new ContentDict();

                //The page size object will hold all the page size information
                //also holds the dictionary objects for font, images etc.
                //A4 595,842
                //Letter 612,792
                PageSize pSize = new PageSize(612, 792); //A4 paper portrait in 1/72" measurements
                pSize.SetMargins(10, 10, 10, 10);

                //create the page main details
                page.CreatePage(pageTreeDict.objectNum, pSize);

                //add a page
                pageTreeDict.AddPage(page.objectNum);

                //add the fonts to this page
                page.AddResource(TimesRoman, content.objectNum);
                page.AddResource(TimesItalic, content.objectNum);
                page.AddResource(TimesBold, content.objectNum);
                page.AddResource(Courier, content.objectNum);

                //Create a Text And Table Object that presents the text elements in the page
                TextAndTables textAndtable = new TextAndTables(pSize);


                //create the reference to an image and the data that represents it
                String ImagePath2 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\Resources\\logo.jpg";   //file path to image source
                ImageDict I2 = new ImageDict();                     //new image dictionary object
                I2.CreateImageDict("I2", ImagePath2);                //create the object which describes the image
                page.AddImageResource(I2.PDFImageName, I2, content.objectNum);  //create a reference where the PDF can identify which object
                //describes the image when we want to draw it on the page

                /*
                 * draw the image to page (add the instruction to the content stream which says draw the image called I1 starting
                 * at X = 269, Y = 20 and with an ACTUAL image size on the page of w = 144 and h = 100)
                 */
                PageImages pi2 = new PageImages();
                content.SetStream(pi2.ShowImage("I2", 400, 680, 155, 85));   //tell the PDF we want to draw an image called 'I1', where and what size

                String address = null;

                try
                {
                    address = new ServiceAddress().get(addressBox.SelectedValue.ToString());
                }
                catch(Exception e)
                {
                    MessageBox.Show("An error occured, or no service addresses exist");
                    return null;
                }

                String reportType = inspectionType.Text;
                //String reportType = "Emergency Light";

                String[] ad = new String[6];
                ad = address.Split(',');

                String id = addressBox.SelectedValue.ToString();

             //   client.get(contract.getClient(sales_order.getSAddress(_view.GetText())))

                try
                {

                    String clientInfo = new Client().get(new ClientContract().getClient(id));
                    String[] client = new String[9];
                    client = clientInfo.Split(',');

                    //Add text to the page
                    textAndtable.AddText(60, 70, "Report of Inspection/Test", 16, "T3", Align.LeftAlign);

                    if (reportType.Contains("Fire Hose Cabinet"))
                    {
                        textAndtable.AddText(60, 85, "Fire Hose Cabinet", 10, "T3", Align.LeftAlign);
                    }
                    else if (reportType.Contains("Emergency Light"))
                    {
                        textAndtable.AddText(60, 85, "Emergency Light", 10, "T3", Align.LeftAlign);
                    }
                    else
                        textAndtable.AddText(60, 85, "Extinguisher", 10, "T3", Align.LeftAlign);

                    string format = "MMMM d, yyyy";
                    textAndtable.AddText(60, 100, DateTime.Today.ToString(format), 10, "T3", Align.LeftAlign);
                    textAndtable.AddText(60, 115, "Property", 10, "T3", Align.LeftAlign);
                    textAndtable.AddText(65, 130, ad[0], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(65, 140, ad[3] + ", " + ad[4], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(65, 150, ad[5] + " " + ad[1], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(65, 180, ad[2], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(65, 190, "N/A", 10, "T4", Align.LeftAlign);

                    textAndtable.AddText(200, 115, "Owner/Agent", 10, "T3", Align.LeftAlign);
                    textAndtable.AddText(205, 130, client[0], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(205, 140, client[1], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(205, 150, client[6] + ", " + client[7], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(205, 180, client[5], 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(205, 190, client[3], 10, "T4", Align.LeftAlign);

                    textAndtable.AddText(370, 160, "Conducted by:", 10, "T3", Align.LeftAlign);
                    textAndtable.AddText(370, 170, "Inspection Ref:", 10, "T3", Align.LeftAlign);
                    textAndtable.AddText(370, 180, "Contact:", 10, "T3", Align.LeftAlign);
                    textAndtable.AddText(450, 160, new Users().getName(Convert.ToInt32(userid)), 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(450, 170, "456", 10, "T4", Align.LeftAlign);
                    textAndtable.AddText(450, 180, "N/A", 10, "T4", Align.LeftAlign);



                    //create the colours for the round rectangles
                    ColorSpec rrBorder = new ColorSpec(0, 0, 0);        //main border colour
                    ColorSpec rrMainBG = new ColorSpec(204, 204, 204);  //background colour of the round rectangle
                    ColorSpec rrTBBG = new ColorSpec(255, 255, 255);    //background colour of the rectangle on top of the round rectangle


                    //create a new round rectangle object
                    RoundRectangle rr = new RoundRectangle();

                    //initialise special graphics state (graphics cursor)
                    content.SetStream("q\r\n");


                    content.SetStream(rr.DrawRoundRectangle(55, 460, 510, 130, 5, 0.55, 20, 90, 1, rrBorder, rrMainBG, rrTBBG));

                    //begin drawing any required lines inside the round rectangle


                    StraightLine line = new StraightLine();             //new straight line object
                    ColorSpec vline = new ColorSpec(0, 0, 0);     //line colour - in this case Red

                    //draw the line
                    content.SetStream(line.DrawLine(180, 570, 180, 480, 1, vline));
                    content.SetStream(line.DrawLine(320, 570, 320, 480, 1, vline));
                    content.SetStream(line.DrawLine(390, 570, 390, 480, 1, vline));

                    content.SetStream(line.DrawLine(55, 525, 565, 525, 1, vline));

                    //close the graphics cursor in PDF
                    content.SetStream("Q\r\n");

                    //add in box headers and contents
                    textAndtable.AddText(65, 215, "Signatures", 11, "T3", Align.LeftAlign);
                    textAndtable.AddText(60, 232, "Inspector - Printed", 8, "T4", Align.LeftAlign);
                    textAndtable.AddText(60, 245, new Users().getName(Convert.ToInt32(userid)), 8, "T3", Align.LeftAlign);
                    textAndtable.AddText(60, 275, "Owner - Printed", 8, "T4", Align.LeftAlign);
                    textAndtable.AddText(60, 288, client[5], 8, "T3", Align.LeftAlign);

                    textAndtable.AddText(181, 232, "Inspector - Signature", 8, "T4", Align.LeftAlign);
                    textAndtable.AddText(181, 275, "Owner - Signature", 8, "T4", Align.LeftAlign);

                    textAndtable.AddText(321, 232, "Date", 8, "T4", Align.LeftAlign);
                    textAndtable.AddText(321, 275, "Date", 8, "T4", Align.LeftAlign);

                    textAndtable.AddText(391, 232, "Conditions", 8, "T4", Align.LeftAlign);
                    textAndtable.AddText(391, 275, "Conditions", 8, "T4", Align.LeftAlign);
                }
                catch(Exception e)
                {
                    MessageBox.Show("An error occured finding the client");
                    MessageBox.Show(e.ToString());
                    return null;
                }

                if (reportType.Contains("Fire Hose Cabinet"))
                {
                    textAndtable.AddText(65, 350, "Fire Hose Cabinet Inspection List", 11, "T3", Align.LeftAlign);
                }
                else if (reportType.Contains("Emergency Light"))
                {
                    textAndtable.AddText(65, 350, "Emergency Light Inspection List", 11, "T3", Align.LeftAlign);
                }
                else
                    textAndtable.AddText(65, 350, "Fire Extinguisher Inspection List", 11, "T3", Align.LeftAlign);

               
                //Specify the color for the cell and the line
                ColorSpec cellColor = new ColorSpec(255, 255, 255);
                ColorSpec lineColor = new ColorSpec(0, 0, 0);


           //     textAndtable.AddText(50, 275, "Page:    1", 10, "T4", Align.LeftAlign);
            // make sure this is the size of the number of columns
                Align[] alignC1 = new Align[17];
                alignC1[0] = Align.LeftAlign;
                alignC1[1] = Align.LeftAlign;
                alignC1[2] = Align.LeftAlign;
                alignC1[3] = Align.LeftAlign;
                alignC1[4] = Align.CenterAlign;
                alignC1[5] = Align.LeftAlign;
                alignC1[6] = Align.LeftAlign;
                alignC1[7] = Align.CenterAlign;
                alignC1[8] = Align.CenterAlign;
                alignC1[9] = Align.CenterAlign;
                alignC1[10] = Align.CenterAlign;
                alignC1[11] = Align.CenterAlign;
                alignC1[12] = Align.CenterAlign;
                alignC1[13] = Align.CenterAlign;
                alignC1[14] = Align.CenterAlign;
                alignC1[15] = Align.CenterAlign;
                alignC1[16] = Align.CenterAlign;

               

                string url = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory)
                   + "\\InspectionData\\In\\InspectionData.xml";

                XmlDocument doc;

                try
                {
                    doc = new System.Xml.XmlDocument();
                    doc.Load(url);
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error occurred or no inspection data exists");
                    return null;
                }
                
                XmlElement docElement = doc.DocumentElement;

                // loop through all childNodes
                //String floor="";
                uint height = 0 ;
                XmlNode start = docElement.FirstChild;

                XmlNode serviceAddress = null;

                String xmlAddress = addressBox.Text.Split(',')[0];

                try
                {
                    serviceAddress = doc.SelectSingleNode("//ServiceAddress[@address='" + xmlAddress + "']");
                }
                catch(Exception e)
                {
                    MessageBox.Show("An error occursed or the service address does not exist in the inspection data");
                    return null;
                }

                if(serviceAddress == null)
                {
                    MessageBox.Show("An error occursed or the service address does not exist in the inspection data");
                    return null;
                }
                

                String floorName = null;

                //--------- HEADER -----------
                ColorSpec headerCellColor = new ColorSpec(255, 0, 0);
                //ColorSpec lineColor = new ColorSpec(0, 0, 0);

                TableParams tableHeader;

                if(reportType.Contains("Fire Hose Cabinet"))
                {
                    tableHeader = new TableParams(9, 60, 28, 30, 90, 59, 59, 59, 59, 57); 
                }
                else if (reportType.Contains("Emergency Light"))
                {
                    tableHeader = new TableParams(11, 60, 28, 30, 90, 30, 50, 50, 50, 30, 50, 50);
                }
                else
                    tableHeader = new TableParams(17, 60, 28, 30, 90, 25, 30, 50, 35, 17, 17, 17, 17, 17, 17, 17, 17, 17);

                uint initHeight = 415;

                tableHeader.yPos = initHeight;
                tableHeader.xPos = 49;
                tableHeader.rowHeight = 15;

                if (reportType.Contains("Fire Hose Cabinet"))
                {
                    textAndtable.SetParams(tableHeader, headerCellColor, Align.LeftAlign, 3);
                }
                else if (reportType.Contains("Emergency Light"))
                {
                    textAndtable.SetParams(tableHeader, headerCellColor, Align.LeftAlign, 3);
                }
                else
                    textAndtable.SetHeaderParams(tableHeader, headerCellColor, Align.LeftAlign, 3, tableHeader.rowHeight);


                if (reportType.Contains("Fire Hose Cabinet"))
                {
                    textAndtable.AddRow(true, 8, "T3", alignC1, false, false, "Floor", "Room", "ID", "Location",
                        "Manufacting Date", "Cabinet Condition", "Nozzle Condition", "Hose Re-Rack", "Hydrostatic Test Due");

                    height += tableHeader.rowHeight * 2; //Move offset to next row
                }
                else if (reportType.Contains("Emergency Light"))
                {
                    textAndtable.AddRow(true, 8, "T3", alignC1, false, false, "Floor", "Room", "ID", "Location",
                        "Model", "Make", "Number of Heads", "Total Power", "Voltage", "Requires Service or Repair", "Operation Confirmed");

                    height += tableHeader.rowHeight * 3; //Move offset to next row
                }
                else
                {
                    textAndtable.AddRow(false, 8, "T3", alignC1, false, true, "Floor", "Room", "ID", "Location",
                        "Size", "Type", "Model", "Serial No.", "H Test", "6 yr", "Wt", "Brckt", "Gauge",
                        "Pin", "Sign", "Coll", "Hose");

                    height += tableHeader.rowHeight; //Move offset to next row
                }

                

                content.SetStream(textAndtable.EndTable(lineColor, true));

                foreach(XmlNode floor in serviceAddress.ChildNodes)
                {

                    //Sets paramaters for tables, first one is number of columns, other are column widths
                    // current total width: 501

                    TableParams table2;

                    if(reportType.Contains("Fire Hose Cabinet"))
                    {
                        table2 = new TableParams(9, 60, 28, 30, 90, 59, 59, 59, 59, 57); 
                    }
                    else if (reportType.Contains("Emergency Light"))
                    {
                        table2 = new TableParams(11, 60, 28, 30, 90, 30, 50, 50, 50, 30, 50, 50);
                    }
                    else
                         table2 = new TableParams(17, 60, 28, 30, 90, 25, 30, 50, 35, 17, 17, 17, 17, 17, 17, 17, 17, 17); 

      
                    table2.yPos = /*340*/ initHeight - height;
                    table2.xPos = 49;
                    table2.rowHeight = 15;
                    textAndtable.SetParams(table2, cellColor, Align.LeftAlign, 3);

                    floorName = floor.Attributes["name"].InnerText;

                    foreach(XmlNode room in floor.ChildNodes)
                    {

                        if (reportType.Contains("Extinguisher"))
                        {
                            XmlNodeList equipmentList = room.SelectNodes("Extinguisher"); //Currently hard coded to extinguisher

                            foreach (XmlNode equipment in equipmentList)
                            {
                                textAndtable.AddRow(true, 8, "T3", alignC1, false, false, floorName, room.Attributes["id"].InnerText,
                                    equipment.Attributes["id"].InnerText, equipment.Attributes["location"].InnerText,
                                    equipment.Attributes["size"].InnerText, equipment.Attributes["type"].InnerText,
                                    equipment.Attributes["model"].InnerText, equipment.Attributes["serialNo"].InnerText,
                                    passFail(equipment.SelectNodes("*[@name='Hydro Test']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='6 Year Insp']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='Weight']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='Bracket']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='Gauge']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='Pull Pin']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='Signage']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='Collar']")[0].Attributes["testResult"].InnerText),
                                    passFail(equipment.SelectNodes("*[@name='Hose']")[0].Attributes["testResult"].InnerText));

                                height += table2.rowHeight;

                                // EXPERIMENTAL: add a new row when there are notes for a failed element
                                // In this case I don't like that it keeps the row formatting
                                XmlNodeList elements = equipment.SelectNodes("*");
                                foreach (XmlNode element in elements)
                                {
                                    if (element.Attributes["testNote"].InnerText.Trim() != "")
                                    {
                                        content.SetStream(textAndtable.EndTable(lineColor, true));

                                        // reset table params
                                        table2 = new TableParams(1, 501); // 1 row, the width of the entire table

                                        table2.yPos = /*340*/ initHeight - height;
                                        table2.xPos = 49;
                                        table2.rowHeight = 15;
                                        textAndtable.SetParams(table2, cellColor, Align.LeftAlign, 3);

                                        textAndtable.AddRow(true, 8, "T3", alignC1, false, false, element.Attributes["name"].InnerText + ": " + element.Attributes["testNote"].InnerText);
                                        height += table2.rowHeight;

                                        content.SetStream(textAndtable.EndTable(lineColor, true));

                                        table2 = new TableParams(17, 60, 28, 30, 90, 25, 30, 50, 35, 17, 17, 17, 17, 17, 17, 17, 17, 17);

                                        table2.yPos = /*340*/ initHeight - height;
                                        table2.xPos = 49;
                                        table2.rowHeight = 15;
                                        textAndtable.SetParams(table2, cellColor, Align.LeftAlign, 3);

                                        floorName = floor.Attributes["name"].InnerText;
                                    }
                                }

                            }
                            //Construct row

                        }
                        else if(reportType.Contains("Fire Hose Cabinet"))
                        {
                            XmlNodeList equipmentList = room.SelectNodes("FireHoseCabinet");

                            foreach (XmlNode equipment in equipmentList)
                            {


                                textAndtable.AddRow(true, 8, "T3", alignC1, false, false, floorName, room.Attributes["id"].InnerText,
                                    equipment.Attributes["id"].InnerText, equipment.Attributes["location"].InnerText,
                                    equipment.Attributes["manufacturingDate"].InnerText,
                                    goodPoor(equipment.SelectNodes("*[@name='Cabinet Condition']")[0].Attributes["testResult"].InnerText),
                                    goodPoor(equipment.SelectNodes("*[@name='Nozzle Condition']")[0].Attributes["testResult"].InnerText),
                                    goodPoor(equipment.SelectNodes("*[@name='Hose Re-Rack']")[0].Attributes["testResult"].InnerText),
                                    goodPoor(equipment.SelectNodes("*[@name='Hydrostatic Test Due']")[0].Attributes["testResult"].InnerText));

                                height += table2.rowHeight;

                                // EXPERIMENTAL: add a new row when there are notes for a failed element
                                // In this case I don't like that it keeps the row formatting
                                XmlNodeList elements = equipment.SelectNodes("*");
                                foreach (XmlNode element in elements)
                                {
                                    if (element.Attributes["testNote"].InnerText.Trim() != "")
                                    {
                                        content.SetStream(textAndtable.EndTable(lineColor, true));

                                        // reset table params
                                        table2 = new TableParams(1, 501); // 1 row, the width of the entire table

                                        table2.yPos = /*340*/ initHeight - height;
                                        table2.xPos = 49;
                                        table2.rowHeight = 15;
                                        textAndtable.SetParams(table2, cellColor, Align.LeftAlign, 3);

                                        textAndtable.AddRow(true, 8, "T3", alignC1, false, false, element.Attributes["name"].InnerText + ": " + element.Attributes["testNote"].InnerText);
                                        height += table2.rowHeight;

                                        content.SetStream(textAndtable.EndTable(lineColor, true));

                                        table2 = new TableParams(9, 60, 28, 30, 90, 59, 59, 59, 59, 57);

                                        table2.yPos = /*340*/ initHeight - height;
                                        table2.xPos = 49;
                                        table2.rowHeight = 15;
                                        textAndtable.SetParams(table2, cellColor, Align.LeftAlign, 3);

                                        floorName = floor.Attributes["name"].InnerText;
                                    }
                                }

                                //height += table2.rowHeight;

                            }
                        }
                        else if (reportType.Contains("Emergency Light"))
                        {
                            XmlNodeList equipmentList = room.SelectNodes("EmergencyLight");

                            foreach (XmlNode equipment in equipmentList)
                            {

                                textAndtable.AddRow(true, 8, "T3", alignC1, false, false, floorName, room.Attributes["id"].InnerText,
                                    equipment.Attributes["id"].InnerText, equipment.Attributes["location"].InnerText,
                                    equipment.Attributes["model"].InnerText, equipment.Attributes["make"].InnerText,
                                    equipment.Attributes["numHeads"].InnerText, equipment.Attributes["totalPower"].InnerText,
                                    equipment.Attributes["voltage"].InnerText,
                                    goodPoor(equipment.SelectNodes("*[@name='Requires Service or Repair']")[0].Attributes["testResult"].InnerText),
                                    goodPoor(equipment.SelectNodes("*[@name='Operation Confirmed']")[0].Attributes["testResult"].InnerText));

                                height += table2.rowHeight;

                                // EXPERIMENTAL: add a new row when there are notes for a failed element
                                // In this case I don't like that it keeps the row formatting
                                XmlNodeList elements = equipment.SelectNodes("*");
                                foreach (XmlNode element in elements)
                                {
                                    if (element.Attributes["testNote"].InnerText.Trim() != "")
                                    {
                                        content.SetStream(textAndtable.EndTable(lineColor, true));

                                        // reset table params
                                        table2 = new TableParams(1, 518); // 1 row, the width of the entire table

                                        table2.yPos = /*340*/ initHeight - height;
                                        table2.xPos = 49;
                                        table2.rowHeight = 15;
                                        textAndtable.SetParams(table2, cellColor, Align.LeftAlign, 3);

                                        textAndtable.AddRow(true, 8, "T3", alignC1, false, false, element.Attributes["name"].InnerText + ": " + element.Attributes["testNote"].InnerText);
                                        height += table2.rowHeight;

                                        content.SetStream(textAndtable.EndTable(lineColor, true));

                                        table2 = new TableParams(11, 60, 28, 30, 90, 30, 50, 50, 50, 30, 50, 50);

                                        table2.yPos = /*340*/ initHeight - height;
                                        table2.xPos = 49;
                                        table2.rowHeight = 15;
                                        textAndtable.SetParams(table2, cellColor, Align.LeftAlign, 3);

                                        floorName = floor.Attributes["name"].InnerText;
                                    }
                                }

                                //height += table2.rowHeight;

                            }
                        }

                        // one row spacing between floors
                        //height += table2.rowHeight;
                        
                    }

                    height += table2.rowHeight; //100; //THIS CAUSES BUGS, REDUCE TO 20 AND YOU WILL SEE
                    content.SetStream(textAndtable.EndTable(lineColor, true));
                }
               

                textAndtable.AddText(65, 720, "Print ", 10, "T3", Align.LeftAlign);
                textAndtable.AddText(125, 720, DateTime.Now.ToString("dd/MM/yyyy"), 10, "T4", Align.LeftAlign);
                textAndtable.AddText(500, 720, "Page 1 of 1", 10, "T3", Align.LeftAlign);
               
          
                content.SetStream(textAndtable.EndText());


                //All done - send the information to the PDF file

                size = 0;
                file = new FileStream(FilePath, FileMode.Append);
                file.Write(page.GetPageDict(file.Length, out size), 0, size);
                file.Write(content.GetContentDict(file.Length, out size), 0, size);
                file.Close();

                file = new FileStream(FilePath, FileMode.Append);
                file.Write(catalogDict.GetCatalogDict(pageTreeDict.objectNum, file.Length, out size), 0, size);
                file.Write(pageTreeDict.GetPageTree(file.Length, out size), 0, size);
                file.Write(TimesRoman.GetFontDict(file.Length, out size), 0, size);
                file.Write(TimesItalic.GetFontDict(file.Length, out size), 0, size);
                file.Write(TimesBold.GetFontDict(file.Length, out size), 0, size);
                file.Write(Courier.GetFontDict(file.Length, out size), 0, size);

                //write image dict
                // file.Write(I1.GetImageDict(file.Length, out size), 0, size);
                 file.Write(I2.GetImageDict(file.Length, out size), 0, size);

                file.Write(infoDict.GetInfoDict(file.Length, out size), 0, size);
                file.Write(pdfUtility.CreateXrefTable(file.Length, out size), 0, size);
                file.Write(pdfUtility.GetTrailer(catalogDict.objectNum, infoDict.objectNum, out size), 0, size);
                file.Close();

                return FilePath;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private String passFail(String raw)
        {
            switch (raw)
            {
                case "Pass":
                    return "OK";
                case "Fail":
                    return "X";
            }

            // if this is the empty string there will be errors
            return " ";
        }

        private String goodPoor(String raw)
        {
            if (raw.Equals(""))
                return " ";
            else
                return raw;
        }
   

    }
}
