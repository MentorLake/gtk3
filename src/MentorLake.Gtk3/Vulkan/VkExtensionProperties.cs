namespace MentorLake.Vulkan;


public class VkExtensionPropertiesHandle : BaseSafeHandle
{
}


public static class VkExtensionPropertiesExtensions
{

	public static VkExtensionProperties Dereference(this VkExtensionPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExtensionProperties>(x.DangerousGetHandle());
}
internal class VkExtensionPropertiesExterns
{
}


public struct VkExtensionProperties
{
}
