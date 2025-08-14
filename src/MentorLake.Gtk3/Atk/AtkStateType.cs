namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The possible types of states of an object
/// </para>
/// </summary>

[Flags]
public enum AtkStateType
{
/// <summary>
/// <para>
/// Indicates an invalid state - probably an error condition.
/// </para>
/// </summary>

	ATK_STATE_INVALID = 0,
/// <summary>
/// <para>
/// Indicates a window is currently the active window, or an object is the active subelement within a container or table. ATK_STATE_ACTIVE should not be used for objects which have ATK_STATE_FOCUSABLE or ATK_STATE_SELECTABLE: Those objects should use ATK_STATE_FOCUSED and ATK_STATE_SELECTED respectively. ATK_STATE_ACTIVE is a means to indicate that an object which is not focusable and not selectable is the currently-active item within its parent container.
/// </para>
/// </summary>

	ATK_STATE_ACTIVE = 1,
/// <summary>
/// <para>
/// Indicates that the object is 'armed', i.e. will be activated by if a pointer button-release event occurs within its bounds.  Buttons often enter this state when a pointer click occurs within their bounds, as a precursor to activation. ATK_STATE_ARMED has been deprecated since ATK-2.16 and should not be used in newly-written code.
/// </para>
/// </summary>

	ATK_STATE_ARMED = 2,
/// <summary>
/// <para>
/// Indicates the current object is busy, i.e. onscreen representation is in the process of changing, or the object is temporarily unavailable for interaction due to activity already in progress.  This state may be used by implementors of Document to indicate that content loading is underway.  It also may indicate other 'pending' conditions; clients may wish to interrogate this object when the ATK_STATE_BUSY flag is removed.
/// </para>
/// </summary>

	ATK_STATE_BUSY = 3,
/// <summary>
/// <para>
/// Indicates this object is currently checked, for instance a checkbox is 'non-empty'.
/// </para>
/// </summary>

	ATK_STATE_CHECKED = 4,
/// <summary>
/// <para>
/// Indicates that this object no longer has a valid backing widget (for instance, if its peer object has been destroyed)
/// </para>
/// </summary>

	ATK_STATE_DEFUNCT = 5,
/// <summary>
/// <para>
/// Indicates that this object can contain text, and that the
/// user can change the textual contents of this object by editing those contents
/// directly. For an object which is expected to be editable due to its type, but
/// which cannot be edited due to the application or platform preventing the user
/// from doing so, that object's #AtkStateSet should lack ATK_STATE_EDITABLE and
/// should contain ATK_STATE_READ_ONLY.
/// </para>
/// </summary>

	ATK_STATE_EDITABLE = 6,
/// <summary>
/// <para>
/// Indicates that this object is enabled, i.e. that it currently reflects some application state. Objects that are "greyed out" may lack this state, and may lack the STATE_SENSITIVE if direct user interaction cannot cause them to acquire STATE_ENABLED. See also: ATK_STATE_SENSITIVE
/// </para>
/// </summary>

	ATK_STATE_ENABLED = 7,
/// <summary>
/// <para>
/// Indicates this object allows progressive disclosure of its children
/// </para>
/// </summary>

	ATK_STATE_EXPANDABLE = 8,
/// <summary>
/// <para>
/// Indicates this object its expanded - see ATK_STATE_EXPANDABLE above
/// </para>
/// </summary>

	ATK_STATE_EXPANDED = 9,
/// <summary>
/// <para>
/// Indicates this object can accept keyboard focus, which means all events resulting from typing on the keyboard will normally be passed to it when it has focus
/// </para>
/// </summary>

	ATK_STATE_FOCUSABLE = 10,
/// <summary>
/// <para>
/// Indicates this object currently has the keyboard focus
/// </para>
/// </summary>

	ATK_STATE_FOCUSED = 11,
/// <summary>
/// <para>
/// Indicates the orientation of this object is horizontal; used, for instance, by objects of ATK_ROLE_SCROLL_BAR.  For objects where vertical/horizontal orientation is especially meaningful.
/// </para>
/// </summary>

	ATK_STATE_HORIZONTAL = 12,
/// <summary>
/// <para>
/// Indicates this object is minimized and is represented only by an icon
/// </para>
/// </summary>

	ATK_STATE_ICONIFIED = 13,
/// <summary>
/// <para>
/// Indicates something must be done with this object before the user can interact with an object in a different window
/// </para>
/// </summary>

	ATK_STATE_MODAL = 14,
/// <summary>
/// <para>
/// Indicates this (text) object can contain multiple lines of text
/// </para>
/// </summary>

	ATK_STATE_MULTI_LINE = 15,
/// <summary>
/// <para>
/// Indicates this object allows more than one of its children to be selected at the same time, or in the case of text objects, that the object supports non-contiguous text selections.
/// </para>
/// </summary>

	ATK_STATE_MULTISELECTABLE = 16,
/// <summary>
/// <para>
/// Indicates this object paints every pixel within its rectangular region.
/// </para>
/// </summary>

