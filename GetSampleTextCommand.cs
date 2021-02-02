using System.Management.Automation;

namespace RiderWithDisabledDebuggerForExecutableRun
{
    [Cmdlet(VerbsCommon.Get, "SampleText")]
    public class GetSampleTextCommand : Cmdlet
    {
        protected override void EndProcessing()
        {
            WriteObject("Hello world!");
        }
    }
}