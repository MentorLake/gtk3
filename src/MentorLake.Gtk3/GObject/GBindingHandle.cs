namespace MentorLake.GObject;

public class GBindingHandle : GObjectHandle
{
}

public static class GBindingHandleExtensions
{
	public static MentorLake.GObject.GObjectHandle DupSource(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_dup_source(binding);
	}

	public static MentorLake.GObject.GObjectHandle DupTarget(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_dup_target(binding);
	}

	public static MentorLake.GObject.GBindingFlags GetFlags(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_flags(binding);
	}

	public static MentorLake.GObject.GObjectHandle GetSource(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_source(binding);
	}

	public static string GetSourceProperty(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_source_property(binding);
	}

	public static MentorLake.GObject.GObjectHandle GetTarget(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_target(binding);
	}

	public static string GetTargetProperty(this MentorLake.GObject.GBindingHandle binding)
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		return GBindingHandleExterns.g_binding_get_target_property(binding);
	}

	public static T Unbind<T>(this T binding) where T : GBindingHandle
	{
		if (binding.IsInvalid || binding.IsClosed) throw new Exception("Invalid or closed handle (GBindingHandle)");
		GBindingHandleExterns.g_binding_unbind(binding);
		return binding;
	}

}

internal class GBindingHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_dup_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_dup_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GBindingFlags g_binding_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_get_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_binding_get_source_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_get_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_binding_get_target_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_binding_unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding);

}
