namespace MentorLake.Gtk;

public class GtkFileChooserNativeClassHandle : BaseSafeHandle
{
}


public static class GtkFileChooserNativeClassExtensions
{

	public static GtkFileChooserNativeClass Dereference(this GtkFileChooserNativeClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserNativeClass>(x.DangerousGetHandle());
}
internal class GtkFileChooserNativeClassExterns
{
}

public struct GtkFileChooserNativeClass
{
	public GtkNativeDialogClass parent_class;
}
