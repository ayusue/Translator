using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //http://fanyi.youdao.com/translate?&doctype=json&type=AUTO&i=计算
        //ZH_CN2EN 中文　»　英语
        //EN2ZH_CN 英语　»　中文

        private async void BT_CtoE_Click(object sender, EventArgs e)
        {
            string sURL = "http://fanyi.youdao.com/translate?&doctype=json&type=ZH_CN2EN&i=";
            string text = RTB_Chinese.Text.Trim();
            if (text != null && text != "")
            {
                sURL += RTB_Chinese.Text;
                String jsonText = await Translate(sURL);
                jsonText = jsonText.Replace("[{\"", "{\"").Replace("\"}]", "\"}");
                //RTB_English.Text = jsonText;
                RootObject rb = JsonConvert.DeserializeObject<RootObject>(jsonText);
                String resultText = null;
                if (CB_Contrast.Checked)
                {
                    foreach (TranslateResult tr in rb.translateResult)
                    {
                        resultText += tr.src.Trim() + "\r\n";
                        resultText += tr.tgt.Trim() + "\r\n" + "\r\n";
                    }
                }
                else {
                    foreach (TranslateResult tr in rb.translateResult)
                    {
                        resultText += tr.tgt.Trim() + "\r\n";
                    }
                }
                RTB_English.Text = resultText;
            }
        }
        private async void BT_EtoC_Click(object sender, EventArgs e)
        {
            string sURL = "http://fanyi.youdao.com/translate?&doctype=json&type=EN2ZH_CN&i=";
            string text = RTB_English.Text.Trim();
            if (text != null && text != "")
            {
                sURL += RTB_English.Text;
                String jsonText = await Translate(sURL);
                jsonText = jsonText.Replace("[{\"", "{\"").Replace("\"}]", "\"}");
                RootObject rb = JsonConvert.DeserializeObject<RootObject>(jsonText);
                String resultText = null;
                if (CB_Contrast.Checked)
                {
                    foreach (TranslateResult tr in rb.translateResult)
                    {
                        resultText += tr.src.Trim() + "\r\n";
                        resultText += tr.tgt.Trim() + "\r\n" + "\r\n";
                    }
                }
                else
                {
                    foreach (TranslateResult tr in rb.translateResult)
                    {
                        resultText += tr.tgt.Trim() + "\r\n";
                    }
                }
                RTB_Chinese.Text = resultText;
            }
        }

        private async Task<string> Translate(string sURL)
        {
            Uri uri = new Uri(sURL);
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(uri);
            return result;
        }

    }
    public class TranslateResult
    {
        public string src { get; set; }
        public string tgt { get; set; }
    }

    public class RootObject
    {
        public string type { get; set; }
        public string errorCode { get; set; }
        public string elapsedTime { get; set; }
        public List<TranslateResult> translateResult { get; set; }
    }
}