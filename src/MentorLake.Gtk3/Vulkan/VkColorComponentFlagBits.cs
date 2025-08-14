namespace MentorLake.Vulkan;


public class VkColorComponentFlagBitsHandle : BaseSafeHandle
{
}


public static class VkColorComponentFlagBitsExtensions
{

	public static VkColorComponentFlagBits Dereference(this VkColorComponentFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkColorComponentFlagBits>(x.DangerousGetHandle());
}
internal class VkColorComponentFlagBitsExterns
{
}


public struct VkColorComponentFlagBits
{
}
