using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace FtToMeterConverterProject
{
    public partial class Form1 : Form
    {
        IFtToMeterConverter converter;

        public Form1()
        {
            InitializeComponent();
            //converter = new MockFtToMeterConverter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            converter = InitApp.container.Resolve<IFtToMeterConverter>();
            //converter = InitApp.container.Resolve<FtToMeterConverter>();
        }

        private void ftToMeterConvert_Click(object sender, EventArgs e)
        {
            textBox2.Text = converter.Convert(textBox1.Text).ToString();
            //textBox2.Text = converter.Convert(textBox1.Text).ToString();
        }
    }
}
