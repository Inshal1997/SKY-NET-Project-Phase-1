using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY
{
    public partial class Setting_control : UserControl
    {
        string setting_var;
        public Setting_control()
        {
            InitializeComponent();
        }


        // ///////////////////// Combo and textbox item change code starts //////////////////////////

        private void amd_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            //amd_tb.Text = amd_combo.SelectedItem.ToString();
            saveLB.Visible = false;
        }

        private void nvidia_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nvidia_tb.Text = nvidia_combo.SelectedItem.ToString();
            saveLB.Visible = false;
        }

        private void wallet_tb_TextChanged(object sender, EventArgs e)
        {
            saveLB.Visible = false;
        }

        // ///////////////////// Combo and textbox item change code starts //////////////////////////


        private void Setting_control_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AMD_found == "AMD Found")
            {
                AMDpanel.Visible = true;

            }
            else
            {
                AMDpanel.Visible = false;

            }

            if (Properties.Settings.Default.Nvidia_found == "Nvidia Found")
            {
                Nvidiapanel.Visible = true;
            }
            else
            {
                Nvidiapanel.Visible = false;
            }



            // ///////////////////// check setting property combo and textbox values code starts //////////////////////////

            string chk_Aminer_sett = Properties.Settings.Default.amd_miner_setting;


            amd_tb.Text = chk_Aminer_sett;




            string chk_Nminer_sett = Properties.Settings.Default.Nvidia_miner_setting;

            nvidia_tb.Text = chk_Nminer_sett;

            wallet_tb.Text = Properties.Settings.Default.WalletAdd;

            // ///////////////////// check setting property combo and textbox values code ends //////////////////////////


            // /////// Set Defaulty Item in combobox code startr ///////////////////////

            amd_combo.SelectedIndex = 0;
            nvidia_combo.SelectedIndex = 0;
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.AMD_found == "AMD Found")
                {
                    Properties.Settings.Default.amd_miner_setting = amd_combo.SelectedItem.ToString();

                }
                else
                {


                }

                if (Properties.Settings.Default.Nvidia_found == "Nvidia Found")
                {
                    Properties.Settings.Default.Nvidia_miner_setting = nvidia_combo.SelectedItem.ToString();
                }
                else
                {

                }





                Properties.Settings.Default.WalletAdd = wallet_tb.Text;
                Properties.Settings.Default.Save();


                saveLB.ForeColor = Color.DeepSkyBlue;
                saveLB.Text = "All changes are saved";
                saveLB.Visible = true;
            }
            catch
            {
                saveLB.ForeColor = Color.SaddleBrown;
                saveLB.Text = "Changes are not Save. Try again";
                saveLB.Visible = true;

            }



            string chk_Aminer_sett = Properties.Settings.Default.amd_miner_setting;

            amd_tb.Text = chk_Aminer_sett;

            string chk_Nminer_sett = Properties.Settings.Default.Nvidia_miner_setting;

            nvidia_tb.Text = chk_Nminer_sett;

        }

        // ///////////////////// Button Hover code starts //////////////////////////


        private void Setting_button_MouseEnter(object sender, EventArgs e)
        {
            Setting_button.BackColor = Color.White;
            Setting_button.ForeColor = Color.DeepSkyBlue;
        }

        private void Setting_button_MouseLeave(object sender, EventArgs e)
        {
            Setting_button.BackColor = Color.DeepSkyBlue;
            Setting_button.ForeColor = Color.White;
        }

        // ///////////////////// Button Hover code ends //////////////////////////


    }
}
