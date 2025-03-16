namespace MentorLake.Gtk;

public class GtkColorChooserDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkColorChooserDialogPrivateExtensions
{

	public static GtkColorChooserDialogPrivate Dereference(this GtkColorChooserDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorChooserDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkColorChooserDialogPrivateExterns
{
}

public struct GtkColorChooserDialogPrivate
{
}
