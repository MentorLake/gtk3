namespace MentorLake.Vulkan;

public class VkDirectDriverLoadingFlagsLUNARGHandle : BaseSafeHandle
{
}


public static class VkDirectDriverLoadingFlagsLUNARGExtensions
{

	public static VkDirectDriverLoadingFlagsLUNARG Dereference(this VkDirectDriverLoadingFlagsLUNARGHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDirectDriverLoadingFlagsLUNARG>(x.DangerousGetHandle());
}
internal class VkDirectDriverLoadingFlagsLUNARGExterns
{
}

public struct VkDirectDriverLoadingFlagsLUNARG
{
}
