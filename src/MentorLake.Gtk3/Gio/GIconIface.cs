namespace MentorLake.Gio;

/// <summary>
/// <para>
/// GIconIface is used to implement GIcon types for various
/// different systems. See #GThemedIcon and #GLoadableIcon for
/// examples of how to implement this interface.
/// </para>
/// </summary>

public class GIconIfaceHandle : BaseSafeHandle
{
}


public static class GIconIfaceExtensions
{

	public static GIconIface Dereference(this GIconIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIconIface>(x.DangerousGetHandle());
}
internal class GIconIfaceExterns
{
}

/// <summary>
/// <para>
/// GIconIface is used to implement GIcon types for various
/// different systems. See #GThemedIcon and #GLoadableIcon for
/// examples of how to implement this interface.
/// </para>
/// </summary>

public struct GIconIface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// A hash for a given #GIcon.
/// </para>
/// </summary>

public IntPtr hash;
	/// <summary>
/// <para>
/// Checks if two #GIcons are equal.
/// </para>
/// </summary>

public IntPtr equal;
	/// <summary>
/// <para>
/// Serializes a #GIcon into tokens. The tokens must not
/// contain any whitespace. Don&apos;t implement if the #GIcon can&apos;t be
/// serialized (Since 2.20).
/// </para>
/// </summary>

public IntPtr to_tokens;
	/// <summary>
/// <para>
/// Constructs a #GIcon from tokens. Set the #GError if
/// the tokens are malformed. Don&apos;t implement if the #GIcon can&apos;t be
/// serialized (Since 2.20).
/// </para>
/// </summary>

public IntPtr from_tokens;
	/// <summary>
/// <para>
/// Serializes a #GIcon into a #GVariant. Since: 2.38
/// </para>
/// </summary>

public IntPtr serialize;
}
