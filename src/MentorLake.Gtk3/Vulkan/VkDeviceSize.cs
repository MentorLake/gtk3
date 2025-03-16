namespace MentorLake.Vulkan;

public class VkDeviceSizeHandle : BaseSafeHandle
{
}


public static class VkDeviceSizeExtensions
{

	public static VkDeviceSize Dereference(this VkDeviceSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceSize>(x.DangerousGetHandle());
}
internal class VkDeviceSizeExterns
{
}

public struct VkDeviceSize
{
}
