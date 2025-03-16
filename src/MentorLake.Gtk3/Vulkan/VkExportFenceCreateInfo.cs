namespace MentorLake.Vulkan;

public class VkExportFenceCreateInfoHandle : BaseSafeHandle
{
}


public static class VkExportFenceCreateInfoExtensions
{

	public static VkExportFenceCreateInfo Dereference(this VkExportFenceCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExportFenceCreateInfo>(x.DangerousGetHandle());
}
internal class VkExportFenceCreateInfoExterns
{
}

public struct VkExportFenceCreateInfo
{
}
