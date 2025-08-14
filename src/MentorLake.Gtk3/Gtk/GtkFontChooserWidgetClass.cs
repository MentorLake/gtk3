namespace MentorLake.Gtk;


public class GtkFontChooserWidgetClassHandle : BaseSafeHandle
{
}


public static class GtkFontChooserWidgetClassExtensions
{

	public static GtkFontChooserWidgetClass Dereference(this GtkFontChooserWidgetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontChooserWidgetClass>(x.DangerousGetHandle());
}
internal class GtkFontChooserWidgetClassExterns
{
}


public struct GtkFontChooserWidgetClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBoxClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
