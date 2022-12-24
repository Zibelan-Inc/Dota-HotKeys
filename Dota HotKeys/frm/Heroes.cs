using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota_HotKeys.frm
{
    public partial class Heroes : UserControl
    {
        public static Heroes heroes;

        public Heroes()
        {
            InitializeComponent();
        }
        private void Heroes_Load(object sender, EventArgs e)
        {
            heroes = this;
        }
        private void heroes_Click(object sender, EventArgs e)
        {
           Bunifu.Framework.UI.BunifuImageButton button = (Bunifu.Framework.UI.BunifuImageButton)sender;
            modCommon.idhero = button.Name;
            frm.ComboManager uC_ = new frm.ComboManager();
            modCommon.addUserControlHeroe(uC_);
        }
    }
}
