namespace MentorLake.Vulkan;


public class VkDisplayModePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayModePropertiesKHRExtensions
{

	public static VkDisplayModePropertiesKHR Dereference(this VkDisplayModePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayModePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkDisplayModePropertiesKHRExterns
{
}


public struct VkDisplayModePropertiesKHR
{
}
