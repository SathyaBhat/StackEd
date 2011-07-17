﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StackEd
{
    public partial class StackEd : Form
    {
        public string case_correction = "lower";

        public StackEd()
        {
            InitializeComponent();
           
        }

        private void StackEd_Load(object sender, EventArgs e)
        {

        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
             string content;
         
            if (txtContent.SelectedText.Equals(""))
            {
                content = txtContent.Text;
               
            }
            else
            {
                content = txtContent.SelectedText;
            }

            stsLogLabel.Text = stsLogLabel.Text + ' ' + content;
            switch (case_correction)
            {
                case "lower":
                    content = convert_to_lower(content);
                    case_correction = "title";
                    break;
                case "title":
                    content = convert_to_titlecase(content);
                    case_correction = "upper";
                    break;
                case "upper":
                   content =  convert_to_upper(content);
                    case_correction = "lower";
                    break;
                
            }
            stsLogLabel.Text = stsLogLabel.Text + ' ' + content;
            stsLogLabel.Text = stsLogLabel.Text + ' ' + case_correction;

            if (txtContent.SelectedText.Equals(""))
            {
                txtContent.Text = content;

            }
            else
            {
                txtContent.SelectedText = content;
            }
        }

        private string convert_to_lower(string text_content)
        {
            string l_text;
            l_text = text_content.ToLower(); 
            return l_text;

            
        }

        private string convert_to_upper(string text_content)
        {
            string u_text;
            u_text = text_content.ToUpper();
            return u_text;
        }

        private string convert_to_titlecase(string text_content)
        {
            string tc_text;
            System.Globalization.CultureInfo cultureInfo =  System.Threading.Thread.CurrentThread.CurrentCulture;  
            System.Globalization.TextInfo TextInfo = cultureInfo.TextInfo;
            tc_text = TextInfo.ToTitleCase(text_content);
            return tc_text;
        }

        private void auto_fix()
        {
            string words_list;
      //      string words_list_regex;
            List<string> words = new List<string>(new string[] 
            {
          "AMD", "AppleScript", "ASUS", "ATI", "Bluetooth", "DivX", "DVD", "Eee PC", "FireWire",
         "GarageBand", "GHz", "iBookstore", "iCal", "iChat", "iLife", "iMac", "iMovie", "iOS", "iPad",
         "iPhone", "iPhoto", "iPod", "iTunes", "iWeb", "iWork", "JavaScript", "jQuery", "Lenovo", 
         "MacBook", "MacPorts", "MHz", "Microsoft", "MobileMe", "MySQL", "Nvidia", "OS X", "PowerBook", "PowerPoint",
         "QuickTime", "SSD", "TextEdit", "TextMate", "ThinkPad", "USB", "Vista", "VMware", "WebKit", "Wi-Fi",
         "Windows XP", "Windows 7", "WordPress", "Xcode", "XMLHttpRequest", "Xserve"
            }

    );
            words_list = string.Join("|", words.ToArray());
            // words_list_regex = "\b(?:(" + words_list + "))\b";
            Regex words_list_regex = new Regex("\b(?:(" + words_list + "))\b");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bur\b", "your");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bi( |')","I$1");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bi ?m\b","I'm");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bu\b","you");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bur\b", "your");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bcud\b", "could");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bb4\b", "before", RegexOptions.IgnoreCase);
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bpl[sz]\b", "please", RegexOptions.IgnoreCase);
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bwin7\b", "Windows 7");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\bwinxp\b", "Windows XP");
            txtContent.Text = Regex.Replace(txtContent.Text, @"\b(can|doesn|won|hasn|isn|didn)t\b", "$1't", RegexOptions.IgnoreCase);
            txtContent.Text = Regex.Replace(txtContent.Text, @"\b(a)n(?= +(?![aeiou]|HTML|user))", "$1", RegexOptions.IgnoreCase);
            txtContent.Text = Regex.Replace(txtContent.Text, @"\b(a)(?= +[aeiou](?!ser))", "$1n", RegexOptions.IgnoreCase);
            txtContent.Text = Regex.Replace(txtContent.Text, @"\b(a)lot", "$1 lot", RegexOptions.IgnoreCase);
            txtContent.Text = Regex.Replace(txtContent.Text, @"^(thx|thanks?|cheers|thanx|tia)\s?((in advance)|you)?[\.\!\,]*", "", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            txtContent.Text = Regex.Replace(txtContent.Text, @"[ ]*\.( ?\.)+ *", ". ", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            txtContent.Text = Regex.Replace(txtContent.Text, @"[ ]*([\?\!] ?)+ *", "$1 ", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            txtContent.Text = Regex.Replace(txtContent.Text, @"e\.? *G\.?\,? +(.)","_",RegexOptions.IgnoreCase);
       //  txtContent.Text = Regex.Replace(txtContent.Text, words_list_regex, "$1".ToUpper(), RegexOptions.IgnoreCase);

           /*
            if (Regex.IsMatch(txtContent.Text,  words_list_regex))
            {
                MessageBox.Show("hello");

            }
            */
        }

        private void btnAutoCorrect_Click(object sender, EventArgs e)
        {
            auto_fix();
        }

        private void txtContent_KeyUp(object sender, KeyEventArgs e)
        {
            if ( e.Control ) 
            {
                switch (e.KeyCode)
                {
                    case ( Keys.A ):
                        txtContent.SelectAll();
                        break;
                    
                    case ( Keys.C):
                        txtContent.Copy();
                        break;

                   

                }

                

            }
        }
    }
}
