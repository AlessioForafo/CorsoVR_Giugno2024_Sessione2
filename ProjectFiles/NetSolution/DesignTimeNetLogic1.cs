#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.DataLogger;
using FTOptix.NativeUI;
using FTOptix.Recipe;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.ODBCStore;
using FTOptix.Modbus;
using FTOptix.System;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using FTOptix.Alarm;
#endregion

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void GenerateMyAlarms()
    {
        // 1. recupero cartella "Alarms"
        var alarmsFolder = Project.Current.Get<Folder>("Alarms");
        // 2. creo cartella "myAlarms"
        var myAlarmsFolder = InformationModel.Make<Folder>("myAlarmsFolder");
        // 3. aggiungo cartella "myAlarms" a cartella "Alarms"
        alarmsFolder.Add(myAlarmsFolder);
        // 4. genero 100 allarmi e li aggiungo alla cartella "myAlarms"
        for (int i = 0; i < 100; i++)
        {
            var dalarm = InformationModel.Make<DigitalAlarm>("dalarm_" + i);
            myAlarmsFolder.Add(dalarm);
        }
    }

}
