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
        private double dblBaseAttack;
        private double dblBaseAttackGrowth;
        private double dblBaseArmor;
        private double dblBaseArmorGrowth;
        private double dblBaseAttackSpeed;
        private double dblBaseAttackSpeedGrowth;
        private double dblBaseMagicResist;
        private double dblBaseMagicResistGrowth;
        private double dblBasehealth;
        private double dblBasehealthGrowth;
        private double dblBaseMana;
        private double dblBaseManaGrowth;
        private double dblBaseMovementSpeed;

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
            //Champion Inputs
            cboxChampion.SelectedIndex = 0;
            nudChampionLevel.Value = 1;
            nudQLevel.Value = 0;
            nudWLevel.Value = 0;
            nudELevel.Value = 0;
            nudRLevel.Value = 0;

            //Champion Stat Reset
            lblHealth.Text = "0";
            lblHealthRegen.Text = "0";
            lblMana.Text = "0";
            lblManaRegen.Text = "0";
            lblArmor.Text = "0";
            lblMagicResist.Text = "0";
            lblAttackDamage.Text = "0";
            lblAttackSpeed.Text = "0";
            lblAbilityPower.Text = "0";
            lblAbilityHaste.Text = "0";
            lblLifeSteal.Text = "0";
            lblOmnivamp.Text = "0";
            lblMovementSpeed.Text = "0";
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

            //Default Champion Abilities/Items With Scaling Selected
            rbtnScaling.Checked = true;

            //Hide Champion Box
            rbtnDisable.Checked = true;

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
        private void btnItemTuner_Click(object sender, EventArgs e)
        {

        }
        //Specific Champion Enabler Group Box
        private void rbtnEnable_CheckedChanged(object sender, EventArgs e)
        {
            gboxChampion.Show();
        }

        private void rbtnDisable_CheckedChanged(object sender, EventArgs e)
        {
            gboxChampion.Hide();
        }
        //Champion Group Box
        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {

        }

        private void cboxChampion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Collect Champion Base Stats, Champion Abilities, Champion Growth, Champion Rules

            //Unusual Champs modify nud of levels: udyr raise cap to 6, yuumi start with w and can get q/e, etc.

        }

        private void nudChampionLevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudQLevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudWLevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudELevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudRLevel_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnRunes_Click(object sender, EventArgs e)
        {

        }
        private void btnRuneTuner_Click(object sender, EventArgs e)
        {

        }
        //Hover To Show Base Stats + Bonus Stats
        private void lblHealth_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblHealthRegen_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblMana_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblManaRegen_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblArmor_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblMagicResist_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblAttackDamage_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblAttackSpeed_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblAbilityPower_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblAbilityHaste_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblLifeSteal_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblOmnivamp_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblMovementSpeed_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblArmorPenetrationPercent_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblLethality_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblMagicPenetrationPercent_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblMagicPenetrationFlat_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblHealShieldPower_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblCriticalStrikeChance_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblCriticalStrikeDamage_MouseHover(object sender, EventArgs e)
        {

        }

        //Abilities & Items Calculations Group Box
        private void rbtnStats_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnScaling_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnPassive_Click(object sender, EventArgs e)
        {

        }

        private void btnQ_Click(object sender, EventArgs e)
        {

        }

        private void btnW_Click(object sender, EventArgs e)
        {

        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {

        }

       
    }
}
