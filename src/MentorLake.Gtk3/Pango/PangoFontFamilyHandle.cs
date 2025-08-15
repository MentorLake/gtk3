namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoFontFamily` is used to represent a family of related
/// font faces.
/// </para>
/// <para>
/// The font faces in a family share a common design, but differ in
/// slant, weight, width or other aspects.
/// </para>
/// </summary>

public class PangoFontFamilyHandle : GObjectHandle, GListModelHandle
{
}
public static class PangoFontFamilyHandleSignalExtensions
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

	public static IObservable<PangoFontFamilyHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this PangoFontFamilyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<PangoFontFamilyHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			PangoFontFamilyHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GListModelHandle self,  uint position,  uint removed,  uint added,  IntPtr user_data) =>
			{
				

				var signalStruct = new PangoFontFamilyHandleSignalStructs.ItemsChangedSignal()
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

public static class PangoFontFamilyHandleSignalStructs
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

public static class PangoFontFamilyHandleSignalDelegates
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


public static class PangoFontFamilyHandleExtensions
{
/// <summary>
/// <para>
/// Gets the `PangoFontFace` of @family with the given name.
/// </para>
/// </summary>

/// <param name="family">
/// a `PangoFontFamily`
/// </param>
/// <param name="name">
/// the name of a face. If the name is %NULL,
///   the family&apos;s default face (fontconfig calls it &quot;Regular&quot;)
///   will be returned.
/// </param>
/// <return>
/// the `PangoFontFace`,
///   or %NULL if no face with the given name exists.
/// </return>

	public static MentorLake.Pango.PangoFontFaceHandle GetFace(this MentorLake.Pango.PangoFontFamilyHandle family, string name)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_get_face(family, name);
	}

/// <summary>
/// <para>
/// Gets the name of the family.
/// </para>
/// <para>
/// The name is unique among all fonts for the font backend and can
/// be used in a `PangoFontDescription` to specify that a face from
/// this family is desired.
/// </para>
/// </summary>

/// <param name="family">
/// a `PangoFontFamily`
/// </param>
/// <return>
/// the name of the family. This string is owned
///   by the family object and must not be modified or freed.
/// </return>

	public static string GetName(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_get_name(family);
	}

/// <summary>
/// <para>
/// A monospace font is a font designed for text display where the the
/// characters form a regular grid.
/// </para>
/// <para>
/// For Western languages this would
/// mean that the advance width of all characters are the same, but
/// this categorization also includes Asian fonts which include
/// double-width characters: characters that occupy two grid cells.
/// g_unichar_iswide() returns a result that indicates whether a
/// character is typically double-width in a monospace font.
/// </para>
/// <para>
/// The best way to find out the grid-cell size is to call
/// [method@Pango.FontMetrics.get_approximate_digit_width], since the
/// results of [method@Pango.FontMetrics.get_approximate_char_width] may
/// be affected by double-width characters.
/// </para>
/// </summary>

/// <param name="family">
/// a `PangoFontFamily`
/// </param>
/// <return>
/// %TRUE if the family is monospace.
/// </return>

	public static bool IsMonospace(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_is_monospace(family);
	}

/// <summary>
/// <para>
/// A variable font is a font which has axes that can be modified to
/// produce different faces.
/// </para>
/// <para>
/// Such axes are also known as _variations_; see
/// [method@Pango.FontDescription.set_variations] for more information.
/// </para>
/// </summary>

/// <param name="family">
/// a `PangoFontFamily`
/// </param>
/// <return>
/// %TRUE if the family is variable
/// </return>

	public static bool IsVariable(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_is_variable(family);
	}

/// <summary>
/// <para>
/// Lists the different font faces that make up @family.
/// </para>
/// <para>
/// The faces in a family share a common design, but differ in slant, weight,
/// width and other aspects.
/// </para>
/// <para>
/// Note that the returned faces are not in any particular order, and
/// multiple faces may have the same name or characteristics.
/// </para>
/// <para>
/// `PangoFontFamily` also implemented the [iface@Gio.ListModel] interface
/// for enumerating faces.
/// </para>
/// </summary>

/// <param name="family">
/// a `PangoFontFamily`
/// </param>
/// <param name="faces">
/// 
///   location to store an array of pointers to `PangoFontFace` objects,
///   or %NULL. This array should be freed with g_free() when it is no
///   longer needed.
/// </param>
/// <param name="n_faces">
/// location to store number of elements in @faces.
/// </param>

	public static T ListFaces<T>(this T family, out MentorLake.Pango.PangoFontFaceHandle[] faces, out int n_faces) where T : PangoFontFamilyHandle
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		PangoFontFamilyHandleExterns.pango_font_family_list_faces(family, out faces, out n_faces);
		return family;
	}

}

internal class PangoFontFamilyHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))]
	internal static extern MentorLake.Pango.PangoFontFaceHandle pango_font_family_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family, string name);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_family_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_family_is_monospace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_family_is_variable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_family_list_faces([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] out MentorLake.Pango.PangoFontFaceHandle[] faces, out int n_faces);

}
