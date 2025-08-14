namespace MentorLake.xft;

public class xftGlobalFunctions
{


	public static void Init()
	{
		xftGlobalFunctionsExterns.XftInit();
	}

}

internal class xftGlobalFunctionsExterns
{
	[DllImport(xftLibrary.Name)]
	internal static extern void XftInit();

}
