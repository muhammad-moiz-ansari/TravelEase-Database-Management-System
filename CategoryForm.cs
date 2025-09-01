using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class CategoryForm : Form
    {
        public CategoryForm(string name, string desc)
        {
            InitializeComponent();

            catNameBox.Text = name;
            descriptionBox.Text = desc;
        }
    }
}
