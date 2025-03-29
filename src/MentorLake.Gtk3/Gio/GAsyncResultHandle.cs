namespace MentorLake.Gio;

public interface GAsyncResultHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GAsyncResultHandleImpl : BaseSafeHandle, GAsyncResultHandle
{
}

public static class GAsyncResultHandleExtensions
{
	public static MentorLake.GObject.GObjectHandle GetSourceObject(this MentorLake.Gio.GAsyncResultHandle res)
	{
		if (res.IsInvalid || res.IsClosed) throw new Exception("Invalid or closed handle (GAsyncResultHandle)");
		return GAsyncResultHandleExterns.g_async_result_get_source_object(res);
	}

	public static IntPtr GetUserData(this MentorLake.Gio.GAsyncResultHandle res)
	{
		if (res.IsInvalid || res.IsClosed) throw new Exception("Invalid or closed handle (GAsyncResultHandle)");
		return GAsyncResultHandleExterns.g_async_result_get_user_data(res);
	}

	public static bool IsTagged(this MentorLake.Gio.GAsyncResultHandle res, IntPtr source_tag)
	{
		if (res.IsInvalid || res.IsClosed) throw new Exception("Invalid or closed handle (GAsyncResultHandle)");
		return GAsyncResultHandleExterns.g_async_result_is_tagged(res, source_tag);
	}

	public static bool LegacyPropagateError(this MentorLake.Gio.GAsyncResultHandle res)
	{
		if (res.IsInvalid || res.IsClosed) throw new Exception("Invalid or closed handle (GAsyncResultHandle)");
		var externCallResult = GAsyncResultHandleExterns.g_async_result_legacy_propagate_error(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
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
	internal static extern bool g_async_result_legacy_propagate_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

}
