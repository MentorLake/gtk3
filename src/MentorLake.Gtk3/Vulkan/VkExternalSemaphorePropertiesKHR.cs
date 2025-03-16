namespace MentorLake.Vulkan;

public class VkExternalSemaphorePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphorePropertiesKHRExtensions
{

	public static VkExternalSemaphorePropertiesKHR Dereference(this VkExternalSemaphorePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphorePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkExternalSemaphorePropertiesKHRExterns
{
}

public struct VkExternalSemaphorePropertiesKHR
{
}
