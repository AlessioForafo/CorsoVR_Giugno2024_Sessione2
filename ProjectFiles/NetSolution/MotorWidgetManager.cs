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

public class MotorWidgetManager : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void GenerateMotorWidgets()
    {
        var myMotorsWidgetWrapper = InformationModel.Get(LogicObject.GetVariable("MyMotorsWidget").Value);
        var motorsToInstantiate = (int) LogicObject.GetVariable("MotorsToInstantiate").Value;

        for (int i = 0; i < motorsToInstantiate; i++)
        {
            var motorWidget = InformationModel.Make<MotorWidget>("myMtr_" + i);
            myMotorsWidgetWrapper.Add(motorWidget);
        }
    }
}
