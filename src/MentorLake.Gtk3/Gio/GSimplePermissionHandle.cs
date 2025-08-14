namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSimplePermission` is a trivial implementation of [class@Gio.Permission]
/// that represents a permission that is either always or never allowed.  The
/// value is given at construction and doesn’t change.
/// </para>
/// <para>
/// Calling [method@Gio.Permission.acquire] or [method@Gio.Permission.release]
/// on a `GSimplePermission` will result in errors.
/// </para>
/// </summary>

public class GSimplePermissionHandle : GPermissionHandle
{
/// <summary>
/// <para>
/// Creates a new #GPermission instance that represents an action that is
/// either always or never allowed.
/// </para>
/// </summary>

/// <param name="allowed">
/// %TRUE if the action is allowed
/// </param>
/// <return>
/// the #GSimplePermission, as a #GPermission
/// </return>

	public static MentorLake.Gio.GSimplePermissionHandle New(bool allowed)
	{
		return GSimplePermissionHandleExterns.g_simple_permission_new(allowed);
	}

}

public static class GSimplePermissionHandleExtensions
{
}

internal class GSimplePermissionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimplePermissionHandle>))]
	internal static extern MentorLake.Gio.GSimplePermissionHandle g_simple_permission_new(bool allowed);

}
