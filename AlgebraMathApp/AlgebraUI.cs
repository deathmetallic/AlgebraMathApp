using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* 
 * 
 * Algebra formulas/calculations reference app
 * Authored by Mark Laxmeter, 2/23/2020. 
 * Available for reuse under the MIT Open License. 
 * 
 * Contact developer: mslaxmeter@gmail.com
 * GitHub repo : https://github.com/deathmetallic/AlgebraMathApp
 * 
 */

namespace AlgebraMathApp
{
    public partial class AlgebraUI : Form
    {
        public AlgebraUI()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TopMenuOpened(object sender, EventArgs e)
        {

        }

        private void TopMenuClosed(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuOptions_Click(object sender, EventArgs e)
        {

        }
    }
}

public class AlgebraUIclass
{
    public void Main(string[] args)
    {
        // declare known math variables
        float PI = Convert.ToSingle(Math.PI);
        float euler = Convert.ToSingle(Math.E);

        // declare variables relating to UI
        int selectedFID = 0; // for determining which formula to apply a "Selected/Highlighted" style to.
        string searchName = ""; // the value of the Find a Formula box
        int searchFID = 0; // FID of the selected formula from Find a Formula
        float[] result1 = { }; // for calculated result to display if formula supports it
        float[] result2 = { }; // additional result if formula outputs multiple results
        float[] result3 = { }; // additional result if formula outputs multiple results
        float[] result4 = { }; // additional result if formula outputs multiple results
        float[] result5 = { }; // additional result if formula outputs multiple results
    }
    // create a Formula class to store formula information
    public class eFormula
    {

        // need to define a method for reading information from a file and assigning key values to the array values
        // possibly with RTF, HTML, or SQL.

        int[] FID = { }; // formula ID used for ordering - should be unique and start at 1 (no zero value)
        string[] Name = { }; // name of formula displayed in list and search
        string[] Desc = { }; // formula description
        string[] Info = { }; // formula information panel text
        string[] ImgPath = { };  // path to the image that shows the formula

        // all variable letters used for formula. 
        /* 
         * In cases where a formula uses multiple instances of a variable (such as (x1-y1)/(x2-y2) ),
         * the sub values should by assigned to unused variables for that formula
         * e.g. x1 = x, y1 = y, x2 = a, y2 = b
         * in code : (x-y)/(a-b)
         */

        float[] a = { };
        float[] b = { };
        float[] c = { };
        float[] d = { };
        float[] e = { };
        float[] f = { };
        float[] g = { };
        float[] h = { };
        float[] i = { };
        float[] j = { };
        float[] k = { };
        float[] l = { };
        float[] m = { };
        float[] n = { };
        float[] o = { };
        float[] p = { };
        float[] q = { };
        float[] r = { };
        float[] s = { };
        float[] t = { };
        float[] u = { };
        float[] v = { };
        float[] w = { };
        float[] x = { };
        float[] y = { };
        float[] z = { };

    }
}