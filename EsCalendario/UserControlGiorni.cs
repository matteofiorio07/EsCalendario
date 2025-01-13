using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsCalendario
{
    public partial class UserControlGiorni : UserControl
    {
        public UserControlGiorni()
        {
            InitializeComponent();
        }
        
        private void UserControlGiorni_Load(object sender, EventArgs e)
        {
            
        }

        public void Giorni(int numGiorni) 
        {
            lb_giorni.Text = numGiorni + "";
        }
    }
}
