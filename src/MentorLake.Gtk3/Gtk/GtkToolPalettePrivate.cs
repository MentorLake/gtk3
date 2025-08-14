namespace MentorLake.Gtk;


public class GtkToolPalettePrivateHandle : BaseSafeHandle
{
}


public static class GtkToolPalettePrivateExtensions
{

	public static GtkToolPalettePrivate Dereference(this GtkToolPalettePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolPalettePrivate>(x.DangerousGetHandle());
}
internal class GtkToolPalettePrivateExterns
{
}


public struct GtkToolPalettePrivate
{
}
