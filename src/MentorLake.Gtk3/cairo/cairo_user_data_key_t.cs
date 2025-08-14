namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_user_data_key_t is used for attaching user data to cairo
/// data structures.  The actual contents of the struct is never used,
/// and there is no need to initialize the object; only the unique
/// address of a #cairo_data_key_t object is used.  Typically, you
/// would just use the address of a static #cairo_data_key_t object.
/// </para>
/// </summary>

public class cairo_user_data_key_tHandle : BaseSafeHandle
{
}


public static class cairo_user_data_key_tExtensions
{

	public static cairo_user_data_key_t Dereference(this cairo_user_data_key_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_user_data_key_t>(x.DangerousGetHandle());
}
internal class cairo_user_data_key_tExterns
{
}

/// <summary>
/// <para>
/// #cairo_user_data_key_t is used for attaching user data to cairo
/// data structures.  The actual contents of the struct is never used,
/// and there is no need to initialize the object; only the unique
/// address of a #cairo_data_key_t object is used.  Typically, you
/// would just use the address of a static #cairo_data_key_t object.
/// </para>
/// </summary>

public struct cairo_user_data_key_t
{
	/// <summary>
/// <para>
/// not used; ignore.
/// </para>
/// </summary>

public int unused;
}
