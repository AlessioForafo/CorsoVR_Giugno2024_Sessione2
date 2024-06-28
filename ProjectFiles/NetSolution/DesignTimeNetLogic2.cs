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
using FTOptix.OPCUAServer;
using FTOptix.OPCUAClient;
#endregion

public class DesignTimeNetLogic2 : BaseNetLogic
{
    [ExportMethod]
    public void Method1()
    {
        var myEmbeddedDb = InformationModel.Make<SQLiteStore>("MyStore");
        Owner.Add(myEmbeddedDb);
    }
}
