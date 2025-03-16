namespace MentorLake.Vulkan;

public class VkQueueHandle : BaseSafeHandle
{
}


public static class VkQueueExtensions
{

	public static VkQueue Dereference(this VkQueueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueue>(x.DangerousGetHandle());
}
internal class VkQueueExterns
{
}

public struct VkQueue
{
}
