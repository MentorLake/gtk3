namespace MentorLake.fontconfig;

public class fontconfigGlobalFunctions
{
	public static void Init()
	{
		fontconfigGlobalFunctionsExterns.FcInit();
	}

}

internal class fontconfigGlobalFunctionsExterns
{
	[DllImport(fontconfigLibrary.Name)]
	internal static extern void FcInit();

}
