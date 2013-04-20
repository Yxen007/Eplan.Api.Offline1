using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Eplan.Api.Offline1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool m_P8ActionDone = false;

        //Method for handling event which fires on clicking a control.
        private void btnStart_Click(object sender, System.EventArgs e)
        {
            EPLInit();

            if (m_bIsP8AlreadyInitialized && !m_P8ActionDone)
            {
                EPLAN_Action.RunAction();
                m_P8ActionDone = true;
            }
        }
        //Method for handling event which fires when closing a form. 
        private void form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EPLExit();
        }
        private void EPLInit()
        {
            try
            {
                if (!m_bIsP8AlreadyInitialized)
                {
                    m_oEplApp.Init("");
                    m_bIsP8AlreadyInitialized = true;
                }
            }
            catch (Exception)
            {
                //ToDo add an exception handling code here
            }

        }
        private void EPLExit()
        {
            try
            {
                if (m_bIsP8AlreadyInitialized)
                {
                    m_oEplApp.Exit();
                    m_bIsP8AlreadyInitialized = false;
                }
            }
            catch (Exception)
            {
                //ToDo add an exception handling code here
            }

        }
    }
}