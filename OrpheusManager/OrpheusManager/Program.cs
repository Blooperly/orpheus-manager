using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;

namespace OrpheusManager
{
    public static class CDATA
    {
        public static byte version = 0x01;
        public static string gameVersion = "The ORPHEUS Protocol v2.1.2";
        public static string cName = "Rodrigo Ledesma";
        public static int cLevel = 0;
        public static string cArch1 = "Weapon Bearer";
        public static string cArch2 = "Wendigo";
        public static string cArch3 = "";
        public static string cBackground = "Criminal";
        public static int[] cAttributes = { 2, 0, 4, 2, 3, 3 };         // PER, COG, DEX, VIT, CHAR, WILL
        public static int[] cAttributesTemp = { 0, 0, 0, 0, 0, 0 };
        public static string cMot1 = "Uniting Force";
        public static string cMot2 = "Lady Killer";
        public static string cMot3 = "Death Wish";


        public static string[] cSkillName = { "Intimidation", "Presence", "Athletics", "Deception", "Cont. (Underworld)", "Security", "Sleight of Hand", "Empathy", "Investigation", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        public static string[] cSkillRank = { "V", "V", "III", "III", "II", "II", "I", "I", "I", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        public static string[] cCkillName = { "Rang. Att. (Pistols)", "Stealth", "Stability", "Dodge", "Discipline", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        public static string[] cCkillRank = { "V", "V", "III", "III", "I", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        public static string[] cAbilityName = { "Inspiration", "Hungry Shadows", "", "", "", "", "", "", "", "", "", "" };
        public static string[] cAbilityRank = { "II", "I", "", "", "", "", "", "", "", "", "", "" };

        public static void addSkill()
        {
            bool full = false;
            int loc = 0;
            if (EDATA.eSkillType == 0)
            {
                for (int i = 0; i < 22; i++)
                {
                    if (cSkillName[i] == "") { loc = i; break; }
                    if (i == 21) full = true;
                }
                if (!full)
                {
                    cSkillName[loc] = EDATA.eSkillName;
                    cSkillRank[loc] = EDATA.eSkillRank;
                }
            }
            else if (EDATA.eSkillType == 1)
            {
                for (int i = 0; i < 22; i++)
                {
                    if (cCkillName[i] == "") { loc = i; break; }
                    if (i == 21) full = true;
                }
                if (!full)
                {
                    cCkillName[loc] = EDATA.eSkillName;
                    cCkillRank[loc] = EDATA.eSkillRank;
                }
            }
        }

        public static void addAbility()
        {
            bool full = false;
            int loc = 0;

            for (int i = 0; i < 12; i++)
            {
                if (cAbilityName[i] == "") { loc = i; break; }
                if (i == 11) full = true;
            }
            if (!full)
            {
                cAbilityName[loc] = EDATA.eAbilityName;
                cAbilityRank[loc] = EDATA.eAbilityRank;
            }
        }
    }

    public static class DDATA
    {
        public static void deriveDATA()
        {
            DDATA.dMeleeAtt = ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2);
            DDATA.dRangedAtt = ((CDATA.cAttributes[2] + CDATA.cAttributes[0]) / 2);
            DDATA.dSpeed = ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2);

            DDATA.dMeleeAttTemp = CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[3];
            DDATA.dRangedAttTemp = CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[0];
            DDATA.dSpeedTemp = CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[3];

            if (CDATA.cAttributes[1] >= 5) DDATA.dClarity = 2;
            else if (CDATA.cAttributes[1] >= 3) DDATA.dClarity = 1;
            else DDATA.dClarity = 0;

            DDATA.dClarityTemp = CDATA.cAttributesTemp[1];

            if (CDATA.cAttributes[3] >= 5) DDATA.dToughness = 2;
            else if (CDATA.cAttributes[3] >= 3) DDATA.dToughness = 1;
            else DDATA.dToughness = 0;

            DDATA.dToughnessTemp = CDATA.cAttributesTemp[3];

            if (CDATA.cAttributes[5] >= 5) DDATA.dForceOfWill = 2;
            else if (CDATA.cAttributes[5] >= 3) DDATA.dForceOfWill = 1;
            else DDATA.dForceOfWill = 0;

            DDATA.dForceOfWillTemp = CDATA.cAttributesTemp[5];

            int temp1;
            int temp2;
            int temp3;

            temp1 = CDATA.cAttributes[2] + CDATA.cAttributesTemp[2] + CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] + dClarity;
            temp2 = CDATA.cAttributes[0] + CDATA.cAttributesTemp[0] + CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] + dClarity;
            temp3 = CDATA.cAttributes[0] + CDATA.cAttributesTemp[0] + CDATA.cAttributes[2] + CDATA.cAttributesTemp[2] + dClarity;


            if (temp1 >= temp2 && temp1 >= temp3)
            {
                DDATA.dInitiative = CDATA.cAttributes[2] + CDATA.cAttributes[5] + dClarity;
                DDATA.dInitiativeTemp = CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[5];
            }
            else if (temp2 >= temp1 && temp2 >= temp3)
            {
                DDATA.dInitiative = CDATA.cAttributes[0] + CDATA.cAttributes[5] + dClarity;
                DDATA.dInitiativeTemp = CDATA.cAttributesTemp[0] + CDATA.cAttributesTemp[5];
            }
            else
            {
                DDATA.dInitiative = CDATA.cAttributes[0] + CDATA.cAttributes[2] + dClarity;
                DDATA.dInitiativeTemp = CDATA.cAttributesTemp[0] + CDATA.cAttributesTemp[2];
            }

            dMentalStrainMax = CDATA.cAttributes[0] + (3 * CDATA.cAttributes[1]);
            dPhysicalStrainMax = CDATA.cAttributes[2] + (3 * CDATA.cAttributes[3]);
            dSpiritualStrainMax = CDATA.cAttributes[4] + (3 * CDATA.cAttributes[5]);
        }

        public static int dMeleeAtt = 0;
        public static int dRangedAtt = 0;
        public static int dSpeed = 0;
        public static int dClarity = 0;
        public static int dToughness = 0;
        public static int dForceOfWill = 0;
        public static int dInitiative = 0;
        public static int dMentalStrainMax = 0;
        public static int dPhysicalStrainMax = 0;
        public static int dSpiritualStrainMax = 0;

        public static int dMeleeAttTemp = 0;
        public static int dRangedAttTemp = 0;
        public static int dSpeedTemp = 0;
        public static int dClarityTemp = 0;
        public static int dToughnessTemp = 0;
        public static int dForceOfWillTemp = 0;
        public static int dInitiativeTemp = 0;
    }

    public static class EDATA
    {
        public static int eSkillType = 0;
        public static string eSkillName = "";
        public static string eSkillRank = "";

        public static string eAbilityName = "";
        public static string eAbilityRank = "";
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharacterSheet());
        }
    }
}
