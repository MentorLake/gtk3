namespace MentorLake.Gtk;


public class GtkFontSelectionDialogClassHandle : BaseSafeHandle
{
}


public static class GtkFontSelectionDialogClassExtensions
{

	public static GtkFontSelectionDialogClass Dereference(this GtkFontSelectionDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontSelectionDialogClass>(x.DangerousGetHandle());
}
internal class GtkFontSelectionDialogClassExterns
{
}


public struct GtkFontSelectionDialogClass
{
	
public GtkDialogClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
