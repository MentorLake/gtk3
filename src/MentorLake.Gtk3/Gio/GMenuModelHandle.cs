namespace MentorLake.Gio;

public class GMenuModelHandle : GObjectHandle
{
}
public static class GMenuModelHandleSignalExtensions
{

	public static IObservable<GMenuModelHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this GMenuModelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GMenuModelHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			GMenuModelHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GMenuModelHandle self,  int position,  int removed,  int added,  IntPtr user_data) =>
			{
				

				var signalStruct = new GMenuModelHandleSignalStructs.ItemsChangedSignal()
				{
					Self = self, Position = position, Removed = removed, Added = added, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "items-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GMenuModelHandleSignalStructs
{

public struct ItemsChangedSignal
{
	public MentorLake.Gio.GMenuModelHandle Self;
	public int Position;
	public int Removed;
	public int Added;
	public IntPtr UserData;
}
}

public static class GMenuModelHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle self, int position, int removed, int added, IntPtr user_data);

}


public static class GMenuModelHandleExtensions
{
	public static bool GetItemAttribute(this MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, string format_string, IntPtr @__arglist)
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_item_attribute(model, item_index, attribute, format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle GetItemAttributeValue(this MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_item_attribute_value(model, item_index, attribute, expected_type);
	}

	public static MentorLake.Gio.GMenuModelHandle GetItemLink(this MentorLake.Gio.GMenuModelHandle model, int item_index, string link)
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_item_link(model, item_index, link);
	}

	public static int GetNItems(this MentorLake.Gio.GMenuModelHandle model)
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_get_n_items(model);
	}

	public static bool IsMutable(this MentorLake.Gio.GMenuModelHandle model)
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_is_mutable(model);
	}

	public static T ItemsChanged<T>(this T model, int position, int removed, int added) where T : GMenuModelHandle
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		GMenuModelHandleExterns.g_menu_model_items_changed(model, position, removed, added);
		return model;
	}

	public static MentorLake.Gio.GMenuAttributeIterHandle IterateItemAttributes(this MentorLake.Gio.GMenuModelHandle model, int item_index)
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_iterate_item_attributes(model, item_index);
	}

	public static MentorLake.Gio.GMenuLinkIterHandle IterateItemLinks(this MentorLake.Gio.GMenuModelHandle model, int item_index)
	{
		if (model.IsInvalid || model.IsClosed) throw new Exception("Invalid or closed handle (GMenuModelHandle)");
		return GMenuModelHandleExterns.g_menu_model_iterate_item_links(model, item_index);
	}

}

internal class GMenuModelHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_model_get_item_attribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, string format_string, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_menu_model_get_item_attribute_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index, string attribute, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuModelHandle g_menu_model_get_item_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index, string link);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_menu_model_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_menu_model_is_mutable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_menu_model_items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int position, int removed, int added);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuAttributeIterHandle g_menu_model_iterate_item_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GMenuLinkIterHandle g_menu_model_iterate_item_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, int item_index);

}
