namespace MentorLake.Vulkan;


public class VkDrawIndexedIndirectCommandHandle : BaseSafeHandle
{
}


public static class VkDrawIndexedIndirectCommandExtensions
{

	public static VkDrawIndexedIndirectCommand Dereference(this VkDrawIndexedIndirectCommandHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrawIndexedIndirectCommand>(x.DangerousGetHandle());
}
internal class VkDrawIndexedIndirectCommandExterns
{
}


public struct VkDrawIndexedIndirectCommand
{
}
