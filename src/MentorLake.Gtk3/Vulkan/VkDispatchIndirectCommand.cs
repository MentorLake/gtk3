namespace MentorLake.Vulkan;


public class VkDispatchIndirectCommandHandle : BaseSafeHandle
{
}


public static class VkDispatchIndirectCommandExtensions
{

	public static VkDispatchIndirectCommand Dereference(this VkDispatchIndirectCommandHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDispatchIndirectCommand>(x.DangerousGetHandle());
}
internal class VkDispatchIndirectCommandExterns
{
}


public struct VkDispatchIndirectCommand
{
}
