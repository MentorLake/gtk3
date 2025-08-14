namespace MentorLake.GL;

public class GLGlobalFunctions
{


	public static void InitNames()
	{
		GLGlobalFunctionsExterns.glInitNames();
	}

}

internal class GLGlobalFunctionsExterns
{
	[DllImport(GLLibrary.Name)]
	internal static extern void glInitNames();

}
