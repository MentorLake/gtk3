namespace MentorLake.Gtk;


public class GtkRadioActionClassHandle : BaseSafeHandle
{
}


public static class GtkRadioActionClassExtensions
{

	public static GtkRadioActionClass Dereference(this GtkRadioActionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioActionClass>(x.DangerousGetHandle());
}
internal class GtkRadioActionClassExterns
{
}


public struct GtkRadioActionClass
{
	
public GtkToggleActionClass parent_class;
	
public IntPtr changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
