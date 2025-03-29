namespace MentorLake.GLib;

public class GVariantBuilderHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GVariantBuilderHandle New(MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantBuilderExterns.g_variant_builder_new(type);
	}

}


public static class GVariantBuilderExtensions
{
	public static void Add(this MentorLake.GLib.GVariantBuilderHandle builder, string format_string, IntPtr @__arglist)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_add(builder, format_string, @__arglist);
	}

	public static void AddParsed(this MentorLake.GLib.GVariantBuilderHandle builder, string format, IntPtr @__arglist)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_add_parsed(builder, format, @__arglist);
	}

	public static void AddValue(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantHandle value)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_add_value(builder, value);
	}

	public static void Clear(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_clear(builder);
	}

	public static void Close(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_close(builder);
	}

	public static MentorLake.GLib.GVariantHandle End(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		return GVariantBuilderExterns.g_variant_builder_end(builder);
	}

	public static void Init(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantTypeHandle type)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_init(builder, type);
	}

	public static void InitStatic(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantTypeHandle type)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_init_static(builder, type);
	}

	public static void Open(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantTypeHandle type)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_open(builder, type);
	}

	public static MentorLake.GLib.GVariantBuilderHandle Ref(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		return GVariantBuilderExterns.g_variant_builder_ref(builder);
	}

	public static void Unref(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid || builder.IsClosed) throw new Exception("Invalid or closed handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_unref(builder);
	}


	public static GVariantBuilder Dereference(this GVariantBuilderHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantBuilder>(x.DangerousGetHandle());
}
internal class GVariantBuilderExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantBuilderHandle g_variant_builder_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_add_parsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_add_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_builder_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_init_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantBuilderHandle g_variant_builder_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

}

public struct GVariantBuilder
{
}
