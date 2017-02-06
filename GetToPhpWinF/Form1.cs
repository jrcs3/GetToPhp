#define PHP_WINDOWS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetToPhpWinF
{
    public partial class Form1 : Form
    {
        private string BaseUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["BaseUrl"].ToString();
            }
        }
        private string Page
        {
            get
            {
                return ConfigurationManager.AppSettings["Page"].ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string pars = getPars();

            Task.Run(() => MainAsync(pars));

        }

        private async Task MainAsync(string urlParameters)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                var result = await client.GetAsync(Page + "?" + urlParameters);
                string resultContent = await result.Content.ReadAsStringAsync();
                MessageBox.Show(resultContent);
            }
        }

        private string getPars()
        {
            return "param1=" + txtParam1.Text + "&param2=" + txtParam2.Text + "&param3=" + txtParam3.Text + "&param4=" + txtParam4.Text;
        }
    }
}
