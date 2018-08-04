using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPathListExist
{
    public partial class Form1 : Form
    {
        private string m_ValidPathList = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessRawInput()
        {
            if (tbRaw.Text != string.Empty)
            {
                string Temp = tbRaw.Text.Split('"','"')[1];
                if (Temp != string.Empty && tbSplit.Text != string.Empty)
                {
                    string[] sListPathTemp = Temp.Split(tbSplit.Text[0]);
                    if (sListPathTemp != null)
                    {
                        rtbInput.Text = string.Empty;
                        foreach (string elementPath in sListPathTemp)
                        {
                            if (elementPath != string.Empty)
                            {
                                rtbInput.Text += elementPath + "\n";
                            }
                        }
                    }
                }
            }
        }

        private string[] ProcessPathListInput()
        {
            string[] sRet = null;
            if (rtbInput.Text != string.Empty)
            {
                sRet = rtbInput.Text.Split('\n');
                Array.Sort(sRet);
            }
            return sRet;
        }

        private bool CheckPathExist(string sPath)
        {
            bool bRet = false;

            if (tbOriginalPath.Text != string.Empty)
            {
                if (Directory.Exists(tbOriginalPath.Text) == true)
                {
                    string sFullPath = tbOriginalPath.Text + "//" +  sPath;
                    if(File.Exists(sFullPath)) 
                    {
                        bRet = true;
                    }               
                    else if(Directory.Exists(sFullPath)) 
                    {
                        bRet = true;
                    }
                }
            }

            return bRet;
        }
        
        private void btClear_Click(object sender, EventArgs e)
        {
            rtbInput.Text = string.Empty;
            rtbOutput.Text = string.Empty;
        }

        private void btProcess_Click(object sender, EventArgs e)
        {
            ProcessRawInput();

            string[] sPathCheckList = ProcessPathListInput(); uint uiTotal = 0;
            string sValidList = null; uint uiValidNumber = 0;
            string sInvalidList = null; uint uiInvalidNumber = 0;

            if (sPathCheckList != null && sPathCheckList.Length > 0)
            {
                foreach (string elementPath in sPathCheckList)
                {
                    if (elementPath != string.Empty)
                    {
                        if (CheckPathExist(elementPath) == true)
                        {
                            sValidList += elementPath + "\n"; uiValidNumber++;
                            m_ValidPathList = sValidList;
                        }
                        else
                        {
                            sInvalidList += elementPath + "\n"; uiInvalidNumber++;
                        }
                        uiTotal++;
                    }
                }

                rtbOutput.Text = "Total: " + (sPathCheckList != null ? sPathCheckList.Length.ToString() : "");

                rtbOutput.Text += "\n========================================\n";
                rtbOutput.Text += "Valid Path List:" + uiValidNumber.ToString() + "\n";
                rtbOutput.Text += sValidList;

                rtbOutput.Text += "\n========================================\n";
                rtbOutput.Text += "Invalid Path List" + uiInvalidNumber.ToString() + "\n";
                rtbOutput.Text += sInvalidList;

            }
            else
            {
                rtbOutput.Text = "Invalid info detected !";
            }
        }

        private void btCopyResult_Click(object sender, EventArgs e)
        {
            if (rtbOutput.Text != string.Empty)
            {
                Clipboard.SetText(rtbOutput.Text);
            }
        }

        private void btCopyInFormat_Click(object sender, EventArgs e)
        {
            if (tbFormat.Text != string.Empty && m_ValidPathList != string.Empty)
            {
                if (tbFormat.Text.Contains("{0}"))
                {
                    try
                    {
                        string sResult = null;
                        string sFormatValidPathList = m_ValidPathList.Replace("\n", "|");
                        sFormatValidPathList = sFormatValidPathList.TrimEnd('|');

                        sResult = string.Format(tbFormat.Text, sFormatValidPathList);
                        Clipboard.SetText(sResult);
                    }
                    catch { MessageBox.Show("Error !");}
                }
            }
        }

        private void btClearRaw_Click(object sender, EventArgs e)
        {
            tbRaw.Text = string.Empty;
        }
    }
}
