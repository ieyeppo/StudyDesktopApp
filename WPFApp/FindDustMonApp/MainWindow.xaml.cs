using MahApps.Metro.Controls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Xml;

namespace FindDustMonApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly string excelPath = $@"{AppDomain.CurrentDomain.BaseDirectory}station_list.xls";
        private string openApiUrl = "http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMsrstnAcctoRltmMesureDnsty?" +
                                    "serviceKey=d9NhCApdAUmLLSNeCAbS0iuAsKtZUb9%2BYf4Xjb1Hj9sEZwvUenJlB7Aj22%2BF2ZrENXn1P9SCudw6Sri31ddXdw%3D%3D&" +
                                    "returnType=xml&numOfRows=100&" +
                                    "pageNo=1&" +
                                    "dataTerm=DAILY&" +
                                    "ver=1.0&" +
                                    $"stationName=";
        private List<FineDustInfo> lstResult;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //엑셀에서 측정소 가져오기
            IWorkbook wb = null;
            ISheet sh = null;

            using(FileStream fs = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
            {
                wb = new HSSFWorkbook(fs);
            }

            List<string> lstLabs = new List<string>();

            sh = wb.GetSheetAt(0);  //sheet 1번에서 데이터를 읽어옴
            int rowCount = sh.LastRowNum;

            try
            {
                for (int r = 0; r < rowCount; r++)
                {
                    if (r == 0) continue;
                    lstLabs.Add(sh.GetRow(r).Cells[1].ToString());
                }
            }
            catch(Exception ex)
            {

            }

            CboStations.ItemsSource = lstLabs;
        }

        private void CboStations_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            lstResult = new List<FineDustInfo>();
            if(CboStations.SelectedItem != null)
            {
                openApiUrl = openApiUrl.Substring(0, openApiUrl.LastIndexOf("=") +1) + CboStations.SelectedItem.ToString();
                XmlDocument xml = new XmlDocument();
                xml.Load(openApiUrl);

                XmlNodeList xnList = xml.SelectNodes("/response/body/items/item");

                foreach(XmlNode item in xnList)
                {
                    //Debug.WriteLine($"dateTime : {item["dateTime"].InnerText}");
                    lstResult.Add(new FineDustInfo() {
                        DataTime = item["dataTime"].InnerText,
                        Khai = item["khaiValue"].InnerText,
                        So2 = item["so2Value"].InnerText
                    });
                }
            }
            DgrFineDustInfos.ItemsSource = lstResult;
        }
    }

    internal class FineDustInfo
    {
        public string DataTime { get; set; }
        public string Khai { get; set; }
        public string So2 { get; set; }
    }
}
