namespace MentorLake.Vulkan;

public class VkExternalMemoryPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryPropertiesKHRExtensions
{

	public static VkExternalMemoryPropertiesKHR Dereference(this VkExternalMemoryPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkExternalMemoryPropertiesKHRExterns
{
}

public struct VkExternalMemoryPropertiesKHR
{
}
