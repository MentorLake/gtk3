namespace MentorLake.Vulkan;

public class VkCuModuleNVXHandle : BaseSafeHandle
{
}


public static class VkCuModuleNVXExtensions
{

	public static VkCuModuleNVX Dereference(this VkCuModuleNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCuModuleNVX>(x.DangerousGetHandle());
}
internal class VkCuModuleNVXExterns
{
}

public struct VkCuModuleNVX
{
}
