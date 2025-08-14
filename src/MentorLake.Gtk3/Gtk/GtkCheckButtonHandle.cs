namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkCheckButton places a discrete #GtkToggleButton next to a widget,
/// (usually a #GtkLabel). See the section on #GtkToggleButton widgets for
/// more information about toggle/check buttons.
/// </para>
/// <para>
/// The important signal ( #GtkToggleButton::toggled ) is also inherited from
/// #GtkToggleButton.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// checkbutton
/// ├── check
/// ╰── <child>
/// ]|
/// </para>
/// <para>
/// A GtkCheckButton with indicator (see gtk_toggle_button_set_mode()) has a
/// main CSS node with name checkbutton and a subnode with name check.
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// button.check
/// ├── check
/// ╰── <child>
/// ]|
/// </para>
/// <para>
/// A GtkCheckButton without indicator changes the name of its main node
/// to button and adds a .check style class to it. The subnode is invisible
/// in this case.
/// </para>
/// </summary>

public class GtkCheckButtonHandle : GtkToggleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCheckButton.
/// </para>
/// </summary>

/// <return>
/// a #GtkWidget.
/// </return>

	public static MentorLake.Gtk.GtkCheckButtonHandle New()
	{
		return GtkCheckButtonHandleExterns.gtk_check_button_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkCheckButton with a #GtkLabel to the right of it.
/// </para>
/// </summary>

/// <param name="label">
/// the text for the check button.
/// </param>
/// <return>
/// a #GtkWidget.
/// </return>

	public static MentorLake.Gtk.GtkCheckButtonHandle NewWithLabel(string label)
	{
		return GtkCheckButtonHandleExterns.gtk_check_button_new_with_label(label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkCheckButton containing a label. The label
/// will be created using gtk_label_new_with_mnemonic(), so underscores
/// in @label indicate the mnemonic for the check button.
/// </para>
/// </summary>

/// <param name="label">
/// The text of the button, with an underscore in front of the
///   mnemonic character
/// </param>
/// <return>
/// a new #GtkCheckButton
/// </return>

	public static MentorLake.Gtk.GtkCheckButtonHandle NewWithMnemonic(string label)
	{
		return GtkCheckButtonHandleExterns.gtk_check_button_new_with_mnemonic(label);
	}

}

public static class GtkCheckButtonHandleExtensions
{
}

internal class GtkCheckButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCheckButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkCheckButtonHandle gtk_check_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCheckButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkCheckButtonHandle gtk_check_button_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCheckButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkCheckButtonHandle gtk_check_button_new_with_mnemonic(string label);

}
