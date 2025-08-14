namespace MentorLake.Gtk;


public class GtkFontSelectionClassHandle : BaseSafeHandle
{
}


public static class GtkFontSelectionClassExtensions
{

	public static GtkFontSelectionClass Dereference(this GtkFontSelectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontSelectionClass>(x.DangerousGetHandle());
}
internal class GtkFontSelectionClassExterns
{
}


public struct GtkFontSelectionClass
{
	
public GtkBoxClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
