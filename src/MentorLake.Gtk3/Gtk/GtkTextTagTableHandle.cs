namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// You may wish to begin by reading the
/// [text widget conceptual overview](TextWidget.html)
/// which gives an overview of all the objects and
/// data types related to the text widget and how they work together.
/// </para>
/// <para>
/// # GtkTextTagTables as GtkBuildable
/// </para>
/// <para>
/// The GtkTextTagTable implementation of the GtkBuildable interface
/// supports adding tags by specifying “tag” as the “type” attribute
/// of a `&amp;lt;child&amp;gt;` element.
/// </para>
/// <para>
/// An example of a UI definition fragment specifying tags:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkTextTagTable&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkTextTagTable&quot;&amp;gt;
///  &amp;lt;child type=&quot;tag&quot;&amp;gt;
///    &amp;lt;object class=&quot;GtkTextTag&quot;/&amp;gt;
///  &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// </summary>

public class GtkTextTagTableHandle : GObjectHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTextTagTable. The table contains no tags by
/// default.
/// </para>
/// </summary>

/// <return>
/// a new #GtkTextTagTable
/// </return>

	public static MentorLake.Gtk.GtkTextTagTableHandle New()
	{
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_new();
	}

}
public static class GtkTextTagTableHandleSignalExtensions
{

	public static IObservable<GtkTextTagTableHandleSignalStructs.TagAddedSignal> Signal_TagAdded(this GtkTextTagTableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextTagTableHandleSignalStructs.TagAddedSignal> obs) =>
		{
			GtkTextTagTableHandleSignalDelegates.tag_added handler = ( MentorLake.Gtk.GtkTextTagTableHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableHandleSignalStructs.TagAddedSignal()
				{
					Self = self, Tag = tag, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tag-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextTagTableHandleSignalStructs.TagChangedSignal> Signal_TagChanged(this GtkTextTagTableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextTagTableHandleSignalStructs.TagChangedSignal> obs) =>
		{
			GtkTextTagTableHandleSignalDelegates.tag_changed handler = ( MentorLake.Gtk.GtkTextTagTableHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  bool size_changed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableHandleSignalStructs.TagChangedSignal()
				{
					Self = self, Tag = tag, SizeChanged = size_changed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tag-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextTagTableHandleSignalStructs.TagRemovedSignal> Signal_TagRemoved(this GtkTextTagTableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextTagTableHandleSignalStructs.TagRemovedSignal> obs) =>
		{
			GtkTextTagTableHandleSignalDelegates.tag_removed handler = ( MentorLake.Gtk.GtkTextTagTableHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableHandleSignalStructs.TagRemovedSignal()
				{
					Self = self, Tag = tag, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tag-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTextTagTableHandleSignalStructs
{

public class TagAddedSignal
{

	public MentorLake.Gtk.GtkTextTagTableHandle Self;
/// <summary>
/// <para>
/// the added tag.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextTagHandle Tag;

	public IntPtr UserData;
}

public class TagChangedSignal
{

	public MentorLake.Gtk.GtkTextTagTableHandle Self;
/// <summary>
/// <para>
/// the changed tag.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextTagHandle Tag;
/// <summary>
/// <para>
/// whether the change affects the #GtkTextView layout.
/// </para>
/// </summary>

	public bool SizeChanged;

	public IntPtr UserData;
}

public class TagRemovedSignal
{

	public MentorLake.Gtk.GtkTextTagTableHandle Self;
/// <summary>
/// <para>
/// the removed tag.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTextTagHandle Tag;

	public IntPtr UserData;
}
}

public static class GtkTextTagTableHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="tag">
/// the added tag.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="tag">
/// the changed tag.
/// </param>
/// <param name="size_changed">
/// whether the change affects the #GtkTextView layout.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, bool size_changed, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="tag">
/// the removed tag.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, IntPtr user_data);

}


public static class GtkTextTagTableHandleExtensions
{
/// <summary>
/// <para>
/// Add a tag to the table. The tag is assigned the highest priority
/// in the table.
/// </para>
/// <para>
/// @tag must not be in a tag table already, and may not have
/// the same name as an already-added tag.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTextTagTable
/// </param>
/// <param name="tag">
/// a #GtkTextTag
/// </param>
/// <return>
/// %TRUE on success.
/// </return>

	public static bool Add(this MentorLake.Gtk.GtkTextTagTableHandle table, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTextTagTableHandle)");
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_add(table, tag);
	}

/// <summary>
/// <para>
/// Calls @func on each tag in @table, with user data @data.
/// Note that the table may not be modified while iterating
/// over it (you can’t add/remove tags).
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTextTagTable
/// </param>
/// <param name="func">
/// a function to call on each tag
/// </param>
/// <param name="data">
/// user data
/// </param>

	public static T Foreach<T>(this T table, MentorLake.Gtk.GtkTextTagTableForeach func, IntPtr data) where T : GtkTextTagTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTextTagTableHandle)");
		GtkTextTagTableHandleExterns.gtk_text_tag_table_foreach(table, func, data);
		return table;
	}

/// <summary>
/// <para>
/// Returns the size of the table (number of tags)
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTextTagTable
/// </param>
/// <return>
/// number of tags in @table
/// </return>

	public static int GetSize(this MentorLake.Gtk.GtkTextTagTableHandle table)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTextTagTableHandle)");
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_get_size(table);
	}

/// <summary>
/// <para>
/// Look up a named tag.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTextTagTable
/// </param>
/// <param name="name">
/// name of a tag
/// </param>
/// <return>
/// The tag, or %NULL if none by that
/// name is in the table.
/// </return>

	public static MentorLake.Gtk.GtkTextTagHandle Lookup(this MentorLake.Gtk.GtkTextTagTableHandle table, string name)
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTextTagTableHandle)");
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_lookup(table, name);
	}

/// <summary>
/// <para>
/// Remove a tag from the table. If a #GtkTextBuffer has @table as its tag table,
/// the tag is removed from the buffer. The table’s reference to the tag is
/// removed, so the tag will end up destroyed if you don’t have a reference to
/// it.
/// </para>
/// </summary>

/// <param name="table">
/// a #GtkTextTagTable
/// </param>
/// <param name="tag">
/// a #GtkTextTag
/// </param>

	public static T Remove<T>(this T table, MentorLake.Gtk.GtkTextTagHandle tag) where T : GtkTextTagTableHandle
	{
		if (table.IsInvalid) throw new Exception("Invalid handle (GtkTextTagTableHandle)");
		GtkTextTagTableHandleExterns.gtk_text_tag_table_remove(table, tag);
		return table;
	}

}

internal class GtkTextTagTableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))]
	internal static extern MentorLake.Gtk.GtkTextTagTableHandle gtk_text_tag_table_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_tag_table_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_tag_table_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, MentorLake.Gtk.GtkTextTagTableForeach func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_tag_table_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))]
	internal static extern MentorLake.Gtk.GtkTextTagHandle gtk_text_tag_table_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_tag_table_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

}
