namespace MentorLake.Gtk;


public class GtkColorChooserDialogClassHandle : BaseSafeHandle
{
}


public static class GtkColorChooserDialogClassExtensions
{

	public static GtkColorChooserDialogClass Dereference(this GtkColorChooserDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorChooserDialogClass>(x.DangerousGetHandle());
}
internal class GtkColorChooserDialogClassExterns
{
}


public struct GtkColorChooserDialogClass
{
	
public GtkDialogClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
