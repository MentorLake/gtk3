namespace MentorLake.Vulkan;


public class VkFenceCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkFenceCreateFlagBitsExtensions
{

	public static VkFenceCreateFlagBits Dereference(this VkFenceCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkFenceCreateFlagBitsExterns
{
}


public struct VkFenceCreateFlagBits
{
}
