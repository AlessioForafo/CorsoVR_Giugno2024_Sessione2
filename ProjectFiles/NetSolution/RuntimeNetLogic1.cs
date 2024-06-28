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

public class RuntimeNetLogic1 : BaseNetLogic
{
    private PeriodicTask periodicTask;
    private DelayedTask dTask;
    private LongRunningTask lTask;

    public override void Start()
    {
        periodicTask = new PeriodicTask(Greetings1, 3000, LogicObject);
        periodicTask.Start();
    }

    private void Greetings1()
    {
        Log.Info("hello periodic task!");
    }

    private void Greetings2()
    {
        Log.Info("hello delayed task!");
    }

    private void Greetings3()
    {
        Log.Info("hello long running task!");
    }

    public override void Stop()
    {
        periodicTask?.Dispose();
        dTask?.Dispose();
        lTask?.Dispose();
    }


    [ExportMethod]
    public void TestMyDelayedTask()
    {
        dTask = new DelayedTask(Greetings2, 5000, LogicObject);
        dTask.Start();
    }

    [ExportMethod]
    public void TestMyLongRunningTask()
    {
        lTask = new LongRunningTask(Greetings3, LogicObject);
        lTask.Start();
    }
}
