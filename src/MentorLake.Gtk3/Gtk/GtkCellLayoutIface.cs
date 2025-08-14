namespace MentorLake.Gtk;


public class GtkCellLayoutIfaceHandle : BaseSafeHandle
{
}


public static class GtkCellLayoutIfaceExtensions
{

	public static GtkCellLayoutIface Dereference(this GtkCellLayoutIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellLayoutIface>(x.DangerousGetHandle());
}
internal class GtkCellLayoutIfaceExterns
{
}


public struct GtkCellLayoutIface
{
	/// <summary>
/// <para>
/// Packs the cell into the beginning of cell_layout.
/// </para>
/// </summary>

public IntPtr pack_start;
	/// <summary>
/// <para>
/// Adds the cell to the end of cell_layout.
/// </para>
/// </summary>

public IntPtr pack_end;
	/// <summary>
/// <para>
/// Unsets all the mappings on all renderers on cell_layout and
///    removes all renderers from cell_layout.
/// </para>
/// </summary>

public IntPtr clear;
	/// <summary>
/// <para>
/// Adds an attribute mapping to the list in
///    cell_layout.
/// </para>
/// </summary>

public IntPtr add_attribute;
	/// <summary>
/// <para>
/// Sets the #GtkCellLayoutDataFunc to use for
///    cell_layout.
/// </para>
/// </summary>

public IntPtr set_cell_data_func;
	/// <summary>
/// <para>
/// Clears all existing attributes previously set
///    with gtk_cell_layout_set_attributes().
/// </para>
/// </summary>

public IntPtr clear_attributes;
	/// <summary>
/// <para>
/// Re-inserts cell at position.
/// </para>
/// </summary>

public IntPtr reorder;
	/// <summary>
/// <para>
/// Get the cell renderers which have been added to
///    cell_layout.
/// </para>
/// </summary>

public IntPtr get_cells;
	/// <summary>
/// <para>
/// Get the underlying #GtkCellArea which might be
///    cell_layout if called on a #GtkCellArea or might be NULL if no
///    #GtkCellArea is used by cell_layout.
/// </para>
/// </summary>

public IntPtr get_area;
}
