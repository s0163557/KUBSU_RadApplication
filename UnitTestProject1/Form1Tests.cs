using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 form1 = new Form1();
            Button accept = new Button();
            for (int i = 0; i < form1.Form2.Controls.Count; i++)
            {
                if (form1.Form2.Controls[i].GetType() == typeof(System.Windows.Forms.Label))
                {
                    form1.Form2.Controls[i].Text = "test";
                }
                if (form1.Form2.Controls[i].GetType() == typeof(System.Windows.Forms.Button)
                    && form1.Form2.Controls[i].Text == "Принять")
                {
                    accept = (Button)form1.Form2.Controls[i];
                }
            }
            Assert.ThrowsException<Npgsql.PostgresException>(accept.PerformClick);
        }
    }
}
