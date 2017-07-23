using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ExportSQL
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog chooseOutputFullFarEast = new OpenFileDialog();
        private readonly OpenFileDialog chooseOutputCharBopo = new OpenFileDialog();
        private readonly OpenFileDialog chooseOutputPinBopo = new OpenFileDialog();
        private readonly OpenFileDialog chooseOutputPinMypin = new OpenFileDialog();
        private readonly OpenFileDialog chooseOutputCeDict = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            chooseOutputFullFarEast.FileOk += OnOutputFullFarEastDialogOK;
            chooseOutputCharBopo.FileOk += OnOutputCharBopoDialogOK;
            chooseOutputPinBopo.FileOk += OnOutputPinBopoDialogOK;
            chooseOutputPinMypin.FileOk += OnOutputPinMypinDialogOK;
            chooseOutputCeDict.FileOk += OnOutputCeDictDialogOK;
        }

        private void OnOutputFullFarEastDialogOK(object sender, CancelEventArgs e)
        {
            OutputFullFarEastName.Text = chooseOutputFullFarEast.FileName;
        }

        private void OnOutputCharBopoDialogOK(object sender, CancelEventArgs e)
        {
            OutputCharBopoName.Text = chooseOutputCharBopo.FileName;
        }

        private void OnOutputPinBopoDialogOK(object sender, CancelEventArgs e)
        {
            OutputPinBopoName.Text = chooseOutputPinBopo.FileName;
        }

        private void OnOutputPinMypinDialogOK(object sender, CancelEventArgs e)
        {
            OutputPinMypinName.Text = chooseOutputPinMypin.FileName;
        }

        private void OnOutputCeDictDialogOK(object sender, CancelEventArgs e)
        {
            OutputCeDictName.Text = chooseOutputCeDict.FileName;
        }

        private void ChooseFullFareast_Click(object sender, EventArgs e)
        {
            chooseOutputFullFarEast.ShowDialog();
        }

        private void ChooseCharBopo_Click(object sender, EventArgs e)
        {
            chooseOutputCharBopo.ShowDialog();
        }

        private void ChoosePinBopo_Click(object sender, EventArgs e)
        {
            chooseOutputPinBopo.ShowDialog();
        }

        private void ChoosePinMypin_Click(object sender, EventArgs e)
        {
            chooseOutputPinMypin.ShowDialog();
        }

        private void ChooseCeDict_Click(object sender, EventArgs e)
        {
            chooseOutputCeDict.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioACER0.Checked == true)
            {
                Properties.Settings.Default.ActiveSQL = Properties.Settings.Default.acer0;
                SetFolders("ACER0");
            }

            if (radioAMAZON1.Checked == true)
            {
                Properties.Settings.Default.ActiveSQL = Properties.Settings.Default.amazon1;
                SetFolders("AMAZON1");
            }

            if (radioBAX2ZAONV6.Checked == true)
            {
                Properties.Settings.Default.ActiveSQL = Properties.Settings.Default.bax2zaonv6;
                SetFolders("BAX2ZAONV6");
            }

            if (chkCharBopo.Checked)
            {
                FileStream Writing1 = new FileStream(OutputCharBopoName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter OutputLine1 = new StreamWriter(Writing1, UTF8Encoding.UTF8);
                string FileLine1 = "ID\tChar\tBopo\tCji";
                OutputLine1.WriteLine(FileLine1);

                using (ChineseStudyDataContext MyChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var MyChars = from q in MyChineseStudy.CharBopos
                                  orderby q.Char, q.Bopo
                                  select q;

                    foreach (var MyChar in MyChars)
                    {
                        FileLine1 = MyChar.ID + "\t" + MyChar.Char + "\t" + MyChar.Bopo + "\t" + MyChar.Cji;
                        OutputLine1.WriteLine(FileLine1);
                    }
                }

                OutputLine1.Close(); 
            }

            if (chkPinBopo.Checked)
            {
                FileStream Writing2 = new FileStream(OutputPinBopoName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter OutputLine2 = new StreamWriter(Writing2, UTF8Encoding.UTF8);
                string FileLine2 = "ID\tPin\tBopo";
                OutputLine2.WriteLine(FileLine2);

                using (ChineseStudyDataContext MyChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var MyBopos = from q in MyChineseStudy.PinBopos
                                  orderby q.Bopo, q.Pin
                                  select q;

                    foreach (var MyBopo in MyBopos)
                    {
                        FileLine2 = MyBopo.ID + "\t" + MyBopo.Pin + "\t" + MyBopo.Bopo;
                        OutputLine2.WriteLine(FileLine2);
                    }
                }

                OutputLine2.Close(); 
            }

            if (chkPinMypin.Checked)
            {
                FileStream Writing3 = new FileStream(OutputPinMypinName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter OutputLine3 = new StreamWriter(Writing3, UTF8Encoding.UTF8);
                string FileLine3 = "ID\tPin\tMyPin";
                OutputLine3.WriteLine(FileLine3);

                using (ChineseStudyDataContext MyChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var MyPins = from q in MyChineseStudy.PinMypins
                                 orderby q.MyPin, q.Pin
                                 select q;

                    foreach (var Mypin in MyPins)
                    {
                        FileLine3 = Mypin.ID + "\t" + Mypin.Pin + "\t" + Mypin.MyPin;
                        OutputLine3.WriteLine(FileLine3);
                    }
                }

                OutputLine3.Close(); 
            }

            if (chkFullFarEast.Checked)
            {
                FileStream Writing4 = new FileStream(OutputFullFarEastName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter OutputLine4 = new StreamWriter(Writing4, UTF8Encoding.UTF8);
                string FileLine4 = "ID\tBopo\tChar\tFeNumber\tEnglish\tHex\tCji";
                OutputLine4.WriteLine(FileLine4);

                using (ChineseStudyDataContext MyChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var MyFes = from q in MyChineseStudy.FullFarEasts
                                orderby q.Char, q.Bopo
                                select q;

                    foreach (var MyFe in MyFes)
                    {
                        FileLine4 = MyFe.ID.ToString();
                        FileLine4 += "\t";
                        FileLine4 += (String.IsNullOrEmpty(MyFe.Bopo) ? " " : MyFe.Bopo);
                        FileLine4 += "\t";
                        FileLine4 += MyFe.Char;
                        FileLine4 += "\t";
                        FileLine4 += ((MyFe.FeNumber == null) ? " " : MyFe.FeNumber.ToString());
                        FileLine4 += "\t";
                        FileLine4 += (String.IsNullOrEmpty(MyFe.English) ? " " : MyFe.English);
                        FileLine4 += "\t";
                        FileLine4 += MyFe.Hex;
                        FileLine4 += "\t";
                        FileLine4 += String.IsNullOrEmpty(MyFe.Cji) ? " " : MyFe.Cji;
                        OutputLine4.WriteLine(FileLine4);
                    }
                }

                OutputLine4.Close(); 
            }

                if (chkCeDict.Checked)
                {
                    FileStream Writing5 = new FileStream(OutputCeDictName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    StreamWriter OutputLine5 = new StreamWriter(Writing5, UTF8Encoding.UTF8);
                    string FileLine5 = "ID\tBopo\tChar\tFeNumber\tEnglish\tHex\tCji";
                    OutputLine5.WriteLine(FileLine5);

                    using (ChineseStudyDataContext MyChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                    {
                        var MyFes = from q in MyChineseStudy.CeDicts
                                    orderby q.Char, q.Bopo
                                    select q;

                        foreach (var MyFe in MyFes)
                        {
                            FileLine5 = MyFe.ID + "\t" + MyFe.Bopo + "\t" + MyFe.Char + "\t" + MyFe.English + "\t" + MyFe.Pinyin + "\t" + MyFe.Hex;
                            OutputLine5.WriteLine(FileLine5);
                        }
                    }

                    OutputLine5.Close(); 
                }

            if (chk_3000_.Checked)
            {
                FileStream Writing6 = new FileStream(Output_3000_Name.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter OutputLine6 = new StreamWriter(Writing6, UTF8Encoding.UTF8);
                string FileLine6 = "ID\tFEseq\tZhuyin\tTraditional\tEnglish\tNumPinyin\tCritPinyin\tSimplified\tCji";
                OutputLine6.WriteLine(FileLine6);

                string looker1 = Properties.Settings.Default.ActiveSQL;

                using (ChineseStudyDataContext MyChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var My3000s = from q in MyChineseStudy._3000_Characters
                                  orderby q.FEseq, q.Traditional
                                  select q;

                    foreach (var My3000 in My3000s)
                    {
                        FileLine6 = My3000.ID + "\t" + My3000.FEseq + "\t" + My3000.Zhuyin + "\t" + My3000.Traditional + "\t" + 
                            My3000.English + "\t" + My3000.NumPinyin + "\t" + My3000.CritPinyin + "\t" + My3000.Simplified + "\t" + My3000.Cji;
                        OutputLine6.WriteLine(FileLine6);
                    }
                }

                OutputLine6.Close();
            }

            if (chkPinBopo.Checked)
            {
                FileStream Writing2 = new FileStream(OutputPinBopoName.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter OutputLine2 = new StreamWriter(Writing2, UTF8Encoding.UTF8);
                string FileLine2 = "ID\tPin\tBopo";
                OutputLine2.WriteLine(FileLine2);

                using (ChineseStudyDataContext MyChineseStudy = new ChineseStudyDataContext(Properties.Settings.Default.ActiveSQL))
                {
                    var MyBopos = from q in MyChineseStudy.PinBopos
                                  orderby q.Bopo, q.Pin
                                  select q;

                    foreach (var MyBopo in MyBopos)
                    {
                        FileLine2 = MyBopo.ID + "\t" + MyBopo.Pin + "\t" + MyBopo.Bopo;
                        OutputLine2.WriteLine(FileLine2);
                    }
                }

                OutputLine2.Close();
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
        }

        private void Choose_3000(object sender, EventArgs e)
        {

        }

        private void grpSelectServer_Enter(object sender, EventArgs e)
        {

        }
    }
}