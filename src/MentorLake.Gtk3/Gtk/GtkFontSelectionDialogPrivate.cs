namespace MentorLake.Gtk;

public class GtkFontSelectionDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkFontSelectionDialogPrivateExtensions
{

	public static GtkFontSelectionDialogPrivate Dereference(this GtkFontSelectionDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontSelectionDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkFontSelectionDialogPrivateExterns
{
}

public struct GtkFontSelectionDialogPrivate
{
}
