namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GSocketAddressEnumerator.
/// </para>
/// </summary>

public class GSocketAddressEnumeratorClassHandle : BaseSafeHandle
{
}


public static class GSocketAddressEnumeratorClassExtensions
{

	public static GSocketAddressEnumeratorClass Dereference(this GSocketAddressEnumeratorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketAddressEnumeratorClass>(x.DangerousGetHandle());
}
internal class GSocketAddressEnumeratorClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GSocketAddressEnumerator.
/// </para>
/// </summary>

public struct GSocketAddressEnumeratorClass
{
	/// <summary>
/// <para>
/// Virtual method for g_socket_address_enumerator_next().
/// </para>
/// </summary>

public IntPtr next;
	/// <summary>
/// <para>
/// Virtual method for g_socket_address_enumerator_next_async().
/// </para>
/// </summary>

public IntPtr next_async;
	/// <summary>
/// <para>
/// Virtual method for g_socket_address_enumerator_next_finish().
/// </para>
/// </summary>

public IntPtr next_finish;
}
