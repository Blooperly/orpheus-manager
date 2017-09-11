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
        public static string cName = "Larry Talbott";
        public static int cLevel = 0;
        public static string cArch1 = "Werewolf";
        public static string cArch2 = "";
        public static string cArch3 = "";
        public static int[] cAttributes = { 2, 2, 3, 4, 2, 2 };         // PER, COG, DEX, VIT, CHAR, WILL
        public static int[] cAttributesTemp = { 0, 0, 0, 0, 0, 0 };
        public static string cMot1 = "Loyalty to his crew";
        public static string cMot2 = "Not afraid to get dirty";
        public static string cMot3 = "Will do anything for his $";
    }

    public static class DDATA
    {
        public static void deriveDATA()
        {
            DDATA.dMeleeAtt = ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2) + CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[3];
            DDATA.dRangedAtt = ((CDATA.cAttributes[2] + CDATA.cAttributes[0]) / 2) + CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[0];
            DDATA.dSpeed = ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2) + CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[3];

            if (CDATA.cAttributes[1] >= 5) DDATA.dClarity = 2 + CDATA.cAttributesTemp[1];
            else if (CDATA.cAttributes[1] >= 3) DDATA.dClarity = 1 + CDATA.cAttributesTemp[1];
            else DDATA.dClarity = 0 + CDATA.cAttributesTemp[1];

            if (CDATA.cAttributes[3] >= 5) DDATA.dToughness = 2 + CDATA.cAttributesTemp[3];
            else if (CDATA.cAttributes[3] >= 3) DDATA.dToughness = 1 + CDATA.cAttributesTemp[3];
            else DDATA.dToughness = 0 + CDATA.cAttributesTemp[3];

            if (CDATA.cAttributes[5] >= 5) DDATA.dForceOfWill = 2 + CDATA.cAttributesTemp[5];
            else if (CDATA.cAttributes[5] >= 3) DDATA.dForceOfWill = 1 + CDATA.cAttributesTemp[5];
            else DDATA.dForceOfWill = 0 + CDATA.cAttributesTemp[5];

            int temp1;
            int temp2;
            int temp3;

            temp1 = CDATA.cAttributes[2] + CDATA.cAttributesTemp[2] + CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] + dClarity;
            temp2 = CDATA.cAttributes[0] + CDATA.cAttributesTemp[0] + CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] + dClarity;
            temp3 = CDATA.cAttributes[0] + CDATA.cAttributesTemp[0] + CDATA.cAttributes[2] + CDATA.cAttributesTemp[2] + dClarity;


            if(temp1 >= temp2 && temp1 >= temp3) DDATA.dInitiative = temp1;
            else if (temp2 >= temp1 && temp2 >= temp3) DDATA.dInitiative = temp2;
            else DDATA.dInitiative = temp3;

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
