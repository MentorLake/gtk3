namespace MentorLake.Vulkan;


public class VkExternalBufferPropertiesHandle : BaseSafeHandle
{
}


public static class VkExternalBufferPropertiesExtensions
{

	public static VkExternalBufferProperties Dereference(this VkExternalBufferPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalBufferProperties>(x.DangerousGetHandle());
}
internal class VkExternalBufferPropertiesExterns
{
}


public struct VkExternalBufferProperties
{
}
