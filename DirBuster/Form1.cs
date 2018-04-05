using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DirBuster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DirBuster.NetWork NtWork = new DirBuster.NetWork();
        DirBuster.BruteForce Brtforce = new DirBuster.BruteForce();
        public static string DirectoryData = Environment.ExpandEnvironmentVariables("%appdata%\\DirBuster.dat");
        public bool Interrupt { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Data;
            try
            {
                StreamReader FileOpen = new StreamReader(DirectoryData);
                Data = FileOpen.ReadToEnd().Split('\n');
                FileOpen.Close();
                foreach (String s in Data)
                {
                    if (s.Length <= 1) continue;
                    ListTarget.Items.Add(s);
                }
            }
            catch (Exception) { }
            this.Text = "DirBuster v" + Application.ProductVersion;
            CheckForIllegalCrossThreadCalls = false;
        }

        private int SelectList()
        {
            if (XTreamCodesRadio.Checked)       return 0;
            if (AllDirectoryRadio.Checked)      return 1;
            if (AdminSetupRadio.Checked)        return 2;
            if (AllFileRadio.Checked)           return 3;
            return -1;
        }

        private void apriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(ListTarget.SelectedItem.ToString());
            }catch(NullReferenceException)
            {
                MessageBox.Show("Nessun Elemento selezionato", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rimuoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListTarget.Items.RemoveAt(ListTarget.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nessun Elemento selezionato", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void apriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(ListResult.SelectedItem.ToString());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nessun Elemento selezionato !", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void copiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ListResult.SelectedItem.ToString());
            }catch(NullReferenceException)
            {
                MessageBox.Show("Nessun Elemento selezionato !", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ripulisciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListResult.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                String Data = null;
                foreach (String s in ListTarget.Items)
                {
                    if (s.IndexOf("http://") == -1) continue;
                    Data += s + "\n";
                }
                TextWriter List = new StreamWriter(DirectoryData);
                List.Write(Data);
                List.Close();
            }
            catch (Exception) { }
        }

        private void ripulisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ListTarget.Items.Count != 0)
            {
                DialogResult Conferma = MessageBox.Show("Rimuovere tutti gli elementi dalla lista?", "Ripulisci lista", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Conferma == DialogResult.Yes) ListTarget.Items.Clear();
            }else
            {
                MessageBox.Show("Non ci sono elementi nella lista", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImportTarget.Filter = "TXT Text|*.txt";
            ImportTarget.Title = "Importa lista server";
            ImportTarget.FileName = string.Empty;
            DialogResult Import = ImportTarget.ShowDialog();
            if (Import == DialogResult.OK)
            {
                TextDirTarget.Text = ImportTarget.FileName;
                foreach (string url in File.ReadAllText(ImportTarget.FileName).Split('\n'))
                {
                    ListTarget.Items.Add(url);
                }
            }
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            if (StartBTN.Text == "Start")
            {
                if (ListTarget.Items.Count != 0)
                {
                    int count = 1;
                    Interrupt = false;
                    ListResult.Items.Clear();
                    Brtforce.interrupt = false;
                    SingleProgress.Value = 0;
                    TotalProgress.Value = 0;
                    string Address = string.Empty;
                    Thread Attack = new Thread(() => {
                        try
                        {
                            foreach (string url in ListTarget.Items)
                            {
                                if (Interrupt) break;
                                Address = CheckPort.Checked && url.Replace("http://", string.Empty).IndexOf(':') != 0 ? "http://" + url.Replace("http://", string.Empty).Split(':')[0] : url;
                                Brtforce.Run(ref ListResult, ref TextConsole, ref SingleProgress, Address, SelectList(),ResultCheckBox.Checked);
                                TotalProgress.Value = Brtforce.Percentuale_Totale(count, ListTarget.Items.Count);
                                count++;
                            }
                        }
                        catch { }
                        finally
                        {
                            StartBTN.Text = "Start";
                            TextConsole.Text = "Console";
                        }
                    });

                    Attack.Start();
                    StartBTN.Text = "Stop";
                }
            }
            else if (StartBTN.Text == "Stop")
            {
                Interrupt = true;
                Brtforce.interrupt = true;
                StartBTN.Text = "Start";
            }
        }

        private void TargetText_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Thread AddUrl = new Thread(() => {
                    if (NtWork.Address_Check(TargetText.Text,false)) ListTarget.Items.Insert(0, TargetText.Text);
                    TargetText.Text = string.Empty;
                });
                AddUrl.Start();
            }
        }

        private void TargetText_Click_1(object sender, EventArgs e)
        {
            if (TargetText.Text == "Host Target...") TargetText.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salvaElencoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ListResult.Items.Count != 0)
            {
                String Log = String.Empty;
                SaveResultDialog.Filter = "TXT Text|*.txt";
                SaveResultDialog.Title = "Salva Elenco";
                SaveResultDialog.FileName = string.Empty;
                DialogResult Save = SaveResultDialog.ShowDialog();
                if(Save == DialogResult.OK)
                {
                    foreach (String str in ListResult.Items) Log += str + "\n";
                    File.WriteAllText(SaveResultDialog.FileName, Log);
                }
            }
            else
            {
                MessageBox.Show("La Playlist è vuota", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void copiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ListTarget.SelectedItem.ToString());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nessun Elemento selezionato !", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ispezionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HTMLEditorText.Text = NtWork.Get_Html(ListResult.SelectedItem.ToString());
                tabControl1.SelectedIndex = 2;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Nessun Elemento selezionato !", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
  
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
