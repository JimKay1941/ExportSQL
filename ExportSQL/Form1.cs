using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ExportSQL
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _chooseOutputFullFarEast = new OpenFileDialog();
        private readonly OpenFileDialog _chooseOutputCharBopo = new OpenFileDialog();
        private readonly OpenFileDialog _chooseOutputPinBopo = new OpenFileDialog();
        private readonly OpenFileDialog _chooseOutputPinMypin = new OpenFileDialog();
        private readonly OpenFileDialog _chooseOutputCeDict = new OpenFileDialog();
        private readonly OpenFileDialog _chooseOutput_3000 = new OpenFileDialog();
        private readonly OpenFileDialog _chooseOutputCharBopoPinCrit = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            _chooseOutputFullFarEast.FileOk += OnOutputFullFarEastDialogOk;
            _chooseOutputCharBopo.FileOk += OnOutputCharBopoDialogOk;
            _chooseOutputPinBopo.FileOk += OnOutputPinBopoDialogOk;
            _chooseOutputPinMypin.FileOk += OnOutputPinMypinDialogOk;
            _chooseOutputCeDict.FileOk += OnOutputCeDictDialogOk;
            _chooseOutput_3000.FileOk += OnOutput_3000DialogOk;
            _chooseOutputCharBopoPinCrit.FileOk += OnOutputCharBopoDialogOk;
        }

        private void OnOutputFullFarEastDialogOk(object sender, CancelEventArgs e)
        {
            OutputFullFarEastName.Text = _chooseOutputFullFarEast.FileName;
        }

        private void OnOutputCharBopoDialogOk(object sender, CancelEventArgs e)
        {
            OutputCharBopoName.Text = _chooseOutputCharBopo.FileName;
        }

        private void OnOutputPinBopoDialogOk(object sender, CancelEventArgs e)
        {
            OutputPinBopoName.Text = _chooseOutputPinBopo.FileName;
        }

        private void OnOutputPinMypinDialogOk(object sender, CancelEventArgs e)
        {
            OutputPinMypinName.Text = _chooseOutputPinMypin.FileName;
        }

        private void OnOutputCeDictDialogOk(object sender, CancelEventArgs e)
        {
            OutputCeDictName.Text = _chooseOutputCeDict.FileName;
        }

        private void OnOutput_3000DialogOk(object sender, CancelEventArgs e)
        {
            Output_3000_Name.Text = _chooseOutput_3000.FileName;
        }

        private void OnOutputCharBopoPinCritDialogOk(object sender, CancelEventArgs e)
        {
            Output_3000_Name.Text = _chooseOutput_3000.FileName;
        }

        private void ChooseFullFareast_Click(object sender, EventArgs e)
        {
            _chooseOutputFullFarEast.ShowDialog();
        }

        private void ChooseCharBopo_Click(object sender, EventArgs e)
        {
            _chooseOutputCharBopo.ShowDialog();
        }

        private void ChoosePinBopo_Click(object sender, EventArgs e)
        {
            _chooseOutputPinBopo.ShowDialog();
        }

        private void ChoosePinMypin_Click(object sender, EventArgs e)
        {
            _chooseOutputPinMypin.ShowDialog();
        }

        private void ChooseCeDict_Click(object sender, EventArgs e)
        {
            _chooseOutputCeDict.ShowDialog();
        }

        private void Choose_3000(object sender, EventArgs e)
        {
            _chooseOutput_3000.ShowDialog();
        }

        private void ChooseCharBopoPinCrit(object sender, EventArgs e)
        {
            _chooseOutputCharBopoPinCrit.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioACER0.Checked)
            {
                Properties.Settings.Default.ActiveSQL = Properties.Settings.Default.acer0;
                SetFolders("ACER0");
            }

            if (radioAMAZON1.Checked)
            {
                Properties.Settings.Default.ActiveSQL = Properties.Settings.Default.amazon1;
                SetFolders("AMAZON1");
            }

            if (radioBAX2ZAONV6.Checked)
            {
                Properties.Settings.Default.ActiveSQL = Properties.Settings.Default.bax2zaonv6;
                SetFolders("BAX2ZAONV6");
            }

            if (chkCharBopo.Checked)
            {
                FileStream writing1 = new FileStream(OutputCharBopoName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter outputLine1 = new StreamWriter(writing1, Encoding.UTF8);
                string fileLine1 = "ID\tChar\tBopo\tCji";
                outputLine1.WriteLine(fileLine1);

                using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var myChars = from q in myChineseStudy.CharBopos
                                  orderby q.Char, q.Bopo
                                  select q;

                    foreach (var myChar in myChars)
                    {
                        fileLine1 = myChar.ID + "\t" + myChar.Char + "\t" + myChar.Bopo + "\t" + myChar.Cji;
                        outputLine1.WriteLine(fileLine1);
                    }
                }

                outputLine1.Close(); 
            }

            if (chkPinBopo.Checked)
            {
                FileStream writing2 = new FileStream(OutputPinBopoName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter outputLine2 = new StreamWriter(writing2, Encoding.UTF8);
                string fileLine2 = "ID\tPin\tBopo";
                outputLine2.WriteLine(fileLine2);

                using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var myBopos = from q in myChineseStudy.PinBopos
                                  orderby q.Bopo, q.Pin
                                  select q;

                    foreach (var myBopo in myBopos)
                    {
                        fileLine2 = myBopo.ID + "\t" + myBopo.Pin + "\t" + myBopo.Bopo;
                        outputLine2.WriteLine(fileLine2);
                    }
                }

                outputLine2.Close(); 
            }

            if (chkPinMypin.Checked)
            {
                FileStream writing3 = new FileStream(OutputPinMypinName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter outputLine3 = new StreamWriter(writing3, Encoding.UTF8);
                string fileLine3 = "ID\tPin\tMyPin";
                outputLine3.WriteLine(fileLine3);

                using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var myPins = from q in myChineseStudy.PinMypins
                                 orderby q.MyPin, q.Pin
                                 select q;

                    foreach (var mypin in myPins)
                    {
                        fileLine3 = mypin.ID + "\t" + mypin.Pin + "\t" + mypin.MyPin;
                        outputLine3.WriteLine(fileLine3);
                    }
                }

                outputLine3.Close(); 
            }

            if (chkFullFarEast.Checked)
            {
                FileStream writing4 = new FileStream(OutputFullFarEastName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter outputLine4 = new StreamWriter(writing4, Encoding.UTF8);
                string fileLine4 = "ID\tBopo\tChar\tFeNumber\tEnglish\tHex\tCji";
                outputLine4.WriteLine(fileLine4);

                using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var myFes = from q in myChineseStudy.FullFarEasts
                                orderby q.Char, q.Bopo
                                select q;

                    foreach (var myFe in myFes)
                    {
                        fileLine4 = myFe.ID.ToString();
                        fileLine4 += "\t";
                        fileLine4 += (String.IsNullOrEmpty(myFe.Bopo) ? " " : myFe.Bopo);
                        fileLine4 += "\t";
                        fileLine4 += myFe.Char;
                        fileLine4 += "\t";
                        fileLine4 += myFe.FeNumber ?? "0";
                        fileLine4 += "\t";
                        fileLine4 += (String.IsNullOrEmpty(myFe.English) ? " " : myFe.English);
                        fileLine4 += "\t";
                        fileLine4 += myFe.Hex;
                        fileLine4 += "\t";
                        fileLine4 += String.IsNullOrEmpty(myFe.Cji) ? " " : myFe.Cji;
                        outputLine4.WriteLine(fileLine4);
                    }
                }

                outputLine4.Close(); 
            }

                if (chkCeDict.Checked)
                {
                    FileStream writing5 = new FileStream(OutputCeDictName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    StreamWriter outputLine5 = new StreamWriter(writing5, Encoding.UTF8);
                    string fileLine5 = "ID\tBopo\tChar\tFeNumber\tEnglish\tHex\tCji";
                    outputLine5.WriteLine(fileLine5);

                    using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                    {
                        var myFes = from q in myChineseStudy.CeDicts
                                    orderby q.Char, q.Bopo
                                    select q;

                        foreach (var myFe in myFes)
                        {
                            fileLine5 = myFe.ID + "\t" + myFe.Bopo + "\t" + myFe.Char + "\t" + myFe.English + "\t" + myFe.Pinyin + "\t" + myFe.Hex;
                            outputLine5.WriteLine(fileLine5);
                        }
                    }

                    outputLine5.Close(); 
                }

            if (chk_3000_.Checked)
            {
                FileStream writing6 = new FileStream(Output_3000_Name.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter outputLine6 = new StreamWriter(writing6, Encoding.UTF8);
                string fileLine6 = "ID\tFEseq\tZhuyin\tTraditional\tEnglish\tNumPinyin\tCritPinyin\tSimplified\tCji";
                outputLine6.WriteLine(fileLine6);

                using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var my3000S = from q in myChineseStudy._3000_Characters
                                  orderby q.FEseq
                                  select q;

                    foreach (var my3000 in my3000S)
                    {
                        int fromFEseq;
                        var isInteger = int.TryParse(my3000.FEseq, out fromFEseq);
                        if (!isInteger)
                        {
                            textStatus.Text = "FEseq is non-integer; ID= " + my3000.ID + " FEseq = " + my3000.FEseq;
                            return;
                        }
                        fileLine6 = my3000.ID + "\t" + my3000.FEseq + "\t" + my3000.Zhuyin + "\t" + my3000.Traditional + "\t" + 
                            my3000.English + "\t" + my3000.NumPinyin + "\t" + my3000.CritPinyin + "\t" + my3000.Simplified + "\t" + my3000.Cji;
                        outputLine6.WriteLine(fileLine6);
                    }
                }

                outputLine6.Close();
            }

            if (chkPinBopo.Checked)
            {
                FileStream writing2 = new FileStream(OutputPinBopoName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter outputLine2 = new StreamWriter(writing2, Encoding.UTF8);
                string fileLine2 = "ID\tPin\tBopo";
                outputLine2.WriteLine(fileLine2);

                using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var myBopos = from q in myChineseStudy.PinBopos
                                  orderby q.Bopo, q.Pin
                                  select q;

                    foreach (var myBopo in myBopos)
                    {
                        fileLine2 = myBopo.ID + "\t" + myBopo.Pin + "\t" + myBopo.Bopo;
                        outputLine2.WriteLine(fileLine2);
                    }
                }

                outputLine2.Close();
            }

            if (chkCharBopoPinCrit.Checked)
            {
                FileStream writing7 = new FileStream(OutputCharBopoPinCrit_Name.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter outputline7 = new StreamWriter(writing7, Encoding.UTF8);
                string fileline7 = "ID\tChar\tBopo\tPin\tCrit\tCji";
                outputline7.WriteLine(fileline7);

                using (ChineseStudyDataContext myChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var myPinCrits = from q in myChineseStudy.CharBopoPinCrits
                        orderby q.Cji, q.Char, q.Pin
                        select q;

                    foreach (var myPinCrit in myPinCrits)
                    {
                        fileline7 = myPinCrit.ID + "\t" + myPinCrit.Char + "\t" + myPinCrit.Bopo + "\t" + myPinCrit.Pin + "\t" + myPinCrit.Crit + "\t" + myPinCrit.Cji;
                        outputline7.WriteLine(fileline7);
                    }
                }

                outputline7.Close();
            }
        }

        private void SetFolders(string subfolder)
        {
            OutputCeDictName.Text = OutputCeDictName.Text.Replace("FOLDER", subfolder).Replace("ACER0", subfolder).Replace("AMAZON1", subfolder).Replace("BAX2ZAONV6", subfolder);
            OutputCharBopoName.Text = OutputCharBopoName.Text.Replace("FOLDER", subfolder).Replace("ACER0", subfolder).Replace("AMAZON1", subfolder).Replace("BAX2ZAONV6", subfolder);
            OutputFullFarEastName.Text = OutputFullFarEastName.Text.Replace("FOLDER", subfolder).Replace("ACER0", subfolder).Replace("AMAZON1", subfolder).Replace("BAX2ZAONV6", subfolder);
            OutputPinBopoName.Text = OutputPinBopoName.Text.Replace("FOLDER", subfolder).Replace("ACER0", subfolder).Replace("AMAZON1", subfolder).Replace("BAX2ZAONV6", subfolder);
            OutputPinMypinName.Text = OutputPinMypinName.Text.Replace("FOLDER", subfolder).Replace("ACER0", subfolder).Replace("AMAZON1", subfolder).Replace("BAX2ZAONV6", subfolder);
            Output_3000_Name.Text = Output_3000_Name.Text.Replace("FOLDER", subfolder).Replace("ACER0", subfolder).Replace("AMAZON1", subfolder).Replace("BAX2ZAONV6", subfolder);
            OutputCharBopoPinCrit_Name.Text = OutputCharBopoPinCrit_Name.Text.Replace("FOLDER", subfolder).Replace("ACER0", subfolder).Replace("AMAZON1", subfolder).Replace("BAX2ZAONV6", subfolder);
        }

        
    }
}