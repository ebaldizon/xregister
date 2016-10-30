using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;

namespace xregister.Presentation
{
    public partial class RegisterFrm : Form
    {
        private RegistryProfile RP;
        private Image picture;
        private string currentPath = System.IO.Path.GetFullPath(@"..\..\IMG\c#image.png");

        public RegisterFrm()
        {
            InitializeComponent();
            dtmBirth.Format = DateTimePickerFormat.Custom;
            dtmBirth.CustomFormat = "dd, MMM, yyyy";
            RP = new RegistryProfile();
            this.picture = Image.FromFile(currentPath);
            pnlPicture.BackgroundImage = this.picture;
            pnlPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(txtName.Text, txtLastName.Text, dtmBirth.Value, txtCity.Text, txtEducation.Text, txtWork.Text ,txtURL.Text, chckbxActive.Checked, rtxtObservations.Text, float.Parse(txtRank.Text), this.picture);

            if(this.RP.createProfile(p))
            {
                MessageBox.Show("Registered profile", "xRegister");
            }
            else
            {
                MessageBox.Show("failure to register", "xRegister");
            }
;       }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(txtName.Text, txtLastName.Text, dtmBirth.Value, txtCity.Text, txtEducation.Text, txtWork.Text, txtURL.Text, chckbxActive.Checked, rtxtObservations.Text, float.Parse(txtRank.Text), this.picture);

            Profile p2 = this.RP.readProfile(p);

            txtName.Text = p2.getName();
            txtLastName.Text = p2.getLastName();
            dtmBirth.Value = p2.getBirth();
            rtxtObservations.Text = p2.getObservations();
            txtURL.Text = p2.getURL();
            txtRank.Text = p2.getRank().ToString();
            this.picture = p2.getPhoto();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OFDPicture.FilterIndex = 1;
            OFDPicture.Multiselect = true;
            OFDPicture.InitialDirectory = "C:\\";

            if (OFDPicture.ShowDialog(this) == DialogResult.OK)
            {
                this.picture = Image.FromFile(OFDPicture.FileName);
                pnlPicture.BackgroundImage = Image.FromFile(OFDPicture.FileName);
                pnlPicture.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
