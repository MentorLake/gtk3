namespace MentorLake.Gtk;


public class GtkColorSelectionDialogClassHandle : BaseSafeHandle
{
}


public static class GtkColorSelectionDialogClassExtensions
{

	public static GtkColorSelectionDialogClass Dereference(this GtkColorSelectionDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorSelectionDialogClass>(x.DangerousGetHandle());
}
internal class GtkColorSelectionDialogClassExterns
{
}


public struct GtkColorSelectionDialogClass
{
	
public GtkDialogClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
