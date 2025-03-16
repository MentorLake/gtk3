namespace MentorLake.Vulkan;

public class VkPhysicalDeviceExternalBufferInfoHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalBufferInfoExtensions
{

	public static VkPhysicalDeviceExternalBufferInfo Dereference(this VkPhysicalDeviceExternalBufferInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalBufferInfo>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalBufferInfoExterns
{
}

public struct VkPhysicalDeviceExternalBufferInfo
{
}
