namespace MentorLake.Vulkan;


public class VkToolPurposeFlagsHandle : BaseSafeHandle
{
}


public static class VkToolPurposeFlagsExtensions
{

	public static VkToolPurposeFlags Dereference(this VkToolPurposeFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkToolPurposeFlags>(x.DangerousGetHandle());
}
internal class VkToolPurposeFlagsExterns
{
}


public struct VkToolPurposeFlags
{
}
