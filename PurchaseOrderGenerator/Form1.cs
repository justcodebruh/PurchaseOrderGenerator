using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Examples.X12.Templates.V4010;
using EdiFabric.Framework.Writers;

namespace PurchaseOrderGenerator
{
    public partial class PurchaseOrderForm : Form
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");

            //  1.  Construct the purchase order
            var purchaseOrder = EF_X12_004010_850_Builder.BuildPurchaseOrder("1");

            //  2.  Write directly to a file
            //  Change the path to a file on your machine
            using (var writer = new X12Writer(@"C:\Users\alxje\dev\Test\PurchaseOrderTestFile.txt", false))
            {
                writer.Write(SegmentBuilders.BuildIsa("1"));
                writer.Write(SegmentBuilders.BuildGs("1"));
                writer.Write(purchaseOrder);
            }

            Debug.WriteLine("Written to file.");
        }
    }
}
