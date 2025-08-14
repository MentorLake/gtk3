namespace MentorLake.Gtk;


public class GtkRadioToolButtonClassHandle : BaseSafeHandle
{
}


public static class GtkRadioToolButtonClassExtensions
{

	public static GtkRadioToolButtonClass Dereference(this GtkRadioToolButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioToolButtonClass>(x.DangerousGetHandle());
}
internal class GtkRadioToolButtonClassExterns
{
}


public struct GtkRadioToolButtonClass
{
	
public GtkToggleToolButtonClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
