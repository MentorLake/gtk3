namespace MentorLake.Vulkan;

public class VkExternalBufferPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkExternalBufferPropertiesKHRExtensions
{

	public static VkExternalBufferPropertiesKHR Dereference(this VkExternalBufferPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalBufferPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkExternalBufferPropertiesKHRExterns
{
}

public struct VkExternalBufferPropertiesKHR
{
}
