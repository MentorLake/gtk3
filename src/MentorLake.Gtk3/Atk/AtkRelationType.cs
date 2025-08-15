namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Describes the type of the relation
/// </para>
/// </summary>

[Flags]
public enum AtkRelationType
{
/// <summary>
/// <para>
/// Not used, represens &quot;no relationship&quot; or an error condition.
/// </para>
/// </summary>

	ATK_RELATION_NULL = 0,
/// <summary>
/// <para>
/// Indicates an object controlled by one or more target objects.
/// </para>
/// </summary>

	ATK_RELATION_CONTROLLED_BY = 1,
/// <summary>
/// <para>
/// Indicates an object is an controller for one or more target objects.
/// </para>
/// </summary>

	ATK_RELATION_CONTROLLER_FOR = 2,
/// <summary>
/// <para>
/// Indicates an object is a label for one or more target objects.
/// </para>
/// </summary>

	ATK_RELATION_LABEL_FOR = 3,
/// <summary>
/// <para>
/// Indicates an object is labelled by one or more target objects.
/// </para>
/// </summary>

	ATK_RELATION_LABELLED_BY = 4,
/// <summary>
/// <para>
/// Indicates an object is a member of a group of one or more target objects.
/// </para>
/// </summary>

	ATK_RELATION_MEMBER_OF = 5,
/// <summary>
/// <para>
/// Indicates an object is a cell in a treetable which is displayed because a cell in the same column is expanded and identifies that cell.
/// </para>
/// </summary>

	ATK_RELATION_NODE_CHILD_OF = 6,
/// <summary>
/// <para>
/// Indicates that the object has content that flows logically to another
///  AtkObject in a sequential way, (for instance text-flow).
/// </para>
/// </summary>

	ATK_RELATION_FLOWS_TO = 7,
/// <summary>
/// <para>
/// Indicates that the object has content that flows logically from
///  another AtkObject in a sequential way, (for instance text-flow).
/// </para>
/// </summary>

	ATK_RELATION_FLOWS_FROM = 8,
/// <summary>
/// <para>
/// Indicates a subwindow attached to a component but otherwise has no connection in  the UI heirarchy to that component.
/// </para>
/// </summary>

	ATK_RELATION_SUBWINDOW_OF = 9,
/// <summary>
/// <para>
/// Indicates that the object visually embeds
///  another object&apos;s content, i.e. this object&apos;s content flows around
///  another&apos;s content.
/// </para>
/// </summary>

	ATK_RELATION_EMBEDS = 10,
/// <summary>
/// <para>
/// Reciprocal of %ATK_RELATION_EMBEDS, indicates that
///  this object&apos;s content is visualy embedded in another object.
/// </para>
/// </summary>

	ATK_RELATION_EMBEDDED_BY = 11,
/// <summary>
/// <para>
/// Indicates that an object is a popup for another object.
/// </para>
/// </summary>

	ATK_RELATION_POPUP_FOR = 12,
/// <summary>
/// <para>
/// Indicates that an object is a parent window of another object.
/// </para>
/// </summary>

	ATK_RELATION_PARENT_WINDOW_OF = 13,
/// <summary>
/// <para>
/// Reciprocal of %ATK_RELATION_DESCRIPTION_FOR. Indicates that one
/// or more target objects provide descriptive information about this object. This relation
/// type is most appropriate for information that is not essential as its presentation may
/// be user-configurable and/or limited to an on-demand mechanism such as an assistive
/// technology command. For brief, essential information such as can be found in a widget&apos;s
/// on-screen label, use %ATK_RELATION_LABELLED_BY. For an on-screen error message, use
/// %ATK_RELATION_ERROR_MESSAGE. For lengthy extended descriptive information contained in
/// an on-screen object, consider using %ATK_RELATION_DETAILS as assistive technologies may
/// provide a means for the user to navigate to objects containing detailed descriptions so
/// that their content can be more closely reviewed.
/// </para>
/// </summary>

	ATK_RELATION_DESCRIBED_BY = 14,
/// <summary>
/// <para>
/// Reciprocal of %ATK_RELATION_DESCRIBED_BY. Indicates that this
/// object provides descriptive information about the target object(s). See also
/// %ATK_RELATION_DETAILS_FOR and %ATK_RELATION_ERROR_FOR.
/// </para>
/// </summary>

	ATK_RELATION_DESCRIPTION_FOR = 15,
/// <summary>
/// <para>
/// Indicates an object is a cell in a treetable and is expanded to display other cells in the same column.
/// </para>
/// </summary>

	ATK_RELATION_NODE_PARENT_OF = 16,
/// <summary>
/// <para>
/// Reciprocal of %ATK_RELATION_DETAILS_FOR. Indicates that this object
/// has a detailed or extended description, the contents of which can be found in the target
/// object(s). This relation type is most appropriate for information that is sufficiently
/// lengthy as to make navigation to the container of that information desirable. For less
/// verbose information suitable for announcement only, see %ATK_RELATION_DESCRIBED_BY. If
/// the detailed information describes an error condition, %ATK_RELATION_ERROR_FOR should be
/// used instead. @Since: ATK-2.26.
/// </para>
/// </summary>

	ATK_RELATION_DETAILS = 17,
/// <summary>
/// <para>
/// Reciprocal of %ATK_RELATION_DETAILS. Indicates that this object
/// provides a detailed or extended description about the target object(s). See also
/// %ATK_RELATION_DESCRIPTION_FOR and %ATK_RELATION_ERROR_FOR. @Since: ATK-2.26.
/// </para>
/// </summary>

	ATK_RELATION_DETAILS_FOR = 18,
/// <summary>
/// <para>
/// Reciprocal of %ATK_RELATION_ERROR_FOR. Indicates that this object
/// has one or more errors, the nature of which is described in the contents of the target
/// object(s). Objects that have this relation type should also contain %ATK_STATE_INVALID_ENTRY
/// in their #AtkStateSet. @Since: ATK-2.26.
/// </para>
/// </summary>

	ATK_RELATION_ERROR_MESSAGE = 19,
/// <summary>
/// <para>
/// Reciprocal of %ATK_RELATION_ERROR_MESSAGE. Indicates that this object
/// contains an error message describing an invalid condition in the target object(s). @Since:
/// ATK_2.26.
/// </para>
/// </summary>

	ATK_RELATION_ERROR_FOR = 20,
/// <summary>
/// <para>
/// Not used, this value indicates the end of the enumeration.
/// </para>
/// </summary>

	ATK_RELATION_LAST_DEFINED = 21
}
