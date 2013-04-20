using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Eplan.EplApi.DataModel;
using Eplan.EplApi.Base;

namespace Eplan.Api.Offline1
{
    public class EPLAN_Action
    {
        private static Eplan.EplApi.Base.TraceListener m_oTrace = new Eplan.EplApi.Base.TraceListener();

        public static void RunAction()
        {
            Trace.Listeners.Add(m_oTrace);

          using(LockingStep o = new LockingStep())
          {
              //call all EPLAN code from here
              string m_strOpenProjectName = @"EPLAN-DEMO.elk";

              string strProjectPath = new Settings().GetExpandedStringSetting("USER.TrDMProject.Masterdata.Pathnames.Projects", 0);
              strProjectPath += "\\" + m_strOpenProjectName;

              if (new ProjectManager().ExistsProject(strProjectPath))
              {
                  Project oOpenProject = new ProjectManager().OpenProject(strProjectPath);
                  Trace.WriteLine("Opened project: " + strProjectPath);
              }
              else
              {
                  Trace.WriteLine("Can not find project: " + strProjectPath);
              }
          }
        }
    }
}