	ATK_STATE_OPAQUE = 17,
/// <summary>
/// <para>
/// Indicates this object is currently pressed.
/// </para>
/// </summary>

	ATK_STATE_PRESSED = 18,
/// <summary>
/// <para>
/// Indicates the size of this object is not fixed
/// </para>
/// </summary>

	ATK_STATE_RESIZABLE = 19,
/// <summary>
/// <para>
/// Indicates this object is the child of an object that allows its children to be selected and that this child is one of those children that can be selected
/// </para>
/// </summary>

	ATK_STATE_SELECTABLE = 20,
/// <summary>
/// <para>
/// Indicates this object is the child of an object that allows its children to be selected and that this child is one of those children that has been selected
/// </para>
/// </summary>

	ATK_STATE_SELECTED = 21,
/// <summary>
/// <para>
/// Indicates this object is sensitive, e.g. to user interaction.
/// STATE_SENSITIVE usually accompanies STATE_ENABLED for user-actionable controls,
/// but may be found in the absence of STATE_ENABLED if the current visible state of the
/// control is "disconnected" from the application state.  In such cases, direct user interaction
/// can often result in the object gaining STATE_SENSITIVE, for instance if a user makes
/// an explicit selection using an object whose current state is ambiguous or undefined.
/// @see STATE_ENABLED, STATE_INDETERMINATE.
/// </para>
/// </summary>

	ATK_STATE_SENSITIVE = 22,
/// <summary>
/// <para>
/// Indicates this object, the object's parent, the object's parent's parent, and so on,
/// are all 'shown' to the end-user, i.e. subject to "exposure" if blocking or obscuring objects do not interpose
/// between this object and the top of the window stack.
/// </para>
/// </summary>

	ATK_STATE_SHOWING = 23,
/// <summary>
/// <para>
/// Indicates this (text) object can contain only a single line of text
/// </para>
/// </summary>

	ATK_STATE_SINGLE_LINE = 24,
/// <summary>
/// <para>
/// Indicates that the information returned for this object may no longer be
/// synchronized with the application state.  This is implied if the object has STATE_TRANSIENT,
/// and can also occur towards the end of the object peer's lifecycle. It can also be used to indicate that
/// the index associated with this object has changed since the user accessed the object (in lieu of
/// "index-in-parent-changed" events).
/// </para>
/// </summary>

	ATK_STATE_STALE = 25,
/// <summary>
/// <para>
/// Indicates this object is transient, i.e. a snapshot which may not emit events when its
/// state changes.  Data from objects with ATK_STATE_TRANSIENT should not be cached, since there may be no
/// notification given when the cached data becomes obsolete.
/// </para>
/// </summary>

	ATK_STATE_TRANSIENT = 26,
/// <summary>
/// <para>
/// Indicates the orientation of this object is vertical
/// </para>
/// </summary>

	ATK_STATE_VERTICAL = 27,
/// <summary>
/// <para>
/// Indicates this object is visible, e.g. has been explicitly marked for exposure to the user.
/// **note**: %ATK_STATE_VISIBLE is no guarantee that the object is actually unobscured on the screen, only
/// that it is 'potentially' visible, barring obstruction, being scrolled or clipped out of the
/// field of view, or having an ancestor container that has not yet made visible.
/// A widget is potentially onscreen if it has both %ATK_STATE_VISIBLE and %ATK_STATE_SHOWING.
/// The absence of %ATK_STATE_VISIBLE and %ATK_STATE_SHOWING is semantically equivalent to saying
/// that an object is 'hidden'.  See also %ATK_STATE_TRUNCATED, which applies if an object with
/// %ATK_STATE_VISIBLE and %ATK_STATE_SHOWING set lies within a viewport which means that its
/// contents are clipped, e.g. a truncated spreadsheet cell or
/// an image within a scrolling viewport.  Mostly useful for screen-review and magnification
/// algorithms.
/// </para>
/// </summary>

	ATK_STATE_VISIBLE = 28,
/// <summary>
/// <para>
/// Indicates that "active-descendant-changed" event
/// is sent when children become 'active' (i.e. are selected or navigated to onscreen).
/// Used to prevent need to enumerate all children in very large containers, like tables.
/// The presence of STATE_MANAGES_DESCENDANTS is an indication to the client.
/// that the children should not, and need not, be enumerated by the client.
/// Objects implementing this state are expected to provide relevant state
/// notifications to listening clients, for instance notifications of visibility
/// changes and activation of their contained child objects, without the client
/// having previously requested references to those children.
/// </para>
/// </summary>

	ATK_STATE_MANAGES_DESCENDANTS = 29,
/// <summary>
/// <para>
/// Indicates that the value, or some other quantifiable
/// property, of this AtkObject cannot be fully determined. In the case of a large
/// data set in which the total number of items in that set is unknown (e.g. 1 of
/// 999+), implementors should expose the currently-known set size (999) along
/// with this state. In the case of a check box, this state should be used to
/// indicate that the check box is a tri-state check box which is currently
/// neither checked nor unchecked.
/// </para>
/// </summary>

