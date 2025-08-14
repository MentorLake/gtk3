namespace MentorLake.Gtk;


public class GtkColorSelectionDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkColorSelectionDialogPrivateExtensions
{

	public static GtkColorSelectionDialogPrivate Dereference(this GtkColorSelectionDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorSelectionDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkColorSelectionDialogPrivateExterns
{
}


public struct GtkColorSelectionDialogPrivate
{
}
