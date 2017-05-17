using System;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class UserPropertiesForm : Form
    {
        public UserPropertiesForm()
        {
            InitializeComponent();
        }

        public object SelectedObject
        {
            get { return propertyGrid1.SelectedObject; }
            set { propertyGrid1.SelectedObject = value; }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SelectedObject = new UserProperties();
        }
    }
}
