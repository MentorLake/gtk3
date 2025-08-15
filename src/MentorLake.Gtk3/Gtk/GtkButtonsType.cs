namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Prebuilt sets of buttons for the dialog. If
/// none of these choices are appropriate, simply use %GTK_BUTTONS_NONE
/// then call gtk_dialog_add_buttons().
/// </para>
/// <para>
/// &amp;gt; Please note that %GTK_BUTTONS_OK, %GTK_BUTTONS_YES_NO
/// &amp;gt; and %GTK_BUTTONS_OK_CANCEL are discouraged by the
/// &amp;gt; [GNOME Human Interface Guidelines](http://library.gnome.org/devel/hig-book/stable/).
/// </para>
/// </summary>

[Flags]
public enum GtkButtonsType
{
/// <summary>
/// <para>
/// no buttons at all
/// </para>
/// </summary>

	GTK_BUTTONS_NONE = 0,
/// <summary>
/// <para>
/// an OK button
/// </para>
/// </summary>

	GTK_BUTTONS_OK = 1,
/// <summary>
/// <para>
/// a Close button
/// </para>
/// </summary>

	GTK_BUTTONS_CLOSE = 2,
/// <summary>
/// <para>
/// a Cancel button
/// </para>
/// </summary>

	GTK_BUTTONS_CANCEL = 3,
/// <summary>
/// <para>
/// Yes and No buttons
/// </para>
/// </summary>

	GTK_BUTTONS_YES_NO = 4,
/// <summary>
/// <para>
/// OK and Cancel buttons
/// </para>
/// </summary>

	GTK_BUTTONS_OK_CANCEL = 5
}
