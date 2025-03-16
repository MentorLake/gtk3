namespace MentorLake.Vulkan;

public class VkPhysicalDeviceExternalSemaphoreInfoHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalSemaphoreInfoExtensions
{

	public static VkPhysicalDeviceExternalSemaphoreInfo Dereference(this VkPhysicalDeviceExternalSemaphoreInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalSemaphoreInfo>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalSemaphoreInfoExterns
{
}

public struct VkPhysicalDeviceExternalSemaphoreInfo
{
}
