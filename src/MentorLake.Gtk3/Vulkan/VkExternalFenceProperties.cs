namespace MentorLake.Vulkan;

public class VkExternalFencePropertiesHandle : BaseSafeHandle
{
}


public static class VkExternalFencePropertiesExtensions
{

	public static VkExternalFenceProperties Dereference(this VkExternalFencePropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceProperties>(x.DangerousGetHandle());
}
internal class VkExternalFencePropertiesExterns
{
}

public struct VkExternalFenceProperties
{
}
