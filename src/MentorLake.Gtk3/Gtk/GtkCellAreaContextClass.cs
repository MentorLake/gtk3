namespace MentorLake.Gtk;


public class GtkCellAreaContextClassHandle : BaseSafeHandle
{
}


public static class GtkCellAreaContextClassExtensions
{

	public static GtkCellAreaContextClass Dereference(this GtkCellAreaContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAreaContextClass>(x.DangerousGetHandle());
}
internal class GtkCellAreaContextClassExterns
{
}


public struct GtkCellAreaContextClass
{
	/// <summary>
/// <para>
/// This tells the context that an allocation width or height
///     (or both) have been decided for a group of rows. The context should
///     store any allocations for internally aligned cells at this point so
///     that they dont need to be recalculated at gtk_cell_area_render() time.
/// </para>
/// </summary>

public IntPtr allocate;
	/// <summary>
/// <para>
/// Clear any previously stored information about requested and
///     allocated sizes for the context.
/// </para>
/// </summary>

public IntPtr reset;
	/// <summary>
/// <para>
/// Returns the aligned height for the given
///     width that context must store while collecting sizes for it’s rows.
/// </para>
/// </summary>

public IntPtr get_preferred_height_for_width;
	/// <summary>
/// <para>
/// Returns the aligned width for the given
///     height that context must store while collecting sizes for it’s rows.
/// </para>
/// </summary>

public IntPtr get_preferred_width_for_height;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
}
