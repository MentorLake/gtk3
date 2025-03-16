namespace MentorLake.libxml2;

public class libxml2GlobalFunctions
{
	public static void Dummy()
	{
		libxml2GlobalFunctionsExterns.dummy();
	}

}

internal class libxml2GlobalFunctionsExterns
{
	[DllImport(libxml2Library.Name)]
	internal static extern void dummy();

}
