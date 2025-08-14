namespace MentorLake.Gtk;


public class GtkFileChooserDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkFileChooserDialogPrivateExtensions
{

	public static GtkFileChooserDialogPrivate Dereference(this GtkFileChooserDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkFileChooserDialogPrivateExterns
{
}


public struct GtkFileChooserDialogPrivate
{
}
