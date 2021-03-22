using System;
using System.Collections.Generic;
using System.Windows.Controls;
using WpfPracticeApp.BusinessLogic;

namespace WpfPracticeApp
{
    /// <summary>
    /// Product.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            var cars = new List<BusinessLogic.Car>();

            for(int i = 0; i < 10; i++)
            {
                cars.Add(new BusinessLogic.Car() { Speed = i * 10 });
            }

            this.DataContext = cars;
        }
    }
}
