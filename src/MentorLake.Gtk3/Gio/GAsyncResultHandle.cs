namespace MentorLake.Gio;

public interface GAsyncResultHandle
{
}

internal class GAsyncResultHandleImpl : BaseSafeHandle, GAsyncResultHandle
{
}

public static class GAsyncResultHandleExtensions
{
	public static MentorLake.GObject.GObjectHandle GetSourceObject(this MentorLake.Gio.GAsyncResultHandle res)
	{
		return GAsyncResultHandleExterns.g_async_result_get_source_object(res);
	}

	public static IntPtr GetUserData(this MentorLake.Gio.GAsyncResultHandle res)
	{
		return GAsyncResultHandleExterns.g_async_result_get_user_data(res);
	}

	public static bool IsTagged(this MentorLake.Gio.GAsyncResultHandle res, IntPtr source_tag)
	{
		return GAsyncResultHandleExterns.g_async_result_is_tagged(res, source_tag);
	}

	public static bool LegacyPropagateError(this MentorLake.Gio.GAsyncResultHandle res, IntPtr error)
	{
		return GAsyncResultHandleExterns.g_async_result_legacy_propagate_error(res, error);
	}

}

internal class GAsyncResultHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_async_result_get_source_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_async_result_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_async_result_is_tagged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr source_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_async_result_legacy_propagate_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, IntPtr error);

}
