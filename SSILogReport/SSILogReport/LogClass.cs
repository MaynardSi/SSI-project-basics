using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Summary description for Class1
/// </summary>
public class LogClass
{
	public LogClass(string logName, List<string> log)
	{
        LogName = logName;
        LogList = log;
    }

    public string LogName { get; private set; }
    public List<string> LogList { get; private set; }
}
