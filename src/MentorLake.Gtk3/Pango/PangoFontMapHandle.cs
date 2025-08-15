namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoFontMap` represents the set of fonts available for a
/// particular rendering system.
/// </para>
/// <para>
/// This is a virtual object with implementations being specific to
/// particular rendering systems.
/// </para>
/// </summary>

public class PangoFontMapHandle : GObjectHandle, GListModelHandle
{
}
public static class PangoFontMapHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted whenever items were added to or removed
/// from @list. At @position, @removed items were removed and @added
/// items were added in their place.
/// </para>
/// <para>
/// Note: If `removed != added`, the positions of all later items
/// in the model change.
/// </para>
/// </summary>

	public static IObservable<PangoFontMapHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this PangoFontMapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<PangoFontMapHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			PangoFontMapHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GListModelHandle self,  uint position,  uint removed,  uint added,  IntPtr user_data) =>
			{
				

				var signalStruct = new PangoFontMapHandleSignalStructs.ItemsChangedSignal()
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

public static class PangoFontMapHandleSignalStructs
{

public class ItemsChangedSignal
{

	public MentorLake.Gio.GListModelHandle Self;
/// <summary>
/// <para>
/// the position at which @list changed
/// </para>
/// </summary>

	public uint Position;
/// <summary>
/// <para>
/// the number of items removed
/// </para>
/// </summary>

	public uint Removed;
/// <summary>
/// <para>
/// the number of items added
/// </para>
/// </summary>

	public uint Added;

	public IntPtr UserData;
}
}

public static class PangoFontMapHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted whenever items were added to or removed
/// from @list. At @position, @removed items were removed and @added
/// items were added in their place.
/// </para>
/// <para>
/// Note: If `removed != added`, the positions of all later items
/// in the model change.
/// </para>
/// </summary>

/// <param name="self">
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
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle self, uint position, uint removed, uint added, IntPtr user_data);

}


public static class PangoFontMapHandleExtensions
{
/// <summary>
/// <para>
/// Loads a font file with one or more fonts into the `PangoFontMap`.
/// </para>
/// <para>
/// The added fonts will take precedence over preexisting
/// fonts with the same name.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <param name="filename">
/// Path to the font file
/// </param>
/// <return>
/// True if the font file is successfully loaded
///     into the fontmap, false if an error occurred.
/// </return>

	public static bool AddFontFile(this MentorLake.Pango.PangoFontMapHandle fontmap, string filename)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		var externCallResult = PangoFontMapHandleExterns.pango_font_map_add_font_file(fontmap, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Forces a change in the context, which will cause any `PangoContext`
/// using this fontmap to change.
/// </para>
/// <para>
/// This function is only useful when implementing a new backend
/// for Pango, something applications won&apos;t do. Backends should
/// call this function if they have attached extra data to the
/// context and such data is changed.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>

	public static T Changed<T>(this T fontmap) where T : PangoFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		PangoFontMapHandleExterns.pango_font_map_changed(fontmap);
		return fontmap;
	}

/// <summary>
/// <para>
/// Creates a `PangoContext` connected to @fontmap.
/// </para>
/// <para>
/// This is equivalent to [ctor@Pango.Context.new] followed by
/// [method@Pango.Context.set_font_map].
/// </para>
/// <para>
/// If you are using Pango as part of a higher-level system,
/// that system may have it&apos;s own way of create a `PangoContext`.
/// For instance, the GTK toolkit has, among others,
/// gtk_widget_get_pango_context(). Use those instead.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <return>
/// the newly allocated `PangoContext`,
///   which should be freed with g_object_unref().
/// </return>

	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.Pango.PangoFontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_create_context(fontmap);
	}

/// <summary>
/// <para>
/// Gets a font family by name.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <param name="name">
/// a family name
/// </param>
/// <return>
/// the `PangoFontFamily`
/// </return>

	public static MentorLake.Pango.PangoFontFamilyHandle GetFamily(this MentorLake.Pango.PangoFontMapHandle fontmap, string name)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_get_family(fontmap, name);
	}

/// <summary>
/// <para>
/// Returns the current serial number of @fontmap.
/// </para>
/// <para>
/// The serial number is initialized to an small number larger than zero
/// when a new fontmap is created and is increased whenever the fontmap
/// is changed. It may wrap, but will never have the value 0. Since it can
/// wrap, never compare it with &quot;less than&quot;, always use &quot;not equals&quot;.
/// </para>
/// <para>
/// The fontmap can only be changed using backend-specific API, like changing
/// fontmap resolution.
/// </para>
/// <para>
/// This can be used to automatically detect changes to a `PangoFontMap`,
/// like in `PangoContext`.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <return>
/// The current serial number of @fontmap.
/// </return>

	public static uint GetSerial(this MentorLake.Pango.PangoFontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_get_serial(fontmap);
	}

/// <summary>
/// <para>
/// List all families for a fontmap.
/// </para>
/// <para>
/// Note that the returned families are not in any particular order.
/// </para>
/// <para>
/// `PangoFontMap` also implemented the [iface@Gio.ListModel] interface
/// for enumerating families.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <param name="families">
/// location to
///   store a pointer to an array of `PangoFontFamily` *.
///   This array should be freed with g_free().
/// </param>
/// <param name="n_families">
/// location to store the number of elements in @families
/// </param>

	public static T ListFamilies<T>(this T fontmap, out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families) where T : PangoFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		PangoFontMapHandleExterns.pango_font_map_list_families(fontmap, out families, out n_families);
		return fontmap;
	}

/// <summary>
/// <para>
/// Load the font in the fontmap that is the closest match for @desc.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <param name="context">
/// the `PangoContext` the font will be used with
/// </param>
/// <param name="desc">
/// a `PangoFontDescription` describing the font to load
/// </param>
/// <return>
/// the newly allocated `PangoFont`
///   loaded, or %NULL if no font matched.
/// </return>

	public static MentorLake.Pango.PangoFontHandle LoadFont(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_load_font(fontmap, context, desc);
	}

/// <summary>
/// <para>
/// Load a set of fonts in the fontmap that can be used to render
/// a font matching @desc.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <param name="context">
/// the `PangoContext` the font will be used with
/// </param>
/// <param name="desc">
/// a `PangoFontDescription` describing the font to load
/// </param>
/// <param name="language">
/// a `PangoLanguage` the fonts will be used for
/// </param>
/// <return>
/// the newly allocated
///   `PangoFontset` loaded, or %NULL if no font matched.
/// </return>

	public static MentorLake.Pango.PangoFontsetHandle LoadFontset(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_load_fontset(fontmap, context, desc, language);
	}

/// <summary>
/// <para>
/// Returns a new font that is like @font, except that its size
/// is multiplied by @scale, its backend-dependent configuration
/// (e.g. cairo font options) is replaced by the one in @context,
/// and its variations are replaced by @variations.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFontMap`
/// </param>
/// <param name="font">
/// a font in @fontmap
/// </param>
/// <param name="scale">
/// the scale factor to apply
/// </param>
/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="variations">
/// font variations to use
/// </param>
/// <return>
/// the modified font
/// </return>

	public static MentorLake.Pango.PangoFontHandle ReloadFont(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoFontHandle font, double scale, MentorLake.Pango.PangoContextHandle context, string variations)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_reload_font(fontmap, font, scale, context, variations);
	}

}

internal class PangoFontMapHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_map_add_font_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_map_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle pango_font_map_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, string name);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_font_map_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_map_list_families([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_map_load_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))]
	internal static extern MentorLake.Pango.PangoFontsetHandle pango_font_map_load_fontset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_map_reload_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, double scale, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, string variations);

}
