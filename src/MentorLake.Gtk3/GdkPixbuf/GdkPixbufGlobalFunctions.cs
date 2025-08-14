namespace MentorLake.GdkPixbuf;

public class GdkPixbufGlobalFunctions
{


	public static MentorLake.GLib.GQuark PixbufErrorQuark()
	{
		return GdkPixbufGlobalFunctionsExterns.gdk_pixbuf_error_quark();
	}

}

internal class GdkPixbufGlobalFunctionsExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gdk_pixbuf_error_quark();

}
