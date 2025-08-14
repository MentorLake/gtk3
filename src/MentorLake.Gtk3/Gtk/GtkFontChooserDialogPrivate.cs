namespace MentorLake.Gtk;


public class GtkFontChooserDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkFontChooserDialogPrivateExtensions
{

	public static GtkFontChooserDialogPrivate Dereference(this GtkFontChooserDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontChooserDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkFontChooserDialogPrivateExterns
{
}


public struct GtkFontChooserDialogPrivate
{
}
