namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A data structure for holding a path. This data structure serves as
/// the return value for cairo_copy_path() and
/// cairo_copy_path_flat() as well the input value for
/// cairo_append_path().
/// </para>
/// <para>
/// See #cairo_path_data_t for hints on how to iterate over the
/// actual data within the path.
/// </para>
/// <para>
/// The num_data member gives the number of elements in the data
/// array. This number is larger than the number of independent path
/// portions (defined in #cairo_path_data_type_t), since the data
/// includes both headers and coordinates for each portion.
/// </para>
/// </summary>

public class cairo_path_tHandle : BaseSafeHandle
{
}


public static class cairo_path_tExtensions
{

	public static cairo_path_t Dereference(this cairo_path_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_t>(x.DangerousGetHandle());
}
internal class cairo_path_tExterns
{
}

/// <summary>
/// <para>
/// A data structure for holding a path. This data structure serves as
/// the return value for cairo_copy_path() and
/// cairo_copy_path_flat() as well the input value for
/// cairo_append_path().
/// </para>
/// <para>
/// See #cairo_path_data_t for hints on how to iterate over the
/// actual data within the path.
/// </para>
/// <para>
/// The num_data member gives the number of elements in the data
/// array. This number is larger than the number of independent path
/// portions (defined in #cairo_path_data_type_t), since the data
/// includes both headers and coordinates for each portion.
/// </para>
/// </summary>

public struct cairo_path_t
{
	/// <summary>
/// <para>
/// the current error status
/// </para>
/// </summary>

public cairo_status_t status;
	/// <summary>
/// <para>
/// the elements in the path
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// the number of elements in the data array
/// </para>
/// </summary>

public int num_data;
}
