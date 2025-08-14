namespace MentorLake.Gtk;


public class GtkRadioButtonClassHandle : BaseSafeHandle
{
}


public static class GtkRadioButtonClassExtensions
{

	public static GtkRadioButtonClass Dereference(this GtkRadioButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioButtonClass>(x.DangerousGetHandle());
}
internal class GtkRadioButtonClassExterns
{
}


public struct GtkRadioButtonClass
{
	
public GtkCheckButtonClass parent_class;
	
public IntPtr group_changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
