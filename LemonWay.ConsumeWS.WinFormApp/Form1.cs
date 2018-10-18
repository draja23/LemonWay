using LemonWay.ConsumeWS.WinFormApp.ServiceReferenceWinFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonWay.ConsumeWS.WinFormApp
{
    public partial class Form1 : Form
    {
        //service
        public LemonWayWebServiceSoapClient service = new LemonWayWebServiceSoapClient();
        //log
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_compute_FS_Click(object sender, EventArgs e)
        {
            if (!ValidateFibonacciInput())
                return;

            this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            log.Info("Sleeping for 2s");
            Thread.Sleep(2000);
            int computeValue = int.Parse(txt_FS.Text);
            log.Info("Appel à la methode ASYNC: Fibonacci");
            int returnedValue = await FibonacciClientAsync(computeValue);
            log.Info("Fin d'appel à la methode ASYNC: Fibonacci");
            lbl_result_fs.Text = returnedValue.ToString();

            lbl_result_fs.ForeColor = Color.Green;
            lbl_result_fs.Visible = true;

            //MessageBox.Show("RESULT IS :" + lbl_result_fs.Text);
            this.Enabled = true;
        }

        private async Task<int> FibonacciClientAsync(int val)
        {
            log.Info("Appel au service: Fibonacci");
            return await service.FibonacciAsync(val);
        }

        private async void btn_convert_json_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            Thread.Sleep(2000);
            string xmlValue = txt_xtj.Text;
            log.Info("Appel à la methode ASYNC: XmlToJson");
            txt_json.Text = await XmlToJsonClientAsync(xmlValue);
            log.Info("Fin d'appel à la methode ASYNC: XmlToJson");
            //MessageBox.Show("RESULT IS :" + txt_json.Text);
            this.Enabled = true;
        }

        private async Task<string> XmlToJsonClientAsync(string xString)
        {
            log.Info("Appel au service: XmlToJson");
            var returnedString = await service.XmlToJsonAsync(xString);
            return returnedString.Body.XmlToJsonResult;
        }

        
        private void btn_execute_all_Click(object sender, EventArgs e)
        {
            if (!ValidateFibonacciInput())
                return;

            this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            int fibonacciClientIn = int.Parse(txt_FS.Text);
            string xmlToJsonClientIn = txt_xtj.Text;

            int fibonacciClientOut = 0;
            string xmlToJsonClientOut = string.Empty;
            log.Info("TPL START");
            Parallel.Invoke(() => fibonacciClientOut = FibonacciClient(fibonacciClientIn),
                            () => xmlToJsonClientOut = XmlToJsonClient(xmlToJsonClientIn));
            log.Info("TPL END");
            lbl_result_fs.Visible = true;
            lbl_result_fs.Text = fibonacciClientOut.ToString();
            txt_json.Text = xmlToJsonClientOut;

            this.Enabled = true;
        }
        
        private string XmlToJsonClient(string xString)
        {
            log.Info("Appel à la methode : XmlToJson");
            return service.XmlToJson(xString).ToString();
        }
        private int FibonacciClient(int val)
        {
            log.Info("Appel à la methode : Fibonacci");
            return service.Fibonacci(val);
        }

        private bool ValidateFibonacciInput()
        {
            try
            {
                log.Info("Validation d'entrer numérique.");
                int.Parse(txt_FS.Text);
                log.Info("Validation d'entrer numérique OK.");
                return true;
            }
            catch (Exception ex)
            {
                txt_FS.Text = string.Empty;
                MessageBox.Show("Veuillez entrer un entier valide pour Fibonacci");
                log.Info("Validation d'entrer numérique KO.");
                return false;
            }
        }

    }
}
