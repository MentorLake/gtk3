namespace MentorLake.Vulkan;


public class VkExternalFencePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkExternalFencePropertiesKHRExtensions
{

	public static VkExternalFencePropertiesKHR Dereference(this VkExternalFencePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFencePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkExternalFencePropertiesKHRExterns
{
}


public struct VkExternalFencePropertiesKHR
{
}
