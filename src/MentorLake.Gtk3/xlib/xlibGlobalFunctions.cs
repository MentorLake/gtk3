namespace MentorLake.xlib;

public class xlibGlobalFunctions
{
	public static void OpenDisplay()
	{
		xlibGlobalFunctionsExterns.XOpenDisplay();
	}

}

internal class xlibGlobalFunctionsExterns
{
	[DllImport(xlibLibrary.Name)]
	internal static extern void XOpenDisplay();

}
