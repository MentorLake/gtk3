namespace MentorLake.Vulkan;


public class VkCullModeFlagBitsHandle : BaseSafeHandle
{
}


public static class VkCullModeFlagBitsExtensions
{

	public static VkCullModeFlagBits Dereference(this VkCullModeFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCullModeFlagBits>(x.DangerousGetHandle());
}
internal class VkCullModeFlagBitsExterns
{
}


public struct VkCullModeFlagBits
{
}
