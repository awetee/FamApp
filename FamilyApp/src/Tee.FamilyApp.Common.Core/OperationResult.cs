using System.Collections.Generic;

namespace Tee.FamilyApp.Common.Core
{
    public class OperationResult
    {
        public OperationResult()
        {
            Succeded = true;
            Messages = new List<string>();
        }

        public bool Succeded { get; set; }
        public List<string> Messages { get; set; }
    }
}