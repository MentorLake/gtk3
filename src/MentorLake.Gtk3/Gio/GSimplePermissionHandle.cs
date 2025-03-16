namespace MentorLake.Gio;

public class GSimplePermissionHandle : GPermissionHandle
{
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
	internal static extern MentorLake.Gio.GSimplePermissionHandle g_simple_permission_new(bool allowed);

}
