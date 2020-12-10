using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 票务管理系统
{
    public partial class user_publicinfo : Form
    {
        private SqlConnection db = new SqlConnection(Form1.connString);
        public user_publicinfo()
        {
            InitializeComponent();
        }
    }
}
