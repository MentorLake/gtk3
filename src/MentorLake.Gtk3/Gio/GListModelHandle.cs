namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GListModel` is an interface that represents a mutable list of
/// [class@GObject.Object]. Its main intention is as a model for various widgets
/// in user interfaces, such as list views, but it can also be used as a
/// convenient method of returning lists of data, with support for
/// updates.
/// </para>
/// <para>
/// Each object in the list may also report changes in itself via some
/// mechanism (normally the [signal@GObject.Object::notify] signal).  Taken
/// together with the [signal@Gio.ListModel::items-changed] signal, this provides
/// for a list that can change its membership, and in which the members can
/// change their individual properties.
/// </para>
/// <para>
/// A good example would be the list of visible wireless network access
/// points, where each access point can report dynamic properties such as
/// signal strength.
/// </para>
/// <para>
/// It is important to note that the `GListModel` itself does not report
/// changes to the individual items.  It only reports changes to the list
/// membership.  If you want to observe changes to the objects themselves
/// then you need to connect signals to the objects that you are
/// interested in.
/// </para>
/// <para>
/// All items in a `GListModel` are of (or derived from) the same type.
/// [method@Gio.ListModel.get_item_type] returns that type.  The type may be an
/// interface, in which case all objects in the list must implement it.
/// </para>
/// <para>
/// The semantics are close to that of an array:
/// [method@Gio.ListModel.get_n_items] returns the number of items in the list
/// and [method@Gio.ListModel.get_item] returns an item at a (0-based) position.
/// In order to allow implementations to calculate the list length lazily,
/// you can also iterate over items: starting from 0, repeatedly call
/// [method@Gio.ListModel.get_item] until it returns `NULL`.
/// </para>
/// <para>
/// An implementation may create objects lazily, but must take care to
/// return the same object for a given position until all references to
/// it are gone.
/// </para>
/// <para>
/// On the other side, a consumer is expected only to hold references on
/// objects that are currently ‘user visible’, in order to facilitate the
/// maximum level of laziness in the implementation of the list and to
/// reduce the required number of signal connections at a given time.
/// </para>
/// <para>
/// This interface is intended only to be used from a single thread.  The
/// thread in which it is appropriate to use it depends on the particular
/// implementation, but typically it will be from the thread that owns
/// the thread-default main context (see
/// [method@GLib.MainContext.push_thread_default]) in effect at the time that the
/// model was created.
/// </para>
/// <para>
/// Over time, it has established itself as good practice for list model
/// implementations to provide properties `item-type` and `n-items` to
/// ease working with them. While it is not required, it is recommended
/// that implementations provide these two properties. They should return
/// the values of [method@Gio.ListModel.get_item_type] and
/// [method@Gio.ListModel.get_n_items] respectively and be defined as such:
/// </para>
/// <para>
/// ```c
/// properties[PROP_ITEM_TYPE] =
///   g_param_spec_gtype ("item-type", NULL, NULL, G_TYPE_OBJECT,
///                       G_PARAM_CONSTRUCT_ONLY | G_PARAM_READWRITE | G_PARAM_STATIC_STRINGS);
/// properties[PROP_N_ITEMS] =
///   g_param_spec_uint ("n-items", NULL, NULL, 0, G_MAXUINT, 0,
///                      G_PARAM_READABLE | G_PARAM_STATIC_STRINGS);
/// ```
/// </para>
/// </summary>

public interface GListModelHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GListModelHandleImpl : BaseSafeHandle, GListModelHandle
{
}

public static class GListModelHandleExtensions
{
/// <summary>
/// <para>
/// Get the item at @position.
/// </para>
/// <para>
/// If @position is greater than the number of items in @list, %NULL is
/// returned.
/// </para>
/// <para>
/// %NULL is never returned for an index that is smaller than the length
/// of the list.
/// </para>
/// <para>
/// See also: g_list_model_get_n_items()
/// </para>
/// </summary>

/// <param name="list">
/// a #GListModel
/// </param>
/// <param name="position">
/// the position of the item to fetch
/// </param>
/// <return>
/// the item at @position.
/// </return>