	ATK_STATE_INDETERMINATE = 30,
/// <summary>
/// <para>
/// Indicates that an object is truncated, e.g. a text value in a speradsheet cell.
/// </para>
/// </summary>

	ATK_STATE_TRUNCATED = 31,
/// <summary>
/// <para>
/// Indicates that explicit user interaction with an object is required by the user interface, e.g. a required field in a "web-form" interface.
/// </para>
/// </summary>

	ATK_STATE_REQUIRED = 32,
/// <summary>
/// <para>
/// Indicates that the object has encountered an error condition due to failure of input validation. For instance, a form control may acquire this state in response to invalid or malformed user input.
/// </para>
/// </summary>

	ATK_STATE_INVALID_ENTRY = 33,
/// <summary>
/// <para>
/// Indicates that the object in question implements some form of ¨typeahead¨ or
/// pre-selection behavior whereby entering the first character of one or more sub-elements
/// causes those elements to scroll into view or become selected.  Subsequent character input
/// may narrow the selection further as long as one or more sub-elements match the string.
/// This state is normally only useful and encountered on objects that implement Selection.
/// In some cases the typeahead behavior may result in full or partial ¨completion¨ of
/// the data in the input field, in which case these input events may trigger text-changed
/// events from the AtkText interface.  This state supplants @ATK_ROLE_AUTOCOMPLETE.
/// </para>
/// </summary>

	ATK_STATE_SUPPORTS_AUTOCOMPLETION = 34,
/// <summary>
/// <para>
/// Indicates that the object in question supports text selection. It should only be exposed on objects which implement the Text interface, in order to distinguish this state from @ATK_STATE_SELECTABLE, which infers that the object in question is a selectable child of an object which implements Selection. While similar, text selection and subelement selection are distinct operations.
/// </para>
/// </summary>

	ATK_STATE_SELECTABLE_TEXT = 35,
/// <summary>
/// <para>
/// Indicates that the object is the "default" active component, i.e. the object which is activated by an end-user press of the "Enter" or "Return" key.  Typically a "close" or "submit" button.
/// </para>
/// </summary>

	ATK_STATE_DEFAULT = 36,
/// <summary>
/// <para>
/// Indicates that the object changes its appearance dynamically as an inherent part of its presentation.  This state may come and go if an object is only temporarily animated on the way to a 'final' onscreen presentation.
/// **note**: some applications, notably content viewers, may not be able to detect
/// all kinds of animated content.  Therefore the absence of this state should not
/// be taken as definitive evidence that the object's visual representation is
/// static; this state is advisory.
/// </para>
/// </summary>

	ATK_STATE_ANIMATED = 37,
/// <summary>
/// <para>
/// Indicates that the object (typically a hyperlink) has already been 'activated', and/or its backing data has already been downloaded, rendered, or otherwise "visited".
/// </para>
/// </summary>

	ATK_STATE_VISITED = 38,
/// <summary>
/// <para>
/// Indicates this object has the potential to be
///  checked, such as a checkbox or toggle-able table cell. @Since:
///  ATK-2.12
/// </para>
/// </summary>

	ATK_STATE_CHECKABLE = 39,
/// <summary>
/// <para>
/// Indicates that the object has a popup context
/// menu or sub-level menu which may or may not be showing. This means
/// that activation renders conditional content.  Note that ordinary
/// tooltips are not considered popups in this context. @Since: ATK-2.12
/// </para>
/// </summary>

	ATK_STATE_HAS_POPUP = 40,
/// <summary>
/// <para>
/// Indicates this object has a tooltip. @Since: ATK-2.16
/// </para>
/// </summary>

	ATK_STATE_HAS_TOOLTIP = 41,
/// <summary>
/// <para>
/// Indicates that a widget which is ENABLED and SENSITIVE
/// has a value which can be read, but not modified, by the user. Note that this
/// state should only be applied to widget types whose value is normally directly
/// user modifiable, such as check boxes, radio buttons, spin buttons, text input
/// fields, and combo boxes, as a means to convey that the expected interaction
/// with that widget is not possible. When the expected interaction with a
/// widget does not include modification by the user, as is the case with
/// labels and containers, ATK_STATE_READ_ONLY should not be applied. See also
/// ATK_STATE_EDITABLE. @Since: ATK-2-16
/// </para>
/// </summary>

	ATK_STATE_READ_ONLY = 42,
/// <summary>
/// <para>
/// Indicates this object is collapsed. @Since: ATK-2.38
/// </para>
/// </summary>

	ATK_STATE_COLLAPSED = 43,
/// <summary>
/// <para>
/// Not a valid state, used for finding end of enumeration
/// </para>
/// </summary>

	ATK_STATE_LAST_DEFINED = 44
}
