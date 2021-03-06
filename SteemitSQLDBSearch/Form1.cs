﻿//using SteemitSQLDBSearch.model;
using SteemitSQLDBSearch.model2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteemitSQLDBSearch
{
    public partial class Form1 : Form
    {
        // backgroundworker
        private BackgroundWorker bw = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();

            // backgroundworker
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; (i <= 10); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    //System.Threading.Thread.Sleep(500);
                    worker.ReportProgress((i * 10));
                    // query
                    /*
                    DBSteemEntities db = new DBSteemEntities();
                    var r = db.Accounts.Where(q => q.name == tbname.Text);
                    var users = r.ToList();
                    e.Result = r;
                    //dgvResults.DataSource = users;
                    foreach(var s in r)
                    {
                        //this.tbTextResult.Text += s.name;
                    }
                    */

                    steemitDataContext dc = new steemitDataContext();
                    var r = dc.Accounts.Where(x => x.name == tbname.Text);
                    List<Account> l = r.ToList<Account>();
                    e.Result = l;

                        
                }
            }
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.tbProgress.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                this.tbProgress.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                this.tbProgress.Text = "Done!";

                List<Account> l = e.Result as List<Account>;                

                //dgvResults.DataSource = worker;
                try
                {
                    List<Account> a = new List<Account>();
                    //var al = l.ToDictionary(x => x);
                    //List<string> ab = al.Keys.ToArray();
                    //ArrayList ac = new ArrayList(al.Keys);

                    //List<string> keyList = new List<string>(al.Values.ToString());
                    //List<String> myKeys = al.Values.ToList();


                    foreach (var r in l)
                    {
                        /*
                        foreach(var a1 in ac)
                        {   
                            this.tbTextResult.Text += a1 + " ";
                        }
                        */
                        this.tbTextResult.Text += "id: " + r.id + Environment.NewLine;
                        this.tbTextResult.Text += "Name: " +  r.name + Environment.NewLine;
                        this.tbTextResult.Text += "Comment Count: " + r.comment_count + Environment.NewLine;
                        this.tbTextResult.Text += "Lifetime Vote Count: " + r.lifetime_vote_count + Environment.NewLine;
                        this.tbTextResult.Text += "Voting Power: " + r.voting_power + Environment.NewLine;
                        this.tbTextResult.Text += "Reputation: " + r.reputation + Environment.NewLine;
                        this.tbTextResult.Text += "Last Post: " + r.last_post + Environment.NewLine;
                        this.tbTextResult.Text += "----------------" + Environment.NewLine + Environment.NewLine;
                    }
                    
                }
                catch(Exception ex)
                {
                    this.tbTextResult.Text = ex.ToString();
                }
                
                
            }
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");
        }
    }
}
