using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace League_Gold_Efficiency
{
    public partial class LeagueGoldEfficiency : Form
    {
        //Variables
       

        public LeagueGoldEfficiency()
        {
            InitializeComponent();
        }

        private void LeagueGoldEfficiency_Load(object sender, EventArgs e)
        {
            Reset();


        }
        private void Reset()
        {
            //Item  Stat Reset
            lblHealth.Text = "0";
            lblHealthRegen.Text = "0%";
            lblMana.Text = "0";
            lblManaRegen.Text = "0%";
            lblArmor.Text = "0";
            lblMagicResist.Text = "0";
            lblAttackDamage.Text = "0";
            lblAttackSpeed.Text = "0%";
            lblAbilityPower.Text = "0";
            lblAbilityHaste.Text = "0";
            lblLifeSteal.Text = "0%";
            lblOmnivamp.Text = "0%";
            lblMovementSpeed.Text = "0";
            lblMovementSpeedPercent.Text = "0%";
            lblTenacity.Text = "0%";
            lblArmorPenetrationPercent.Text = "0%";
            lblLethality.Text = "0";
            lblMagicPenetrationPercent.Text = "0%";
            lblMagicPenetrationFlat.Text = "0";
            lblHealShieldPower.Text = "0%";
            lblCriticalStrikeChance.Text = "0%";
            lblCriticalStrikeDamage.Text = "0%";
           
            

            //First Half of Stat Selector
            chkboxHealth.Checked = false;
            chkboxHealthRegen.Checked = false;
            chkboxMana.Checked = false;
            chkboxManaRegen.Checked = false;
            chkboxArmor.Checked = false;
            chkboxMagicResist.Checked = false;
            chkboxAbilityHaste.Checked = false;
            chkboxMovementSpeedPercent.Checked = false;
            chkboxMovementSpeedFlat.Checked = false;
            chkboxHealShieldPower.Checked = false;

            //Second Half of Stat Selector
            chkboxAbilityPower.Checked = false;
            chkboxMagicPenetrationPercent.Checked = false;
            chkboxMagicPenetrationFlat.Checked = false;
            chkboxOmnivamp.Checked = false;
            chkboxAttackDamage.Checked = false;
            chkboxArmorPenetrationPercent.Checked = false;
            chkboxLethality.Checked = false;
            chkboxAttackSpeed.Checked = false;
            chkboxLifeSteal.Checked = false;
            chkboxCrticialStrikeChance.Checked = false;
            chkBoxCriticalStrikeDamage.Checked = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTenacity_Click(object sender, EventArgs e)
        {

        }

        private void lblArmorPenetrationPercent_Click(object sender, EventArgs e)
        {

        }

        private void lblMagicPenetrationPercent_Click(object sender, EventArgs e)
        {

        }

        private void lblMovementSpeedPercent_Click(object sender, EventArgs e)
        {

        }

        private void lblCriticalStrikeDamage_Click(object sender, EventArgs e)
        {

        }

        private void lblCriticalStrikeChance_Click(object sender, EventArgs e)
        {

        }
    }
