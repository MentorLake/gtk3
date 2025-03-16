namespace MentorLake.Gtk;

public class GtkFontSelectionPrivateHandle : BaseSafeHandle
{
}


public static class GtkFontSelectionPrivateExtensions
{

	public static GtkFontSelectionPrivate Dereference(this GtkFontSelectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontSelectionPrivate>(x.DangerousGetHandle());
}
internal class GtkFontSelectionPrivateExterns
{
}

public struct GtkFontSelectionPrivate
{
}
