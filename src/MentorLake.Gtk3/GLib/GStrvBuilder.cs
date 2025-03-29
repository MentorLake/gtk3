namespace MentorLake.GLib;

public class GStrvBuilderHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GStrvBuilderHandle New()
	{
		return GStrvBuilderExterns.g_strv_builder_new();
	}

}


public static class GStrvBuilderExtensions
{
	public static void Add(this MentorLake.GLib.GStrvBuilderHandle builder, string value)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_add(builder, value);
	}

	public static void AddMany(this MentorLake.GLib.GStrvBuilderHandle builder, IntPtr @__arglist)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_add_many(builder, @__arglist);
	}

	public static void Addv(this MentorLake.GLib.GStrvBuilderHandle builder, string[] value)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_addv(builder, value);
	}

	public static string[] End(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		return GStrvBuilderExterns.g_strv_builder_end(builder);
	}

	public static MentorLake.GLib.GStrvBuilderHandle Ref(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		return GStrvBuilderExterns.g_strv_builder_ref(builder);
	}

	public static void Take(this MentorLake.GLib.GStrvBuilderHandle builder, string value)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_take(builder, value);
	}

	public static void Unref(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_unref(builder);
	}

	public static string[] UnrefToStrv(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GStrvBuilder)");
		return GStrvBuilderExterns.g_strv_builder_unref_to_strv(builder);
	}


	public static GStrvBuilder Dereference(this GStrvBuilderHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStrvBuilder>(x.DangerousGetHandle());
}
internal class GStrvBuilderExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStrvBuilderHandle g_strv_builder_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, string value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_add_many([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_addv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, string[] value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strv_builder_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GStrvBuilderHandle g_strv_builder_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_take([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, string value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strv_builder_unref_to_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

}

public struct GStrvBuilder
{
}
