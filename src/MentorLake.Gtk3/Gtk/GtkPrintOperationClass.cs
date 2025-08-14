namespace MentorLake.Gtk;


public class GtkPrintOperationClassHandle : BaseSafeHandle
{
}


public static class GtkPrintOperationClassExtensions
{

	public static GtkPrintOperationClass Dereference(this GtkPrintOperationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPrintOperationClass>(x.DangerousGetHandle());
}
internal class GtkPrintOperationClassExterns
{
}


public struct GtkPrintOperationClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the print operation run has finished
///    doing everything required for printing.
/// </para>
/// </summary>

public IntPtr done;
	/// <summary>
/// <para>
/// Signal emitted after the user has finished changing
///    print settings in the dialog, before the actual rendering starts.
/// </para>
/// </summary>

public IntPtr begin_print;
	/// <summary>
/// <para>
/// Signal emitted after the “begin-print” signal, but
///    before the actual rendering starts.
/// </para>
/// </summary>

public IntPtr paginate;
	/// <summary>
/// <para>
/// Emitted once for every page that is printed,
///    to give the application a chance to modify the page setup.
/// </para>
/// </summary>

public IntPtr request_page_setup;
	/// <summary>
/// <para>
/// Signal emitted for every page that is printed.
/// </para>
/// </summary>

public IntPtr draw_page;
	/// <summary>
/// <para>
/// Signal emitted after all pages have been rendered.
/// </para>
/// </summary>

public IntPtr end_print;
	/// <summary>
/// <para>
/// Emitted at between the various phases of the print
///    operation.
/// </para>
/// </summary>

public IntPtr status_changed;
	/// <summary>
/// <para>
/// Signal emitted when displaying the print dialog.
/// </para>
/// </summary>

public IntPtr create_custom_widget;
	/// <summary>
/// <para>
/// Signal emitted right before “begin-print” if
///    you added a custom widget in the “create-custom-widget” handler.
/// </para>
/// </summary>

public IntPtr custom_widget_apply;
	/// <summary>
/// <para>
/// Signal emitted when a preview is requested from the
///    native dialog.
/// </para>
/// </summary>

public IntPtr preview;
	/// <summary>
/// <para>
/// Emitted after change of selected printer.
/// </para>
/// </summary>

public IntPtr update_custom_widget;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
