namespace MentorLake.Gtk;


public class GtkFileChooserDialogClassHandle : BaseSafeHandle
{
}


public static class GtkFileChooserDialogClassExtensions
{

	public static GtkFileChooserDialogClass Dereference(this GtkFileChooserDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserDialogClass>(x.DangerousGetHandle());
}
internal class GtkFileChooserDialogClassExterns
{
}


public struct GtkFileChooserDialogClass
{
	
public GtkDialogClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
