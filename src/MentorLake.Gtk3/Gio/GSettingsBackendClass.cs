namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GSettingsBackend.
/// </para>
/// </summary>

public class GSettingsBackendClassHandle : BaseSafeHandle
{
}


public static class GSettingsBackendClassExtensions
{

	public static GSettingsBackendClass Dereference(this GSettingsBackendClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsBackendClass>(x.DangerousGetHandle());
}
internal class GSettingsBackendClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GSettingsBackend.
/// </para>
/// </summary>

public struct GSettingsBackendClass
{
	
public GObjectClass parent_class;
	/// <summary>
/// <para>
/// virtual method to read a key&apos;s value
/// </para>
/// </summary>

public IntPtr read;
	/// <summary>
/// <para>
/// virtual method to get if a key is writable
/// </para>
/// </summary>

public IntPtr get_writable;
	/// <summary>
/// <para>
/// virtual method to change key&apos;s value
/// </para>
/// </summary>

public IntPtr write;
	/// <summary>
/// <para>
/// virtual method to change a tree of keys
/// </para>
/// </summary>

public IntPtr write_tree;
	/// <summary>
/// <para>
/// virtual method to reset state
/// </para>
/// </summary>

public IntPtr reset;
	/// <summary>
/// <para>
/// virtual method to subscribe to key changes
/// </para>
/// </summary>

public IntPtr subscribe;
	/// <summary>
/// <para>
/// virtual method to unsubscribe to key changes
/// </para>
/// </summary>

public IntPtr unsubscribe;
	/// <summary>
/// <para>
/// virtual method to sync state
/// </para>
/// </summary>

public IntPtr sync;
	/// <summary>
/// <para>
/// virtual method to get permission of a key
/// </para>
/// </summary>

public IntPtr get_permission;
	/// <summary>
/// <para>
/// virtual method to read user&apos;s key value
/// </para>
/// </summary>

public IntPtr read_user_value;
}