	public static IntPtr GetItem(this MentorLake.Gio.GListModelHandle list, uint position)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_item(list, position);
	}

/// <summary>
/// <para>
/// Gets the type of the items in @list.
/// </para>
/// <para>
/// All items returned from g_list_model_get_item() are of the type
/// returned by this function, or a subtype, or if the type is an
/// interface, they are an implementation of that interface.
/// </para>
/// <para>
/// The item type of a #GListModel can not change during the life of the
/// model.
/// </para>
/// </summary>

/// <param name="list">
/// a #GListModel
/// </param>
/// <return>
/// the #GType of the items contained in @list.
/// </return>

	public static MentorLake.GObject.GType GetItemType(this MentorLake.Gio.GListModelHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_item_type(list);
	}

/// <summary>
/// <para>
/// Gets the number of items in @list.
/// </para>
/// <para>
/// Depending on the model implementation, calling this function may be
/// less efficient than iterating the list with increasing values for
/// @position until g_list_model_get_item() returns %NULL.
/// </para>
/// </summary>

/// <param name="list">
/// a #GListModel
/// </param>
/// <return>
/// the number of items in @list.
/// </return>

	public static uint GetNItems(this MentorLake.Gio.GListModelHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_n_items(list);
	}

/// <summary>
/// <para>
/// Get the item at @position.
/// </para>
/// <para>
/// If @position is greater than the number of items in @list, %NULL is
/// returned.
/// </para>
/// <para>
/// %NULL is never returned for an index that is smaller than the length
/// of the list.
/// </para>
/// <para>
/// This function is meant to be used by language bindings in place
/// of g_list_model_get_item().
/// </para>
/// <para>
/// See also: g_list_model_get_n_items()
/// </para>
/// </summary>

/// <param name="list">
/// a #GListModel
/// </param>
/// <param name="position">
/// the position of the item to fetch
/// </param>
/// <return>
/// the object at @position.
/// </return>

	public static MentorLake.GObject.GObjectHandle GetObject(this MentorLake.Gio.GListModelHandle list, uint position)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		return GListModelHandleExterns.g_list_model_get_object(list, position);
	}

/// <summary>
/// <para>
/// Emits the #GListModel::items-changed signal on @list.
/// </para>
/// <para>
/// This function should only be called by classes implementing
/// #GListModel. It has to be called after the internal representation
/// of @list has been updated, because handlers connected to this signal
/// might query the new state of the list.
/// </para>
/// <para>
/// Implementations must only make changes to the model (as visible to
/// its consumer) in places that will not cause problems for that
/// consumer.  For models that are driven directly by a write API (such
/// as #GListStore), changes can be reported in response to uses of that
/// API.  For models that represent remote data, changes should only be
/// made from a fresh mainloop dispatch.  It is particularly not
/// permitted to make changes in response to a call to the #GListModel
/// consumer API.
/// </para>
/// <para>
/// Stated another way: in general, it is assumed that code making a
/// series of accesses to the model via the API, without returning to the
/// mainloop, and without calling other code, will continue to view the
/// same contents of the model.
/// </para>
/// </summary>

/// <param name="list">
/// a #GListModel
/// </param>
/// <param name="position">
/// the position at which @list changed
/// </param>
/// <param name="removed">
/// the number of items removed
/// </param>
/// <param name="added">
/// the number of items added
/// </param>

	public static T ItemsChanged<T>(this T list, uint position, uint removed, uint added) where T : GListModelHandle
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GListModelHandle)");
		GListModelHandleExterns.g_list_model_items_changed(list, position, removed, added);
		return list;
	}

}

internal class GListModelHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_list_model_get_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list, uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_list_model_get_item_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_list_model_get_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_list_model_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list, uint position);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_list_model_items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle list, uint position, uint removed, uint added);

}
