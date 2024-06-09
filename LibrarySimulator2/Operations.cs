using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySimulator2
{
    public partial class Operations : Form
    {
        public bool isVisible = false;
        public Operations()
        {
            InitializeComponent();
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            isVisible = true;
            
        }
    }
}
