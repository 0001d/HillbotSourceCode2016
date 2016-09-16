/* ///////////////////////////////////////////////////////////////////////////////////////////////////////
 * Title:       Hillbot Programming
 * 
 * Desc:        The actual source code for Hillbots (Hillary Supporters)
 * Version:     2016 Campaign (upgraded from version 2008)
 * Owners:      George Soros, Saudi Royal Family, Wall Street, various Clinton Foundation contributors.
 * Reference:   https://www.hillaryclinton.com/ http://www.cnn.com/ MSM, etc.
 * Copyright:   2016 (c)
 * Author:      Yeah right. I like breathing.
 * Special thanks to contributors:  Henry Kissinger, Barack Obama, and FBI for nixing the indictment.
 * 
 * */
////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HillBotSourceCode2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            bool control = (2 + 2 == 5);

            string HilQuestion = textBox1.Text.ToString();
            if (HilQuestion.IndexOf("clinton foundation", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "You need to do more research.  The Clinton Foundation is a great organization, " +
                    "and they only do good work.  To say otherwise is extreme sexism.";
            }
            else if ((HilQuestion.IndexOf("cnn", StringComparison.CurrentCultureIgnoreCase) >= 0) || 
                (HilQuestion.IndexOf("msnbc", StringComparison.CurrentCultureIgnoreCase) >= 0) ||
                (HilQuestion.IndexOf("media", StringComparison.CurrentCultureIgnoreCase) >= 0) ||
                (HilQuestion.IndexOf("msm", StringComparison.CurrentCultureIgnoreCase) >= 0))
            {
                labelOutput.Text = "ACTUALLY, the media has been very critical of Hillary and it's mean. " +
                    "By the way, you are sexist.";
            }
            else if ((HilQuestion.IndexOf("bernie", StringComparison.CurrentCultureIgnoreCase) >= 0) ||
                (HilQuestion.IndexOf("sanders", StringComparison.CurrentCultureIgnoreCase) >= 0))
            {
                labelOutput.Text = "Berniebros.  So sick of Berniebros being mean with all their facts." +
                    "They are sooooooooooo sexist.";
            }
            else if (HilQuestion.IndexOf("trump", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "Misogynist.  Just stop.  Deplorables.  Can't even.  I get allergic." +
                    "";
            }
            else if (HilQuestion.IndexOf("debbie", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "Great woman and a DNC hero.  She didn't rig anything.  You are so sexist." +
                    "";
            }
            else if ((HilQuestion.IndexOf("sick", StringComparison.CurrentCultureIgnoreCase) >= 0) || 
                (HilQuestion.IndexOf("health", StringComparison.CurrentCultureIgnoreCase) >= 0) )
            {
                labelOutput.Text = "HILLARY CLINTON IS NOT SICK.  YOU ARE SICK IN THE MIND AND" +
                    "ONE THE DEPLORABLE ANTI-CLINTON SEXISTS WHO CANNOT HANDLE A STRONG WOMAN.";
            }
            else if (HilQuestion.IndexOf("health care", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "Hillary was an innovator back when she wanted healthcare in the 90's.  " + 
                    "The fact that she reneged once she was bought by the health industry, is of no consequence.";
            }
            else if (HilQuestion.IndexOf("am i sexist", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "Yes." +
                    "";
            }
            else if (HilQuestion.IndexOf("dnc", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "Look.  The DNC is extremely fair and impartial.  They didn't rig the primary " +
                    "and didn't collude with the media to hide Clinton's faults.  To allude otherwise would be sexist.";
            }
            else if (HilQuestion.IndexOf("wall", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "Who cares about those speeches??? She isn't beholden to those bankers and speaks for us. " +
                    "Do you really want a Trump presidency!!!!???";
            }
            else if (HilQuestion.IndexOf("corporat", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                labelOutput.Text = "We must do everything to defeat Trump!" +
                    "Do you really want a Trump presidency!!!!???";
            }



            else
            {
                // If someone criticizes Hillary, and you don't understand it, 
                // you dislike their point, 
                // or can't think of anything, 
                // ALWAYS DEFAULT TO SEXISM ACCUSATION!
                if ((HilQuestion.Length > 5) && (HilQuestion.Length < 10))
                {
                    labelOutput.Text = "You are sexist.";
                }
                else if ((HilQuestion.Length >= 10) && (HilQuestion.Length < 15))
                {
                    labelOutput.Text = "OMG Shut up.  You are so sexist.";
                }
                else if ((HilQuestion.Length >= 15) && (HilQuestion.Length < 20))
                {
                    labelOutput.Text = "Does Trump have you on his payroll???  You are SEXIST.";
                }
                else if ((HilQuestion.Length >= 20) && (HilQuestion.Length < 25))
                {
                    labelOutput.Text = "You are SO DEPLORABLE.  You are SEXIST, RACIST, XENOPHOBIC, HOMOPHOBIC...";
                }
                else if (HilQuestion.Length >= 25)
                {
                    labelOutput.Text = "SHE WILL BE THE FIRST WOMAN PRESIDENT REGARDLESS OF YOUR EXTREME SEXISM, " +
                        "RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, SEXISM, RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, " + 
                        "RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, SEXISM, RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, " +
                        "RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, SEXISM, RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, " +
                        "RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, SEXISM, RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, " +
                        "RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, SEXISM, RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, " +
                        "RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC, SEXISM, RACISM, XENOPHOBIA, TRANSPHOBIC, HOMOPHOBIC... " ;
                }

            }


        }
    }
}
