using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;

namespace OrpheusManager
{
    public partial class mPortrait : Form
    {
        int oldPortrait = CDATA.cPortrait;

        public mPortrait()
        {
            InitializeComponent();
        }

        private void mPortrait_Load(object sender, EventArgs e)
        {
            reloadArch();
        }

        // Reload Archetype Image
        // IF MODIFIED, COPY TO [CharacterSheet.cs]
        private void reloadArch()
        {
            // Mitch
            if (((CDATA.cName == "Mitch Hook" || CDATA.cName == "Mitchell Hook" || CDATA.cName == "Mitch") && CDATA.cPortrait == 0) 
                || CDATA.cPortrait == 16)
            {
                System.Reflection.Assembly myAssemblyMitch = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamMitch = myAssemblyMitch.GetManifestResourceStream("OrpheusManager.archetypeMitch.png");
                Bitmap imageMitch = new Bitmap(myStreamMitch);
                archetypePic.Image = imageMitch;
            }
            // Pierce
            else if (((CDATA.cName == "Pierce Keswick" || CDATA.cName == "Pierce") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 17)
            {
                System.Reflection.Assembly myAssemblyPierce = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamPierce = myAssemblyPierce.GetManifestResourceStream("OrpheusManager.archetypePierce.png");
                Bitmap imagePierce = new Bitmap(myStreamPierce);
                archetypePic.Image = imagePierce;
            }
            // Pierce Keswick, Corrupted
            else if (CDATA.cPortrait == 18)
            {
                System.Reflection.Assembly myAssemblyPierceCorrupted = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamPierceCorrupted = myAssemblyPierceCorrupted.GetManifestResourceStream("OrpheusManager.archetypePierceCorrupted.png");
                Bitmap imagePierceCorrupted = new Bitmap(myStreamPierceCorrupted);
                archetypePic.Image = imagePierceCorrupted;
            }
            // Keira
            else if (((CDATA.cName == "Kiera Jackson" || CDATA.cName == "Kiera") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 19)
            {
                System.Reflection.Assembly myAssemblyKiera = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamKiera = myAssemblyKiera.GetManifestResourceStream("OrpheusManager.archetypeKiera.png");
                Bitmap imageKiera = new Bitmap(myStreamKiera);
                archetypePic.Image = imageKiera;
            }
            // Hermetic Magician
            else if (((CDATA.cArch1 == "Hermetic Magician") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 1)
            {
                System.Reflection.Assembly myAssemblyHermetic = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamHermetic = myAssemblyHermetic.GetManifestResourceStream("OrpheusManager.archetypeHermetic.png");
                Bitmap imageHermetic = new Bitmap(myStreamHermetic);
                archetypePic.Image = imageHermetic;
            }
            // Witch
            else if (((CDATA.cArch1 == "Witch") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 2)
            {
                System.Reflection.Assembly myAssemblyWitch = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamWitch = myAssemblyWitch.GetManifestResourceStream("OrpheusManager.archetypeWitch.png");
                Bitmap imageWitch = new Bitmap(myStreamWitch);
                archetypePic.Image = imageWitch;
            }
            // Psychic
            else if (((CDATA.cArch1 == "Psychic") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 3)
            {
                System.Reflection.Assembly myAssemblyPsychic = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamPsychic = myAssemblyPsychic.GetManifestResourceStream("OrpheusManager.archetypePsychic.png");
                Bitmap imagePsychic = new Bitmap(myStreamPsychic);
                archetypePic.Image = imagePsychic;
            }
            // Weapon Bearer
            else if (((CDATA.cArch1 == "Weapon Bearer") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 4)
            {
                System.Reflection.Assembly myAssemblyWeapon = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamWeapon = myAssemblyWeapon.GetManifestResourceStream("OrpheusManager.archetypeWeapon.png");
                Bitmap imageWeapon = new Bitmap(myStreamWeapon);
                archetypePic.Image = imageWeapon;
            }
            // Occultist
            else if (((CDATA.cArch1 == "Occultist") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 5)
            {
                System.Reflection.Assembly myAssemblyOccultist = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamOccultist = myAssemblyOccultist.GetManifestResourceStream("OrpheusManager.archetypeOccultist.png");
                Bitmap imageOccultist = new Bitmap(myStreamOccultist);
                archetypePic.Image = imageOccultist;
            }
            // Cyborg
            else if (((CDATA.cArch1 == "Cyborg") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 6)
            {
                System.Reflection.Assembly myAssemblyCyborg = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamCyborg = myAssemblyCyborg.GetManifestResourceStream("OrpheusManager.archetypeCyborg.png");
                Bitmap imageCyborg = new Bitmap(myStreamCyborg);
                archetypePic.Image = imageCyborg;
            }
            // Wendigo
            else if (((CDATA.cArch1 == "Wendigo") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 7)
            {
                System.Reflection.Assembly myAssemblyWendigo = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamWendigo = myAssemblyWendigo.GetManifestResourceStream("OrpheusManager.archetypeWendigo.png");
                Bitmap imageWendigo = new Bitmap(myStreamWendigo);
                archetypePic.Image = imageWendigo;
            }
            // Telekinetic
            else if (((CDATA.cArch1 == "Telekinetic") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 8)
            {
                System.Reflection.Assembly myAssemblyTelekinetic = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamTelekinetic = myAssemblyTelekinetic.GetManifestResourceStream("OrpheusManager.archetypeTelekinetic.png");
                Bitmap imageTelekinetic = new Bitmap(myStreamTelekinetic);
                archetypePic.Image = imageTelekinetic;
            }
            // Werewolf
            else if (((CDATA.cArch1 == "Werewolf") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 9)
            {
                System.Reflection.Assembly myAssemblyWerewolf = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamWerewolf = myAssemblyWerewolf.GetManifestResourceStream("OrpheusManager.archetypeWerewolf.png");
                Bitmap imageWerewolf = new Bitmap(myStreamWerewolf);
                archetypePic.Image = imageWerewolf;
            }
            // True Faith
            else if (((CDATA.cArch1 == "True Faith") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 10)
            {
                System.Reflection.Assembly myAssemblyTrueFaith = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamTrueFaith = myAssemblyTrueFaith.GetManifestResourceStream("OrpheusManager.archetypeTrueFaith.png");
                Bitmap imageTrueFaith = new Bitmap(myStreamTrueFaith);
                archetypePic.Image = imageTrueFaith;
            }
            // Medium
            else if (((CDATA.cArch1 == "Medium") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 11)
            {
                System.Reflection.Assembly myAssemblyMedium = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamMedium = myAssemblyMedium.GetManifestResourceStream("OrpheusManager.archetypeMedium.png");
                Bitmap imageMedium = new Bitmap(myStreamMedium);
                archetypePic.Image = imageMedium;
            }
            // Soldier
            else if (((CDATA.cArch1 == "Soldier") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 12)
            {
                System.Reflection.Assembly myAssemblySoldier = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamSoldier = myAssemblySoldier.GetManifestResourceStream("OrpheusManager.archetypeSoldier.png");
                Bitmap imageSoldier = new Bitmap(myStreamSoldier);
                archetypePic.Image = imageSoldier;
            }
            // Vampire Thrall
            else if (((CDATA.cArch1 == "Vampire Thrall") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 13)
            {
                System.Reflection.Assembly myAssemblyVampire = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamVampire = myAssemblyVampire.GetManifestResourceStream("OrpheusManager.archetypeVampire.png");
                Bitmap imageVampire = new Bitmap(myStreamVampire);
                archetypePic.Image = imageVampire;
            }
            // Pathokinetic
            else if (((CDATA.cArch1 == "Pathokinetic") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 14)
            {
                System.Reflection.Assembly myAssemblyPathokinetic = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamPathokinetic = myAssemblyPathokinetic.GetManifestResourceStream("OrpheusManager.archetypePathokinetic.png");
                Bitmap imagePathokinetic = new Bitmap(myStreamPathokinetic);
                archetypePic.Image = imagePathokinetic;
            }
            // Hero
            else if (((CDATA.cArch1 == "Hero") && CDATA.cPortrait == 0)
                || CDATA.cPortrait == 15)
            {
                System.Reflection.Assembly myAssemblyHero = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamHero = myAssemblyHero.GetManifestResourceStream("OrpheusManager.archetypeHero.png");
                Bitmap imageHero = new Bitmap(myStreamHero);
                archetypePic.Image = imageHero;
            }
            // Default
            else
            {
                System.Reflection.Assembly myAssemblyWitch = System.Reflection.Assembly.GetExecutingAssembly();
                Stream myStreamWitch = myAssemblyWitch.GetManifestResourceStream("OrpheusManager.archetypeWitch.png");
                Bitmap imageWitch = new Bitmap(myStreamWitch);
                archetypePic.Image = imageWitch;
            }
        }

        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nCharCancel_Click(object sender, EventArgs e)
        {
            CDATA.cPortrait = oldPortrait;
            this.Close();
        }

        private void nCharArch1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CDATA.cPortrait = nCharArch1.SelectedIndex;
            reloadArch();
        }
    }
}
