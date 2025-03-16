namespace MentorLake.Vulkan;

public class VkExternalSemaphorePropertiesHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphorePropertiesExtensions
{

	public static VkExternalSemaphoreProperties Dereference(this VkExternalSemaphorePropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreProperties>(x.DangerousGetHandle());
}
internal class VkExternalSemaphorePropertiesExterns
{
}

public struct VkExternalSemaphoreProperties
{
}
