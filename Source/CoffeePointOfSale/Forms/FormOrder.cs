using CoffeePointOfSale.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrder : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        public FormOrder(IAppSettings appSettings)
        {
            _appSettings = appSettings;
            InitializeComponent();
        }
    }
}
