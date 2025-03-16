namespace MentorLake.Vulkan;

public class VkSurfaceCapabilitiesPresentBarrierNVHandle : BaseSafeHandle
{
}


public static class VkSurfaceCapabilitiesPresentBarrierNVExtensions
{

	public static VkSurfaceCapabilitiesPresentBarrierNV Dereference(this VkSurfaceCapabilitiesPresentBarrierNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceCapabilitiesPresentBarrierNV>(x.DangerousGetHandle());
}
internal class VkSurfaceCapabilitiesPresentBarrierNVExterns
{
}

public struct VkSurfaceCapabilitiesPresentBarrierNV
{
}
