namespace MentorLake.Vulkan;


public class VkAmigoProfilingSubmitInfoSECHandle : BaseSafeHandle
{
}


public static class VkAmigoProfilingSubmitInfoSECExtensions
{

	public static VkAmigoProfilingSubmitInfoSEC Dereference(this VkAmigoProfilingSubmitInfoSECHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAmigoProfilingSubmitInfoSEC>(x.DangerousGetHandle());
}
internal class VkAmigoProfilingSubmitInfoSECExterns
{
}


public struct VkAmigoProfilingSubmitInfoSEC
{
}
